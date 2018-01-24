namespace MediaInfoWrapper
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using MediaInfoLib;

    public class MediaInfo : IDisposable
    {
        private List<AudioTrack> _Audio;
        private int _AudioCount;
        private List<GeneralTrack> _General;
        private int _GeneralCount;
        private List<ImageTrack> _Image;
        private int _ImageCount;
        private List<MenuTrack> _Menu;
        private int _MenuCount;
        private List<OtherTrack> _Other;
        private int _OtherCount;
        private List<TextTrack> _Text;
        private int _TextCount;
        private List<VideoTrack> _Video;
        private int _VideoCount;

        private string _FileName;
        private bool disposed;
        private MediaInfoLib.MediaInfo MediaInfoLibClass;

// Constructor
        public MediaInfo(string path)
        {
            if (this.CheckFileExistence(path))
            {
                this._FileName = path;
                MediaInfoLibClass = new MediaInfoLib.MediaInfo();
                MediaInfoLibClass.Open(path);
                try
                {
                    this.getStreamCount();
                    this.getAllInfos();
                }
                finally
                {
                    MediaInfoLibClass.Close();
                }
            }
        }

// Capatibility
        public static string Version()
        {
            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();
            return MediaInfoLibClass.Option("Info_Version", "");
        }

        public static string KnownCodecs()
        {
            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();
            return MediaInfoLibClass.Option("Info_Codecs", "");
        }

        public static string ParameterList()
        {
            MediaInfoLib.MediaInfo MediaInfoLibClass = new MediaInfoLib.MediaInfo();
            return MediaInfoLibClass.Option("Info_Parameters", "");
        }

        protected void CheckDisposed()
        {
            if (this.disposed)
            {
                throw new ObjectDisposedException(this.ToString());
            }
        }

        protected bool CheckFileExistence(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException("File not found :" + filepath, filepath);
            }
            return true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    this.DisposeManagedResources();
                }
                this.DisposeUnmanagedResources();
            }
            this.disposed = true;
        }

        protected virtual void DisposeManagedResources()
        {
        }

        protected virtual void DisposeUnmanagedResources()
        {
            MediaInfoLibClass.Close();
        }

        ~MediaInfo()
        {
            this.Dispose(false);
        }

        private string ListEveryAvailablePropery<T1>(List<T1> L)
        {
            string str = "";
            foreach (T1 local in L)
            {
                foreach (PropertyInfo info in local.GetType().GetProperties())
                {
                    str = str + ((info.GetValue(local, null).ToString() == "") ? (info.Name + " : Not available" + Environment.NewLine) : string.Concat(new object[] { info.Name, " : ", info.GetValue(local, null), Environment.NewLine }));
                }
            }
            return str;
        }

        private void getStreamCount()
        {
            this._AudioCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Audio);
            this._GeneralCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.General);
            this._ImageCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Image);
            this._MenuCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Menu);
            this._OtherCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Other);
            this._TextCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Text);
            this._VideoCount = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Video);
        }

        private void getAllInfos()
        {
            this.getAudioInfo();
            this.getGeneralInfo();
            this.getImageInfo();
            this.getMenuInfo();
            this.getOtherInfo();
            this.getTextInfo();
            this.getVideoInfo();
        }

        private void getAudioInfo()
        {
            if (this._Audio == null)
            {
                this._Audio = new List<AudioTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Audio);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        AudioTrack item = new AudioTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "MenuID/String"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Profile"),
                            Format_Level = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Level"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings"),
                            Format_Settings_SBR = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_SBR"),
                            Format_Settings_SBRString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_SBR/String"),
                            Format_Settings_PS = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_PS"),
                            Format_Settings_PSString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_PS/String"),
                            Format_Settings_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Mode"),
                            Format_Settings_ModeExtension = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_ModeExtension"),
                            Format_Settings_Emphasis = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Emphasis"),
                            Format_Settings_Floor = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Floor"),
                            Format_Settings_Firm = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Firm"),
                            Format_Settings_Endianness = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Endianness"),
                            Format_Settings_Sign = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Sign"),
                            Format_Settings_Law = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Law"),
                            Format_Settings_ITU = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_ITU"),
                            Format_Settings_Wrapping = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Format_Settings_Wrapping"),
                            Matrix_Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Matrix_Format"),
                            InternetMediaType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "InternetMediaType"),
                            MuxingMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "MuxingMode"),
                            MuxingMode_MoreInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "MuxingMode_MoreInfo"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "CodecID_Description"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec/String"),
                            CodecFamily = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec/Family"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec/Url"),
                            CodecCC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec/CC"),
                            Codec_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Description"),
                            Codec_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Profile"),
                            Codec_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings"),
                            Codec_Settings_Automatic = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Automatic"),
                            Codec_Settings_Floor = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Floor"),
                            Codec_Settings_Firm = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Firm"),
                            Codec_Settings_Endianness = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Endianness"),
                            Codec_Settings_Sign = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Sign"),
                            Codec_Settings_Law = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_Law"),
                            Codec_Settings_ITU = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Codec_Settings_ITU"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration/String5"),
                            Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame"),
                            Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String"),
                            Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String1"),
                            Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String2"),
                            Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String3"),
                            Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String4"),
                            Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_FirstFrame/String5"),
                            Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame"),
                            Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String"),
                            Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String1"),
                            Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String2"),
                            Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String3"),
                            Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String4"),
                            Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Duration_LastFrame/String5"),
                            Source_Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration"),
                            Source_DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String"),
                            Source_DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String1"),
                            Source_DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String2"),
                            Source_DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String3"),
                            Source_DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String4"),
                            Source_DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration/String5"),
                            Source_Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame"),
                            Source_Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String"),
                            Source_Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String1"),
                            Source_Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String2"),
                            Source_Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String3"),
                            Source_Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String4"),
                            Source_Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_FirstFrame/String5"),
                            Source_Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame"),
                            Source_Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String"),
                            Source_Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String1"),
                            Source_Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String2"),
                            Source_Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String3"),
                            Source_Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String4"),
                            Source_Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_Duration_LastFrame/String5"),
                            BitRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Mode"),
                            BitRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Mode/String"),
                            BitRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate"),
                            BitRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate/String"),
                            BitRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Minimum"),
                            BitRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Minimum/String"),
                            BitRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Nominal"),
                            BitRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Nominal/String"),
                            BitRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Maximum"),
                            BitRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Maximum/String"),
                            BitRate_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Encoded"),
                            BitRate_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitRate_Encoded/String"),
                            Channels = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Channel(s)"),
                            ChannelsString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Channel(s)/String"),
                            Channels_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Channel(s)_Original"),
                            Channels_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Channel(s)_Original/String"),
                            Matrix_Channels = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Matrix_Channel(s)"),
                            Matrix_ChannelsString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Matrix_Channel(s)/String"),
                            ChannelPositions = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ChannelPositions"),
                            ChannelPositionsString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ChannelPositions/String2"),
                            Matrix_ChannelPositions = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Matrix_ChannelPositions"),
                            Matrix_ChannelPositionsString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Matrix_ChannelPositions/String2"),
                            ChannelLayout = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ChannelLayout"),
                            ChannelLayoutID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ChannelLayoutID"),
                            SamplesPerFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "SamplesPerFrame"),
                            SamplingRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "SamplingRate"),
                            SamplingRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "SamplingRate/String"),
                            SamplingCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "SamplingCount"),
                            Source_SamplingCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_SamplingCount"),
                            FrameRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FrameRate"),
                            FrameRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FrameRate/String"),
                            FrameRate_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FrameRate_Num"),
                            FrameRate_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FrameRate_Den"),
                            FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "FrameCount"),
                            Source_FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_FrameCount"),
                            Resolution = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Resolution"),
                            ResolutionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Resolution/String"),
                            BitDepth = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth"),
                            BitDepthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth/String"),
                            BitDepth_Detected = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth_Detected"),
                            BitDepth_DetectedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth_Detected/String"),
                            BitDepth_Stored = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth_Stored"),
                            BitDepth_StoredString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "BitDepth_Stored/String"),
                            Compression_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Compression_Mode"),
                            Compression_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Compression_Mode/String"),
                            Compression_Ratio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Compression_Ratio"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Source"),
                            Delay_SourceString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Source/String"),
                            Delay_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original"),
                            Delay_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String"),
                            Delay_OriginalString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String1"),
                            Delay_OriginalString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String2"),
                            Delay_OriginalString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String3"),
                            Delay_OriginalString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String4"),
                            Delay_OriginalString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original/String5"),
                            Delay_Original_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original_Settings"),
                            Delay_Original_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original_DropFrame"),
                            Delay_Original_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Delay_Original_Source"),
                            Video_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay"),
                            Video_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String"),
                            Video_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String1"),
                            Video_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String2"),
                            Video_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String3"),
                            Video_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String4"),
                            Video_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video_Delay/String5"),
                            Video0_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay"),
                            Video0_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String"),
                            Video0_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String1"),
                            Video0_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String2"),
                            Video0_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String3"),
                            Video0_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String4"),
                            Video0_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Video0_Delay/String5"),
                            ReplayGain_Gain = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ReplayGain_Gain"),
                            ReplayGain_GainString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ReplayGain_Gain/String"),
                            ReplayGain_Peak = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ReplayGain_Peak"),
                            StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize"),
                            StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String"),
                            StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String1"),
                            StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String2"),
                            StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String3"),
                            StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String4"),
                            StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize/String5"),
                            StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Proportion"),
                            StreamSize_Demuxed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed"),
                            StreamSize_DemuxedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String"),
                            StreamSize_DemuxedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String1"),
                            StreamSize_DemuxedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String2"),
                            StreamSize_DemuxedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String3"),
                            StreamSize_DemuxedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String4"),
                            StreamSize_DemuxedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Demuxed/String5"),
                            Source_StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize"),
                            Source_StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String"),
                            Source_StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String1"),
                            Source_StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String2"),
                            Source_StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String3"),
                            Source_StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String4"),
                            Source_StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize/String5"),
                            Source_StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Proportion"),
                            StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded"),
                            StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String"),
                            StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String1"),
                            StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String2"),
                            StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String3"),
                            StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String4"),
                            StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded/String5"),
                            StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "StreamSize_Encoded_Proportion"),
                            Source_StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded"),
                            Source_StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String"),
                            Source_StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String1"),
                            Source_StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String2"),
                            Source_StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String3"),
                            Source_StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String4"),
                            Source_StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded/String5"),
                            Source_StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Source_StreamSize_Encoded_Proportion"),
                            Alignment = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Alignment"),
                            AlignmentString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Alignment/String"),
                            Interleave_VideoFrames = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Interleave_VideoFrames"),
                            Interleave_Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Interleave_Duration"),
                            Interleave_DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Interleave_Duration/String"),
                            Interleave_Preload = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Interleave_Preload"),
                            Interleave_PreloadString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Interleave_Preload/String"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Title"),
                            Encoded_Application = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application"),
                            Encoded_ApplicationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application/String"),
                            Encoded_Application_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application_CompanyName"),
                            Encoded_Application_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application_Name"),
                            Encoded_Application_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application_Version"),
                            Encoded_Application_Url = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Application_Url"),
                            Encoded_Library = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library"),
                            Encoded_LibraryString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library/String"),
                            Encoded_Library_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library_CompanyName"),
                            Encoded_Library_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library_Name"),
                            Encoded_Library_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library_Version"),
                            Encoded_Library_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library_Date"),
                            Encoded_Library_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Library_Settings"),
                            Encoded_OperatingSystem = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_OperatingSystem"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "ServiceKind/String"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "AlternateGroup/String"),
                            Encoded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encoded_Date"),
                            Tagged_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Tagged_Date"),
                            Encryption = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Audio, i, "Encryption"),
                        };
                        this._Audio.Add(item);
                    }
                }
            }
        }

        public List<AudioTrack> Audio
        {
            get
            {
                if (this._Audio == null)
                {
                    this.getAudioInfo();
                }
                return this._Audio;
            }
        }

        public int AudioCount
        {
            get
            {
                return this._AudioCount;
            }
        }

        private void getGeneralInfo()
        {
            if (this._General == null)
            {
                this._General = new List<GeneralTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.General);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        GeneralTrack item = new GeneralTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "MenuID/String"),
                            GeneralCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "GeneralCount"),
                            VideoCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "VideoCount"),
                            AudioCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "AudioCount"),
                            TextCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "TextCount"),
                            OtherCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OtherCount"),
                            ImageCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ImageCount"),
                            MenuCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "MenuCount"),
                            Video_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Video_Format_List"),
                            Video_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Video_Format_WithHint_List"),
                            Video_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Video_Codec_List"),
                            Video_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Video_Language_List"),
                            Audio_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Audio_Format_List"),
                            Audio_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Audio_Format_WithHint_List"),
                            Audio_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Audio_Codec_List"),
                            Audio_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Audio_Language_List"),
                            Text_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Text_Format_List"),
                            Text_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Text_Format_WithHint_List"),
                            Text_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Text_Codec_List"),
                            Text_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Text_Language_List"),
                            Other_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Other_Format_List"),
                            Other_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Other_Format_WithHint_List"),
                            Other_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Other_Codec_List"),
                            Other_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Other_Language_List"),
                            Image_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Image_Format_List"),
                            Image_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Image_Format_WithHint_List"),
                            Image_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Image_Codec_List"),
                            Image_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Image_Language_List"),
                            Menu_Format_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Menu_Format_List"),
                            Menu_Format_WithHint_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Menu_Format_WithHint_List"),
                            Menu_Codec_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Menu_Codec_List"),
                            Menu_Language_List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Menu_Language_List"),
                            CompleteName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CompleteName"),
                            FolderName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FolderName"),
                            FileName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileName"),
                            FileExtension = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileExtension"),
                            CompleteName_Last = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CompleteName_Last"),
                            FolderName_Last = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FolderName_Last"),
                            FileName_Last = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileName_Last"),
                            FileExtension_Last = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileExtension_Last"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format"),
                            FormatString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format/String"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format/Url"),
                            FormatExtensions = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format/Extensions"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Profile"),
                            Format_Level = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Level"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Format_Settings"),
                            InternetMediaType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "InternetMediaType"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID_Description"),
                            CodecID_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID_Version"),
                            CodecID_Compatible = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CodecID_Compatible"),
                            Interleaved = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Interleaved"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec/String"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec/Url"),
                            CodecExtensions = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec/Extensions"),
                            Codec_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec_Settings"),
                            Codec_Settings_Automatic = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Codec_Settings_Automatic"),
                            FileSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize"),
                            FileSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize/String"),
                            FileSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize/String1"),
                            FileSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize/String2"),
                            FileSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize/String3"),
                            FileSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FileSize/String4"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration/String5"),
                            Duration_Start = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration_Start"),
                            Duration_End = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Duration_End"),
                            OverallBitRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Mode"),
                            OverallBitRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Mode/String"),
                            OverallBitRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate"),
                            OverallBitRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate/String"),
                            OverallBitRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Minimum"),
                            OverallBitRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Minimum/String"),
                            OverallBitRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Nominal"),
                            OverallBitRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Nominal/String"),
                            OverallBitRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Maximum"),
                            OverallBitRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OverallBitRate_Maximum/String"),
                            FrameRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FrameRate"),
                            FrameRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FrameRate/String"),
                            FrameRate_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FrameRate_Num"),
                            FrameRate_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FrameRate_Den"),
                            FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FrameCount"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay_Source"),
                            Delay_SourceString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Delay_Source/String"),
                            StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize"),
                            StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String"),
                            StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String1"),
                            StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String2"),
                            StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String3"),
                            StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String4"),
                            StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize/String5"),
                            StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Proportion"),
                            StreamSize_Demuxed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed"),
                            StreamSize_DemuxedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String"),
                            StreamSize_DemuxedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String1"),
                            StreamSize_DemuxedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String2"),
                            StreamSize_DemuxedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String3"),
                            StreamSize_DemuxedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String4"),
                            StreamSize_DemuxedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "StreamSize_Demuxed/String5"),
                            HeaderSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "HeaderSize"),
                            DataSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "DataSize"),
                            FooterSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "FooterSize"),
                            IsStreamable = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "IsStreamable"),
                            Album_ReplayGain_Gain = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album_ReplayGain_Gain"),
                            Album_ReplayGain_GainString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album_ReplayGain_Gain/String"),
                            Album_ReplayGain_Peak = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album_ReplayGain_Peak"),
                            Encryption = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption"),
                            Encryption_Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_Format"),
                            Encryption_Length = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_Length"),
                            Encryption_Method = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_Method"),
                            Encryption_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_Mode"),
                            Encryption_Padding = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_Padding"),
                            Encryption_InitializationVector = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encryption_InitializationVector"),
                            UniversalAdIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "UniversalAdID/String"),
                            UniversalAdID_Registry = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "UniversalAdID_Registry"),
                            UniversalAdID_Value = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "UniversalAdID_Value"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Title"),
                            Title_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Title_More"),
                            TitleUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Title/Url"),
                            Domain = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Domain"),
                            Collection = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Collection"),
                            Season = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Season"),
                            Season_Position = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Season_Position"),
                            Season_Position_Total = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Season_Position_Total"),
                            Movie = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Movie"),
                            Movie_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Movie_More"),
                            MovieCountry = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Movie/Country"),
                            MovieUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Movie/Url"),
                            Album = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album"),
                            Album_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album_More"),
                            AlbumSort = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album/Sort"),
                            AlbumPerformer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album/Performer"),
                            AlbumPerformerSort = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album/Performer/Sort"),
                            AlbumPerformerUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Album/Performer/Url"),
                            Comic = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Comic"),
                            Comic_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Comic_More"),
                            ComicPosition_Total = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Comic/Position_Total"),
                            Part = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Part"),
                            PartPosition = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Part/Position"),
                            PartPosition_Total = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Part/Position_Total"),
                            Track = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track"),
                            Track_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track_More"),
                            TrackUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track/Url"),
                            TrackSort = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track/Sort"),
                            TrackPosition = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track/Position"),
                            TrackPosition_Total = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Track/Position_Total"),
                            PackageName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "PackageName"),
                            Grouping = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Grouping"),
                            Chapter = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Chapter"),
                            SubTrack = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "SubTrack"),
                            OriginalAlbum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Album"),
                            OriginalMovie = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Movie"),
                            OriginalPart = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Part"),
                            OriginalTrack = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Track"),
                            Compilation = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Compilation"),
                            CompilationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Compilation/String"),
                            Performer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Performer"),
                            PerformerSort = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Performer/Sort"),
                            PerformerUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Performer/Url"),
                            OriginalPerformer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Performer"),
                            Accompaniment = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Accompaniment"),
                            Composer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Composer"),
                            ComposerNationality = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Composer/Nationality"),
                            ComposerSort = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Composer/Sort"),
                            Arranger = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Arranger"),
                            Lyricist = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Lyricist"),
                            OriginalLyricist = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Lyricist"),
                            Conductor = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Conductor"),
                            Director = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Director"),
                            CoDirector = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CoDirector"),
                            AssistantDirector = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "AssistantDirector"),
                            DirectorOfPhotography = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "DirectorOfPhotography"),
                            SoundEngineer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "SoundEngineer"),
                            ArtDirector = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ArtDirector"),
                            ProductionDesigner = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ProductionDesigner"),
                            Choregrapher = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Choregrapher"),
                            CostumeDesigner = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CostumeDesigner"),
                            Actor = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Actor"),
                            Actor_Character = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Actor_Character"),
                            WrittenBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "WrittenBy"),
                            ScreenplayBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ScreenplayBy"),
                            EditedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "EditedBy"),
                            CommissionedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CommissionedBy"),
                            Producer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Producer"),
                            CoProducer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CoProducer"),
                            ExecutiveProducer = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ExecutiveProducer"),
                            MusicBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "MusicBy"),
                            DistributedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "DistributedBy"),
                            OriginalSourceFormDistributedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm/DistributedBy"),
                            MasteredBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "MasteredBy"),
                            EncodedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "EncodedBy"),
                            RemixedBy = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "RemixedBy"),
                            ProductionStudio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ProductionStudio"),
                            ThanksTo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ThanksTo"),
                            Publisher = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Publisher"),
                            PublisherURL = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Publisher/URL"),
                            Label = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Label"),
                            Genre = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Genre"),
                            PodcastCategory = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "PodcastCategory"),
                            Mood = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Mood"),
                            ContentType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ContentType"),
                            Subject = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Subject"),
                            Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Description"),
                            Keywords = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Keywords"),
                            Summary = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Summary"),
                            Synopsis = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Synopsis"),
                            Period = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Period"),
                            LawRating = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "LawRating"),
                            LawRating_Reason = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "LawRating_Reason"),
                            ICRA = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ICRA"),
                            Released_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Released_Date"),
                            OriginalReleased_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Original/Released_Date"),
                            Recorded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Recorded_Date"),
                            Encoded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Date"),
                            Tagged_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Tagged_Date"),
                            Written_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Written_Date"),
                            Mastered_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Mastered_Date"),
                            File_Created_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "File_Created_Date"),
                            File_Created_Date_Local = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "File_Created_Date_Local"),
                            File_Modified_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "File_Modified_Date"),
                            File_Modified_Date_Local = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "File_Modified_Date_Local"),
                            Recorded_Location = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Recorded_Location"),
                            Written_Location = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Written_Location"),
                            Archival_Location = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Archival_Location"),
                            Encoded_Application = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application"),
                            Encoded_ApplicationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application/String"),
                            Encoded_Application_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application_CompanyName"),
                            Encoded_Application_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application_Name"),
                            Encoded_Application_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application_Version"),
                            Encoded_Application_Url = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Application_Url"),
                            Encoded_Library = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library"),
                            Encoded_LibraryString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library/String"),
                            Encoded_Library_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library_CompanyName"),
                            Encoded_Library_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library_Name"),
                            Encoded_Library_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library_Version"),
                            Encoded_Library_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library_Date"),
                            Encoded_Library_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_Library_Settings"),
                            Encoded_OperatingSystem = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Encoded_OperatingSystem"),
                            Cropped = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cropped"),
                            Dimensions = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Dimensions"),
                            DotsPerInch = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "DotsPerInch"),
                            Lightness = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Lightness"),
                            OriginalSourceMedium = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceMedium"),
                            OriginalSourceForm = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm"),
                            OriginalSourceFormNumColors = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm/NumColors"),
                            OriginalSourceFormName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm/Name"),
                            OriginalSourceFormCropped = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm/Cropped"),
                            OriginalSourceFormSharpness = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalSourceForm/Sharpness"),
                            Tagged_Application = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Tagged_Application"),
                            BPM = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "BPM"),
                            ISRC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ISRC"),
                            ISBN = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ISBN"),
                            BarCode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "BarCode"),
                            LCCN = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "LCCN"),
                            CatalogNumber = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "CatalogNumber"),
                            LabelCode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "LabelCode"),
                            Owner = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Owner"),
                            Copyright = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Copyright"),
                            CopyrightUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Copyright/Url"),
                            Producer_Copyright = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Producer_Copyright"),
                            TermsOfUse = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "TermsOfUse"),
                            ServiceName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ServiceName"),
                            ServiceChannel = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ServiceChannel"),
                            ServiceUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Service/Url"),
                            ServiceProvider = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ServiceProvider"),
                            ServiceProviderUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ServiceProvider/Url"),
                            ServiceType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "ServiceType"),
                            NetworkName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "NetworkName"),
                            OriginalNetworkName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "OriginalNetworkName"),
                            Country = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Country"),
                            TimeZone = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "TimeZone"),
                            Cover = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cover"),
                            Cover_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cover_Description"),
                            Cover_Type = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cover_Type"),
                            Cover_Mime = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cover_Mime"),
                            Cover_Data = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Cover_Data"),
                            Lyrics = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Lyrics"),
                            Comment = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Comment"),
                            Rating = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Rating"),
                            Added_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Added_Date"),
                            Played_First_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Played_First_Date"),
                            Played_Last_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Played_Last_Date"),
                            Played_Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "Played_Count"),
                            EPG_Positions_Begin = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "EPG_Positions_Begin"),
                            EPG_Positions_End = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.General, i, "EPG_Positions_End"),
                        };
                        this._General.Add(item);
                    }
                }
            }
        }

        public List<GeneralTrack> General
        {
            get
            {
                if (this._General == null)
                {
                    this.getGeneralInfo();
                }
                return this._General;
            }
        }

        public int GeneralCount
        {
            get
            {
                return this._GeneralCount;
            }
        }

        private void getImageInfo()
        {
            if (this._Image == null)
            {
                this._Image = new List<ImageTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Image);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        ImageTrack item = new ImageTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "MenuID/String"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Title"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Profile"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Settings"),
                            Format_Settings_Wrapping = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Format_Settings_Wrapping"),
                            InternetMediaType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "InternetMediaType"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "CodecID_Description"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Codec/String"),
                            CodecFamily = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Codec/Family"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Codec/Url"),
                            Width = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width"),
                            WidthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width/String"),
                            Width_Offset = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width_Offset"),
                            Width_OffsetString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width_Offset/String"),
                            Width_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width_Original"),
                            Width_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Width_Original/String"),
                            Height = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height"),
                            HeightString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height/String"),
                            Height_Offset = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height_Offset"),
                            Height_OffsetString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height_Offset/String"),
                            Height_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height_Original"),
                            Height_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Height_Original/String"),
                            PixelAspectRatio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "PixelAspectRatio"),
                            PixelAspectRatioString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "PixelAspectRatio/String"),
                            PixelAspectRatio_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "PixelAspectRatio_Original"),
                            PixelAspectRatio_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "PixelAspectRatio_Original/String"),
                            DisplayAspectRatio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "DisplayAspectRatio"),
                            DisplayAspectRatioString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "DisplayAspectRatio/String"),
                            DisplayAspectRatio_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "DisplayAspectRatio_Original"),
                            DisplayAspectRatio_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "DisplayAspectRatio_Original/String"),
                            ColorSpace = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ColorSpace"),
                            ChromaSubsampling = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ChromaSubsampling"),
                            Resolution = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Resolution"),
                            ResolutionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Resolution/String"),
                            BitDepth = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "BitDepth"),
                            BitDepthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "BitDepth/String"),
                            Compression_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Compression_Mode"),
                            Compression_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Compression_Mode/String"),
                            Compression_Ratio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Compression_Ratio"),
                            StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize"),
                            StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String"),
                            StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String1"),
                            StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String2"),
                            StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String3"),
                            StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String4"),
                            StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize/String5"),
                            StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Proportion"),
                            StreamSize_Demuxed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed"),
                            StreamSize_DemuxedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String"),
                            StreamSize_DemuxedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String1"),
                            StreamSize_DemuxedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String2"),
                            StreamSize_DemuxedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String3"),
                            StreamSize_DemuxedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String4"),
                            StreamSize_DemuxedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "StreamSize_Demuxed/String5"),
                            Encoded_Library = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library"),
                            Encoded_LibraryString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library/String"),
                            Encoded_Library_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library_Name"),
                            Encoded_Library_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library_Version"),
                            Encoded_Library_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library_Date"),
                            Encoded_Library_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Library_Settings"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "ServiceKind/String"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "AlternateGroup/String"),
                            Summary = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Summary"),
                            Encoded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encoded_Date"),
                            Tagged_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Tagged_Date"),
                            Encryption = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "Encryption"),
                            colour_description_present = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "colour_description_present"),
                            colour_primaries = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "colour_primaries"),
                            transfer_characteristics = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "transfer_characteristics"),
                            matrix_coefficients = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "matrix_coefficients"),
                            colour_description_present_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "colour_description_present_Original"),
                            colour_primaries_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "colour_primaries_Original"),
                            transfer_characteristics_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "transfer_characteristics_Original"),
                            matrix_coefficients_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Image, i, "matrix_coefficients_Original"),
                        };
                        this._Image.Add(item);
                    }
                }
            }
        }

        public List<ImageTrack> Image
        {
            get
            {
                if (this._Image == null)
                {
                    this.getImageInfo();
                }
                return this._Image;
            }
        }

        public int ImageCount
        {
            get
            {
                return this._ImageCount;
            }
        }

        private void getMenuInfo()
        {
            if (this._Menu == null)
            {
                this._Menu = new List<MenuTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Menu);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        MenuTrack item = new MenuTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "MenuID/String"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Profile"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Format_Settings"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "CodecID_Description"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Codec/String"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Codec/Url"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration/String5"),
                            Duration_Start = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration_Start"),
                            Duration_End = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Duration_End"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Delay_Source"),
                            List_StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "List_StreamKind"),
                            List_StreamPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "List_StreamPos"),
                            List = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "List"),
                            ListString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "List/String"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Title"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceKind/String"),
                            ServiceName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceName"),
                            ServiceChannel = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceChannel"),
                            ServiceUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Service/Url"),
                            ServiceProvider = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceProvider"),
                            ServiceProviderUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceProvider/Url"),
                            ServiceType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "ServiceType"),
                            NetworkName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "NetworkName"),
                            OriginalNetworkName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Original/NetworkName"),
                            Countries = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Countries"),
                            TimeZones = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "TimeZones"),
                            LawRating = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "LawRating"),
                            LawRating_Reason = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "LawRating_Reason"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "AlternateGroup/String"),
                            Chapters_Pos_Begin = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Chapters_Pos_Begin"),
                            Chapters_Pos_End = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Menu, i, "Chapters_Pos_End"),
                        };
                        this._Menu.Add(item);
                    }
                }
            }
        }

        public List<MenuTrack> Menu
        {
            get
            {
                if (this._Menu == null)
                {
                    this.getMenuInfo();
                }
                return this._Menu;
            }
        }

        public int MenuCount
        {
            get
            {
                return this._MenuCount;
            }
        }

        private void getOtherInfo()
        {
            if (this._Other == null)
            {
                this._Other = new List<OtherTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Other);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        OtherTrack item = new OtherTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "MenuID/String"),
                            Type = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Type"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Profile"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Format_Settings"),
                            MuxingMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "MuxingMode"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "CodecID_Description"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration/String5"),
                            Duration_Start = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration_Start"),
                            Duration_End = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Duration_End"),
                            FrameRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FrameRate"),
                            FrameRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FrameRate/String"),
                            FrameRate_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FrameRate_Num"),
                            FrameRate_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FrameRate_Den"),
                            FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "FrameCount"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Source"),
                            Delay_SourceString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Source/String"),
                            Delay_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original"),
                            Delay_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String"),
                            Delay_OriginalString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String1"),
                            Delay_OriginalString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String2"),
                            Delay_OriginalString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String3"),
                            Delay_OriginalString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String4"),
                            Delay_OriginalString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original/String5"),
                            Delay_Original_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original_Settings"),
                            Delay_Original_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original_DropFrame"),
                            Delay_Original_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Delay_Original_Source"),
                            Video_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay"),
                            Video_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String"),
                            Video_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String1"),
                            Video_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String2"),
                            Video_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String3"),
                            Video_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String4"),
                            Video_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video_Delay/String5"),
                            Video0_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay"),
                            Video0_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String"),
                            Video0_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String1"),
                            Video0_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String2"),
                            Video0_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String3"),
                            Video0_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String4"),
                            Video0_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Video0_Delay/String5"),
                            TimeStamp_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame"),
                            TimeStamp_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String"),
                            TimeStamp_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String1"),
                            TimeStamp_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String2"),
                            TimeStamp_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String3"),
                            TimeStamp_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String4"),
                            TimeStamp_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeStamp_FirstFrame/String5"),
                            TimeCode_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeCode_FirstFrame"),
                            TimeCode_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeCode_Settings"),
                            TimeCode_Striped = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeCode_Striped"),
                            TimeCode_StripedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "TimeCode_Striped/String"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Title"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "ServiceKind/String"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Other, i, "AlternateGroup/String"),
                        };
                        this._Other.Add(item);
                    }
                }
            }
        }

        public List<OtherTrack> Other
        {
            get
            {
                if (this._Other == null)
                {
                    this.getOtherInfo();
                }
                return this._Other;
            }
        }

        public int OtherCount
        {
            get
            {
                return this._OtherCount;
            }
        }

        private void getTextInfo()
        {
            if (this._Text == null)
            {
                this._Text = new List<TextTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Text);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        TextTrack item = new TextTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "MenuID/String"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Profile"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Compression"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Settings"),
                            Format_Settings_Wrapping = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Format_Settings_Wrapping"),
                            InternetMediaType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "InternetMediaType"),
                            MuxingMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "MuxingMode"),
                            MuxingMode_MoreInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "MuxingMode_MoreInfo"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "CodecID_Description"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Codec/String"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Codec/Url"),
                            CodecCC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Codec/CC"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration/String5"),
                            Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame"),
                            Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String"),
                            Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String1"),
                            Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String2"),
                            Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String3"),
                            Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String4"),
                            Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_FirstFrame/String5"),
                            Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame"),
                            Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String"),
                            Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String1"),
                            Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String2"),
                            Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String3"),
                            Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String4"),
                            Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Duration_LastFrame/String5"),
                            Source_Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration"),
                            Source_DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String"),
                            Source_DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String1"),
                            Source_DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String2"),
                            Source_DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String3"),
                            Source_DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String4"),
                            Source_DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration/String5"),
                            Source_Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame"),
                            Source_Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String"),
                            Source_Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String1"),
                            Source_Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String2"),
                            Source_Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String3"),
                            Source_Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String4"),
                            Source_Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_FirstFrame/String5"),
                            Source_Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame"),
                            Source_Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String"),
                            Source_Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String1"),
                            Source_Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String2"),
                            Source_Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String3"),
                            Source_Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String4"),
                            Source_Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_Duration_LastFrame/String5"),
                            BitRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Mode"),
                            BitRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Mode/String"),
                            BitRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate"),
                            BitRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate/String"),
                            BitRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Minimum"),
                            BitRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Minimum/String"),
                            BitRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Nominal"),
                            BitRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Nominal/String"),
                            BitRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Maximum"),
                            BitRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Maximum/String"),
                            BitRate_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Encoded"),
                            BitRate_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitRate_Encoded/String"),
                            Width = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Width"),
                            WidthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Width/String"),
                            Height = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Height"),
                            HeightString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Height/String"),
                            FrameRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Mode"),
                            FrameRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Mode/String"),
                            FrameRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate"),
                            FrameRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate/String"),
                            FrameRate_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Num"),
                            FrameRate_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Den"),
                            FrameRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Minimum"),
                            FrameRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Minimum/String"),
                            FrameRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Nominal"),
                            FrameRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Nominal/String"),
                            FrameRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Maximum"),
                            FrameRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Maximum/String"),
                            FrameRate_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Original"),
                            FrameRate_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameRate_Original/String"),
                            FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "FrameCount"),
                            ElementCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ElementCount"),
                            Source_FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_FrameCount"),
                            ColorSpace = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ColorSpace"),
                            ChromaSubsampling = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ChromaSubsampling"),
                            Resolution = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Resolution"),
                            ResolutionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Resolution/String"),
                            BitDepth = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitDepth"),
                            BitDepthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "BitDepth/String"),
                            Compression_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Compression_Mode"),
                            Compression_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Compression_Mode/String"),
                            Compression_Ratio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Compression_Ratio"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Source"),
                            Delay_SourceString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Source/String"),
                            Delay_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original"),
                            Delay_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String"),
                            Delay_OriginalString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String1"),
                            Delay_OriginalString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String2"),
                            Delay_OriginalString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String3"),
                            Delay_OriginalString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String4"),
                            Delay_OriginalString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original/String5"),
                            Delay_Original_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original_Settings"),
                            Delay_Original_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original_DropFrame"),
                            Delay_Original_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Delay_Original_Source"),
                            Video_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay"),
                            Video_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String"),
                            Video_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String1"),
                            Video_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String2"),
                            Video_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String3"),
                            Video_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String4"),
                            Video_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video_Delay/String5"),
                            Video0_Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay"),
                            Video0_DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String"),
                            Video0_DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String1"),
                            Video0_DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String2"),
                            Video0_DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String3"),
                            Video0_DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String4"),
                            Video0_DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Video0_Delay/String5"),
                            StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize"),
                            StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String"),
                            StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String1"),
                            StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String2"),
                            StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String3"),
                            StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String4"),
                            StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize/String5"),
                            StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Proportion"),
                            StreamSize_Demuxed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed"),
                            StreamSize_DemuxedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String"),
                            StreamSize_DemuxedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String1"),
                            StreamSize_DemuxedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String2"),
                            StreamSize_DemuxedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String3"),
                            StreamSize_DemuxedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String4"),
                            StreamSize_DemuxedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Demuxed/String5"),
                            Source_StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize"),
                            Source_StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String"),
                            Source_StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String1"),
                            Source_StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String2"),
                            Source_StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String3"),
                            Source_StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String4"),
                            Source_StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize/String5"),
                            Source_StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Proportion"),
                            StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded"),
                            StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String"),
                            StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String1"),
                            StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String2"),
                            StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String3"),
                            StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String4"),
                            StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded/String5"),
                            StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "StreamSize_Encoded_Proportion"),
                            Source_StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded"),
                            Source_StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String"),
                            Source_StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String1"),
                            Source_StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String2"),
                            Source_StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String3"),
                            Source_StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String4"),
                            Source_StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded/String5"),
                            Source_StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Source_StreamSize_Encoded_Proportion"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Title"),
                            Encoded_Application = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application"),
                            Encoded_ApplicationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application/String"),
                            Encoded_Application_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application_CompanyName"),
                            Encoded_Application_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application_Name"),
                            Encoded_Application_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application_Version"),
                            Encoded_Application_Url = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Application_Url"),
                            Encoded_Library = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library"),
                            Encoded_LibraryString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library/String"),
                            Encoded_Library_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library_CompanyName"),
                            Encoded_Library_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library_Name"),
                            Encoded_Library_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library_Version"),
                            Encoded_Library_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library_Date"),
                            Encoded_Library_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Library_Settings"),
                            Encoded_OperatingSystem = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_OperatingSystem"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "ServiceKind/String"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "AlternateGroup/String"),
                            Summary = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Summary"),
                            Encoded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encoded_Date"),
                            Tagged_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Tagged_Date"),
                            Encryption = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Text, i, "Encryption"),
                        };
                        this._Text.Add(item);
                    }
                }
            }
        }

        public List<TextTrack> Text
        {
            get
            {
                if (this._Text == null)
                {
                    this.getTextInfo();
                }
                return this._Text;
            }
        }

        public int TextCount
        {
            get
            {
                return this._TextCount;
            }
        }

        private void getVideoInfo()
        {
            if (this._Video == null)
            {
                this._Video = new List<VideoTrack>();
                int num = MediaInfoLibClass.Count_Get(MediaInfoLib.StreamKind.Video);
                if (num > 0)
                {
                    int num2 = num - 1;
                    for (int i = 0; i <= num2; i++)
                    {
                        VideoTrack item = new VideoTrack {
                            Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Count"),
                            Status = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Status"),
                            StreamCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamCount"),
                            StreamKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamKind"),
                            StreamKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamKind/String"),
                            StreamKindID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamKindID"),
                            StreamKindPos = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamKindPos"),
                            StreamOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamOrder"),
                            FirstPacketOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FirstPacketOrder"),
                            Inform = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Inform"),
                            ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ID"),
                            IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ID/String"),
                            OriginalSourceMedium_ID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "OriginalSourceMedium_ID"),
                            OriginalSourceMedium_IDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "OriginalSourceMedium_ID/String"),
                            UniqueID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "UniqueID"),
                            UniqueIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "UniqueID/String"),
                            MenuID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MenuID"),
                            MenuIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MenuID/String"),
                            Format = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format"),
                            FormatInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format/Info"),
                            FormatUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format/Url"),
                            Format_Commercial = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Commercial"),
                            Format_Commercial_IfAny = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Commercial_IfAny"),
                            Format_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Version"),
                            Format_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Profile"),
                            Format_Level = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Level"),
                            Format_Tier = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Tier"),
                            Format_Compression = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Compression"),
                            MultiView_BaseProfile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MultiView_BaseProfile"),
                            MultiView_Count = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MultiView_Count"),
                            MultiView_Layout = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MultiView_Layout"),
                            DolbyVisionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DolbyVision/String"),
                            DolbyVision_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DolbyVision_Version"),
                            DolbyVision_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DolbyVision_Profile"),
                            DolbyVision_Layers = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DolbyVision_Layers"),
                            Format_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings"),
                            Format_Settings_BVOP = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_BVOP"),
                            Format_Settings_BVOPString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_BVOP/String"),
                            Format_Settings_QPel = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_QPel"),
                            Format_Settings_QPelString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_QPel/String"),
                            Format_Settings_GMC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_GMC"),
                            Format_Settings_GMCString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_GMC/String"),
                            Format_Settings_Matrix = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_Matrix"),
                            Format_Settings_MatrixString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_Matrix/String"),
                            Format_Settings_Matrix_Data = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_Matrix_Data"),
                            Format_Settings_CABAC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_CABAC"),
                            Format_Settings_CABACString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_CABAC/String"),
                            Format_Settings_RefFrames = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_RefFrames"),
                            Format_Settings_RefFramesString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_RefFrames/String"),
                            Format_Settings_Pulldown = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_Pulldown"),
                            Format_Settings_FrameMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_FrameMode"),
                            Format_Settings_GOP = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_GOP"),
                            Format_Settings_PictureStructure = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_PictureStructure"),
                            Format_Settings_Wrapping = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Format_Settings_Wrapping"),
                            InternetMediaType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "InternetMediaType"),
                            MuxingMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "MuxingMode"),
                            CodecID = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID"),
                            CodecIDString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID/String"),
                            CodecIDInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID/Info"),
                            CodecIDHint = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID/Hint"),
                            CodecIDUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID/Url"),
                            CodecID_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "CodecID_Description"),
                            Codec = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec"),
                            CodecString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec/String"),
                            CodecFamily = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec/Family"),
                            CodecInfo = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec/Info"),
                            CodecUrl = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec/Url"),
                            CodecCC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec/CC"),
                            Codec_Profile = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Profile"),
                            Codec_Description = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Description"),
                            Codec_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings"),
                            Codec_Settings_PacketBitStream = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_PacketBitStream"),
                            Codec_Settings_BVOP = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_BVOP"),
                            Codec_Settings_QPel = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_QPel"),
                            Codec_Settings_GMC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_GMC"),
                            Codec_Settings_GMCString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_GMC/String"),
                            Codec_Settings_Matrix = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_Matrix"),
                            Codec_Settings_Matrix_Data = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_Matrix_Data"),
                            Codec_Settings_CABAC = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_CABAC"),
                            Codec_Settings_RefFrames = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Codec_Settings_RefFrames"),
                            Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration"),
                            DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String"),
                            DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String1"),
                            DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String2"),
                            DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String3"),
                            DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String4"),
                            DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration/String5"),
                            Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame"),
                            Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String"),
                            Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String1"),
                            Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String2"),
                            Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String3"),
                            Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String4"),
                            Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_FirstFrame/String5"),
                            Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame"),
                            Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String"),
                            Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String1"),
                            Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String2"),
                            Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String3"),
                            Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String4"),
                            Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Duration_LastFrame/String5"),
                            Source_Duration = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration"),
                            Source_DurationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String"),
                            Source_DurationString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String1"),
                            Source_DurationString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String2"),
                            Source_DurationString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String3"),
                            Source_DurationString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String4"),
                            Source_DurationString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration/String5"),
                            Source_Duration_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame"),
                            Source_Duration_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String"),
                            Source_Duration_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String1"),
                            Source_Duration_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String2"),
                            Source_Duration_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String3"),
                            Source_Duration_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String4"),
                            Source_Duration_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_FirstFrame/String5"),
                            Source_Duration_LastFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame"),
                            Source_Duration_LastFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String"),
                            Source_Duration_LastFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String1"),
                            Source_Duration_LastFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String2"),
                            Source_Duration_LastFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String3"),
                            Source_Duration_LastFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String4"),
                            Source_Duration_LastFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_Duration_LastFrame/String5"),
                            BitRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Mode"),
                            BitRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Mode/String"),
                            BitRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate"),
                            BitRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate/String"),
                            BitRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Minimum"),
                            BitRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Minimum/String"),
                            BitRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Nominal"),
                            BitRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Nominal/String"),
                            BitRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Maximum"),
                            BitRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Maximum/String"),
                            BitRate_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Encoded"),
                            BitRate_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitRate_Encoded/String"),
                            Width = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width"),
                            WidthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width/String"),
                            Width_Offset = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_Offset"),
                            Width_OffsetString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_Offset/String"),
                            Width_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_Original"),
                            Width_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_Original/String"),
                            Width_CleanAperture = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_CleanAperture"),
                            Width_CleanApertureString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Width_CleanAperture/String"),
                            Height = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height"),
                            HeightString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height/String"),
                            Height_Offset = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_Offset"),
                            Height_OffsetString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_Offset/String"),
                            Height_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_Original"),
                            Height_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_Original/String"),
                            Height_CleanAperture = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_CleanAperture"),
                            Height_CleanApertureString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Height_CleanAperture/String"),
                            Stored_Width = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Stored_Width"),
                            Stored_Height = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Stored_Height"),
                            Sampled_Width = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Sampled_Width"),
                            Sampled_Height = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Sampled_Height"),
                            PixelAspectRatio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio"),
                            PixelAspectRatioString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio/String"),
                            PixelAspectRatio_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio_Original"),
                            PixelAspectRatio_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio_Original/String"),
                            PixelAspectRatio_CleanAperture = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio_CleanAperture"),
                            PixelAspectRatio_CleanApertureString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "PixelAspectRatio_CleanAperture/String"),
                            DisplayAspectRatio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio"),
                            DisplayAspectRatioString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio/String"),
                            DisplayAspectRatio_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio_Original"),
                            DisplayAspectRatio_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio_Original/String"),
                            DisplayAspectRatio_CleanAperture = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio_CleanAperture"),
                            DisplayAspectRatio_CleanApertureString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "DisplayAspectRatio_CleanAperture/String"),
                            ActiveFormatDescription = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ActiveFormatDescription"),
                            ActiveFormatDescriptionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ActiveFormatDescription/String"),
                            ActiveFormatDescription_MuxingMode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ActiveFormatDescription_MuxingMode"),
                            Rotation = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Rotation"),
                            RotationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Rotation/String"),
                            FrameRate_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Mode"),
                            FrameRate_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Mode/String"),
                            FrameRate_Mode_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Mode_Original"),
                            FrameRate_Mode_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Mode_Original/String"),
                            FrameRate = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate"),
                            FrameRateString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate/String"),
                            FrameRate_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Num"),
                            FrameRate_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Den"),
                            FrameRate_Minimum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Minimum"),
                            FrameRate_MinimumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Minimum/String"),
                            FrameRate_Nominal = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Nominal"),
                            FrameRate_NominalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Nominal/String"),
                            FrameRate_Maximum = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Maximum"),
                            FrameRate_MaximumString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Maximum/String"),
                            FrameRate_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Original"),
                            FrameRate_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Original/String"),
                            FrameRate_Original_Num = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Original_Num"),
                            FrameRate_Original_Den = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameRate_Original_Den"),
                            FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "FrameCount"),
                            Source_FrameCount = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_FrameCount"),
                            Standard = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Standard"),
                            Resolution = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Resolution"),
                            ResolutionString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Resolution/String"),
                            Colorimetry = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Colorimetry"),
                            ColorSpace = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ColorSpace"),
                            ChromaSubsampling = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ChromaSubsampling"),
                            ChromaSubsamplingString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ChromaSubsampling/String"),
                            ChromaSubsampling_Position = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ChromaSubsampling_Position"),
                            BitDepth = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitDepth"),
                            BitDepthString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BitDepth/String"),
                            ScanType = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType"),
                            ScanTypeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType/String"),
                            ScanType_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType_Original"),
                            ScanType_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType_Original/String"),
                            ScanType_StoreMethod = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType_StoreMethod"),
                            ScanType_StoreMethod_FieldsPerBlock = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType_StoreMethod_FieldsPerBlock"),
                            ScanType_StoreMethodString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanType_StoreMethod/String"),
                            ScanOrder = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder"),
                            ScanOrderString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder/String"),
                            ScanOrder_Stored = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder_Stored"),
                            ScanOrder_StoredString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder_Stored/String"),
                            ScanOrder_StoredDisplayedInverted = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder_StoredDisplayedInverted"),
                            ScanOrder_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder_Original"),
                            ScanOrder_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ScanOrder_Original/String"),
                            Interlacement = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Interlacement"),
                            InterlacementString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Interlacement/String"),
                            Compression_Mode = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Compression_Mode"),
                            Compression_ModeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Compression_Mode/String"),
                            Compression_Ratio = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Compression_Ratio"),
                            BitsPixelFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Bits-(Pixel*Frame)"),
                            Delay = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay"),
                            DelayString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String"),
                            DelayString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String1"),
                            DelayString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String2"),
                            DelayString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String3"),
                            DelayString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String4"),
                            DelayString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay/String5"),
                            Delay_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Settings"),
                            Delay_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_DropFrame"),
                            Delay_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Source"),
                            Delay_SourceString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Source/String"),
                            Delay_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original"),
                            Delay_OriginalString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String"),
                            Delay_OriginalString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String1"),
                            Delay_OriginalString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String2"),
                            Delay_OriginalString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String3"),
                            Delay_OriginalString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String4"),
                            Delay_OriginalString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original/String5"),
                            Delay_Original_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original_Settings"),
                            Delay_Original_DropFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original_DropFrame"),
                            Delay_Original_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Delay_Original_Source"),
                            TimeStamp_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame"),
                            TimeStamp_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String"),
                            TimeStamp_FirstFrameString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String1"),
                            TimeStamp_FirstFrameString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String2"),
                            TimeStamp_FirstFrameString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String3"),
                            TimeStamp_FirstFrameString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String4"),
                            TimeStamp_FirstFrameString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeStamp_FirstFrame/String5"),
                            TimeCode_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeCode_FirstFrame"),
                            TimeCode_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeCode_Settings"),
                            TimeCode_Source = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "TimeCode_Source"),
                            Gop_OpenClosed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Gop_OpenClosed"),
                            Gop_OpenClosedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Gop_OpenClosed/String"),
                            Gop_OpenClosed_FirstFrame = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Gop_OpenClosed_FirstFrame"),
                            Gop_OpenClosed_FirstFrameString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Gop_OpenClosed_FirstFrame/String"),
                            StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize"),
                            StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String"),
                            StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String1"),
                            StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String2"),
                            StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String3"),
                            StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String4"),
                            StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize/String5"),
                            StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Proportion"),
                            StreamSize_Demuxed = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed"),
                            StreamSize_DemuxedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String"),
                            StreamSize_DemuxedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String1"),
                            StreamSize_DemuxedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String2"),
                            StreamSize_DemuxedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String3"),
                            StreamSize_DemuxedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String4"),
                            StreamSize_DemuxedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Demuxed/String5"),
                            Source_StreamSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize"),
                            Source_StreamSizeString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String"),
                            Source_StreamSizeString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String1"),
                            Source_StreamSizeString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String2"),
                            Source_StreamSizeString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String3"),
                            Source_StreamSizeString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String4"),
                            Source_StreamSizeString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize/String5"),
                            Source_StreamSize_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Proportion"),
                            StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded"),
                            StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String"),
                            StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String1"),
                            StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String2"),
                            StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String3"),
                            StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String4"),
                            StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded/String5"),
                            StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "StreamSize_Encoded_Proportion"),
                            Source_StreamSize_Encoded = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded"),
                            Source_StreamSize_EncodedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String"),
                            Source_StreamSize_EncodedString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String1"),
                            Source_StreamSize_EncodedString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String2"),
                            Source_StreamSize_EncodedString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String3"),
                            Source_StreamSize_EncodedString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String4"),
                            Source_StreamSize_EncodedString5 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded/String5"),
                            Source_StreamSize_Encoded_Proportion = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Source_StreamSize_Encoded_Proportion"),
                            Alignment = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Alignment"),
                            AlignmentString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Alignment/String"),
                            Title = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Title"),
                            Encoded_Application = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application"),
                            Encoded_ApplicationString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application/String"),
                            Encoded_Application_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application_CompanyName"),
                            Encoded_Application_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application_Name"),
                            Encoded_Application_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application_Version"),
                            Encoded_Application_Url = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Application_Url"),
                            Encoded_Library = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library"),
                            Encoded_LibraryString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library/String"),
                            Encoded_Library_CompanyName = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library_CompanyName"),
                            Encoded_Library_Name = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library_Name"),
                            Encoded_Library_Version = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library_Version"),
                            Encoded_Library_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library_Date"),
                            Encoded_Library_Settings = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Library_Settings"),
                            Encoded_OperatingSystem = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_OperatingSystem"),
                            Language = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language"),
                            LanguageString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language/String"),
                            LanguageString1 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language/String1"),
                            LanguageString2 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language/String2"),
                            LanguageString3 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language/String3"),
                            LanguageString4 = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language/String4"),
                            Language_More = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Language_More"),
                            ServiceKind = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ServiceKind"),
                            ServiceKindString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "ServiceKind/String"),
                            Disabled = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Disabled"),
                            DisabledString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Disabled/String"),
                            Default = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Default"),
                            DefaultString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Default/String"),
                            Forced = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Forced"),
                            ForcedString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Forced/String"),
                            AlternateGroup = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "AlternateGroup"),
                            AlternateGroupString = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "AlternateGroup/String"),
                            Encoded_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encoded_Date"),
                            Tagged_Date = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Tagged_Date"),
                            Encryption = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "Encryption"),
                            BufferSize = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "BufferSize"),
                            colour_range = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "colour_range"),
                            colour_description_present = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "colour_description_present"),
                            colour_primaries = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "colour_primaries"),
                            transfer_characteristics = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "transfer_characteristics"),
                            matrix_coefficients = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "matrix_coefficients"),
                            colour_description_present_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "colour_description_present_Original"),
                            colour_primaries_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "colour_primaries_Original"),
                            transfer_characteristics_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "transfer_characteristics_Original"),
                            matrix_coefficients_Original = MediaInfoLibClass.Get(MediaInfoLib.StreamKind.Video, i, "matrix_coefficients_Original"),
                        };
                        this._Video.Add(item);
                    }
                }
            }
        }

        public List<VideoTrack> Video
        {
            get
            {
                if (this._Video == null)
                {
                    this.getVideoInfo();
                }
                return this._Video;
            }
        }

        public int VideoCount
        {
            get
            {
                return this._VideoCount;
            }
        }

    }
}


