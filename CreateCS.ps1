# *Track.cs Maker
ForEach ($filename in $(dir .\MediaInfoWrapper\List_Of_Parameters\*.csv)) {
    $outfile = ""
    $params = Import-Csv $filename.FullName -Delimiter ";" -Header Name,Custom01,Custom02,Required,Custom03,Custom04,Description,Custom05

    $outfile += "namespace MediaInfoWrapper`r`n{`r`n    using System;`r`n`r`n    public class $($filename.BaseName)Track`r`n    {`r`n"

    ForEach ($param in $params) {
        $param01 = $($param.Name) -replace '[()/*-]',''
        $outfile += "        private string _$param01;  //$($param.Description)`r`n"
    }
    $outfile += "`r`n"

    ForEach ($param in $params) {
        $param01 = $($param.Name) -replace '[()/*-]',''
        $outfile += "        public string $param01 { get { if (string.IsNullOrEmpty(this._$param01)) { this._$param01 = """"; } return this._$param01; } set { this._$param01 = value; } }`r`n"
    }
    $outfile += "    }`r`n}`r`n"

	Out-File -FilePath ".\MediaInfoWrapper\MediaInfoWrapper\$($filename.BaseName)Track.cs" -InputObject $outfile
}

# MediaInfo.cs Maker

$outfile = ""
$outfile += "namespace MediaInfoWrapper`r`n{`r`n    using System;`r`n    using System.Collections.Generic;`r`n    using System.IO;`r`n    using System.Reflection;`r`n    using System.Runtime.InteropServices;`r`n    using MediaInfoLib;`r`n`r`n    public class MediaInfo : IDisposable`r`n    {`r`n"

#$filename = get-Item "C:\Games\OTHER\C#\Projects\MediaInfoWrapper\MediaInfoWrapper\List_Of_Parameters\Audio.csv"
ForEach ($filename in $(dir .\MediaInfoWrapper\List_Of_Parameters\*.csv)) {
    $outfile += "        private List<$($filename.BaseName)Track> _$($filename.BaseName);`r`n        private int _$($filename.BaseName)Count;`r`n"
}

# Common Code
$outfile += "`r`n        private string _FileName;`r`n        private bool disposed;`r`n        private MediaInfoLib.MediaInfo MediaInfoLibClass;`r`n`r`n"
$outfile += "// Constructor`r`n        public MediaInfo(string path)`r`n        {`r`n            if (this.CheckFileExistence(path))`r`n            {`r`n                this._FileName = path;`r`n                MediaInfoLibClass = new MediaInfoLib.MediaInfo();`r`n                MediaInfoLibClass.Open(path);`r`n                try`r`n                {`r`n                    this.getStreamCount();`r`n                    this.getAllInfos();`r`n                }`r`n                finally`r`n                {`r`n                    MediaInfoLibClass.Close();`r`n                }`r`n            }`r`n        }`r`n`r`n"
$outfile += "// Capatibility`r`n        public static string Version()`r`n        {`r`n            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();`r`n            return MediaInfoLibClass.Option(""Info_Version"", """");`r`n        }`r`n`r`n"
$outfile += "        public static string KnownCodecs()`r`n        {`r`n            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();`r`n            return MediaInfoLibClass.Option(""Info_Codecs"", """");`r`n        }`r`n`r`n"
$outfile += "        public static string ParameterList()`r`n        {`r`n            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();`r`n            return MediaInfoLibClass.Option(""Info_Parameters"", """");`r`n        }`r`n`r`n"
$outfile += "        protected void CheckDisposed()`r`n        {`r`n            if (this.disposed)`r`n            {`r`n                throw new ObjectDisposedException(this.ToString());`r`n            }`r`n        }`r`n`r`n"
$outfile += "        protected bool CheckFileExistence(string filepath)`r`n        {`r`n            if (!File.Exists(filepath))`r`n            {`r`n                throw new FileNotFoundException(""File not found :"" + filepath, filepath);`r`n            }`r`n            return true;`r`n        }`r`n`r`n"
$outfile += "        public void Dispose()`r`n        {`r`n            this.Dispose(true);`r`n            GC.SuppressFinalize(this);`r`n        }`r`n`r`n"
$outfile += "        protected virtual void Dispose(bool disposing)`r`n        {`r`n            if (!this.disposed)`r`n            {`r`n                if (disposing)`r`n                {`r`n                    this.DisposeManagedResources();`r`n                }`r`n                this.DisposeUnmanagedResources();`r`n            }`r`n            this.disposed = true;`r`n        }`r`n`r`n"
$outfile += "        protected virtual void DisposeManagedResources()`r`n        {`r`n        }`r`n`r`n"
$outfile += "        protected virtual void DisposeUnmanagedResources()`r`n        {`r`n            MediaInfoLibClass.Close();`r`n        }`r`n`r`n"
$outfile += "        ~MediaInfo()`r`n        {`r`n            this.Dispose(false);`r`n        }`r`n`r`n"
$outfile += "        private string ListEveryAvailablePropery<T1>(List<T1> L)`r`n        {`r`n            string str = """";`r`n            foreach (T1 local in L)`r`n            {`r`n                foreach (PropertyInfo info in local.GetType().GetProperties())`r`n                {`r`n                    str = str + ((info.GetValue(local, null).ToString() == """") ? (info.Name + "" : Not available"" + Environment.NewLine) : string.Concat(new object[] { info.Name, "" : "", info.GetValue(local, null), Environment.NewLine }));`r`n                }`r`n            }`r`n            return str;`r`n        }`r`n`r`n"

#getStreamCount
$outfile += "        private void getStreamCount()`r`n        {`r`n"
ForEach ($filename in $(dir .\MediaInfoWrapper\List_Of_Parameters\*.csv)) {
    $outfile += "            this._$($filename.BaseName)Count = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.$($filename.BaseName));`r`n"
}
$outfile += "        }`r`n`r`n"

# getAllInfos
$outfile += "        private void getAllInfos()`r`n        {`r`n"
ForEach ($filename in $(dir .\MediaInfoWrapper\List_Of_Parameters\*.csv)) {
    $outfile += "            this.get$($filename.BaseName)Info();`r`n"
}
$outfile += "        }`r`n`r`n"

# getXXXInfo
ForEach ($filename in $(dir .\MediaInfoWrapper\List_Of_Parameters\*.csv)) {

    $outfile += "        private void get$($filename.BaseName)Info()`r`n        {`r`n            if (this._$($filename.BaseName) == null)`r`n            {`r`n                this._$($filename.BaseName) = new List<$($filename.BaseName)Track>();`r`n                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.$($filename.BaseName));`r`n                if (num > 0)`r`n                {`r`n                    int num2 = num - 1;`r`n                    for (int i = 0; i <= num2; i++)`r`n                    {`r`n                        $($filename.BaseName)Track item = new $($filename.BaseName)Track {`r`n"
    $params = Import-Csv $filename.FullName -Delimiter ";" -Header Name,Custom01,Custom02,Required,Custom03,Custom04,Description,Custom05
    ForEach ($param in $params) {
        $param01 = $($param.Name) -replace '[()/*-]',''
        $outfile += "                            $param01 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.$($filename.BaseName), i, ""$($param.Name)""),`r`n"
    }
    $outfile += "                        };`r`n                        this._$($filename.BaseName).Add(item);`r`n                    }`r`n                }`r`n            }`r`n        }`r`n`r`n"
    $outfile += "        public List<$($filename.BaseName)Track> $($filename.BaseName)`r`n        {`r`n            get`r`n            {`r`n                if (this._$($filename.BaseName) == null)`r`n                {`r`n                    this.get$($filename.BaseName)Info();`r`n                }`r`n                return this._$($filename.BaseName);`r`n            }`r`n        }`r`n`r`n"
    $outfile += "        public int $($filename.BaseName)Count`r`n        {`r`n            get`r`n            {`r`n                return this._$($filename.BaseName)Count;`r`n            }`r`n        }`r`n`r`n"
}

$outfile += "    }`r`n}`r`n`r`n"

Out-File -FilePath ".\MediaInfoWrapper\MediaInfoWrapper\MediaInfo.cs" -InputObject $outfile
