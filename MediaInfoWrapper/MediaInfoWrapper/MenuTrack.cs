namespace MediaInfoWrapper
{
    using System;

    public class MenuTrack
    {
        private string _Count;  //Count of objects available in this stream created by MediaInfo when analyzing file. This is mostly for internal use
        private string _Status;  //Status of bit field when parsing. Options are: 0=IsAccepted, 1=IsFilled, 2=IsUpdated, 3=IsFinished. This is mostly for internal use
        private string _StreamCount;  //Total number of streams available for this StreamKind. Counting starts at 1
        private string _StreamKind;  //Name of stream type. Options are: Audio, General, Image, Menu, Other, Text, or Video
        private string _StreamKindString;  //Name of stream type. Options are: Audio, General, Image, Menu, Other, Text, or Video
        private string _StreamKindID;  //Identification number for stream, assigned in order of parsing. Counting starts at 0
        private string _StreamKindPos;  //Identification number for stream when multiple, assigned in order of parsing. Counting starts at 1
        private string _StreamOrder;  //Stream order in the file for type of stream. Counting starts at 0
        private string _FirstPacketOrder;  //Order of the first fully decodable packet parsed in the file for stream type. Counting starts at 0
        private string _Inform;  //Last **Inform** call. This is mostly for internal use
        private string _ID;  //The identification number for this stream in this file
        private string _IDString;  //The identification number for this stream in this file (String format)
        private string _OriginalSourceMedium_ID;  //Identification for this stream in the original medium of the material
        private string _OriginalSourceMedium_IDString;  //Identification for this stream in the original medium of the material (String format)
        private string _UniqueID;  //The unique ID for this stream, should be copied with stream copy
        private string _UniqueIDString;  //The unique ID for this stream, should be copied with stream copy
        private string _MenuID;  //The menu ID for this stream in this file
        private string _MenuIDString;  //The menu ID for this stream in this file
        private string _Format;  //Format used
        private string _FormatString;  //Format used and any additional features or settings
        private string _FormatInfo;  //More details about the identified Format
        private string _FormatUrl;  //Link to a description of this format
        private string _Format_Commercial;  //Commercial name used by vendor for these settings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for these settings, if available
        private string _Format_Version;  //Version for the identified format
        private string _Format_Profile;  //Profile of the Format
        private string _Format_Compression;  //Compression method used
        private string _Format_Settings;  //Settings used and required by decoder
        private string _Format_AdditionalFeatures;  //Features from the format that are required to fully support the file content
        private string _CodecID;  //Codec identifier as indicated by the container
        private string _CodecIDString;  //Codec identifier, as indicated by the container
        private string _CodecIDInfo;  //More information about this codec identifier
        private string _CodecIDHint;  //Common alternative names for this codec identifier
        private string _CodecIDUrl;  //A link to more details about this codec identifier
        private string _CodecID_Description;  //Codec description, as defined by the container
        private string _Codec;  //Deprecated
        private string _CodecString;  //Deprecated
        private string _CodecInfo;  //Deprecated
        private string _CodecUrl;  //Deprecated
        private string _Duration;  //Play time of the stream, in s (ms for text output)
        private string _DurationString;  //Play time in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _DurationString1;  //Play time in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _DurationString2;  //Play time in format XXx YYy, with YYy omitted if value is zero
        private string _DurationString3;  //Play time in format HH:MM:SS.mmm (e.g. 01:40:00.000)
        private string _DurationString4;  //Play time in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _DurationString5;  //Play time in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start;  //Start time of stream, in UTC
        private string _Duration_End;  //End time of stream, in UTC
        private string _Delay;  //Delay fixed in the stream (relative), in ms
        private string _DelayString;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString1;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString2;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString3;  //Delay fixed in the stream (relative) in format HH:MM:SS.mmm, with measurement
        private string _DelayString4;  //Delay in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _DelayString5;  //Delay in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Settings;  //Delay settings (in case of timecode for example)
        private string _Delay_DropFrame;  //Delay drop frame
        private string _Delay_Source;  //Part of the file where the delay was set (e.g. Container, Stream, or empty)
        private string _FrameRate_Mode;  //Frame rate mode, as acronym (e.g. CFR, VFR)
        private string _FrameRate_ModeString;  //Frame rate mode, as word (e.g. Constant, Variable)
        private string _FrameRate;  //Frames per second, as float (e.g. 29.970)
        private string _FrameRateString;  //Frames per second, with measurement (e.g. 29.970 (29970/1000) FPS)
        private string _FrameRate_Num;  //Numerator for determined frames per second (e.g. 29970)
        private string _FrameRate_Den;  //Denominator for determined frames per second (e.g. 1000)
        private string _FrameCount;  //Numer of frames
        private string _List_StreamKind;  //List of programs available
        private string _List_StreamPos;  //List of programs available
        private string _List;  //List of programs available
        private string _ListString;  //List of programs available
        private string _Title;  //Name of this menu
        private string _Language;  //Language, formatted as 2-letter ISO 639-1 if exists, else 3-letter ISO 639-2, and with optional ISO 3166-1 country separated by a dash if available (e.g. en, en-US, en-CN)
        private string _LanguageString;  //Language, as full name (e.g. English)
        private string _LanguageString1;  //Language, as full name (e.g. English)
        private string _LanguageString2;  //Language, formatted as 2-letter ISO 639-1, if exists (e.g. en)
        private string _LanguageString3;  //Language, formatted as 3-letter ISO 639-2, if exists (e.g. eng)
        private string _LanguageString4;  //Language, formatted as 2-letter ISO 639-1, if exists, with optional ISO 3166-1 country separated by a dash if available (e.g. en-US)
        private string _Language_More;  //More information about Language (e.g. Director's Comment)
        private string _ServiceKind;  //Type of assisted service (e.g. visually impaired, commentary, voice over)
        private string _ServiceKindString;  //Type of assisted service (e.g. visually impaired, commentary, voice over)
        private string _ServiceName;  //Name of assisted service
        private string _ServiceChannel;  //Channel of assisted service
        private string _ServiceUrl;  //URL of assisted service
        private string _ServiceProvider;  //Provider of assisted service
        private string _ServiceProviderUrl;  //URL of provider of assisted service
        private string _ServiceType;  //Type of assisted service
        private string _NetworkName;  //Television network name
        private string _OriginalNetworkName;  //Television network name of original broadcast
        private string _Countries;  //Country information of the content
        private string _TimeZones;  //TimeZone information of the content
        private string _LawRating;  //Legal rating of a movie. Format depends on country of origin (e.g. PG, 16)
        private string _LawRating_Reason;  //Reason of the law rating
        private string _Disabled;  //Set if this stream should not be used (Yes, No)
        private string _DisabledString;  //Set if this stream should not be used (Yes, No)
        private string _Default;  //Flag set if this stream should be used if no language found matches the user preference (Yes, No)
        private string _DefaultString;  //Flag set if this stream should be used if no language found matches the user preference (Yes, No)
        private string _Forced;  //Flag set if this stream should be used regardless of user preferences, often used for sparse subtitle dialogue in an otherwise unsubtitled movie (Yes, No)
        private string _ForcedString;  //Flag set if this stream should be used regardless of user preferences, often used for sparse subtitle dialogue in an otherwise unsubtitled movie (Yes, No)
        private string _AlternateGroup;  //Number of a group in order to provide versions of the same track
        private string _AlternateGroupString;  //Number of a group in order to provide versions of the same track
        private string _Chapters_Pos_Begin;  //Used by third-party developers to know about the beginning of the chapters list, to be used by Get (Stream_Menu, x, Pos), where Pos is an Integer between Chapters_Pos_Begin and Chapters_Pos_End
        private string _Chapters_Pos_End;  //Used by third-party developers to know about the end of the chapters list (this position excluded)

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
        public string Format { get { if (string.IsNullOrEmpty(this._Format)) { this._Format = ""; } return this._Format; } set { this._Format = value; } }
        public string FormatString { get { if (string.IsNullOrEmpty(this._FormatString)) { this._FormatString = ""; } return this._FormatString; } set { this._FormatString = value; } }
        public string FormatInfo { get { if (string.IsNullOrEmpty(this._FormatInfo)) { this._FormatInfo = ""; } return this._FormatInfo; } set { this._FormatInfo = value; } }
        public string FormatUrl { get { if (string.IsNullOrEmpty(this._FormatUrl)) { this._FormatUrl = ""; } return this._FormatUrl; } set { this._FormatUrl = value; } }
        public string Format_Commercial { get { if (string.IsNullOrEmpty(this._Format_Commercial)) { this._Format_Commercial = ""; } return this._Format_Commercial; } set { this._Format_Commercial = value; } }
        public string Format_Commercial_IfAny { get { if (string.IsNullOrEmpty(this._Format_Commercial_IfAny)) { this._Format_Commercial_IfAny = ""; } return this._Format_Commercial_IfAny; } set { this._Format_Commercial_IfAny = value; } }
        public string Format_Version { get { if (string.IsNullOrEmpty(this._Format_Version)) { this._Format_Version = ""; } return this._Format_Version; } set { this._Format_Version = value; } }
        public string Format_Profile { get { if (string.IsNullOrEmpty(this._Format_Profile)) { this._Format_Profile = ""; } return this._Format_Profile; } set { this._Format_Profile = value; } }
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string Format_AdditionalFeatures { get { if (string.IsNullOrEmpty(this._Format_AdditionalFeatures)) { this._Format_AdditionalFeatures = ""; } return this._Format_AdditionalFeatures; } set { this._Format_AdditionalFeatures = value; } }
        public string CodecID { get { if (string.IsNullOrEmpty(this._CodecID)) { this._CodecID = ""; } return this._CodecID; } set { this._CodecID = value; } }
        public string CodecIDString { get { if (string.IsNullOrEmpty(this._CodecIDString)) { this._CodecIDString = ""; } return this._CodecIDString; } set { this._CodecIDString = value; } }
        public string CodecIDInfo { get { if (string.IsNullOrEmpty(this._CodecIDInfo)) { this._CodecIDInfo = ""; } return this._CodecIDInfo; } set { this._CodecIDInfo = value; } }
        public string CodecIDHint { get { if (string.IsNullOrEmpty(this._CodecIDHint)) { this._CodecIDHint = ""; } return this._CodecIDHint; } set { this._CodecIDHint = value; } }
        public string CodecIDUrl { get { if (string.IsNullOrEmpty(this._CodecIDUrl)) { this._CodecIDUrl = ""; } return this._CodecIDUrl; } set { this._CodecIDUrl = value; } }
        public string CodecID_Description { get { if (string.IsNullOrEmpty(this._CodecID_Description)) { this._CodecID_Description = ""; } return this._CodecID_Description; } set { this._CodecID_Description = value; } }
        public string Codec { get { if (string.IsNullOrEmpty(this._Codec)) { this._Codec = ""; } return this._Codec; } set { this._Codec = value; } }
        public string CodecString { get { if (string.IsNullOrEmpty(this._CodecString)) { this._CodecString = ""; } return this._CodecString; } set { this._CodecString = value; } }
        public string CodecInfo { get { if (string.IsNullOrEmpty(this._CodecInfo)) { this._CodecInfo = ""; } return this._CodecInfo; } set { this._CodecInfo = value; } }
        public string CodecUrl { get { if (string.IsNullOrEmpty(this._CodecUrl)) { this._CodecUrl = ""; } return this._CodecUrl; } set { this._CodecUrl = value; } }
        public string Duration { get { if (string.IsNullOrEmpty(this._Duration)) { this._Duration = ""; } return this._Duration; } set { this._Duration = value; } }
        public string DurationString { get { if (string.IsNullOrEmpty(this._DurationString)) { this._DurationString = ""; } return this._DurationString; } set { this._DurationString = value; } }
        public string DurationString1 { get { if (string.IsNullOrEmpty(this._DurationString1)) { this._DurationString1 = ""; } return this._DurationString1; } set { this._DurationString1 = value; } }
        public string DurationString2 { get { if (string.IsNullOrEmpty(this._DurationString2)) { this._DurationString2 = ""; } return this._DurationString2; } set { this._DurationString2 = value; } }
        public string DurationString3 { get { if (string.IsNullOrEmpty(this._DurationString3)) { this._DurationString3 = ""; } return this._DurationString3; } set { this._DurationString3 = value; } }
        public string DurationString4 { get { if (string.IsNullOrEmpty(this._DurationString4)) { this._DurationString4 = ""; } return this._DurationString4; } set { this._DurationString4 = value; } }
        public string DurationString5 { get { if (string.IsNullOrEmpty(this._DurationString5)) { this._DurationString5 = ""; } return this._DurationString5; } set { this._DurationString5 = value; } }
        public string Duration_Start { get { if (string.IsNullOrEmpty(this._Duration_Start)) { this._Duration_Start = ""; } return this._Duration_Start; } set { this._Duration_Start = value; } }
        public string Duration_End { get { if (string.IsNullOrEmpty(this._Duration_End)) { this._Duration_End = ""; } return this._Duration_End; } set { this._Duration_End = value; } }
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
        public string FrameRate_Mode { get { if (string.IsNullOrEmpty(this._FrameRate_Mode)) { this._FrameRate_Mode = ""; } return this._FrameRate_Mode; } set { this._FrameRate_Mode = value; } }
        public string FrameRate_ModeString { get { if (string.IsNullOrEmpty(this._FrameRate_ModeString)) { this._FrameRate_ModeString = ""; } return this._FrameRate_ModeString; } set { this._FrameRate_ModeString = value; } }
        public string FrameRate { get { if (string.IsNullOrEmpty(this._FrameRate)) { this._FrameRate = ""; } return this._FrameRate; } set { this._FrameRate = value; } }
        public string FrameRateString { get { if (string.IsNullOrEmpty(this._FrameRateString)) { this._FrameRateString = ""; } return this._FrameRateString; } set { this._FrameRateString = value; } }
        public string FrameRate_Num { get { if (string.IsNullOrEmpty(this._FrameRate_Num)) { this._FrameRate_Num = ""; } return this._FrameRate_Num; } set { this._FrameRate_Num = value; } }
        public string FrameRate_Den { get { if (string.IsNullOrEmpty(this._FrameRate_Den)) { this._FrameRate_Den = ""; } return this._FrameRate_Den; } set { this._FrameRate_Den = value; } }
        public string FrameCount { get { if (string.IsNullOrEmpty(this._FrameCount)) { this._FrameCount = ""; } return this._FrameCount; } set { this._FrameCount = value; } }
        public string List_StreamKind { get { if (string.IsNullOrEmpty(this._List_StreamKind)) { this._List_StreamKind = ""; } return this._List_StreamKind; } set { this._List_StreamKind = value; } }
        public string List_StreamPos { get { if (string.IsNullOrEmpty(this._List_StreamPos)) { this._List_StreamPos = ""; } return this._List_StreamPos; } set { this._List_StreamPos = value; } }
        public string List { get { if (string.IsNullOrEmpty(this._List)) { this._List = ""; } return this._List; } set { this._List = value; } }
        public string ListString { get { if (string.IsNullOrEmpty(this._ListString)) { this._ListString = ""; } return this._ListString; } set { this._ListString = value; } }
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
        public string ServiceName { get { if (string.IsNullOrEmpty(this._ServiceName)) { this._ServiceName = ""; } return this._ServiceName; } set { this._ServiceName = value; } }
        public string ServiceChannel { get { if (string.IsNullOrEmpty(this._ServiceChannel)) { this._ServiceChannel = ""; } return this._ServiceChannel; } set { this._ServiceChannel = value; } }
        public string ServiceUrl { get { if (string.IsNullOrEmpty(this._ServiceUrl)) { this._ServiceUrl = ""; } return this._ServiceUrl; } set { this._ServiceUrl = value; } }
        public string ServiceProvider { get { if (string.IsNullOrEmpty(this._ServiceProvider)) { this._ServiceProvider = ""; } return this._ServiceProvider; } set { this._ServiceProvider = value; } }
        public string ServiceProviderUrl { get { if (string.IsNullOrEmpty(this._ServiceProviderUrl)) { this._ServiceProviderUrl = ""; } return this._ServiceProviderUrl; } set { this._ServiceProviderUrl = value; } }
        public string ServiceType { get { if (string.IsNullOrEmpty(this._ServiceType)) { this._ServiceType = ""; } return this._ServiceType; } set { this._ServiceType = value; } }
        public string NetworkName { get { if (string.IsNullOrEmpty(this._NetworkName)) { this._NetworkName = ""; } return this._NetworkName; } set { this._NetworkName = value; } }
        public string OriginalNetworkName { get { if (string.IsNullOrEmpty(this._OriginalNetworkName)) { this._OriginalNetworkName = ""; } return this._OriginalNetworkName; } set { this._OriginalNetworkName = value; } }
        public string Countries { get { if (string.IsNullOrEmpty(this._Countries)) { this._Countries = ""; } return this._Countries; } set { this._Countries = value; } }
        public string TimeZones { get { if (string.IsNullOrEmpty(this._TimeZones)) { this._TimeZones = ""; } return this._TimeZones; } set { this._TimeZones = value; } }
        public string LawRating { get { if (string.IsNullOrEmpty(this._LawRating)) { this._LawRating = ""; } return this._LawRating; } set { this._LawRating = value; } }
        public string LawRating_Reason { get { if (string.IsNullOrEmpty(this._LawRating_Reason)) { this._LawRating_Reason = ""; } return this._LawRating_Reason; } set { this._LawRating_Reason = value; } }
        public string Disabled { get { if (string.IsNullOrEmpty(this._Disabled)) { this._Disabled = ""; } return this._Disabled; } set { this._Disabled = value; } }
        public string DisabledString { get { if (string.IsNullOrEmpty(this._DisabledString)) { this._DisabledString = ""; } return this._DisabledString; } set { this._DisabledString = value; } }
        public string Default { get { if (string.IsNullOrEmpty(this._Default)) { this._Default = ""; } return this._Default; } set { this._Default = value; } }
        public string DefaultString { get { if (string.IsNullOrEmpty(this._DefaultString)) { this._DefaultString = ""; } return this._DefaultString; } set { this._DefaultString = value; } }
        public string Forced { get { if (string.IsNullOrEmpty(this._Forced)) { this._Forced = ""; } return this._Forced; } set { this._Forced = value; } }
        public string ForcedString { get { if (string.IsNullOrEmpty(this._ForcedString)) { this._ForcedString = ""; } return this._ForcedString; } set { this._ForcedString = value; } }
        public string AlternateGroup { get { if (string.IsNullOrEmpty(this._AlternateGroup)) { this._AlternateGroup = ""; } return this._AlternateGroup; } set { this._AlternateGroup = value; } }
        public string AlternateGroupString { get { if (string.IsNullOrEmpty(this._AlternateGroupString)) { this._AlternateGroupString = ""; } return this._AlternateGroupString; } set { this._AlternateGroupString = value; } }
        public string Chapters_Pos_Begin { get { if (string.IsNullOrEmpty(this._Chapters_Pos_Begin)) { this._Chapters_Pos_Begin = ""; } return this._Chapters_Pos_Begin; } set { this._Chapters_Pos_Begin = value; } }
        public string Chapters_Pos_End { get { if (string.IsNullOrEmpty(this._Chapters_Pos_End)) { this._Chapters_Pos_End = ""; } return this._Chapters_Pos_End; } set { this._Chapters_Pos_End = value; } }
    }
}

