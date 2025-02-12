namespace MediaInfoWrapper
{
    using System;

    public class ImageTrack
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
        private string _Title;  //Title of track
        private string _Format;  //Format used
        private string _FormatString;  //Format used and any additional features or settings
        private string _FormatInfo;  //More details about the identified Format
        private string _FormatUrl;  //Link to a description of this format
        private string _Format_Commercial;  //Commercial name used by vendor for these settings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for these settings, if available
        private string _Format_Version;  //Version for the identified format
        private string _Format_Profile;  //Profile of the Format
        private string _Format_Compression;  //Compression method used
        private string _Format_AdditionalFeatures;  //Format features needed for fully supporting the content
        private string _HDR_Format;  //High Dynamic Range Format used
        private string _HDR_FormatString;  //HDR Format used, along with version, profile, level, layers, settings, and compatibility information
        private string _HDR_Format_Commercial;  //Commercial name used by vendor for these HDR settings or HDR Format field if there is no difference
        private string _HDR_Format_Version;  //Version of HDR Format
        private string _HDR_Format_Profile;  //Profile of HDR Format
        private string _HDR_Format_Level;  //Level of HDR Format
        private string _HDR_Format_Settings;  //HDR Format settings
        private string _HDR_Format_Compatibility;  //HDR Format compatibility with commercial products (e.g. HDR10)
        private string _Format_Settings;  //Settings used and required by decoder
        private string _Format_Settings_Endianness;  //Order of bytes required for decoding. Options are Big/Little
        private string _Format_Settings_Packing;  //Data packing method used in DPX frames (e.g. Packed, Filled A, Filled B)
        private string _Format_Settings_Wrapping;  //Wrapping mode set for format (e.g. Frame, Clip)
        private string _InternetMediaType;  //Internet Media Type (aka MIME Type, Content-Type)
        private string _CodecID;  //Codec identifier as indicated by the container
        private string _CodecIDString;  //Codec identifier, as indicated by the container
        private string _CodecIDInfo;  //More information about this codec identifier
        private string _CodecIDHint;  //Common alternative names for this codec identifier
        private string _CodecIDUrl;  //A link to more details about this codec identifier
        private string _CodecID_Description;  //Codec description, as defined by the container
        private string _Codec;  //Deprecated, do not use in new projects
        private string _CodecString;  //Deprecated, do not use in new projects
        private string _CodecFamily;  //Deprecated, do not use in new projects
        private string _CodecInfo;  //Deprecated, do not use in new projects
        private string _CodecUrl;  //Deprecated, do not use in new projects
        private string _Width;  //Width of frame (trimmed to "clean aperture" size if present) in pixels, as integer (e.g. 1920)
        private string _WidthString;  //Width of frame (trimmed to "clean aperture" size if present) in pixels, presented in SI unit digit spacing style, with measurement (e.g. 1 920 pixels)
        private string _Width_Offset;  //Offset between original width and displayed width, in pixels
        private string _Width_OffsetString;  //Offset between original width and displayed width, in pixels
        private string _Width_Original;  //Width of frame (not including aperture size if present) in pixels, presented as integer (e.g. 1920)
        private string _Width_OriginalString;  //Width of frame (not including aperture size if present) in pixels, present in SI unit digit spacing style, with measurement (e.g. 1 920 pixels)
        private string _Height;  //Height of frame (including aperture size if present) in pixels, presented as integer (e.g. 1080)
        private string _HeightString;  //Height of frame (including aperture size if present) in pixels, present in SI unit digit spacing style, with measurement (e.g. 1 080 pixels)
        private string _Height_Offset;  //Offset between original height and displayed height, in pixels
        private string _Height_OffsetString;  //Offset between original height and displayed height, in pixels
        private string _Height_Original;  //Height of frame (not including aperture size if present) in pixels, presented as integer (e.g. 1080)
        private string _Height_OriginalString;  //Height of frame (not including aperture size if present) in pixels, present in SI unit digit spacing style, with measurement (e.g. 1 080 pixels)
        private string _PixelAspectRatio;  //Pixel Aspect ratio
        private string _PixelAspectRatioString;  //Pixel Aspect ratio
        private string _PixelAspectRatio_Original;  //Original (in the raw stream) Pixel Aspect ratio
        private string _PixelAspectRatio_OriginalString;  //Original (in the raw stream) Pixel Aspect ratio
        private string _DisplayAspectRatio;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatioString;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatio_Original;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatio_OriginalString;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _Active_Width;  //Width of frame, not considering black bars
        private string _Active_WidthString;  //Width of frame, not considering black bars, in pixels, presented in SI unit digit spacing style, with measurement (e.g. 1 920 pixels)
        private string _Active_Height;  //Height of frame, not considering black bars
        private string _Active_HeightString;  //Height of frame, not considering black bars, in pixels, presented in SI unit digit spacing style, with measurement (e.g. 1 080 pixels)
        private string _Active_DisplayAspectRatio;  //The proportional relationship between the active width and active height of a frame (e.g. 4:3)
        private string _Active_DisplayAspectRatioString;  //The proportional relationship between the active width and active height of a frame (e.g. 4:3)
        private string _ColorSpace;  //Color profile of the image (e.g. YUV)
        private string _ChromaSubsampling;  //Ratio of chroma to luma in encoded image (e.g. 4:2:2)
        private string _Resolution;  //Deprecated, do not use in new projects
        private string _ResolutionString;  //Deprecated, do not use in new projects
        private string _BitDepth;  //Color information stored in the frame, as integer (e.g. 10)
        private string _BitDepthString;  //Color information stored in the frame, as string (e.g. 10 bits)
        private string _Compression_Mode;  //Compression mode (Lossy, Lossless)
        private string _Compression_ModeString;  //Compression mode (Lossy, Lossless)
        private string _Compression_Ratio;  //Stream size divided by uncompressed stream size
        private string _StreamSize;  //Size of this stream, in bytes
        private string _StreamSizeString;  //Size of this stream, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _StreamSizeString1;  //Size of this stream, with measurement (measured in powers of 1024) rounded to the nearest integer (e.g. 11 MiB)
        private string _StreamSizeString2;  //Size of this stream, measurement (measured in powers of 1024) rounded to the two most significant digits (e.g. 11 MiB)
        private string _StreamSizeString3;  //Size of this stream, measurement (measured in powers of 1024) rounded to the three most significant digits (e.g. 10.5 MiB)
        private string _StreamSizeString4;  //Size of this stream, measurement (measured in powers of 1024) rounded to the four most significant digits (e.g. 10.50 MiB)
        private string _StreamSizeString5;  //Size of this stream, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _StreamSize_Proportion;  //Size of this stream divided by total file size
        private string _StreamSize_Demuxed;  //Size of this stream after demuxing, in bytes
        private string _StreamSize_DemuxedString;  //Size of this stream after demuxing, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _StreamSize_DemuxedString1;  //Size of this stream after demuxing, with measurement (measured in powers of 1024) rounded to the nearest integer (e.g. 11 MiB)
        private string _StreamSize_DemuxedString2;  //Size of this stream after demuxing, measurement (measured in powers of 1024) rounded to the two most significant digits (e.g. 11 MiB)
        private string _StreamSize_DemuxedString3;  //Size of this stream after demuxing, measurement (measured in powers of 1024) rounded to the three most significant digits (e.g. 10.5 MiB)
        private string _StreamSize_DemuxedString4;  //Size of this stream after demuxing, measurement (measured in powers of 1024) rounded to the four most significant digits (e.g. 10.50 MiB)
        private string _StreamSize_DemuxedString5;  //Size of this stream after demuxing, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _Encoded_Library;  //Software used to create the file
        private string _Encoded_LibraryString;  //Software used to create the file, in the format "CompanyName ProductName (OperatingSystem) Version (Date)"
        private string _Encoded_Library_Name;  //Name of the encoding software
        private string _Encoded_Library_Version;  //Version of the encoding software
        private string _Encoded_Library_Date;  //Release date of the encoding software, in UTC
        private string _Encoded_Library_Settings;  //Parameters used by the encoding software
        private string _Language;  //Language, formatted as 2-letter ISO 639-1 if exists, else 3-letter ISO 639-2, and with optional ISO 3166-1 country separated by a dash if available (e.g. en, en-US, en-CN)
        private string _LanguageString;  //Language, as full name (e.g. English)
        private string _LanguageString1;  //Language, as full name (e.g. English)
        private string _LanguageString2;  //Language, formatted as 2-letter ISO 639-1, if exists (e.g. en)
        private string _LanguageString3;  //Language, formatted as 3-letter ISO 639-2, if exists (e.g. eng)
        private string _LanguageString4;  //Language, formatted as 2-letter ISO 639-1, if exists, with optional ISO 3166-1 country separated by a dash if available (e.g. en-US)
        private string _Language_More;  //More information about Language (e.g. Director's Comment)
        private string _ServiceKind;  //Type of assisted service (e.g. visually impaired, commentary, voice over)
        private string _ServiceKindString;  //Type of assisted service (e.g. visually impaired, commentary, voice over)
        private string _Disabled;  //Set if this stream should not be used (Yes, No)
        private string _DisabledString;  //Set if this stream should not be used (Yes, No)
        private string _Default;  //Flag set if this stream should be used if no language found matches the user preference (Yes, No)
        private string _DefaultString;  //Flag set if this stream should be used if no language found matches the user preference (Yes, No)
        private string _Forced;  //Flag set if this stream should be used regardless of user preferences, often used for sparse subtitle dialogue in an otherwise unsubtitled movie (Yes, No)
        private string _ForcedString;  //Flag set if this stream should be used regardless of user preferences, often used for sparse subtitle dialogue in an otherwise unsubtitled movie (Yes, No)
        private string _AlternateGroup;  //Number of a group in order to provide versions of the same track
        private string _AlternateGroupString;  //Number of a group in order to provide versions of the same track
        private string _Summary;  //Plot outline or a summary of the story
        private string _Encoded_Date;  //Time that the encoding of this item was completed, in UTC
        private string _Tagged_Date;  //Time that the tags were added to this item, in UTC
        private string _Encryption;  //Whether this stream is encrypted and, if available, how it is encrypted
        private string _colour_description_present;  //Presence of color description (Yes, No)
        private string _colour_description_present_Source;  //Presence of colour description (source)
        private string _colour_description_present_Original;  //Presence of colour description (if incoherencies)
        private string _colour_description_present_Original_Source;  //Presence of colour description (source if incoherencies)
        private string _colour_range;  //Color range for YUV color space
        private string _colour_range_Source;  //Colour range for YUV colour space (source)
        private string _colour_range_Original;  //Colour range for YUV colour space (if incoherencies)
        private string _colour_range_Original_Source;  //Colour range for YUV colour space (source if incoherencies)
        private string _colour_primaries;  //Chromaticity coordinates of the source primaries
        private string _colour_primaries_Source;  //Chromaticity coordinates of the source primaries (source)
        private string _colour_primaries_Original;  //Chromaticity coordinates of the source primaries (if incoherencies)
        private string _colour_primaries_Original_Source;  //Chromaticity coordinates of the source primaries (source if incoherencies)
        private string _transfer_characteristics;  //Opto-electronic transfer characteristic of the source picture
        private string _transfer_characteristics_Source;  //Opto-electronic transfer characteristic of the source picture (source)
        private string _transfer_characteristics_Original;  //Opto-electronic transfer characteristic of the source picture (if incoherencies)
        private string _transfer_characteristics_Original_Source;  //Opto-electronic transfer characteristic of the source picture (source if incoherencies)
        private string _matrix_coefficients;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries
        private string _matrix_coefficients_Source;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries (source)
        private string _matrix_coefficients_Original;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries (if incoherencies)
        private string _matrix_coefficients_Original_Source;  //Matrix coefficients used in deriving luma and chroma signals from the green, blue, and red primaries (source if incoherencies)
        private string _MasteringDisplay_ColorPrimaries;  //Chromaticity coordinates of the source primaries of the mastering display
        private string _MasteringDisplay_ColorPrimaries_Source;  //Chromaticity coordinates of the source primaries of the mastering display (source)
        private string _MasteringDisplay_ColorPrimaries_Original;  //Chromaticity coordinates of the source primaries of the mastering display (if incoherencies)
        private string _MasteringDisplay_ColorPrimaries_Original_Source;  //Chromaticity coordinates of the source primaries of the mastering display (source if incoherencies)
        private string _MasteringDisplay_Luminance;  //Luminance of the mastering display
        private string _MasteringDisplay_Luminance_Source;  //Luminance of the mastering display (source)
        private string _MasteringDisplay_Luminance_Original;  //Luminance of the mastering display (if incoherencies)
        private string _MasteringDisplay_Luminance_Original_Source;  //Luminance of the mastering display (source if incoherencies)
        private string _MaxCLL;  //Maximum content light level
        private string _MaxCLL_Source;  //Maximum content light level (source)
        private string _MaxCLL_Original;  //Maximum content light level (if incoherencies)
        private string _MaxCLL_Original_Source;  //Maximum content light level (source if incoherencies)
        private string _MaxFALL;  //Maximum frame average light level
        private string _MaxFALL_Source;  //Maximum frame average light level (source)
        private string _MaxFALL_Original;  //Maximum frame average light level (if incoherencies)
        private string _MaxFALL_Original_Source;  //Maximum frame average light level (source if incoherencies)

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
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_AdditionalFeatures { get { if (string.IsNullOrEmpty(this._Format_AdditionalFeatures)) { this._Format_AdditionalFeatures = ""; } return this._Format_AdditionalFeatures; } set { this._Format_AdditionalFeatures = value; } }
        public string HDR_Format { get { if (string.IsNullOrEmpty(this._HDR_Format)) { this._HDR_Format = ""; } return this._HDR_Format; } set { this._HDR_Format = value; } }
        public string HDR_FormatString { get { if (string.IsNullOrEmpty(this._HDR_FormatString)) { this._HDR_FormatString = ""; } return this._HDR_FormatString; } set { this._HDR_FormatString = value; } }
        public string HDR_Format_Commercial { get { if (string.IsNullOrEmpty(this._HDR_Format_Commercial)) { this._HDR_Format_Commercial = ""; } return this._HDR_Format_Commercial; } set { this._HDR_Format_Commercial = value; } }
        public string HDR_Format_Version { get { if (string.IsNullOrEmpty(this._HDR_Format_Version)) { this._HDR_Format_Version = ""; } return this._HDR_Format_Version; } set { this._HDR_Format_Version = value; } }
        public string HDR_Format_Profile { get { if (string.IsNullOrEmpty(this._HDR_Format_Profile)) { this._HDR_Format_Profile = ""; } return this._HDR_Format_Profile; } set { this._HDR_Format_Profile = value; } }
        public string HDR_Format_Level { get { if (string.IsNullOrEmpty(this._HDR_Format_Level)) { this._HDR_Format_Level = ""; } return this._HDR_Format_Level; } set { this._HDR_Format_Level = value; } }
        public string HDR_Format_Settings { get { if (string.IsNullOrEmpty(this._HDR_Format_Settings)) { this._HDR_Format_Settings = ""; } return this._HDR_Format_Settings; } set { this._HDR_Format_Settings = value; } }
        public string HDR_Format_Compatibility { get { if (string.IsNullOrEmpty(this._HDR_Format_Compatibility)) { this._HDR_Format_Compatibility = ""; } return this._HDR_Format_Compatibility; } set { this._HDR_Format_Compatibility = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string Format_Settings_Endianness { get { if (string.IsNullOrEmpty(this._Format_Settings_Endianness)) { this._Format_Settings_Endianness = ""; } return this._Format_Settings_Endianness; } set { this._Format_Settings_Endianness = value; } }
        public string Format_Settings_Packing { get { if (string.IsNullOrEmpty(this._Format_Settings_Packing)) { this._Format_Settings_Packing = ""; } return this._Format_Settings_Packing; } set { this._Format_Settings_Packing = value; } }
        public string Format_Settings_Wrapping { get { if (string.IsNullOrEmpty(this._Format_Settings_Wrapping)) { this._Format_Settings_Wrapping = ""; } return this._Format_Settings_Wrapping; } set { this._Format_Settings_Wrapping = value; } }
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
        public string Active_Width { get { if (string.IsNullOrEmpty(this._Active_Width)) { this._Active_Width = ""; } return this._Active_Width; } set { this._Active_Width = value; } }
        public string Active_WidthString { get { if (string.IsNullOrEmpty(this._Active_WidthString)) { this._Active_WidthString = ""; } return this._Active_WidthString; } set { this._Active_WidthString = value; } }
        public string Active_Height { get { if (string.IsNullOrEmpty(this._Active_Height)) { this._Active_Height = ""; } return this._Active_Height; } set { this._Active_Height = value; } }
        public string Active_HeightString { get { if (string.IsNullOrEmpty(this._Active_HeightString)) { this._Active_HeightString = ""; } return this._Active_HeightString; } set { this._Active_HeightString = value; } }
        public string Active_DisplayAspectRatio { get { if (string.IsNullOrEmpty(this._Active_DisplayAspectRatio)) { this._Active_DisplayAspectRatio = ""; } return this._Active_DisplayAspectRatio; } set { this._Active_DisplayAspectRatio = value; } }
        public string Active_DisplayAspectRatioString { get { if (string.IsNullOrEmpty(this._Active_DisplayAspectRatioString)) { this._Active_DisplayAspectRatioString = ""; } return this._Active_DisplayAspectRatioString; } set { this._Active_DisplayAspectRatioString = value; } }
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
        public string colour_description_present_Source { get { if (string.IsNullOrEmpty(this._colour_description_present_Source)) { this._colour_description_present_Source = ""; } return this._colour_description_present_Source; } set { this._colour_description_present_Source = value; } }
        public string colour_description_present_Original { get { if (string.IsNullOrEmpty(this._colour_description_present_Original)) { this._colour_description_present_Original = ""; } return this._colour_description_present_Original; } set { this._colour_description_present_Original = value; } }
        public string colour_description_present_Original_Source { get { if (string.IsNullOrEmpty(this._colour_description_present_Original_Source)) { this._colour_description_present_Original_Source = ""; } return this._colour_description_present_Original_Source; } set { this._colour_description_present_Original_Source = value; } }
        public string colour_range { get { if (string.IsNullOrEmpty(this._colour_range)) { this._colour_range = ""; } return this._colour_range; } set { this._colour_range = value; } }
        public string colour_range_Source { get { if (string.IsNullOrEmpty(this._colour_range_Source)) { this._colour_range_Source = ""; } return this._colour_range_Source; } set { this._colour_range_Source = value; } }
        public string colour_range_Original { get { if (string.IsNullOrEmpty(this._colour_range_Original)) { this._colour_range_Original = ""; } return this._colour_range_Original; } set { this._colour_range_Original = value; } }
        public string colour_range_Original_Source { get { if (string.IsNullOrEmpty(this._colour_range_Original_Source)) { this._colour_range_Original_Source = ""; } return this._colour_range_Original_Source; } set { this._colour_range_Original_Source = value; } }
        public string colour_primaries { get { if (string.IsNullOrEmpty(this._colour_primaries)) { this._colour_primaries = ""; } return this._colour_primaries; } set { this._colour_primaries = value; } }
        public string colour_primaries_Source { get { if (string.IsNullOrEmpty(this._colour_primaries_Source)) { this._colour_primaries_Source = ""; } return this._colour_primaries_Source; } set { this._colour_primaries_Source = value; } }
        public string colour_primaries_Original { get { if (string.IsNullOrEmpty(this._colour_primaries_Original)) { this._colour_primaries_Original = ""; } return this._colour_primaries_Original; } set { this._colour_primaries_Original = value; } }
        public string colour_primaries_Original_Source { get { if (string.IsNullOrEmpty(this._colour_primaries_Original_Source)) { this._colour_primaries_Original_Source = ""; } return this._colour_primaries_Original_Source; } set { this._colour_primaries_Original_Source = value; } }
        public string transfer_characteristics { get { if (string.IsNullOrEmpty(this._transfer_characteristics)) { this._transfer_characteristics = ""; } return this._transfer_characteristics; } set { this._transfer_characteristics = value; } }
        public string transfer_characteristics_Source { get { if (string.IsNullOrEmpty(this._transfer_characteristics_Source)) { this._transfer_characteristics_Source = ""; } return this._transfer_characteristics_Source; } set { this._transfer_characteristics_Source = value; } }
        public string transfer_characteristics_Original { get { if (string.IsNullOrEmpty(this._transfer_characteristics_Original)) { this._transfer_characteristics_Original = ""; } return this._transfer_characteristics_Original; } set { this._transfer_characteristics_Original = value; } }
        public string transfer_characteristics_Original_Source { get { if (string.IsNullOrEmpty(this._transfer_characteristics_Original_Source)) { this._transfer_characteristics_Original_Source = ""; } return this._transfer_characteristics_Original_Source; } set { this._transfer_characteristics_Original_Source = value; } }
        public string matrix_coefficients { get { if (string.IsNullOrEmpty(this._matrix_coefficients)) { this._matrix_coefficients = ""; } return this._matrix_coefficients; } set { this._matrix_coefficients = value; } }
        public string matrix_coefficients_Source { get { if (string.IsNullOrEmpty(this._matrix_coefficients_Source)) { this._matrix_coefficients_Source = ""; } return this._matrix_coefficients_Source; } set { this._matrix_coefficients_Source = value; } }
        public string matrix_coefficients_Original { get { if (string.IsNullOrEmpty(this._matrix_coefficients_Original)) { this._matrix_coefficients_Original = ""; } return this._matrix_coefficients_Original; } set { this._matrix_coefficients_Original = value; } }
        public string matrix_coefficients_Original_Source { get { if (string.IsNullOrEmpty(this._matrix_coefficients_Original_Source)) { this._matrix_coefficients_Original_Source = ""; } return this._matrix_coefficients_Original_Source; } set { this._matrix_coefficients_Original_Source = value; } }
        public string MasteringDisplay_ColorPrimaries { get { if (string.IsNullOrEmpty(this._MasteringDisplay_ColorPrimaries)) { this._MasteringDisplay_ColorPrimaries = ""; } return this._MasteringDisplay_ColorPrimaries; } set { this._MasteringDisplay_ColorPrimaries = value; } }
        public string MasteringDisplay_ColorPrimaries_Source { get { if (string.IsNullOrEmpty(this._MasteringDisplay_ColorPrimaries_Source)) { this._MasteringDisplay_ColorPrimaries_Source = ""; } return this._MasteringDisplay_ColorPrimaries_Source; } set { this._MasteringDisplay_ColorPrimaries_Source = value; } }
        public string MasteringDisplay_ColorPrimaries_Original { get { if (string.IsNullOrEmpty(this._MasteringDisplay_ColorPrimaries_Original)) { this._MasteringDisplay_ColorPrimaries_Original = ""; } return this._MasteringDisplay_ColorPrimaries_Original; } set { this._MasteringDisplay_ColorPrimaries_Original = value; } }
        public string MasteringDisplay_ColorPrimaries_Original_Source { get { if (string.IsNullOrEmpty(this._MasteringDisplay_ColorPrimaries_Original_Source)) { this._MasteringDisplay_ColorPrimaries_Original_Source = ""; } return this._MasteringDisplay_ColorPrimaries_Original_Source; } set { this._MasteringDisplay_ColorPrimaries_Original_Source = value; } }
        public string MasteringDisplay_Luminance { get { if (string.IsNullOrEmpty(this._MasteringDisplay_Luminance)) { this._MasteringDisplay_Luminance = ""; } return this._MasteringDisplay_Luminance; } set { this._MasteringDisplay_Luminance = value; } }
        public string MasteringDisplay_Luminance_Source { get { if (string.IsNullOrEmpty(this._MasteringDisplay_Luminance_Source)) { this._MasteringDisplay_Luminance_Source = ""; } return this._MasteringDisplay_Luminance_Source; } set { this._MasteringDisplay_Luminance_Source = value; } }
        public string MasteringDisplay_Luminance_Original { get { if (string.IsNullOrEmpty(this._MasteringDisplay_Luminance_Original)) { this._MasteringDisplay_Luminance_Original = ""; } return this._MasteringDisplay_Luminance_Original; } set { this._MasteringDisplay_Luminance_Original = value; } }
        public string MasteringDisplay_Luminance_Original_Source { get { if (string.IsNullOrEmpty(this._MasteringDisplay_Luminance_Original_Source)) { this._MasteringDisplay_Luminance_Original_Source = ""; } return this._MasteringDisplay_Luminance_Original_Source; } set { this._MasteringDisplay_Luminance_Original_Source = value; } }
        public string MaxCLL { get { if (string.IsNullOrEmpty(this._MaxCLL)) { this._MaxCLL = ""; } return this._MaxCLL; } set { this._MaxCLL = value; } }
        public string MaxCLL_Source { get { if (string.IsNullOrEmpty(this._MaxCLL_Source)) { this._MaxCLL_Source = ""; } return this._MaxCLL_Source; } set { this._MaxCLL_Source = value; } }
        public string MaxCLL_Original { get { if (string.IsNullOrEmpty(this._MaxCLL_Original)) { this._MaxCLL_Original = ""; } return this._MaxCLL_Original; } set { this._MaxCLL_Original = value; } }
        public string MaxCLL_Original_Source { get { if (string.IsNullOrEmpty(this._MaxCLL_Original_Source)) { this._MaxCLL_Original_Source = ""; } return this._MaxCLL_Original_Source; } set { this._MaxCLL_Original_Source = value; } }
        public string MaxFALL { get { if (string.IsNullOrEmpty(this._MaxFALL)) { this._MaxFALL = ""; } return this._MaxFALL; } set { this._MaxFALL = value; } }
        public string MaxFALL_Source { get { if (string.IsNullOrEmpty(this._MaxFALL_Source)) { this._MaxFALL_Source = ""; } return this._MaxFALL_Source; } set { this._MaxFALL_Source = value; } }
        public string MaxFALL_Original { get { if (string.IsNullOrEmpty(this._MaxFALL_Original)) { this._MaxFALL_Original = ""; } return this._MaxFALL_Original; } set { this._MaxFALL_Original = value; } }
        public string MaxFALL_Original_Source { get { if (string.IsNullOrEmpty(this._MaxFALL_Original_Source)) { this._MaxFALL_Original_Source = ""; } return this._MaxFALL_Original_Source; } set { this._MaxFALL_Original_Source = value; } }
    }
}

