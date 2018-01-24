namespace MediaInfoWrapper
{
    using System;

    public class OtherTrack
    {
        private string _Count;  //Count of objects available in this stream
        private string _Status;  //bit field (0=IsAccepted, 1=IsFilled, 2=IsUpdated, 3=IsFinished)
        private string _StreamCount;  //Count of streams of that kind available
        private string _StreamKind;  //Stream type name
        private string _StreamKindString;  //Stream type name
        private string _StreamKindID;  //Number of the stream (base=0)
        private string _StreamKindPos;  //When multiple streams, number of the stream (base=1)
        private string _StreamOrder;  //Stream order in the file, whatever is the kind of stream (base=0)
        private string _FirstPacketOrder;  //Order of the first fully decodable packet met in the file, whatever is the kind of stream (base=0)
        private string _Inform;  //Last **Inform** call
        private string _ID;  //The ID for this stream in this file
        private string _IDString;  //The ID for this stream in this file
        private string _OriginalSourceMedium_ID;  //The ID for this stream in the original medium of the material
        private string _OriginalSourceMedium_IDString;  //The ID for this stream in the original medium of the material
        private string _UniqueID;  //The unique ID for this stream, should be copied with stream copy
        private string _UniqueIDString;  //The unique ID for this stream, should be copied with stream copy
        private string _MenuID;  //The menu ID for this stream in this file
        private string _MenuIDString;  //The menu ID for this stream in this file
        private string _Type;  //Type
        private string _Format;  //Format used
        private string _FormatInfo;  //Info about Format
        private string _FormatUrl;  //Link
        private string _Format_Commercial;  //Commercial name used by vendor for theses setings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for theses setings if there is one
        private string _Format_Version;  //Version of this format
        private string _Format_Profile;  //Profile of the Format
        private string _Format_Compression;  //Compression method used
        private string _Format_Settings;  //Settings needed for decoder used
        private string _MuxingMode;  //How this file is muxed in the container
        private string _CodecID;  //Codec ID (found in some containers)
        private string _CodecIDString;  //Codec ID (found in some containers)
        private string _CodecIDInfo;  //Info about this codec
        private string _CodecIDHint;  //A hint/popular name for this codec
        private string _CodecIDUrl;  //A link to more details about this codec ID
        private string _CodecID_Description;  //Manual description given by the container
        private string _Duration;  //Play time of the stream in ms
        private string _DurationString;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString1;  //Play time in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _DurationString2;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString3;  //Play time in format : HH:MM:SS.MMM
        private string _DurationString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _DurationString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start;  //
        private string _Duration_End;  //
        private string _FrameRate;  //Frames per second
        private string _FrameRateString;  //Frames per second (with measurement)
        private string _FrameRate_Num;  //Frames per second, numerator
        private string _FrameRate_Den;  //Frames per second, denominator
        private string _FrameCount;  //Number of frames
        private string _Delay;  //Delay fixed in the stream (relative) IN MS
        private string _DelayString;  //Delay with measurement
        private string _DelayString1;  //Delay with measurement
        private string _DelayString2;  //Delay with measurement
        private string _DelayString3;  //Delay in format : HH:MM:SS.MMM
        private string _DelayString4;  //Delay in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _DelayString5;  //Delay in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Settings;  //Delay settings (in case of timecode for example)
        private string _Delay_DropFrame;  //Delay drop frame
        private string _Delay_Source;  //Delay source (Container or Stream or empty)
        private string _Delay_SourceString;  //Delay source (Container or Stream or empty)
        private string _Delay_Original;  //Delay fixed in the raw stream (relative) IN MS
        private string _Delay_OriginalString;  //Delay with measurement
        private string _Delay_OriginalString1;  //Delay with measurement
        private string _Delay_OriginalString2;  //Delay with measurement
        private string _Delay_OriginalString3;  //Delay in format: HH:MM:SS.MMM
        private string _Delay_OriginalString4;  //Delay in format: HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Delay_OriginalString5;  //Delay in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Original_Settings;  //Delay settings (in case of timecode for example)
        private string _Delay_Original_DropFrame;  //Delay drop frame info
        private string _Delay_Original_Source;  //Delay source (Stream or empty)
        private string _Video_Delay;  //Delay fixed in the stream (absolute / video)
        private string _Video_DelayString;  //
        private string _Video_DelayString1;  //
        private string _Video_DelayString2;  //
        private string _Video_DelayString3;  //
        private string _Video_DelayString4;  //
        private string _Video_DelayString5;  //
        private string _Video0_Delay;  //Deprecated, do not use in new projects
        private string _Video0_DelayString;  //Deprecated, do not use in new projects
        private string _Video0_DelayString1;  //Deprecated, do not use in new projects
        private string _Video0_DelayString2;  //Deprecated, do not use in new projects
        private string _Video0_DelayString3;  //Deprecated, do not use in new projects
        private string _Video0_DelayString4;  //Deprecated, do not use in new projects
        private string _Video0_DelayString5;  //Deprecated, do not use in new projects
        private string _TimeStamp_FirstFrame;  //TimeStamp fixed in the stream (relative) IN MS
        private string _TimeStamp_FirstFrameString;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString1;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString2;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString3;  //TimeStamp in format : HH:MM:SS.MMM
        private string _TimeStamp_FirstFrameString4;  //TimeStamp in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _TimeStamp_FirstFrameString5;  //TimeStamp in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _TimeCode_FirstFrame;  //Time code in HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available format
        private string _TimeCode_Settings;  //Time code settings
        private string _TimeCode_Striped;  //Time code is striped (only 1st time code, no discontinuity)
        private string _TimeCode_StripedString;  //Time code is striped (only 1st time code, no discontinuity)
        private string _Title;  //Name of this menu
        private string _Language;  //Language (2-letter ISO 639-1 if exists, else 3-letter ISO 639-2, and with optional ISO 3166-1 country separated by a dash if available, e.g. en, en-us, zh-cn)
        private string _LanguageString;  //Language (full)
        private string _LanguageString1;  //Language (full)
        private string _LanguageString2;  //Language (2-letter ISO 639-1 if exists, else empty)
        private string _LanguageString3;  //Language (3-letter ISO 639-2 if exists, else empty)
        private string _LanguageString4;  //Language (2-letter ISO 639-1 if exists with optional ISO 3166-1 country separated by a dash if available, e.g. en, en-us, zh-cn, else empty)
        private string _Language_More;  //More info about Language (e.g. Director's Comment)
        private string _ServiceKind;  //Service kind, e.g. visually impaired, commentary, voice over
        private string _ServiceKindString;  //Service kind (full)
        private string _Disabled;  //Set if that track should not be used
        private string _DisabledString;  //Set if that track should not be used
        private string _Default;  //Set if that track should be used if no language found matches the user preference.
        private string _DefaultString;  //Set if that track should be used if no language found matches the user preference.
        private string _Forced;  //Set if that track should be used if no language found matches the user preference.
        private string _ForcedString;  //Set if that track should be used if no language found matches the user preference.
        private string _AlternateGroup;  //Number of a group in order to provide versions of the same track
        private string _AlternateGroupString;  //Number of a group in order to provide versions of the same track

        public string Count { get { if (string.IsNullOrEmpty(this._Count)) { this._Count = ""; } return this._Count; } set { this._Count = value; } }
        public string Status { get { if (string.IsNullOrEmpty(this._Status)) { this._Status = ""; } return this._Status; } set { this._Status = value; } }
        public string StreamCount { get { if (string.IsNullOrEmpty(this._StreamCount)) { this._StreamCount = ""; } return this._StreamCount; } set { this._StreamCount = value; } }
        public string StreamKind { get { if (string.IsNullOrEmpty(this._StreamKind)) { this._StreamKind = ""; } return this._StreamKind; } set { this._StreamKind = value; } }
        public string StreamKindString { get { if (string.IsNullOrEmpty(this._StreamKindString)) { this._StreamKindString = ""; } return this._StreamKindString; } set { this._StreamKindString = value; } }
        public string StreamKindID { get { if (string.IsNullOrEmpty(this._StreamKindID)) { this._StreamKindID = ""; } return this._StreamKindID; } set { this._StreamKindID = value; } }
        public string StreamKindPos { get { if (string.IsNullOrEmpty(this._StreamKindPos)) { this._StreamKindPos = ""; } return this._StreamKindPos; } set { this._StreamKindPos = value; } }
        public string StreamOrder { get { if (string.IsNullOrEmpty(this._StreamOrder)) { this._StreamOrder = ""; } return this._StreamOrder; } set { this._StreamOrder = value; } }
        public string FirstPacketOrder { get { if (string.IsNullOrEmpty(this._FirstPacketOrder)) { this._FirstPacketOrder = ""; } return this._FirstPacketOrder; } set { this._FirstPacketOrder = value; } }
        public string Inform { get { if (string.IsNullOrEmpty(this._Inform)) { this._Inform = ""; } return this._Inform; } set { this._Inform = value; } }
        public string ID { get { if (string.IsNullOrEmpty(this._ID)) { this._ID = ""; } return this._ID; } set { this._ID = value; } }
        public string IDString { get { if (string.IsNullOrEmpty(this._IDString)) { this._IDString = ""; } return this._IDString; } set { this._IDString = value; } }
        public string OriginalSourceMedium_ID { get { if (string.IsNullOrEmpty(this._OriginalSourceMedium_ID)) { this._OriginalSourceMedium_ID = ""; } return this._OriginalSourceMedium_ID; } set { this._OriginalSourceMedium_ID = value; } }
        public string OriginalSourceMedium_IDString { get { if (string.IsNullOrEmpty(this._OriginalSourceMedium_IDString)) { this._OriginalSourceMedium_IDString = ""; } return this._OriginalSourceMedium_IDString; } set { this._OriginalSourceMedium_IDString = value; } }
        public string UniqueID { get { if (string.IsNullOrEmpty(this._UniqueID)) { this._UniqueID = ""; } return this._UniqueID; } set { this._UniqueID = value; } }
        public string UniqueIDString { get { if (string.IsNullOrEmpty(this._UniqueIDString)) { this._UniqueIDString = ""; } return this._UniqueIDString; } set { this._UniqueIDString = value; } }
        public string MenuID { get { if (string.IsNullOrEmpty(this._MenuID)) { this._MenuID = ""; } return this._MenuID; } set { this._MenuID = value; } }
        public string MenuIDString { get { if (string.IsNullOrEmpty(this._MenuIDString)) { this._MenuIDString = ""; } return this._MenuIDString; } set { this._MenuIDString = value; } }
        public string Type { get { if (string.IsNullOrEmpty(this._Type)) { this._Type = ""; } return this._Type; } set { this._Type = value; } }
        public string Format { get { if (string.IsNullOrEmpty(this._Format)) { this._Format = ""; } return this._Format; } set { this._Format = value; } }
        public string FormatInfo { get { if (string.IsNullOrEmpty(this._FormatInfo)) { this._FormatInfo = ""; } return this._FormatInfo; } set { this._FormatInfo = value; } }
        public string FormatUrl { get { if (string.IsNullOrEmpty(this._FormatUrl)) { this._FormatUrl = ""; } return this._FormatUrl; } set { this._FormatUrl = value; } }
        public string Format_Commercial { get { if (string.IsNullOrEmpty(this._Format_Commercial)) { this._Format_Commercial = ""; } return this._Format_Commercial; } set { this._Format_Commercial = value; } }
        public string Format_Commercial_IfAny { get { if (string.IsNullOrEmpty(this._Format_Commercial_IfAny)) { this._Format_Commercial_IfAny = ""; } return this._Format_Commercial_IfAny; } set { this._Format_Commercial_IfAny = value; } }
        public string Format_Version { get { if (string.IsNullOrEmpty(this._Format_Version)) { this._Format_Version = ""; } return this._Format_Version; } set { this._Format_Version = value; } }
        public string Format_Profile { get { if (string.IsNullOrEmpty(this._Format_Profile)) { this._Format_Profile = ""; } return this._Format_Profile; } set { this._Format_Profile = value; } }
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string MuxingMode { get { if (string.IsNullOrEmpty(this._MuxingMode)) { this._MuxingMode = ""; } return this._MuxingMode; } set { this._MuxingMode = value; } }
        public string CodecID { get { if (string.IsNullOrEmpty(this._CodecID)) { this._CodecID = ""; } return this._CodecID; } set { this._CodecID = value; } }
        public string CodecIDString { get { if (string.IsNullOrEmpty(this._CodecIDString)) { this._CodecIDString = ""; } return this._CodecIDString; } set { this._CodecIDString = value; } }
        public string CodecIDInfo { get { if (string.IsNullOrEmpty(this._CodecIDInfo)) { this._CodecIDInfo = ""; } return this._CodecIDInfo; } set { this._CodecIDInfo = value; } }
        public string CodecIDHint { get { if (string.IsNullOrEmpty(this._CodecIDHint)) { this._CodecIDHint = ""; } return this._CodecIDHint; } set { this._CodecIDHint = value; } }
        public string CodecIDUrl { get { if (string.IsNullOrEmpty(this._CodecIDUrl)) { this._CodecIDUrl = ""; } return this._CodecIDUrl; } set { this._CodecIDUrl = value; } }
        public string CodecID_Description { get { if (string.IsNullOrEmpty(this._CodecID_Description)) { this._CodecID_Description = ""; } return this._CodecID_Description; } set { this._CodecID_Description = value; } }
        public string Duration { get { if (string.IsNullOrEmpty(this._Duration)) { this._Duration = ""; } return this._Duration; } set { this._Duration = value; } }
        public string DurationString { get { if (string.IsNullOrEmpty(this._DurationString)) { this._DurationString = ""; } return this._DurationString; } set { this._DurationString = value; } }
        public string DurationString1 { get { if (string.IsNullOrEmpty(this._DurationString1)) { this._DurationString1 = ""; } return this._DurationString1; } set { this._DurationString1 = value; } }
        public string DurationString2 { get { if (string.IsNullOrEmpty(this._DurationString2)) { this._DurationString2 = ""; } return this._DurationString2; } set { this._DurationString2 = value; } }
        public string DurationString3 { get { if (string.IsNullOrEmpty(this._DurationString3)) { this._DurationString3 = ""; } return this._DurationString3; } set { this._DurationString3 = value; } }
        public string DurationString4 { get { if (string.IsNullOrEmpty(this._DurationString4)) { this._DurationString4 = ""; } return this._DurationString4; } set { this._DurationString4 = value; } }
        public string DurationString5 { get { if (string.IsNullOrEmpty(this._DurationString5)) { this._DurationString5 = ""; } return this._DurationString5; } set { this._DurationString5 = value; } }
        public string Duration_Start { get { if (string.IsNullOrEmpty(this._Duration_Start)) { this._Duration_Start = ""; } return this._Duration_Start; } set { this._Duration_Start = value; } }
        public string Duration_End { get { if (string.IsNullOrEmpty(this._Duration_End)) { this._Duration_End = ""; } return this._Duration_End; } set { this._Duration_End = value; } }
        public string FrameRate { get { if (string.IsNullOrEmpty(this._FrameRate)) { this._FrameRate = ""; } return this._FrameRate; } set { this._FrameRate = value; } }
        public string FrameRateString { get { if (string.IsNullOrEmpty(this._FrameRateString)) { this._FrameRateString = ""; } return this._FrameRateString; } set { this._FrameRateString = value; } }
        public string FrameRate_Num { get { if (string.IsNullOrEmpty(this._FrameRate_Num)) { this._FrameRate_Num = ""; } return this._FrameRate_Num; } set { this._FrameRate_Num = value; } }
        public string FrameRate_Den { get { if (string.IsNullOrEmpty(this._FrameRate_Den)) { this._FrameRate_Den = ""; } return this._FrameRate_Den; } set { this._FrameRate_Den = value; } }
        public string FrameCount { get { if (string.IsNullOrEmpty(this._FrameCount)) { this._FrameCount = ""; } return this._FrameCount; } set { this._FrameCount = value; } }
        public string Delay { get { if (string.IsNullOrEmpty(this._Delay)) { this._Delay = ""; } return this._Delay; } set { this._Delay = value; } }
        public string DelayString { get { if (string.IsNullOrEmpty(this._DelayString)) { this._DelayString = ""; } return this._DelayString; } set { this._DelayString = value; } }
        public string DelayString1 { get { if (string.IsNullOrEmpty(this._DelayString1)) { this._DelayString1 = ""; } return this._DelayString1; } set { this._DelayString1 = value; } }
        public string DelayString2 { get { if (string.IsNullOrEmpty(this._DelayString2)) { this._DelayString2 = ""; } return this._DelayString2; } set { this._DelayString2 = value; } }
        public string DelayString3 { get { if (string.IsNullOrEmpty(this._DelayString3)) { this._DelayString3 = ""; } return this._DelayString3; } set { this._DelayString3 = value; } }
        public string DelayString4 { get { if (string.IsNullOrEmpty(this._DelayString4)) { this._DelayString4 = ""; } return this._DelayString4; } set { this._DelayString4 = value; } }
        public string DelayString5 { get { if (string.IsNullOrEmpty(this._DelayString5)) { this._DelayString5 = ""; } return this._DelayString5; } set { this._DelayString5 = value; } }
        public string Delay_Settings { get { if (string.IsNullOrEmpty(this._Delay_Settings)) { this._Delay_Settings = ""; } return this._Delay_Settings; } set { this._Delay_Settings = value; } }
        public string Delay_DropFrame { get { if (string.IsNullOrEmpty(this._Delay_DropFrame)) { this._Delay_DropFrame = ""; } return this._Delay_DropFrame; } set { this._Delay_DropFrame = value; } }
        public string Delay_Source { get { if (string.IsNullOrEmpty(this._Delay_Source)) { this._Delay_Source = ""; } return this._Delay_Source; } set { this._Delay_Source = value; } }
        public string Delay_SourceString { get { if (string.IsNullOrEmpty(this._Delay_SourceString)) { this._Delay_SourceString = ""; } return this._Delay_SourceString; } set { this._Delay_SourceString = value; } }
        public string Delay_Original { get { if (string.IsNullOrEmpty(this._Delay_Original)) { this._Delay_Original = ""; } return this._Delay_Original; } set { this._Delay_Original = value; } }
        public string Delay_OriginalString { get { if (string.IsNullOrEmpty(this._Delay_OriginalString)) { this._Delay_OriginalString = ""; } return this._Delay_OriginalString; } set { this._Delay_OriginalString = value; } }
        public string Delay_OriginalString1 { get { if (string.IsNullOrEmpty(this._Delay_OriginalString1)) { this._Delay_OriginalString1 = ""; } return this._Delay_OriginalString1; } set { this._Delay_OriginalString1 = value; } }
        public string Delay_OriginalString2 { get { if (string.IsNullOrEmpty(this._Delay_OriginalString2)) { this._Delay_OriginalString2 = ""; } return this._Delay_OriginalString2; } set { this._Delay_OriginalString2 = value; } }
        public string Delay_OriginalString3 { get { if (string.IsNullOrEmpty(this._Delay_OriginalString3)) { this._Delay_OriginalString3 = ""; } return this._Delay_OriginalString3; } set { this._Delay_OriginalString3 = value; } }
        public string Delay_OriginalString4 { get { if (string.IsNullOrEmpty(this._Delay_OriginalString4)) { this._Delay_OriginalString4 = ""; } return this._Delay_OriginalString4; } set { this._Delay_OriginalString4 = value; } }
        public string Delay_OriginalString5 { get { if (string.IsNullOrEmpty(this._Delay_OriginalString5)) { this._Delay_OriginalString5 = ""; } return this._Delay_OriginalString5; } set { this._Delay_OriginalString5 = value; } }
        public string Delay_Original_Settings { get { if (string.IsNullOrEmpty(this._Delay_Original_Settings)) { this._Delay_Original_Settings = ""; } return this._Delay_Original_Settings; } set { this._Delay_Original_Settings = value; } }
        public string Delay_Original_DropFrame { get { if (string.IsNullOrEmpty(this._Delay_Original_DropFrame)) { this._Delay_Original_DropFrame = ""; } return this._Delay_Original_DropFrame; } set { this._Delay_Original_DropFrame = value; } }
        public string Delay_Original_Source { get { if (string.IsNullOrEmpty(this._Delay_Original_Source)) { this._Delay_Original_Source = ""; } return this._Delay_Original_Source; } set { this._Delay_Original_Source = value; } }
        public string Video_Delay { get { if (string.IsNullOrEmpty(this._Video_Delay)) { this._Video_Delay = ""; } return this._Video_Delay; } set { this._Video_Delay = value; } }
        public string Video_DelayString { get { if (string.IsNullOrEmpty(this._Video_DelayString)) { this._Video_DelayString = ""; } return this._Video_DelayString; } set { this._Video_DelayString = value; } }
        public string Video_DelayString1 { get { if (string.IsNullOrEmpty(this._Video_DelayString1)) { this._Video_DelayString1 = ""; } return this._Video_DelayString1; } set { this._Video_DelayString1 = value; } }
        public string Video_DelayString2 { get { if (string.IsNullOrEmpty(this._Video_DelayString2)) { this._Video_DelayString2 = ""; } return this._Video_DelayString2; } set { this._Video_DelayString2 = value; } }
        public string Video_DelayString3 { get { if (string.IsNullOrEmpty(this._Video_DelayString3)) { this._Video_DelayString3 = ""; } return this._Video_DelayString3; } set { this._Video_DelayString3 = value; } }
        public string Video_DelayString4 { get { if (string.IsNullOrEmpty(this._Video_DelayString4)) { this._Video_DelayString4 = ""; } return this._Video_DelayString4; } set { this._Video_DelayString4 = value; } }
        public string Video_DelayString5 { get { if (string.IsNullOrEmpty(this._Video_DelayString5)) { this._Video_DelayString5 = ""; } return this._Video_DelayString5; } set { this._Video_DelayString5 = value; } }
        public string Video0_Delay { get { if (string.IsNullOrEmpty(this._Video0_Delay)) { this._Video0_Delay = ""; } return this._Video0_Delay; } set { this._Video0_Delay = value; } }
        public string Video0_DelayString { get { if (string.IsNullOrEmpty(this._Video0_DelayString)) { this._Video0_DelayString = ""; } return this._Video0_DelayString; } set { this._Video0_DelayString = value; } }
        public string Video0_DelayString1 { get { if (string.IsNullOrEmpty(this._Video0_DelayString1)) { this._Video0_DelayString1 = ""; } return this._Video0_DelayString1; } set { this._Video0_DelayString1 = value; } }
        public string Video0_DelayString2 { get { if (string.IsNullOrEmpty(this._Video0_DelayString2)) { this._Video0_DelayString2 = ""; } return this._Video0_DelayString2; } set { this._Video0_DelayString2 = value; } }
        public string Video0_DelayString3 { get { if (string.IsNullOrEmpty(this._Video0_DelayString3)) { this._Video0_DelayString3 = ""; } return this._Video0_DelayString3; } set { this._Video0_DelayString3 = value; } }
        public string Video0_DelayString4 { get { if (string.IsNullOrEmpty(this._Video0_DelayString4)) { this._Video0_DelayString4 = ""; } return this._Video0_DelayString4; } set { this._Video0_DelayString4 = value; } }
        public string Video0_DelayString5 { get { if (string.IsNullOrEmpty(this._Video0_DelayString5)) { this._Video0_DelayString5 = ""; } return this._Video0_DelayString5; } set { this._Video0_DelayString5 = value; } }
        public string TimeStamp_FirstFrame { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrame)) { this._TimeStamp_FirstFrame = ""; } return this._TimeStamp_FirstFrame; } set { this._TimeStamp_FirstFrame = value; } }
        public string TimeStamp_FirstFrameString { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString)) { this._TimeStamp_FirstFrameString = ""; } return this._TimeStamp_FirstFrameString; } set { this._TimeStamp_FirstFrameString = value; } }
        public string TimeStamp_FirstFrameString1 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString1)) { this._TimeStamp_FirstFrameString1 = ""; } return this._TimeStamp_FirstFrameString1; } set { this._TimeStamp_FirstFrameString1 = value; } }
        public string TimeStamp_FirstFrameString2 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString2)) { this._TimeStamp_FirstFrameString2 = ""; } return this._TimeStamp_FirstFrameString2; } set { this._TimeStamp_FirstFrameString2 = value; } }
        public string TimeStamp_FirstFrameString3 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString3)) { this._TimeStamp_FirstFrameString3 = ""; } return this._TimeStamp_FirstFrameString3; } set { this._TimeStamp_FirstFrameString3 = value; } }
        public string TimeStamp_FirstFrameString4 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString4)) { this._TimeStamp_FirstFrameString4 = ""; } return this._TimeStamp_FirstFrameString4; } set { this._TimeStamp_FirstFrameString4 = value; } }
        public string TimeStamp_FirstFrameString5 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString5)) { this._TimeStamp_FirstFrameString5 = ""; } return this._TimeStamp_FirstFrameString5; } set { this._TimeStamp_FirstFrameString5 = value; } }
        public string TimeCode_FirstFrame { get { if (string.IsNullOrEmpty(this._TimeCode_FirstFrame)) { this._TimeCode_FirstFrame = ""; } return this._TimeCode_FirstFrame; } set { this._TimeCode_FirstFrame = value; } }
        public string TimeCode_Settings { get { if (string.IsNullOrEmpty(this._TimeCode_Settings)) { this._TimeCode_Settings = ""; } return this._TimeCode_Settings; } set { this._TimeCode_Settings = value; } }
        public string TimeCode_Striped { get { if (string.IsNullOrEmpty(this._TimeCode_Striped)) { this._TimeCode_Striped = ""; } return this._TimeCode_Striped; } set { this._TimeCode_Striped = value; } }
        public string TimeCode_StripedString { get { if (string.IsNullOrEmpty(this._TimeCode_StripedString)) { this._TimeCode_StripedString = ""; } return this._TimeCode_StripedString; } set { this._TimeCode_StripedString = value; } }
        public string Title { get { if (string.IsNullOrEmpty(this._Title)) { this._Title = ""; } return this._Title; } set { this._Title = value; } }
        public string Language { get { if (string.IsNullOrEmpty(this._Language)) { this._Language = ""; } return this._Language; } set { this._Language = value; } }
        public string LanguageString { get { if (string.IsNullOrEmpty(this._LanguageString)) { this._LanguageString = ""; } return this._LanguageString; } set { this._LanguageString = value; } }
        public string LanguageString1 { get { if (string.IsNullOrEmpty(this._LanguageString1)) { this._LanguageString1 = ""; } return this._LanguageString1; } set { this._LanguageString1 = value; } }
        public string LanguageString2 { get { if (string.IsNullOrEmpty(this._LanguageString2)) { this._LanguageString2 = ""; } return this._LanguageString2; } set { this._LanguageString2 = value; } }
        public string LanguageString3 { get { if (string.IsNullOrEmpty(this._LanguageString3)) { this._LanguageString3 = ""; } return this._LanguageString3; } set { this._LanguageString3 = value; } }
        public string LanguageString4 { get { if (string.IsNullOrEmpty(this._LanguageString4)) { this._LanguageString4 = ""; } return this._LanguageString4; } set { this._LanguageString4 = value; } }
        public string Language_More { get { if (string.IsNullOrEmpty(this._Language_More)) { this._Language_More = ""; } return this._Language_More; } set { this._Language_More = value; } }
        public string ServiceKind { get { if (string.IsNullOrEmpty(this._ServiceKind)) { this._ServiceKind = ""; } return this._ServiceKind; } set { this._ServiceKind = value; } }
        public string ServiceKindString { get { if (string.IsNullOrEmpty(this._ServiceKindString)) { this._ServiceKindString = ""; } return this._ServiceKindString; } set { this._ServiceKindString = value; } }
        public string Disabled { get { if (string.IsNullOrEmpty(this._Disabled)) { this._Disabled = ""; } return this._Disabled; } set { this._Disabled = value; } }
        public string DisabledString { get { if (string.IsNullOrEmpty(this._DisabledString)) { this._DisabledString = ""; } return this._DisabledString; } set { this._DisabledString = value; } }
        public string Default { get { if (string.IsNullOrEmpty(this._Default)) { this._Default = ""; } return this._Default; } set { this._Default = value; } }
        public string DefaultString { get { if (string.IsNullOrEmpty(this._DefaultString)) { this._DefaultString = ""; } return this._DefaultString; } set { this._DefaultString = value; } }
        public string Forced { get { if (string.IsNullOrEmpty(this._Forced)) { this._Forced = ""; } return this._Forced; } set { this._Forced = value; } }
        public string ForcedString { get { if (string.IsNullOrEmpty(this._ForcedString)) { this._ForcedString = ""; } return this._ForcedString; } set { this._ForcedString = value; } }
        public string AlternateGroup { get { if (string.IsNullOrEmpty(this._AlternateGroup)) { this._AlternateGroup = ""; } return this._AlternateGroup; } set { this._AlternateGroup = value; } }
        public string AlternateGroupString { get { if (string.IsNullOrEmpty(this._AlternateGroupString)) { this._AlternateGroupString = ""; } return this._AlternateGroupString; } set { this._AlternateGroupString = value; } }
    }
}

