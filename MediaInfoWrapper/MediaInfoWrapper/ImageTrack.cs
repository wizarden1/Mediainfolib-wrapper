namespace MediaInfoWrapper
{
    using System;

    public class ImageTrack
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
        private string _Title;  //Name of the track
        private string _Format;  //Format used
        private string _FormatString;  //Format used + additional features
        private string _FormatInfo;  //Info about Format
        private string _FormatUrl;  //Link
        private string _Format_Commercial;  //Commercial name used by vendor for theses setings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for theses setings if there is one
        private string _Format_Version;  //Version of this format
        private string _Format_Profile;  //Profile of the Format
        private string _Format_Settings_Endianness;  //
        private string _Format_Settings_Packing;  //
        private string _Format_Compression;  //Compression method used
        private string _Format_Settings;  //Settings needed for decoder used
        private string _Format_Settings_Wrapping;  //Wrapping mode (Frame wrapped or Clip wrapped)
        private string _Format_AdditionalFeatures;  //Format features needed for fully supporting the content
        private string _InternetMediaType;  //Internet Media Type (aka MIME Type, Content-Type)
        private string _CodecID;  //Codec ID (found in some containers)
        private string _CodecIDString;  //Codec ID (found in some containers)
        private string _CodecIDInfo;  //Info about codec ID
        private string _CodecIDHint;  //A hint for this codec ID
        private string _CodecIDUrl;  //A link for more details about this codec ID
        private string _CodecID_Description;  //Manual description given by the container
        private string _Codec;  //Deprecated, do not use in new projects
        private string _CodecString;  //Deprecated, do not use in new projects
        private string _CodecFamily;  //Deprecated, do not use in new projects
        private string _CodecInfo;  //Deprecated, do not use in new projects
        private string _CodecUrl;  //Deprecated, do not use in new projects
        private string _Width;  //Width (aperture size if present) in pixel
        private string _WidthString;  //Width (aperture size if present) with measurement (pixel)
        private string _Width_Offset;  //Offset between original width and displayed width (aperture size) in pixel
        private string _Width_OffsetString;  //Offset between original width and displayed width (aperture size)  in pixel
        private string _Width_Original;  //Original (in the raw stream) width in pixel
        private string _Width_OriginalString;  //Original (in the raw stream) width with measurement (pixel)
        private string _Height;  //Height (aperture size if present) in pixel
        private string _HeightString;  //Height (aperture size if present) with measurement (pixel)
        private string _Height_Offset;  //Offset between original height and displayed height (aperture size) in pixel
        private string _Height_OffsetString;  //Offset between original height and displayed height (aperture size)  in pixel
        private string _Height_Original;  //Original (in the raw stream) height in pixel
        private string _Height_OriginalString;  //Original (in the raw stream) height with measurement (pixel)
        private string _PixelAspectRatio;  //Pixel Aspect ratio
        private string _PixelAspectRatioString;  //Pixel Aspect ratio
        private string _PixelAspectRatio_Original;  //Original (in the raw stream) Pixel Aspect ratio
        private string _PixelAspectRatio_OriginalString;  //Original (in the raw stream) Pixel Aspect ratio
        private string _DisplayAspectRatio;  //Display Aspect ratio
        private string _DisplayAspectRatioString;  //Display Aspect ratio
        private string _DisplayAspectRatio_Original;  //Original (in the raw stream) Display Aspect ratio
        private string _DisplayAspectRatio_OriginalString;  //Original (in the raw stream) Display Aspect ratio
        private string _ColorSpace;  //
        private string _ChromaSubsampling;  //
        private string _Resolution;  //Deprecated, do not use in new projects
        private string _ResolutionString;  //Deprecated, do not use in new projects
        private string _BitDepth;  //
        private string _BitDepthString;  //
        private string _Compression_Mode;  //Compression mode (Lossy or Lossless)
        private string _Compression_ModeString;  //Compression mode (Lossy or Lossless)
        private string _Compression_Ratio;  //Current stream size divided by uncompressed stream size
        private string _StreamSize;  //Stream size in bytes
        private string _StreamSizeString;  //
        private string _StreamSizeString1;  //
        private string _StreamSizeString2;  //
        private string _StreamSizeString3;  //
        private string _StreamSizeString4;  //
        private string _StreamSizeString5;  //With proportion
        private string _StreamSize_Proportion;  //Stream size divided by file size
        private string _StreamSize_Demuxed;  //StreamSize in bytes of hte stream after demux
        private string _StreamSize_DemuxedString;  //StreamSize_Demuxed in with percentage value
        private string _StreamSize_DemuxedString1;  //
        private string _StreamSize_DemuxedString2;  //
        private string _StreamSize_DemuxedString3;  //
        private string _StreamSize_DemuxedString4;  //
        private string _StreamSize_DemuxedString5;  //StreamSize_Demuxed in with percentage value (note: theoritical value, not for real use)
        private string _Encoded_Library;  //Software used to create the file
        private string _Encoded_LibraryString;  //Software used to create the file
        private string _Encoded_Library_Name;  //Info from the software
        private string _Encoded_Library_Version;  //Version of software
        private string _Encoded_Library_Date;  //Release date of software
        private string _Encoded_Library_Settings;  //Parameters used by the software
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
        private string _Summary;  //
        private string _Encoded_Date;  //The time that the encoding of this item was completed began.
        private string _Tagged_Date;  //The time that the tags were done for this item.
        private string _Encryption;  //
        private string _colour_description_present;  //Presence of colour description
        private string _colour_primaries;  //Chromaticity coordinates of the source primaries
        private string _transfer_characteristics;  //Opto-electronic transfer characteristic of the source picture
        private string _matrix_coefficients;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries
        private string _colour_description_present_Original;  //Presence of colour description
        private string _colour_primaries_Original;  //Chromaticity coordinates of the source primaries
        private string _transfer_characteristics_Original;  //Opto-electronic transfer characteristic of the source picture
        private string _matrix_coefficients_Original;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries

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
        public string Title { get { if (string.IsNullOrEmpty(this._Title)) { this._Title = ""; } return this._Title; } set { this._Title = value; } }
        public string Format { get { if (string.IsNullOrEmpty(this._Format)) { this._Format = ""; } return this._Format; } set { this._Format = value; } }
        public string FormatString { get { if (string.IsNullOrEmpty(this._FormatString)) { this._FormatString = ""; } return this._FormatString; } set { this._FormatString = value; } }
        public string FormatInfo { get { if (string.IsNullOrEmpty(this._FormatInfo)) { this._FormatInfo = ""; } return this._FormatInfo; } set { this._FormatInfo = value; } }
        public string FormatUrl { get { if (string.IsNullOrEmpty(this._FormatUrl)) { this._FormatUrl = ""; } return this._FormatUrl; } set { this._FormatUrl = value; } }
        public string Format_Commercial { get { if (string.IsNullOrEmpty(this._Format_Commercial)) { this._Format_Commercial = ""; } return this._Format_Commercial; } set { this._Format_Commercial = value; } }
        public string Format_Commercial_IfAny { get { if (string.IsNullOrEmpty(this._Format_Commercial_IfAny)) { this._Format_Commercial_IfAny = ""; } return this._Format_Commercial_IfAny; } set { this._Format_Commercial_IfAny = value; } }
        public string Format_Version { get { if (string.IsNullOrEmpty(this._Format_Version)) { this._Format_Version = ""; } return this._Format_Version; } set { this._Format_Version = value; } }
        public string Format_Profile { get { if (string.IsNullOrEmpty(this._Format_Profile)) { this._Format_Profile = ""; } return this._Format_Profile; } set { this._Format_Profile = value; } }
        public string Format_Settings_Endianness { get { if (string.IsNullOrEmpty(this._Format_Settings_Endianness)) { this._Format_Settings_Endianness = ""; } return this._Format_Settings_Endianness; } set { this._Format_Settings_Endianness = value; } }
        public string Format_Settings_Packing { get { if (string.IsNullOrEmpty(this._Format_Settings_Packing)) { this._Format_Settings_Packing = ""; } return this._Format_Settings_Packing; } set { this._Format_Settings_Packing = value; } }
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string Format_Settings_Wrapping { get { if (string.IsNullOrEmpty(this._Format_Settings_Wrapping)) { this._Format_Settings_Wrapping = ""; } return this._Format_Settings_Wrapping; } set { this._Format_Settings_Wrapping = value; } }
        public string Format_AdditionalFeatures { get { if (string.IsNullOrEmpty(this._Format_AdditionalFeatures)) { this._Format_AdditionalFeatures = ""; } return this._Format_AdditionalFeatures; } set { this._Format_AdditionalFeatures = value; } }
        public string InternetMediaType { get { if (string.IsNullOrEmpty(this._InternetMediaType)) { this._InternetMediaType = ""; } return this._InternetMediaType; } set { this._InternetMediaType = value; } }
        public string CodecID { get { if (string.IsNullOrEmpty(this._CodecID)) { this._CodecID = ""; } return this._CodecID; } set { this._CodecID = value; } }
        public string CodecIDString { get { if (string.IsNullOrEmpty(this._CodecIDString)) { this._CodecIDString = ""; } return this._CodecIDString; } set { this._CodecIDString = value; } }
        public string CodecIDInfo { get { if (string.IsNullOrEmpty(this._CodecIDInfo)) { this._CodecIDInfo = ""; } return this._CodecIDInfo; } set { this._CodecIDInfo = value; } }
        public string CodecIDHint { get { if (string.IsNullOrEmpty(this._CodecIDHint)) { this._CodecIDHint = ""; } return this._CodecIDHint; } set { this._CodecIDHint = value; } }
        public string CodecIDUrl { get { if (string.IsNullOrEmpty(this._CodecIDUrl)) { this._CodecIDUrl = ""; } return this._CodecIDUrl; } set { this._CodecIDUrl = value; } }
        public string CodecID_Description { get { if (string.IsNullOrEmpty(this._CodecID_Description)) { this._CodecID_Description = ""; } return this._CodecID_Description; } set { this._CodecID_Description = value; } }
        public string Codec { get { if (string.IsNullOrEmpty(this._Codec)) { this._Codec = ""; } return this._Codec; } set { this._Codec = value; } }
        public string CodecString { get { if (string.IsNullOrEmpty(this._CodecString)) { this._CodecString = ""; } return this._CodecString; } set { this._CodecString = value; } }
        public string CodecFamily { get { if (string.IsNullOrEmpty(this._CodecFamily)) { this._CodecFamily = ""; } return this._CodecFamily; } set { this._CodecFamily = value; } }
        public string CodecInfo { get { if (string.IsNullOrEmpty(this._CodecInfo)) { this._CodecInfo = ""; } return this._CodecInfo; } set { this._CodecInfo = value; } }
        public string CodecUrl { get { if (string.IsNullOrEmpty(this._CodecUrl)) { this._CodecUrl = ""; } return this._CodecUrl; } set { this._CodecUrl = value; } }
        public string Width { get { if (string.IsNullOrEmpty(this._Width)) { this._Width = ""; } return this._Width; } set { this._Width = value; } }
        public string WidthString { get { if (string.IsNullOrEmpty(this._WidthString)) { this._WidthString = ""; } return this._WidthString; } set { this._WidthString = value; } }
        public string Width_Offset { get { if (string.IsNullOrEmpty(this._Width_Offset)) { this._Width_Offset = ""; } return this._Width_Offset; } set { this._Width_Offset = value; } }
        public string Width_OffsetString { get { if (string.IsNullOrEmpty(this._Width_OffsetString)) { this._Width_OffsetString = ""; } return this._Width_OffsetString; } set { this._Width_OffsetString = value; } }
        public string Width_Original { get { if (string.IsNullOrEmpty(this._Width_Original)) { this._Width_Original = ""; } return this._Width_Original; } set { this._Width_Original = value; } }
        public string Width_OriginalString { get { if (string.IsNullOrEmpty(this._Width_OriginalString)) { this._Width_OriginalString = ""; } return this._Width_OriginalString; } set { this._Width_OriginalString = value; } }
        public string Height { get { if (string.IsNullOrEmpty(this._Height)) { this._Height = ""; } return this._Height; } set { this._Height = value; } }
        public string HeightString { get { if (string.IsNullOrEmpty(this._HeightString)) { this._HeightString = ""; } return this._HeightString; } set { this._HeightString = value; } }
        public string Height_Offset { get { if (string.IsNullOrEmpty(this._Height_Offset)) { this._Height_Offset = ""; } return this._Height_Offset; } set { this._Height_Offset = value; } }
        public string Height_OffsetString { get { if (string.IsNullOrEmpty(this._Height_OffsetString)) { this._Height_OffsetString = ""; } return this._Height_OffsetString; } set { this._Height_OffsetString = value; } }
        public string Height_Original { get { if (string.IsNullOrEmpty(this._Height_Original)) { this._Height_Original = ""; } return this._Height_Original; } set { this._Height_Original = value; } }
        public string Height_OriginalString { get { if (string.IsNullOrEmpty(this._Height_OriginalString)) { this._Height_OriginalString = ""; } return this._Height_OriginalString; } set { this._Height_OriginalString = value; } }
        public string PixelAspectRatio { get { if (string.IsNullOrEmpty(this._PixelAspectRatio)) { this._PixelAspectRatio = ""; } return this._PixelAspectRatio; } set { this._PixelAspectRatio = value; } }
        public string PixelAspectRatioString { get { if (string.IsNullOrEmpty(this._PixelAspectRatioString)) { this._PixelAspectRatioString = ""; } return this._PixelAspectRatioString; } set { this._PixelAspectRatioString = value; } }
        public string PixelAspectRatio_Original { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_Original)) { this._PixelAspectRatio_Original = ""; } return this._PixelAspectRatio_Original; } set { this._PixelAspectRatio_Original = value; } }
        public string PixelAspectRatio_OriginalString { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_OriginalString)) { this._PixelAspectRatio_OriginalString = ""; } return this._PixelAspectRatio_OriginalString; } set { this._PixelAspectRatio_OriginalString = value; } }
        public string DisplayAspectRatio { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio)) { this._DisplayAspectRatio = ""; } return this._DisplayAspectRatio; } set { this._DisplayAspectRatio = value; } }
        public string DisplayAspectRatioString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatioString)) { this._DisplayAspectRatioString = ""; } return this._DisplayAspectRatioString; } set { this._DisplayAspectRatioString = value; } }
        public string DisplayAspectRatio_Original { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_Original)) { this._DisplayAspectRatio_Original = ""; } return this._DisplayAspectRatio_Original; } set { this._DisplayAspectRatio_Original = value; } }
        public string DisplayAspectRatio_OriginalString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_OriginalString)) { this._DisplayAspectRatio_OriginalString = ""; } return this._DisplayAspectRatio_OriginalString; } set { this._DisplayAspectRatio_OriginalString = value; } }
        public string ColorSpace { get { if (string.IsNullOrEmpty(this._ColorSpace)) { this._ColorSpace = ""; } return this._ColorSpace; } set { this._ColorSpace = value; } }
        public string ChromaSubsampling { get { if (string.IsNullOrEmpty(this._ChromaSubsampling)) { this._ChromaSubsampling = ""; } return this._ChromaSubsampling; } set { this._ChromaSubsampling = value; } }
        public string Resolution { get { if (string.IsNullOrEmpty(this._Resolution)) { this._Resolution = ""; } return this._Resolution; } set { this._Resolution = value; } }
        public string ResolutionString { get { if (string.IsNullOrEmpty(this._ResolutionString)) { this._ResolutionString = ""; } return this._ResolutionString; } set { this._ResolutionString = value; } }
        public string BitDepth { get { if (string.IsNullOrEmpty(this._BitDepth)) { this._BitDepth = ""; } return this._BitDepth; } set { this._BitDepth = value; } }
        public string BitDepthString { get { if (string.IsNullOrEmpty(this._BitDepthString)) { this._BitDepthString = ""; } return this._BitDepthString; } set { this._BitDepthString = value; } }
        public string Compression_Mode { get { if (string.IsNullOrEmpty(this._Compression_Mode)) { this._Compression_Mode = ""; } return this._Compression_Mode; } set { this._Compression_Mode = value; } }
        public string Compression_ModeString { get { if (string.IsNullOrEmpty(this._Compression_ModeString)) { this._Compression_ModeString = ""; } return this._Compression_ModeString; } set { this._Compression_ModeString = value; } }
        public string Compression_Ratio { get { if (string.IsNullOrEmpty(this._Compression_Ratio)) { this._Compression_Ratio = ""; } return this._Compression_Ratio; } set { this._Compression_Ratio = value; } }
        public string StreamSize { get { if (string.IsNullOrEmpty(this._StreamSize)) { this._StreamSize = ""; } return this._StreamSize; } set { this._StreamSize = value; } }
        public string StreamSizeString { get { if (string.IsNullOrEmpty(this._StreamSizeString)) { this._StreamSizeString = ""; } return this._StreamSizeString; } set { this._StreamSizeString = value; } }
        public string StreamSizeString1 { get { if (string.IsNullOrEmpty(this._StreamSizeString1)) { this._StreamSizeString1 = ""; } return this._StreamSizeString1; } set { this._StreamSizeString1 = value; } }
        public string StreamSizeString2 { get { if (string.IsNullOrEmpty(this._StreamSizeString2)) { this._StreamSizeString2 = ""; } return this._StreamSizeString2; } set { this._StreamSizeString2 = value; } }
        public string StreamSizeString3 { get { if (string.IsNullOrEmpty(this._StreamSizeString3)) { this._StreamSizeString3 = ""; } return this._StreamSizeString3; } set { this._StreamSizeString3 = value; } }
        public string StreamSizeString4 { get { if (string.IsNullOrEmpty(this._StreamSizeString4)) { this._StreamSizeString4 = ""; } return this._StreamSizeString4; } set { this._StreamSizeString4 = value; } }
        public string StreamSizeString5 { get { if (string.IsNullOrEmpty(this._StreamSizeString5)) { this._StreamSizeString5 = ""; } return this._StreamSizeString5; } set { this._StreamSizeString5 = value; } }
        public string StreamSize_Proportion { get { if (string.IsNullOrEmpty(this._StreamSize_Proportion)) { this._StreamSize_Proportion = ""; } return this._StreamSize_Proportion; } set { this._StreamSize_Proportion = value; } }
        public string StreamSize_Demuxed { get { if (string.IsNullOrEmpty(this._StreamSize_Demuxed)) { this._StreamSize_Demuxed = ""; } return this._StreamSize_Demuxed; } set { this._StreamSize_Demuxed = value; } }
        public string StreamSize_DemuxedString { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString)) { this._StreamSize_DemuxedString = ""; } return this._StreamSize_DemuxedString; } set { this._StreamSize_DemuxedString = value; } }
        public string StreamSize_DemuxedString1 { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString1)) { this._StreamSize_DemuxedString1 = ""; } return this._StreamSize_DemuxedString1; } set { this._StreamSize_DemuxedString1 = value; } }
        public string StreamSize_DemuxedString2 { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString2)) { this._StreamSize_DemuxedString2 = ""; } return this._StreamSize_DemuxedString2; } set { this._StreamSize_DemuxedString2 = value; } }
        public string StreamSize_DemuxedString3 { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString3)) { this._StreamSize_DemuxedString3 = ""; } return this._StreamSize_DemuxedString3; } set { this._StreamSize_DemuxedString3 = value; } }
        public string StreamSize_DemuxedString4 { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString4)) { this._StreamSize_DemuxedString4 = ""; } return this._StreamSize_DemuxedString4; } set { this._StreamSize_DemuxedString4 = value; } }
        public string StreamSize_DemuxedString5 { get { if (string.IsNullOrEmpty(this._StreamSize_DemuxedString5)) { this._StreamSize_DemuxedString5 = ""; } return this._StreamSize_DemuxedString5; } set { this._StreamSize_DemuxedString5 = value; } }
        public string Encoded_Library { get { if (string.IsNullOrEmpty(this._Encoded_Library)) { this._Encoded_Library = ""; } return this._Encoded_Library; } set { this._Encoded_Library = value; } }
        public string Encoded_LibraryString { get { if (string.IsNullOrEmpty(this._Encoded_LibraryString)) { this._Encoded_LibraryString = ""; } return this._Encoded_LibraryString; } set { this._Encoded_LibraryString = value; } }
        public string Encoded_Library_Name { get { if (string.IsNullOrEmpty(this._Encoded_Library_Name)) { this._Encoded_Library_Name = ""; } return this._Encoded_Library_Name; } set { this._Encoded_Library_Name = value; } }
        public string Encoded_Library_Version { get { if (string.IsNullOrEmpty(this._Encoded_Library_Version)) { this._Encoded_Library_Version = ""; } return this._Encoded_Library_Version; } set { this._Encoded_Library_Version = value; } }
        public string Encoded_Library_Date { get { if (string.IsNullOrEmpty(this._Encoded_Library_Date)) { this._Encoded_Library_Date = ""; } return this._Encoded_Library_Date; } set { this._Encoded_Library_Date = value; } }
        public string Encoded_Library_Settings { get { if (string.IsNullOrEmpty(this._Encoded_Library_Settings)) { this._Encoded_Library_Settings = ""; } return this._Encoded_Library_Settings; } set { this._Encoded_Library_Settings = value; } }
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
        public string Summary { get { if (string.IsNullOrEmpty(this._Summary)) { this._Summary = ""; } return this._Summary; } set { this._Summary = value; } }
        public string Encoded_Date { get { if (string.IsNullOrEmpty(this._Encoded_Date)) { this._Encoded_Date = ""; } return this._Encoded_Date; } set { this._Encoded_Date = value; } }
        public string Tagged_Date { get { if (string.IsNullOrEmpty(this._Tagged_Date)) { this._Tagged_Date = ""; } return this._Tagged_Date; } set { this._Tagged_Date = value; } }
        public string Encryption { get { if (string.IsNullOrEmpty(this._Encryption)) { this._Encryption = ""; } return this._Encryption; } set { this._Encryption = value; } }
        public string colour_description_present { get { if (string.IsNullOrEmpty(this._colour_description_present)) { this._colour_description_present = ""; } return this._colour_description_present; } set { this._colour_description_present = value; } }
        public string colour_primaries { get { if (string.IsNullOrEmpty(this._colour_primaries)) { this._colour_primaries = ""; } return this._colour_primaries; } set { this._colour_primaries = value; } }
        public string transfer_characteristics { get { if (string.IsNullOrEmpty(this._transfer_characteristics)) { this._transfer_characteristics = ""; } return this._transfer_characteristics; } set { this._transfer_characteristics = value; } }
        public string matrix_coefficients { get { if (string.IsNullOrEmpty(this._matrix_coefficients)) { this._matrix_coefficients = ""; } return this._matrix_coefficients; } set { this._matrix_coefficients = value; } }
        public string colour_description_present_Original { get { if (string.IsNullOrEmpty(this._colour_description_present_Original)) { this._colour_description_present_Original = ""; } return this._colour_description_present_Original; } set { this._colour_description_present_Original = value; } }
        public string colour_primaries_Original { get { if (string.IsNullOrEmpty(this._colour_primaries_Original)) { this._colour_primaries_Original = ""; } return this._colour_primaries_Original; } set { this._colour_primaries_Original = value; } }
        public string transfer_characteristics_Original { get { if (string.IsNullOrEmpty(this._transfer_characteristics_Original)) { this._transfer_characteristics_Original = ""; } return this._transfer_characteristics_Original; } set { this._transfer_characteristics_Original = value; } }
        public string matrix_coefficients_Original { get { if (string.IsNullOrEmpty(this._matrix_coefficients_Original)) { this._matrix_coefficients_Original = ""; } return this._matrix_coefficients_Original; } set { this._matrix_coefficients_Original = value; } }
    }
}

