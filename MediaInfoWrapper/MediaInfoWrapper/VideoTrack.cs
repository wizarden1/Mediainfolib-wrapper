namespace MediaInfoWrapper
{
    using System;

    public class VideoTrack
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
        private string _Format;  //Format used
        private string _FormatString;  //Format used + additional features
        private string _FormatInfo;  //Info about Format
        private string _FormatUrl;  //Link
        private string _Format_Commercial;  //Commercial name used by vendor for theses setings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for theses setings if there is one
        private string _Format_Version;  //Version of this format
        private string _Format_Profile;  //Profile of the Format (old XML: 'Profile@Level@Tier' format
        private string _Format_Level;  //Level of the Format (only MIXML)
        private string _Format_Tier;  //Tier of the Format (only MIXML)
        private string _Format_Compression;  //Compression method used
        private string _Format_AdditionalFeatures;  //Format features needed for fully supporting the content
        private string _MultiView_BaseProfile;  //Multiview, profile of the base stream
        private string _MultiView_Count;  //Multiview, count of views
        private string _MultiView_Layout;  //Multiview, how views are muxed in the container in case of it is not muxing in the stream
        private string _HDR_Format;  //Format used
        private string _HDR_FormatString;  //Format used + version + profile + level + layers + settings + compatibility
        private string _HDR_Format_Commercial;  //Commercial name used by vendor for theses HDR settings or HDR Format field if there is no difference
        private string _HDR_Format_Version;  //Version of this format
        private string _HDR_Format_Profile;  //Profile of the Format
        private string _HDR_Format_Level;  //Level of the Format
        private string _HDR_Format_Settings;  //Settings of the Format
        private string _HDR_Format_Compatibility;  //Compatibility with some commercial namings
        private string _Format_Settings;  //Settings needed for decoder used, summary
        private string _Format_Settings_BVOP;  //Settings needed for decoder used, detailled
        private string _Format_Settings_BVOPString;  //Settings needed for decoder used, detailled
        private string _Format_Settings_QPel;  //Settings needed for decoder used, detailled
        private string _Format_Settings_QPelString;  //Settings needed for decoder used, detailled
        private string _Format_Settings_GMC;  //Settings needed for decoder used, detailled
        private string _Format_Settings_GMCString;  //
        private string _Format_Settings_Matrix;  //Settings needed for decoder used, detailled
        private string _Format_Settings_MatrixString;  //Settings needed for decoder used, detailled
        private string _Format_Settings_Matrix_Data;  //Matrix, in binary format encoded BASE64. Order = intra, non-intra, gray intra, gray non-intra
        private string _Format_Settings_CABAC;  //Settings needed for decoder used, detailled
        private string _Format_Settings_CABACString;  //Settings needed for decoder used, detailled
        private string _Format_Settings_RefFrames;  //Settings needed for decoder used, detailled
        private string _Format_Settings_RefFramesString;  //Settings needed for decoder used, detailled
        private string _Format_Settings_Pulldown;  //Settings needed for decoder used, detailled
        private string _Format_Settings_Endianness;  //
        private string _Format_Settings_Packing;  //
        private string _Format_Settings_FrameMode;  //Settings needed for decoder used, detailled
        private string _Format_Settings_GOP;  //Settings needed for decoder used, detailled (M=x N=y)
        private string _Format_Settings_PictureStructure;  //Settings needed for decoder used, detailled (Type of frame, and field/frame info)
        private string _Format_Settings_Wrapping;  //Wrapping mode (Frame wrapped or Clip wrapped)
        private string _InternetMediaType;  //Internet Media Type (aka MIME Type, Content-Type)
        private string _MuxingMode;  //How this file is muxed in the container
        private string _CodecID;  //Codec ID (found in some containers)
        private string _CodecIDString;  //Codec ID (found in some containers)
        private string _CodecIDInfo;  //Info on the codec
        private string _CodecIDHint;  //Hint/popular name for this codec
        private string _CodecIDUrl;  //Homepage for more details about this codec
        private string _CodecID_Description;  //Manual description given by the container
        private string _Codec;  //Deprecated, do not use in new projects
        private string _CodecString;  //Deprecated, do not use in new projects
        private string _CodecFamily;  //Deprecated, do not use in new projects
        private string _CodecInfo;  //Deprecated, do not use in new projects
        private string _CodecUrl;  //Deprecated, do not use in new projects
        private string _CodecCC;  //Deprecated, do not use in new projects
        private string _Codec_Profile;  //Deprecated, do not use in new projects
        private string _Codec_Description;  //Deprecated, do not use in new projects
        private string _Codec_Settings;  //Deprecated, do not use in new projects
        private string _Codec_Settings_PacketBitStream;  //Deprecated, do not use in new projects
        private string _Codec_Settings_BVOP;  //Deprecated, do not use in new projects
        private string _Codec_Settings_QPel;  //Deprecated, do not use in new projects
        private string _Codec_Settings_GMC;  //Deprecated, do not use in new projects
        private string _Codec_Settings_GMCString;  //Deprecated, do not use in new projects
        private string _Codec_Settings_Matrix;  //Deprecated, do not use in new projects
        private string _Codec_Settings_Matrix_Data;  //Deprecated, do not use in new projects
        private string _Codec_Settings_CABAC;  //Deprecated, do not use in new projects
        private string _Codec_Settings_RefFrames;  //Deprecated, do not use in new projects
        private string _Duration;  //Play time of the stream in ms
        private string _DurationString;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString1;  //Play time in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _DurationString2;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString3;  //Play time in format : HH:MM:SS.MMM
        private string _DurationString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _DurationString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_FirstFrame;  //Duration of the first frame if it is longer than others, in ms
        private string _Duration_FirstFrameString;  //Duration of the first frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Duration_FirstFrameString1;  //Duration of the first frame if it is longer than others, in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _Duration_FirstFrameString2;  //Duration of the first frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Duration_FirstFrameString3;  //Duration of the first frame if it is longer than others, in format : HH:MM:SS.MMM
        private string _Duration_FirstFrameString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Duration_FirstFrameString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_LastFrame;  //Duration of the last frame if it is longer than others, in ms
        private string _Duration_LastFrameString;  //Duration of the last frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Duration_LastFrameString1;  //Duration of the last frame if it is longer than others, in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _Duration_LastFrameString2;  //Duration of the last frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Duration_LastFrameString3;  //Duration of the last frame if it is longer than others, in format : HH:MM:SS.MMM
        private string _Duration_LastFrameString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Duration_LastFrameString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Source_Duration;  //Source Play time of the stream, in ms
        private string _Source_DurationString;  //Source Play time in format : XXx YYy only, YYy omited if zero
        private string _Source_DurationString1;  //Source Play time in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _Source_DurationString2;  //Source Play time in format : XXx YYy only, YYy omited if zero
        private string _Source_DurationString3;  //Source Play time in format : HH:MM:SS.MMM
        private string _Source_DurationString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Source_DurationString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Source_Duration_FirstFrame;  //Source Duration of the first frame if it is longer than others, in ms
        private string _Source_Duration_FirstFrameString;  //Source Duration of the first frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Source_Duration_FirstFrameString1;  //Source Duration of the first frame if it is longer than others, in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _Source_Duration_FirstFrameString2;  //Source Duration of the first frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Source_Duration_FirstFrameString3;  //Source Duration of the first frame if it is longer than others, in format : HH:MM:SS.MMM
        private string _Source_Duration_FirstFrameString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Source_Duration_FirstFrameString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Source_Duration_LastFrame;  //Source Duration of the last frame if it is longer than others, in ms
        private string _Source_Duration_LastFrameString;  //Source Duration of the last frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Source_Duration_LastFrameString1;  //Source Duration of the last frame if it is longer than others, in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _Source_Duration_LastFrameString2;  //Source Duration of the last frame if it is longer than others, in format : XXx YYy only, YYy omited if zero
        private string _Source_Duration_LastFrameString3;  //Source Duration of the last frame if it is longer than others, in format : HH:MM:SS.MMM
        private string _Source_Duration_LastFrameString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _Source_Duration_LastFrameString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _BitRate_Mode;  //Bit rate mode (VBR, CBR)
        private string _BitRate_ModeString;  //Bit rate mode (Variable, Cconstant)
        private string _BitRate;  //Bit rate in bps
        private string _BitRateString;  //Bit rate (with measurement)
        private string _BitRate_Minimum;  //Minimum Bit rate in bps
        private string _BitRate_MinimumString;  //Minimum Bit rate (with measurement)
        private string _BitRate_Nominal;  //Nominal Bit rate in bps
        private string _BitRate_NominalString;  //Nominal Bit rate (with measurement)
        private string _BitRate_Maximum;  //Maximum Bit rate in bps
        private string _BitRate_MaximumString;  //Maximum Bit rate (with measurement)
        private string _BitRate_Encoded;  //Encoded (with forced padding) bit rate in bps, if some container padding is present
        private string _BitRate_EncodedString;  //Encoded (with forced padding) bit rate (with measurement), if some container padding is present
        private string _Width;  //Width (aperture size if present) in pixel
        private string _WidthString;  //Width (aperture size if present) with measurement (pixel)
        private string _Width_Offset;  //Offset between original width and displayed width in pixel
        private string _Width_OffsetString;  //Offset between original width and displayed width in pixel
        private string _Width_Original;  //Original (in the raw stream) width in pixel
        private string _Width_OriginalString;  //Original (in the raw stream) width with measurement (pixel)
        private string _Width_CleanAperture;  //Clean Aperture width in pixel
        private string _Width_CleanApertureString;  //Clean Aperture width with measurement (pixel)
        private string _Height;  //Height in pixel
        private string _HeightString;  //Height with measurement (pixel)
        private string _Height_Offset;  //Offset between original height and displayed height in pixel
        private string _Height_OffsetString;  //Offset between original height and displayed height  in pixel
        private string _Height_Original;  //Original (in the raw stream) height in pixel
        private string _Height_OriginalString;  //Original (in the raw stream) height with measurement (pixel)
        private string _Height_CleanAperture;  //Clean Aperture height in pixel
        private string _Height_CleanApertureString;  //Clean Aperture height with measurement (pixel)
        private string _Stored_Width;  //Stored width
        private string _Stored_Height;  //Stored height
        private string _Sampled_Width;  //Sampled width
        private string _Sampled_Height;  //Sampled height
        private string _PixelAspectRatio;  //Pixel Aspect ratio
        private string _PixelAspectRatioString;  //Pixel Aspect ratio
        private string _PixelAspectRatio_Original;  //Original (in the raw stream) Pixel Aspect ratio
        private string _PixelAspectRatio_OriginalString;  //Original (in the raw stream) Pixel Aspect ratio
        private string _PixelAspectRatio_CleanAperture;  //Clean Aperture Pixel Aspect ratio
        private string _PixelAspectRatio_CleanApertureString;  //Clean Aperture Pixel Aspect ratio
        private string _DisplayAspectRatio;  //Display Aspect ratio
        private string _DisplayAspectRatioString;  //Display Aspect ratio
        private string _DisplayAspectRatio_Original;  //Original (in the raw stream) Display Aspect ratio
        private string _DisplayAspectRatio_OriginalString;  //Original (in the raw stream) Display Aspect ratio
        private string _DisplayAspectRatio_CleanAperture;  //Clean Aperture Display Aspect ratio
        private string _DisplayAspectRatio_CleanApertureString;  //Clean Aperture Display Aspect ratio
        private string _ActiveFormatDescription;  //Active Format Description (AFD value)
        private string _ActiveFormatDescriptionString;  //Active Format Description (text)
        private string _ActiveFormatDescription_MuxingMode;  //Active Format Description (AFD value) muxing mode (Ancillary or Raw stream)
        private string _Rotation;  //Rotation
        private string _RotationString;  //Rotation (if not horizontal)
        private string _FrameRate_Mode;  //Frame rate mode (CFR, VFR)
        private string _FrameRate_ModeString;  //Frame rate mode (Constant, Variable)
        private string _FrameRate_Mode_Original;  //Original frame rate mode (CFR, VFR)
        private string _FrameRate_Mode_OriginalString;  //Original frame rate mode (Constant, Variable)
        private string _FrameRate;  //Frames per second
        private string _FrameRateString;  //Frames per second (with measurement)
        private string _FrameRate_Num;  //Frames per second, numerator
        private string _FrameRate_Den;  //Frames per second, denominator
        private string _FrameRate_Minimum;  //Minimum Frames per second
        private string _FrameRate_MinimumString;  //Minimum Frames per second (with measurement)
        private string _FrameRate_Nominal;  //Nominal Frames per second
        private string _FrameRate_NominalString;  //Nominal Frames per second (with measurement)
        private string _FrameRate_Maximum;  //Maximum Frames per second
        private string _FrameRate_MaximumString;  //Maximum Frames per second (with measurement)
        private string _FrameRate_Original;  //Original (in the raw stream) frames per second
        private string _FrameRate_OriginalString;  //Original (in the raw stream) frames per second (with measurement)
        private string _FrameRate_Original_Num;  //Frames per second, numerator
        private string _FrameRate_Original_Den;  //Frames per second, denominator
        private string _FrameCount;  //Number of frames
        private string _Source_FrameCount;  //Source Number of frames
        private string _Standard;  //NTSC or PAL
        private string _Resolution;  //Deprecated, do not use in new projects
        private string _ResolutionString;  //Deprecated, do not use in new projects
        private string _Colorimetry;  //Deprecated, do not use in new projects
        private string _ColorSpace;  //
        private string _ChromaSubsampling;  //
        private string _ChromaSubsamplingString;  //
        private string _ChromaSubsampling_Position;  //
        private string _BitDepth;  //16/24/32
        private string _BitDepthString;  //16/24/32 bits
        private string _ScanType;  //
        private string _ScanTypeString;  //
        private string _ScanType_Original;  //
        private string _ScanType_OriginalString;  //
        private string _ScanType_StoreMethod;  //
        private string _ScanType_StoreMethod_FieldsPerBlock;  //
        private string _ScanType_StoreMethodString;  //
        private string _ScanOrder;  //
        private string _ScanOrderString;  //
        private string _ScanOrder_Stored;  //
        private string _ScanOrder_StoredString;  //
        private string _ScanOrder_StoredDisplayedInverted;  //
        private string _ScanOrder_Original;  //
        private string _ScanOrder_OriginalString;  //
        private string _Interlacement;  //Deprecated, do not use in new projects
        private string _InterlacementString;  //Deprecated, do not use in new projects
        private string _Compression_Mode;  //Compression mode (Lossy or Lossless)
        private string _Compression_ModeString;  //Compression mode (Lossy or Lossless)
        private string _Compression_Ratio;  //Current stream size divided by uncompressed stream size
        private string _BitsPixelFrame;  //bits/(Pixel*Frame) (like Gordian Knot)
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
        private string _TimeStamp_FirstFrame;  //TimeStamp fixed in the stream (relative) IN MS
        private string _TimeStamp_FirstFrameString;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString1;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString2;  //TimeStamp with measurement
        private string _TimeStamp_FirstFrameString3;  //TimeStamp in format : HH:MM:SS.MMM
        private string _TimeStamp_FirstFrameString4;  //TimeStamp in format: HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _TimeStamp_FirstFrameString5;  //TimeStamp in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _TimeCode_FirstFrame;  //Time code in HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available format
        private string _TimeCode_Settings;  //Time code settings
        private string _TimeCode_Source;  //Time code source (Container, Stream, SystemScheme1, SDTI, ANC...)
        private string _Gop_OpenClosed;  //Time code information about Open/Closed
        private string _Gop_OpenClosedString;  //Time code information about Open/Closed
        private string _Gop_OpenClosed_FirstFrame;  //Time code information about Open/Closed of first frame if GOP is Open for the other GOPs
        private string _Gop_OpenClosed_FirstFrameString;  //Time code information about Open/Closed of first frame if GOP is Open for the other GOPs
        private string _StreamSize;  //Streamsize in bytes
        private string _StreamSizeString;  //Streamsize in with percentage value
        private string _StreamSizeString1;  //
        private string _StreamSizeString2;  //
        private string _StreamSizeString3;  //
        private string _StreamSizeString4;  //
        private string _StreamSizeString5;  //Streamsize in with percentage value
        private string _StreamSize_Proportion;  //Stream size divided by file size
        private string _StreamSize_Demuxed;  //StreamSize in bytes of hte stream after demux
        private string _StreamSize_DemuxedString;  //StreamSize_Demuxed in with percentage value
        private string _StreamSize_DemuxedString1;  //
        private string _StreamSize_DemuxedString2;  //
        private string _StreamSize_DemuxedString3;  //
        private string _StreamSize_DemuxedString4;  //
        private string _StreamSize_DemuxedString5;  //StreamSize_Demuxed in with percentage value (note: theoritical value, not for real use)
        private string _Source_StreamSize;  //Source Streamsize in bytes
        private string _Source_StreamSizeString;  //Source Streamsize in with percentage value
        private string _Source_StreamSizeString1;  //
        private string _Source_StreamSizeString2;  //
        private string _Source_StreamSizeString3;  //
        private string _Source_StreamSizeString4;  //
        private string _Source_StreamSizeString5;  //Source Streamsize in with percentage value
        private string _Source_StreamSize_Proportion;  //Source Stream size divided by file size
        private string _StreamSize_Encoded;  //Encoded Streamsize in bytes
        private string _StreamSize_EncodedString;  //Encoded Streamsize in with percentage value
        private string _StreamSize_EncodedString1;  //
        private string _StreamSize_EncodedString2;  //
        private string _StreamSize_EncodedString3;  //
        private string _StreamSize_EncodedString4;  //
        private string _StreamSize_EncodedString5;  //Encoded Streamsize in with percentage value
        private string _StreamSize_Encoded_Proportion;  //Encoded Stream size divided by file size
        private string _Source_StreamSize_Encoded;  //Source Encoded Streamsize in bytes
        private string _Source_StreamSize_EncodedString;  //Source Encoded Streamsize in with percentage value
        private string _Source_StreamSize_EncodedString1;  //
        private string _Source_StreamSize_EncodedString2;  //
        private string _Source_StreamSize_EncodedString3;  //
        private string _Source_StreamSize_EncodedString4;  //
        private string _Source_StreamSize_EncodedString5;  //Source Encoded Streamsize in with percentage value
        private string _Source_StreamSize_Encoded_Proportion;  //Source Encoded Stream size divided by file size
        private string _Alignment;  //How this stream file is aligned in the container
        private string _AlignmentString;  //
        private string _Title;  //Name of the track
        private string _Encoded_Application;  //Name of the software package used to create the file, such as Microsoft WaveEdit
        private string _Encoded_ApplicationString;  //Name of the software package used to create the file, such as Microsoft WaveEdit, trying to have the format 'CompanyName ProductName (OperatingSystem) Version (Date)'
        private string _Encoded_Application_CompanyName;  //Name of the company
        private string _Encoded_Application_Name;  //Name of the product
        private string _Encoded_Application_Version;  //Version of the product
        private string _Encoded_Application_Url;  //Name of the software package used to create the file, such as Microsoft WaveEdit.
        private string _Encoded_Library;  //Software used to create the file
        private string _Encoded_LibraryString;  //Software used to create the file, trying to have the format 'CompanyName ProductName (OperatingSystem) Version (Date)'
        private string _Encoded_Library_CompanyName;  //Name of the company
        private string _Encoded_Library_Name;  //Name of the the encoding-software
        private string _Encoded_Library_Version;  //Version of encoding-software
        private string _Encoded_Library_Date;  //Release date of software
        private string _Encoded_Library_Settings;  //Parameters used by the software
        private string _Encoded_OperatingSystem;  //Operating System of encoding-software
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
        private string _Encoded_Date;  //UTC time that the encoding of this item was completed began.
        private string _Tagged_Date;  //UTC time that the tags were done for this item.
        private string _Encryption;  //
        private string _BufferSize;  //Defines the size of the buffer needed to decode the sequence.
        private string _colour_description_present;  //Presence of colour description
        private string _colour_description_present_Source;  //Presence of colour description (source)
        private string _colour_description_present_Original;  //Presence of colour description (if incoherencies)
        private string _colour_description_present_Original_Source;  //Presence of colour description (source if incoherencies)
        private string _colour_range;  //Colour range for YUV colour space
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
        public string Format { get { if (string.IsNullOrEmpty(this._Format)) { this._Format = ""; } return this._Format; } set { this._Format = value; } }
        public string FormatString { get { if (string.IsNullOrEmpty(this._FormatString)) { this._FormatString = ""; } return this._FormatString; } set { this._FormatString = value; } }
        public string FormatInfo { get { if (string.IsNullOrEmpty(this._FormatInfo)) { this._FormatInfo = ""; } return this._FormatInfo; } set { this._FormatInfo = value; } }
        public string FormatUrl { get { if (string.IsNullOrEmpty(this._FormatUrl)) { this._FormatUrl = ""; } return this._FormatUrl; } set { this._FormatUrl = value; } }
        public string Format_Commercial { get { if (string.IsNullOrEmpty(this._Format_Commercial)) { this._Format_Commercial = ""; } return this._Format_Commercial; } set { this._Format_Commercial = value; } }
        public string Format_Commercial_IfAny { get { if (string.IsNullOrEmpty(this._Format_Commercial_IfAny)) { this._Format_Commercial_IfAny = ""; } return this._Format_Commercial_IfAny; } set { this._Format_Commercial_IfAny = value; } }
        public string Format_Version { get { if (string.IsNullOrEmpty(this._Format_Version)) { this._Format_Version = ""; } return this._Format_Version; } set { this._Format_Version = value; } }
        public string Format_Profile { get { if (string.IsNullOrEmpty(this._Format_Profile)) { this._Format_Profile = ""; } return this._Format_Profile; } set { this._Format_Profile = value; } }
        public string Format_Level { get { if (string.IsNullOrEmpty(this._Format_Level)) { this._Format_Level = ""; } return this._Format_Level; } set { this._Format_Level = value; } }
        public string Format_Tier { get { if (string.IsNullOrEmpty(this._Format_Tier)) { this._Format_Tier = ""; } return this._Format_Tier; } set { this._Format_Tier = value; } }
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_AdditionalFeatures { get { if (string.IsNullOrEmpty(this._Format_AdditionalFeatures)) { this._Format_AdditionalFeatures = ""; } return this._Format_AdditionalFeatures; } set { this._Format_AdditionalFeatures = value; } }
        public string MultiView_BaseProfile { get { if (string.IsNullOrEmpty(this._MultiView_BaseProfile)) { this._MultiView_BaseProfile = ""; } return this._MultiView_BaseProfile; } set { this._MultiView_BaseProfile = value; } }
        public string MultiView_Count { get { if (string.IsNullOrEmpty(this._MultiView_Count)) { this._MultiView_Count = ""; } return this._MultiView_Count; } set { this._MultiView_Count = value; } }
        public string MultiView_Layout { get { if (string.IsNullOrEmpty(this._MultiView_Layout)) { this._MultiView_Layout = ""; } return this._MultiView_Layout; } set { this._MultiView_Layout = value; } }
        public string HDR_Format { get { if (string.IsNullOrEmpty(this._HDR_Format)) { this._HDR_Format = ""; } return this._HDR_Format; } set { this._HDR_Format = value; } }
        public string HDR_FormatString { get { if (string.IsNullOrEmpty(this._HDR_FormatString)) { this._HDR_FormatString = ""; } return this._HDR_FormatString; } set { this._HDR_FormatString = value; } }
        public string HDR_Format_Commercial { get { if (string.IsNullOrEmpty(this._HDR_Format_Commercial)) { this._HDR_Format_Commercial = ""; } return this._HDR_Format_Commercial; } set { this._HDR_Format_Commercial = value; } }
        public string HDR_Format_Version { get { if (string.IsNullOrEmpty(this._HDR_Format_Version)) { this._HDR_Format_Version = ""; } return this._HDR_Format_Version; } set { this._HDR_Format_Version = value; } }
        public string HDR_Format_Profile { get { if (string.IsNullOrEmpty(this._HDR_Format_Profile)) { this._HDR_Format_Profile = ""; } return this._HDR_Format_Profile; } set { this._HDR_Format_Profile = value; } }
        public string HDR_Format_Level { get { if (string.IsNullOrEmpty(this._HDR_Format_Level)) { this._HDR_Format_Level = ""; } return this._HDR_Format_Level; } set { this._HDR_Format_Level = value; } }
        public string HDR_Format_Settings { get { if (string.IsNullOrEmpty(this._HDR_Format_Settings)) { this._HDR_Format_Settings = ""; } return this._HDR_Format_Settings; } set { this._HDR_Format_Settings = value; } }
        public string HDR_Format_Compatibility { get { if (string.IsNullOrEmpty(this._HDR_Format_Compatibility)) { this._HDR_Format_Compatibility = ""; } return this._HDR_Format_Compatibility; } set { this._HDR_Format_Compatibility = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string Format_Settings_BVOP { get { if (string.IsNullOrEmpty(this._Format_Settings_BVOP)) { this._Format_Settings_BVOP = ""; } return this._Format_Settings_BVOP; } set { this._Format_Settings_BVOP = value; } }
        public string Format_Settings_BVOPString { get { if (string.IsNullOrEmpty(this._Format_Settings_BVOPString)) { this._Format_Settings_BVOPString = ""; } return this._Format_Settings_BVOPString; } set { this._Format_Settings_BVOPString = value; } }
        public string Format_Settings_QPel { get { if (string.IsNullOrEmpty(this._Format_Settings_QPel)) { this._Format_Settings_QPel = ""; } return this._Format_Settings_QPel; } set { this._Format_Settings_QPel = value; } }
        public string Format_Settings_QPelString { get { if (string.IsNullOrEmpty(this._Format_Settings_QPelString)) { this._Format_Settings_QPelString = ""; } return this._Format_Settings_QPelString; } set { this._Format_Settings_QPelString = value; } }
        public string Format_Settings_GMC { get { if (string.IsNullOrEmpty(this._Format_Settings_GMC)) { this._Format_Settings_GMC = ""; } return this._Format_Settings_GMC; } set { this._Format_Settings_GMC = value; } }
        public string Format_Settings_GMCString { get { if (string.IsNullOrEmpty(this._Format_Settings_GMCString)) { this._Format_Settings_GMCString = ""; } return this._Format_Settings_GMCString; } set { this._Format_Settings_GMCString = value; } }
        public string Format_Settings_Matrix { get { if (string.IsNullOrEmpty(this._Format_Settings_Matrix)) { this._Format_Settings_Matrix = ""; } return this._Format_Settings_Matrix; } set { this._Format_Settings_Matrix = value; } }
        public string Format_Settings_MatrixString { get { if (string.IsNullOrEmpty(this._Format_Settings_MatrixString)) { this._Format_Settings_MatrixString = ""; } return this._Format_Settings_MatrixString; } set { this._Format_Settings_MatrixString = value; } }
        public string Format_Settings_Matrix_Data { get { if (string.IsNullOrEmpty(this._Format_Settings_Matrix_Data)) { this._Format_Settings_Matrix_Data = ""; } return this._Format_Settings_Matrix_Data; } set { this._Format_Settings_Matrix_Data = value; } }
        public string Format_Settings_CABAC { get { if (string.IsNullOrEmpty(this._Format_Settings_CABAC)) { this._Format_Settings_CABAC = ""; } return this._Format_Settings_CABAC; } set { this._Format_Settings_CABAC = value; } }
        public string Format_Settings_CABACString { get { if (string.IsNullOrEmpty(this._Format_Settings_CABACString)) { this._Format_Settings_CABACString = ""; } return this._Format_Settings_CABACString; } set { this._Format_Settings_CABACString = value; } }
        public string Format_Settings_RefFrames { get { if (string.IsNullOrEmpty(this._Format_Settings_RefFrames)) { this._Format_Settings_RefFrames = ""; } return this._Format_Settings_RefFrames; } set { this._Format_Settings_RefFrames = value; } }
        public string Format_Settings_RefFramesString { get { if (string.IsNullOrEmpty(this._Format_Settings_RefFramesString)) { this._Format_Settings_RefFramesString = ""; } return this._Format_Settings_RefFramesString; } set { this._Format_Settings_RefFramesString = value; } }
        public string Format_Settings_Pulldown { get { if (string.IsNullOrEmpty(this._Format_Settings_Pulldown)) { this._Format_Settings_Pulldown = ""; } return this._Format_Settings_Pulldown; } set { this._Format_Settings_Pulldown = value; } }
        public string Format_Settings_Endianness { get { if (string.IsNullOrEmpty(this._Format_Settings_Endianness)) { this._Format_Settings_Endianness = ""; } return this._Format_Settings_Endianness; } set { this._Format_Settings_Endianness = value; } }
        public string Format_Settings_Packing { get { if (string.IsNullOrEmpty(this._Format_Settings_Packing)) { this._Format_Settings_Packing = ""; } return this._Format_Settings_Packing; } set { this._Format_Settings_Packing = value; } }
        public string Format_Settings_FrameMode { get { if (string.IsNullOrEmpty(this._Format_Settings_FrameMode)) { this._Format_Settings_FrameMode = ""; } return this._Format_Settings_FrameMode; } set { this._Format_Settings_FrameMode = value; } }
        public string Format_Settings_GOP { get { if (string.IsNullOrEmpty(this._Format_Settings_GOP)) { this._Format_Settings_GOP = ""; } return this._Format_Settings_GOP; } set { this._Format_Settings_GOP = value; } }
        public string Format_Settings_PictureStructure { get { if (string.IsNullOrEmpty(this._Format_Settings_PictureStructure)) { this._Format_Settings_PictureStructure = ""; } return this._Format_Settings_PictureStructure; } set { this._Format_Settings_PictureStructure = value; } }
        public string Format_Settings_Wrapping { get { if (string.IsNullOrEmpty(this._Format_Settings_Wrapping)) { this._Format_Settings_Wrapping = ""; } return this._Format_Settings_Wrapping; } set { this._Format_Settings_Wrapping = value; } }
        public string InternetMediaType { get { if (string.IsNullOrEmpty(this._InternetMediaType)) { this._InternetMediaType = ""; } return this._InternetMediaType; } set { this._InternetMediaType = value; } }
        public string MuxingMode { get { if (string.IsNullOrEmpty(this._MuxingMode)) { this._MuxingMode = ""; } return this._MuxingMode; } set { this._MuxingMode = value; } }
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
        public string CodecCC { get { if (string.IsNullOrEmpty(this._CodecCC)) { this._CodecCC = ""; } return this._CodecCC; } set { this._CodecCC = value; } }
        public string Codec_Profile { get { if (string.IsNullOrEmpty(this._Codec_Profile)) { this._Codec_Profile = ""; } return this._Codec_Profile; } set { this._Codec_Profile = value; } }
        public string Codec_Description { get { if (string.IsNullOrEmpty(this._Codec_Description)) { this._Codec_Description = ""; } return this._Codec_Description; } set { this._Codec_Description = value; } }
        public string Codec_Settings { get { if (string.IsNullOrEmpty(this._Codec_Settings)) { this._Codec_Settings = ""; } return this._Codec_Settings; } set { this._Codec_Settings = value; } }
        public string Codec_Settings_PacketBitStream { get { if (string.IsNullOrEmpty(this._Codec_Settings_PacketBitStream)) { this._Codec_Settings_PacketBitStream = ""; } return this._Codec_Settings_PacketBitStream; } set { this._Codec_Settings_PacketBitStream = value; } }
        public string Codec_Settings_BVOP { get { if (string.IsNullOrEmpty(this._Codec_Settings_BVOP)) { this._Codec_Settings_BVOP = ""; } return this._Codec_Settings_BVOP; } set { this._Codec_Settings_BVOP = value; } }
        public string Codec_Settings_QPel { get { if (string.IsNullOrEmpty(this._Codec_Settings_QPel)) { this._Codec_Settings_QPel = ""; } return this._Codec_Settings_QPel; } set { this._Codec_Settings_QPel = value; } }
        public string Codec_Settings_GMC { get { if (string.IsNullOrEmpty(this._Codec_Settings_GMC)) { this._Codec_Settings_GMC = ""; } return this._Codec_Settings_GMC; } set { this._Codec_Settings_GMC = value; } }
        public string Codec_Settings_GMCString { get { if (string.IsNullOrEmpty(this._Codec_Settings_GMCString)) { this._Codec_Settings_GMCString = ""; } return this._Codec_Settings_GMCString; } set { this._Codec_Settings_GMCString = value; } }
        public string Codec_Settings_Matrix { get { if (string.IsNullOrEmpty(this._Codec_Settings_Matrix)) { this._Codec_Settings_Matrix = ""; } return this._Codec_Settings_Matrix; } set { this._Codec_Settings_Matrix = value; } }
        public string Codec_Settings_Matrix_Data { get { if (string.IsNullOrEmpty(this._Codec_Settings_Matrix_Data)) { this._Codec_Settings_Matrix_Data = ""; } return this._Codec_Settings_Matrix_Data; } set { this._Codec_Settings_Matrix_Data = value; } }
        public string Codec_Settings_CABAC { get { if (string.IsNullOrEmpty(this._Codec_Settings_CABAC)) { this._Codec_Settings_CABAC = ""; } return this._Codec_Settings_CABAC; } set { this._Codec_Settings_CABAC = value; } }
        public string Codec_Settings_RefFrames { get { if (string.IsNullOrEmpty(this._Codec_Settings_RefFrames)) { this._Codec_Settings_RefFrames = ""; } return this._Codec_Settings_RefFrames; } set { this._Codec_Settings_RefFrames = value; } }
        public string Duration { get { if (string.IsNullOrEmpty(this._Duration)) { this._Duration = ""; } return this._Duration; } set { this._Duration = value; } }
        public string DurationString { get { if (string.IsNullOrEmpty(this._DurationString)) { this._DurationString = ""; } return this._DurationString; } set { this._DurationString = value; } }
        public string DurationString1 { get { if (string.IsNullOrEmpty(this._DurationString1)) { this._DurationString1 = ""; } return this._DurationString1; } set { this._DurationString1 = value; } }
        public string DurationString2 { get { if (string.IsNullOrEmpty(this._DurationString2)) { this._DurationString2 = ""; } return this._DurationString2; } set { this._DurationString2 = value; } }
        public string DurationString3 { get { if (string.IsNullOrEmpty(this._DurationString3)) { this._DurationString3 = ""; } return this._DurationString3; } set { this._DurationString3 = value; } }
        public string DurationString4 { get { if (string.IsNullOrEmpty(this._DurationString4)) { this._DurationString4 = ""; } return this._DurationString4; } set { this._DurationString4 = value; } }
        public string DurationString5 { get { if (string.IsNullOrEmpty(this._DurationString5)) { this._DurationString5 = ""; } return this._DurationString5; } set { this._DurationString5 = value; } }
        public string Duration_FirstFrame { get { if (string.IsNullOrEmpty(this._Duration_FirstFrame)) { this._Duration_FirstFrame = ""; } return this._Duration_FirstFrame; } set { this._Duration_FirstFrame = value; } }
        public string Duration_FirstFrameString { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString)) { this._Duration_FirstFrameString = ""; } return this._Duration_FirstFrameString; } set { this._Duration_FirstFrameString = value; } }
        public string Duration_FirstFrameString1 { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString1)) { this._Duration_FirstFrameString1 = ""; } return this._Duration_FirstFrameString1; } set { this._Duration_FirstFrameString1 = value; } }
        public string Duration_FirstFrameString2 { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString2)) { this._Duration_FirstFrameString2 = ""; } return this._Duration_FirstFrameString2; } set { this._Duration_FirstFrameString2 = value; } }
        public string Duration_FirstFrameString3 { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString3)) { this._Duration_FirstFrameString3 = ""; } return this._Duration_FirstFrameString3; } set { this._Duration_FirstFrameString3 = value; } }
        public string Duration_FirstFrameString4 { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString4)) { this._Duration_FirstFrameString4 = ""; } return this._Duration_FirstFrameString4; } set { this._Duration_FirstFrameString4 = value; } }
        public string Duration_FirstFrameString5 { get { if (string.IsNullOrEmpty(this._Duration_FirstFrameString5)) { this._Duration_FirstFrameString5 = ""; } return this._Duration_FirstFrameString5; } set { this._Duration_FirstFrameString5 = value; } }
        public string Duration_LastFrame { get { if (string.IsNullOrEmpty(this._Duration_LastFrame)) { this._Duration_LastFrame = ""; } return this._Duration_LastFrame; } set { this._Duration_LastFrame = value; } }
        public string Duration_LastFrameString { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString)) { this._Duration_LastFrameString = ""; } return this._Duration_LastFrameString; } set { this._Duration_LastFrameString = value; } }
        public string Duration_LastFrameString1 { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString1)) { this._Duration_LastFrameString1 = ""; } return this._Duration_LastFrameString1; } set { this._Duration_LastFrameString1 = value; } }
        public string Duration_LastFrameString2 { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString2)) { this._Duration_LastFrameString2 = ""; } return this._Duration_LastFrameString2; } set { this._Duration_LastFrameString2 = value; } }
        public string Duration_LastFrameString3 { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString3)) { this._Duration_LastFrameString3 = ""; } return this._Duration_LastFrameString3; } set { this._Duration_LastFrameString3 = value; } }
        public string Duration_LastFrameString4 { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString4)) { this._Duration_LastFrameString4 = ""; } return this._Duration_LastFrameString4; } set { this._Duration_LastFrameString4 = value; } }
        public string Duration_LastFrameString5 { get { if (string.IsNullOrEmpty(this._Duration_LastFrameString5)) { this._Duration_LastFrameString5 = ""; } return this._Duration_LastFrameString5; } set { this._Duration_LastFrameString5 = value; } }
        public string Source_Duration { get { if (string.IsNullOrEmpty(this._Source_Duration)) { this._Source_Duration = ""; } return this._Source_Duration; } set { this._Source_Duration = value; } }
        public string Source_DurationString { get { if (string.IsNullOrEmpty(this._Source_DurationString)) { this._Source_DurationString = ""; } return this._Source_DurationString; } set { this._Source_DurationString = value; } }
        public string Source_DurationString1 { get { if (string.IsNullOrEmpty(this._Source_DurationString1)) { this._Source_DurationString1 = ""; } return this._Source_DurationString1; } set { this._Source_DurationString1 = value; } }
        public string Source_DurationString2 { get { if (string.IsNullOrEmpty(this._Source_DurationString2)) { this._Source_DurationString2 = ""; } return this._Source_DurationString2; } set { this._Source_DurationString2 = value; } }
        public string Source_DurationString3 { get { if (string.IsNullOrEmpty(this._Source_DurationString3)) { this._Source_DurationString3 = ""; } return this._Source_DurationString3; } set { this._Source_DurationString3 = value; } }
        public string Source_DurationString4 { get { if (string.IsNullOrEmpty(this._Source_DurationString4)) { this._Source_DurationString4 = ""; } return this._Source_DurationString4; } set { this._Source_DurationString4 = value; } }
        public string Source_DurationString5 { get { if (string.IsNullOrEmpty(this._Source_DurationString5)) { this._Source_DurationString5 = ""; } return this._Source_DurationString5; } set { this._Source_DurationString5 = value; } }
        public string Source_Duration_FirstFrame { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrame)) { this._Source_Duration_FirstFrame = ""; } return this._Source_Duration_FirstFrame; } set { this._Source_Duration_FirstFrame = value; } }
        public string Source_Duration_FirstFrameString { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString)) { this._Source_Duration_FirstFrameString = ""; } return this._Source_Duration_FirstFrameString; } set { this._Source_Duration_FirstFrameString = value; } }
        public string Source_Duration_FirstFrameString1 { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString1)) { this._Source_Duration_FirstFrameString1 = ""; } return this._Source_Duration_FirstFrameString1; } set { this._Source_Duration_FirstFrameString1 = value; } }
        public string Source_Duration_FirstFrameString2 { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString2)) { this._Source_Duration_FirstFrameString2 = ""; } return this._Source_Duration_FirstFrameString2; } set { this._Source_Duration_FirstFrameString2 = value; } }
        public string Source_Duration_FirstFrameString3 { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString3)) { this._Source_Duration_FirstFrameString3 = ""; } return this._Source_Duration_FirstFrameString3; } set { this._Source_Duration_FirstFrameString3 = value; } }
        public string Source_Duration_FirstFrameString4 { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString4)) { this._Source_Duration_FirstFrameString4 = ""; } return this._Source_Duration_FirstFrameString4; } set { this._Source_Duration_FirstFrameString4 = value; } }
        public string Source_Duration_FirstFrameString5 { get { if (string.IsNullOrEmpty(this._Source_Duration_FirstFrameString5)) { this._Source_Duration_FirstFrameString5 = ""; } return this._Source_Duration_FirstFrameString5; } set { this._Source_Duration_FirstFrameString5 = value; } }
        public string Source_Duration_LastFrame { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrame)) { this._Source_Duration_LastFrame = ""; } return this._Source_Duration_LastFrame; } set { this._Source_Duration_LastFrame = value; } }
        public string Source_Duration_LastFrameString { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString)) { this._Source_Duration_LastFrameString = ""; } return this._Source_Duration_LastFrameString; } set { this._Source_Duration_LastFrameString = value; } }
        public string Source_Duration_LastFrameString1 { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString1)) { this._Source_Duration_LastFrameString1 = ""; } return this._Source_Duration_LastFrameString1; } set { this._Source_Duration_LastFrameString1 = value; } }
        public string Source_Duration_LastFrameString2 { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString2)) { this._Source_Duration_LastFrameString2 = ""; } return this._Source_Duration_LastFrameString2; } set { this._Source_Duration_LastFrameString2 = value; } }
        public string Source_Duration_LastFrameString3 { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString3)) { this._Source_Duration_LastFrameString3 = ""; } return this._Source_Duration_LastFrameString3; } set { this._Source_Duration_LastFrameString3 = value; } }
        public string Source_Duration_LastFrameString4 { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString4)) { this._Source_Duration_LastFrameString4 = ""; } return this._Source_Duration_LastFrameString4; } set { this._Source_Duration_LastFrameString4 = value; } }
        public string Source_Duration_LastFrameString5 { get { if (string.IsNullOrEmpty(this._Source_Duration_LastFrameString5)) { this._Source_Duration_LastFrameString5 = ""; } return this._Source_Duration_LastFrameString5; } set { this._Source_Duration_LastFrameString5 = value; } }
        public string BitRate_Mode { get { if (string.IsNullOrEmpty(this._BitRate_Mode)) { this._BitRate_Mode = ""; } return this._BitRate_Mode; } set { this._BitRate_Mode = value; } }
        public string BitRate_ModeString { get { if (string.IsNullOrEmpty(this._BitRate_ModeString)) { this._BitRate_ModeString = ""; } return this._BitRate_ModeString; } set { this._BitRate_ModeString = value; } }
        public string BitRate { get { if (string.IsNullOrEmpty(this._BitRate)) { this._BitRate = ""; } return this._BitRate; } set { this._BitRate = value; } }
        public string BitRateString { get { if (string.IsNullOrEmpty(this._BitRateString)) { this._BitRateString = ""; } return this._BitRateString; } set { this._BitRateString = value; } }
        public string BitRate_Minimum { get { if (string.IsNullOrEmpty(this._BitRate_Minimum)) { this._BitRate_Minimum = ""; } return this._BitRate_Minimum; } set { this._BitRate_Minimum = value; } }
        public string BitRate_MinimumString { get { if (string.IsNullOrEmpty(this._BitRate_MinimumString)) { this._BitRate_MinimumString = ""; } return this._BitRate_MinimumString; } set { this._BitRate_MinimumString = value; } }
        public string BitRate_Nominal { get { if (string.IsNullOrEmpty(this._BitRate_Nominal)) { this._BitRate_Nominal = ""; } return this._BitRate_Nominal; } set { this._BitRate_Nominal = value; } }
        public string BitRate_NominalString { get { if (string.IsNullOrEmpty(this._BitRate_NominalString)) { this._BitRate_NominalString = ""; } return this._BitRate_NominalString; } set { this._BitRate_NominalString = value; } }
        public string BitRate_Maximum { get { if (string.IsNullOrEmpty(this._BitRate_Maximum)) { this._BitRate_Maximum = ""; } return this._BitRate_Maximum; } set { this._BitRate_Maximum = value; } }
        public string BitRate_MaximumString { get { if (string.IsNullOrEmpty(this._BitRate_MaximumString)) { this._BitRate_MaximumString = ""; } return this._BitRate_MaximumString; } set { this._BitRate_MaximumString = value; } }
        public string BitRate_Encoded { get { if (string.IsNullOrEmpty(this._BitRate_Encoded)) { this._BitRate_Encoded = ""; } return this._BitRate_Encoded; } set { this._BitRate_Encoded = value; } }
        public string BitRate_EncodedString { get { if (string.IsNullOrEmpty(this._BitRate_EncodedString)) { this._BitRate_EncodedString = ""; } return this._BitRate_EncodedString; } set { this._BitRate_EncodedString = value; } }
        public string Width { get { if (string.IsNullOrEmpty(this._Width)) { this._Width = ""; } return this._Width; } set { this._Width = value; } }
        public string WidthString { get { if (string.IsNullOrEmpty(this._WidthString)) { this._WidthString = ""; } return this._WidthString; } set { this._WidthString = value; } }
        public string Width_Offset { get { if (string.IsNullOrEmpty(this._Width_Offset)) { this._Width_Offset = ""; } return this._Width_Offset; } set { this._Width_Offset = value; } }
        public string Width_OffsetString { get { if (string.IsNullOrEmpty(this._Width_OffsetString)) { this._Width_OffsetString = ""; } return this._Width_OffsetString; } set { this._Width_OffsetString = value; } }
        public string Width_Original { get { if (string.IsNullOrEmpty(this._Width_Original)) { this._Width_Original = ""; } return this._Width_Original; } set { this._Width_Original = value; } }
        public string Width_OriginalString { get { if (string.IsNullOrEmpty(this._Width_OriginalString)) { this._Width_OriginalString = ""; } return this._Width_OriginalString; } set { this._Width_OriginalString = value; } }
        public string Width_CleanAperture { get { if (string.IsNullOrEmpty(this._Width_CleanAperture)) { this._Width_CleanAperture = ""; } return this._Width_CleanAperture; } set { this._Width_CleanAperture = value; } }
        public string Width_CleanApertureString { get { if (string.IsNullOrEmpty(this._Width_CleanApertureString)) { this._Width_CleanApertureString = ""; } return this._Width_CleanApertureString; } set { this._Width_CleanApertureString = value; } }
        public string Height { get { if (string.IsNullOrEmpty(this._Height)) { this._Height = ""; } return this._Height; } set { this._Height = value; } }
        public string HeightString { get { if (string.IsNullOrEmpty(this._HeightString)) { this._HeightString = ""; } return this._HeightString; } set { this._HeightString = value; } }
        public string Height_Offset { get { if (string.IsNullOrEmpty(this._Height_Offset)) { this._Height_Offset = ""; } return this._Height_Offset; } set { this._Height_Offset = value; } }
        public string Height_OffsetString { get { if (string.IsNullOrEmpty(this._Height_OffsetString)) { this._Height_OffsetString = ""; } return this._Height_OffsetString; } set { this._Height_OffsetString = value; } }
        public string Height_Original { get { if (string.IsNullOrEmpty(this._Height_Original)) { this._Height_Original = ""; } return this._Height_Original; } set { this._Height_Original = value; } }
        public string Height_OriginalString { get { if (string.IsNullOrEmpty(this._Height_OriginalString)) { this._Height_OriginalString = ""; } return this._Height_OriginalString; } set { this._Height_OriginalString = value; } }
        public string Height_CleanAperture { get { if (string.IsNullOrEmpty(this._Height_CleanAperture)) { this._Height_CleanAperture = ""; } return this._Height_CleanAperture; } set { this._Height_CleanAperture = value; } }
        public string Height_CleanApertureString { get { if (string.IsNullOrEmpty(this._Height_CleanApertureString)) { this._Height_CleanApertureString = ""; } return this._Height_CleanApertureString; } set { this._Height_CleanApertureString = value; } }
        public string Stored_Width { get { if (string.IsNullOrEmpty(this._Stored_Width)) { this._Stored_Width = ""; } return this._Stored_Width; } set { this._Stored_Width = value; } }
        public string Stored_Height { get { if (string.IsNullOrEmpty(this._Stored_Height)) { this._Stored_Height = ""; } return this._Stored_Height; } set { this._Stored_Height = value; } }
        public string Sampled_Width { get { if (string.IsNullOrEmpty(this._Sampled_Width)) { this._Sampled_Width = ""; } return this._Sampled_Width; } set { this._Sampled_Width = value; } }
        public string Sampled_Height { get { if (string.IsNullOrEmpty(this._Sampled_Height)) { this._Sampled_Height = ""; } return this._Sampled_Height; } set { this._Sampled_Height = value; } }
        public string PixelAspectRatio { get { if (string.IsNullOrEmpty(this._PixelAspectRatio)) { this._PixelAspectRatio = ""; } return this._PixelAspectRatio; } set { this._PixelAspectRatio = value; } }
        public string PixelAspectRatioString { get { if (string.IsNullOrEmpty(this._PixelAspectRatioString)) { this._PixelAspectRatioString = ""; } return this._PixelAspectRatioString; } set { this._PixelAspectRatioString = value; } }
        public string PixelAspectRatio_Original { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_Original)) { this._PixelAspectRatio_Original = ""; } return this._PixelAspectRatio_Original; } set { this._PixelAspectRatio_Original = value; } }
        public string PixelAspectRatio_OriginalString { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_OriginalString)) { this._PixelAspectRatio_OriginalString = ""; } return this._PixelAspectRatio_OriginalString; } set { this._PixelAspectRatio_OriginalString = value; } }
        public string PixelAspectRatio_CleanAperture { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_CleanAperture)) { this._PixelAspectRatio_CleanAperture = ""; } return this._PixelAspectRatio_CleanAperture; } set { this._PixelAspectRatio_CleanAperture = value; } }
        public string PixelAspectRatio_CleanApertureString { get { if (string.IsNullOrEmpty(this._PixelAspectRatio_CleanApertureString)) { this._PixelAspectRatio_CleanApertureString = ""; } return this._PixelAspectRatio_CleanApertureString; } set { this._PixelAspectRatio_CleanApertureString = value; } }
        public string DisplayAspectRatio { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio)) { this._DisplayAspectRatio = ""; } return this._DisplayAspectRatio; } set { this._DisplayAspectRatio = value; } }
        public string DisplayAspectRatioString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatioString)) { this._DisplayAspectRatioString = ""; } return this._DisplayAspectRatioString; } set { this._DisplayAspectRatioString = value; } }
        public string DisplayAspectRatio_Original { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_Original)) { this._DisplayAspectRatio_Original = ""; } return this._DisplayAspectRatio_Original; } set { this._DisplayAspectRatio_Original = value; } }
        public string DisplayAspectRatio_OriginalString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_OriginalString)) { this._DisplayAspectRatio_OriginalString = ""; } return this._DisplayAspectRatio_OriginalString; } set { this._DisplayAspectRatio_OriginalString = value; } }
        public string DisplayAspectRatio_CleanAperture { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_CleanAperture)) { this._DisplayAspectRatio_CleanAperture = ""; } return this._DisplayAspectRatio_CleanAperture; } set { this._DisplayAspectRatio_CleanAperture = value; } }
        public string DisplayAspectRatio_CleanApertureString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_CleanApertureString)) { this._DisplayAspectRatio_CleanApertureString = ""; } return this._DisplayAspectRatio_CleanApertureString; } set { this._DisplayAspectRatio_CleanApertureString = value; } }
        public string ActiveFormatDescription { get { if (string.IsNullOrEmpty(this._ActiveFormatDescription)) { this._ActiveFormatDescription = ""; } return this._ActiveFormatDescription; } set { this._ActiveFormatDescription = value; } }
        public string ActiveFormatDescriptionString { get { if (string.IsNullOrEmpty(this._ActiveFormatDescriptionString)) { this._ActiveFormatDescriptionString = ""; } return this._ActiveFormatDescriptionString; } set { this._ActiveFormatDescriptionString = value; } }
        public string ActiveFormatDescription_MuxingMode { get { if (string.IsNullOrEmpty(this._ActiveFormatDescription_MuxingMode)) { this._ActiveFormatDescription_MuxingMode = ""; } return this._ActiveFormatDescription_MuxingMode; } set { this._ActiveFormatDescription_MuxingMode = value; } }
        public string Rotation { get { if (string.IsNullOrEmpty(this._Rotation)) { this._Rotation = ""; } return this._Rotation; } set { this._Rotation = value; } }
        public string RotationString { get { if (string.IsNullOrEmpty(this._RotationString)) { this._RotationString = ""; } return this._RotationString; } set { this._RotationString = value; } }
        public string FrameRate_Mode { get { if (string.IsNullOrEmpty(this._FrameRate_Mode)) { this._FrameRate_Mode = ""; } return this._FrameRate_Mode; } set { this._FrameRate_Mode = value; } }
        public string FrameRate_ModeString { get { if (string.IsNullOrEmpty(this._FrameRate_ModeString)) { this._FrameRate_ModeString = ""; } return this._FrameRate_ModeString; } set { this._FrameRate_ModeString = value; } }
        public string FrameRate_Mode_Original { get { if (string.IsNullOrEmpty(this._FrameRate_Mode_Original)) { this._FrameRate_Mode_Original = ""; } return this._FrameRate_Mode_Original; } set { this._FrameRate_Mode_Original = value; } }
        public string FrameRate_Mode_OriginalString { get { if (string.IsNullOrEmpty(this._FrameRate_Mode_OriginalString)) { this._FrameRate_Mode_OriginalString = ""; } return this._FrameRate_Mode_OriginalString; } set { this._FrameRate_Mode_OriginalString = value; } }
        public string FrameRate { get { if (string.IsNullOrEmpty(this._FrameRate)) { this._FrameRate = ""; } return this._FrameRate; } set { this._FrameRate = value; } }
        public string FrameRateString { get { if (string.IsNullOrEmpty(this._FrameRateString)) { this._FrameRateString = ""; } return this._FrameRateString; } set { this._FrameRateString = value; } }
        public string FrameRate_Num { get { if (string.IsNullOrEmpty(this._FrameRate_Num)) { this._FrameRate_Num = ""; } return this._FrameRate_Num; } set { this._FrameRate_Num = value; } }
        public string FrameRate_Den { get { if (string.IsNullOrEmpty(this._FrameRate_Den)) { this._FrameRate_Den = ""; } return this._FrameRate_Den; } set { this._FrameRate_Den = value; } }
        public string FrameRate_Minimum { get { if (string.IsNullOrEmpty(this._FrameRate_Minimum)) { this._FrameRate_Minimum = ""; } return this._FrameRate_Minimum; } set { this._FrameRate_Minimum = value; } }
        public string FrameRate_MinimumString { get { if (string.IsNullOrEmpty(this._FrameRate_MinimumString)) { this._FrameRate_MinimumString = ""; } return this._FrameRate_MinimumString; } set { this._FrameRate_MinimumString = value; } }
        public string FrameRate_Nominal { get { if (string.IsNullOrEmpty(this._FrameRate_Nominal)) { this._FrameRate_Nominal = ""; } return this._FrameRate_Nominal; } set { this._FrameRate_Nominal = value; } }
        public string FrameRate_NominalString { get { if (string.IsNullOrEmpty(this._FrameRate_NominalString)) { this._FrameRate_NominalString = ""; } return this._FrameRate_NominalString; } set { this._FrameRate_NominalString = value; } }
        public string FrameRate_Maximum { get { if (string.IsNullOrEmpty(this._FrameRate_Maximum)) { this._FrameRate_Maximum = ""; } return this._FrameRate_Maximum; } set { this._FrameRate_Maximum = value; } }
        public string FrameRate_MaximumString { get { if (string.IsNullOrEmpty(this._FrameRate_MaximumString)) { this._FrameRate_MaximumString = ""; } return this._FrameRate_MaximumString; } set { this._FrameRate_MaximumString = value; } }
        public string FrameRate_Original { get { if (string.IsNullOrEmpty(this._FrameRate_Original)) { this._FrameRate_Original = ""; } return this._FrameRate_Original; } set { this._FrameRate_Original = value; } }
        public string FrameRate_OriginalString { get { if (string.IsNullOrEmpty(this._FrameRate_OriginalString)) { this._FrameRate_OriginalString = ""; } return this._FrameRate_OriginalString; } set { this._FrameRate_OriginalString = value; } }
        public string FrameRate_Original_Num { get { if (string.IsNullOrEmpty(this._FrameRate_Original_Num)) { this._FrameRate_Original_Num = ""; } return this._FrameRate_Original_Num; } set { this._FrameRate_Original_Num = value; } }
        public string FrameRate_Original_Den { get { if (string.IsNullOrEmpty(this._FrameRate_Original_Den)) { this._FrameRate_Original_Den = ""; } return this._FrameRate_Original_Den; } set { this._FrameRate_Original_Den = value; } }
        public string FrameCount { get { if (string.IsNullOrEmpty(this._FrameCount)) { this._FrameCount = ""; } return this._FrameCount; } set { this._FrameCount = value; } }
        public string Source_FrameCount { get { if (string.IsNullOrEmpty(this._Source_FrameCount)) { this._Source_FrameCount = ""; } return this._Source_FrameCount; } set { this._Source_FrameCount = value; } }
        public string Standard { get { if (string.IsNullOrEmpty(this._Standard)) { this._Standard = ""; } return this._Standard; } set { this._Standard = value; } }
        public string Resolution { get { if (string.IsNullOrEmpty(this._Resolution)) { this._Resolution = ""; } return this._Resolution; } set { this._Resolution = value; } }
        public string ResolutionString { get { if (string.IsNullOrEmpty(this._ResolutionString)) { this._ResolutionString = ""; } return this._ResolutionString; } set { this._ResolutionString = value; } }
        public string Colorimetry { get { if (string.IsNullOrEmpty(this._Colorimetry)) { this._Colorimetry = ""; } return this._Colorimetry; } set { this._Colorimetry = value; } }
        public string ColorSpace { get { if (string.IsNullOrEmpty(this._ColorSpace)) { this._ColorSpace = ""; } return this._ColorSpace; } set { this._ColorSpace = value; } }
        public string ChromaSubsampling { get { if (string.IsNullOrEmpty(this._ChromaSubsampling)) { this._ChromaSubsampling = ""; } return this._ChromaSubsampling; } set { this._ChromaSubsampling = value; } }
        public string ChromaSubsamplingString { get { if (string.IsNullOrEmpty(this._ChromaSubsamplingString)) { this._ChromaSubsamplingString = ""; } return this._ChromaSubsamplingString; } set { this._ChromaSubsamplingString = value; } }
        public string ChromaSubsampling_Position { get { if (string.IsNullOrEmpty(this._ChromaSubsampling_Position)) { this._ChromaSubsampling_Position = ""; } return this._ChromaSubsampling_Position; } set { this._ChromaSubsampling_Position = value; } }
        public string BitDepth { get { if (string.IsNullOrEmpty(this._BitDepth)) { this._BitDepth = ""; } return this._BitDepth; } set { this._BitDepth = value; } }
        public string BitDepthString { get { if (string.IsNullOrEmpty(this._BitDepthString)) { this._BitDepthString = ""; } return this._BitDepthString; } set { this._BitDepthString = value; } }
        public string ScanType { get { if (string.IsNullOrEmpty(this._ScanType)) { this._ScanType = ""; } return this._ScanType; } set { this._ScanType = value; } }
        public string ScanTypeString { get { if (string.IsNullOrEmpty(this._ScanTypeString)) { this._ScanTypeString = ""; } return this._ScanTypeString; } set { this._ScanTypeString = value; } }
        public string ScanType_Original { get { if (string.IsNullOrEmpty(this._ScanType_Original)) { this._ScanType_Original = ""; } return this._ScanType_Original; } set { this._ScanType_Original = value; } }
        public string ScanType_OriginalString { get { if (string.IsNullOrEmpty(this._ScanType_OriginalString)) { this._ScanType_OriginalString = ""; } return this._ScanType_OriginalString; } set { this._ScanType_OriginalString = value; } }
        public string ScanType_StoreMethod { get { if (string.IsNullOrEmpty(this._ScanType_StoreMethod)) { this._ScanType_StoreMethod = ""; } return this._ScanType_StoreMethod; } set { this._ScanType_StoreMethod = value; } }
        public string ScanType_StoreMethod_FieldsPerBlock { get { if (string.IsNullOrEmpty(this._ScanType_StoreMethod_FieldsPerBlock)) { this._ScanType_StoreMethod_FieldsPerBlock = ""; } return this._ScanType_StoreMethod_FieldsPerBlock; } set { this._ScanType_StoreMethod_FieldsPerBlock = value; } }
        public string ScanType_StoreMethodString { get { if (string.IsNullOrEmpty(this._ScanType_StoreMethodString)) { this._ScanType_StoreMethodString = ""; } return this._ScanType_StoreMethodString; } set { this._ScanType_StoreMethodString = value; } }
        public string ScanOrder { get { if (string.IsNullOrEmpty(this._ScanOrder)) { this._ScanOrder = ""; } return this._ScanOrder; } set { this._ScanOrder = value; } }
        public string ScanOrderString { get { if (string.IsNullOrEmpty(this._ScanOrderString)) { this._ScanOrderString = ""; } return this._ScanOrderString; } set { this._ScanOrderString = value; } }
        public string ScanOrder_Stored { get { if (string.IsNullOrEmpty(this._ScanOrder_Stored)) { this._ScanOrder_Stored = ""; } return this._ScanOrder_Stored; } set { this._ScanOrder_Stored = value; } }
        public string ScanOrder_StoredString { get { if (string.IsNullOrEmpty(this._ScanOrder_StoredString)) { this._ScanOrder_StoredString = ""; } return this._ScanOrder_StoredString; } set { this._ScanOrder_StoredString = value; } }
        public string ScanOrder_StoredDisplayedInverted { get { if (string.IsNullOrEmpty(this._ScanOrder_StoredDisplayedInverted)) { this._ScanOrder_StoredDisplayedInverted = ""; } return this._ScanOrder_StoredDisplayedInverted; } set { this._ScanOrder_StoredDisplayedInverted = value; } }
        public string ScanOrder_Original { get { if (string.IsNullOrEmpty(this._ScanOrder_Original)) { this._ScanOrder_Original = ""; } return this._ScanOrder_Original; } set { this._ScanOrder_Original = value; } }
        public string ScanOrder_OriginalString { get { if (string.IsNullOrEmpty(this._ScanOrder_OriginalString)) { this._ScanOrder_OriginalString = ""; } return this._ScanOrder_OriginalString; } set { this._ScanOrder_OriginalString = value; } }
        public string Interlacement { get { if (string.IsNullOrEmpty(this._Interlacement)) { this._Interlacement = ""; } return this._Interlacement; } set { this._Interlacement = value; } }
        public string InterlacementString { get { if (string.IsNullOrEmpty(this._InterlacementString)) { this._InterlacementString = ""; } return this._InterlacementString; } set { this._InterlacementString = value; } }
        public string Compression_Mode { get { if (string.IsNullOrEmpty(this._Compression_Mode)) { this._Compression_Mode = ""; } return this._Compression_Mode; } set { this._Compression_Mode = value; } }
        public string Compression_ModeString { get { if (string.IsNullOrEmpty(this._Compression_ModeString)) { this._Compression_ModeString = ""; } return this._Compression_ModeString; } set { this._Compression_ModeString = value; } }
        public string Compression_Ratio { get { if (string.IsNullOrEmpty(this._Compression_Ratio)) { this._Compression_Ratio = ""; } return this._Compression_Ratio; } set { this._Compression_Ratio = value; } }
        public string BitsPixelFrame { get { if (string.IsNullOrEmpty(this._BitsPixelFrame)) { this._BitsPixelFrame = ""; } return this._BitsPixelFrame; } set { this._BitsPixelFrame = value; } }
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
        public string TimeStamp_FirstFrame { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrame)) { this._TimeStamp_FirstFrame = ""; } return this._TimeStamp_FirstFrame; } set { this._TimeStamp_FirstFrame = value; } }
        public string TimeStamp_FirstFrameString { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString)) { this._TimeStamp_FirstFrameString = ""; } return this._TimeStamp_FirstFrameString; } set { this._TimeStamp_FirstFrameString = value; } }
        public string TimeStamp_FirstFrameString1 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString1)) { this._TimeStamp_FirstFrameString1 = ""; } return this._TimeStamp_FirstFrameString1; } set { this._TimeStamp_FirstFrameString1 = value; } }
        public string TimeStamp_FirstFrameString2 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString2)) { this._TimeStamp_FirstFrameString2 = ""; } return this._TimeStamp_FirstFrameString2; } set { this._TimeStamp_FirstFrameString2 = value; } }
        public string TimeStamp_FirstFrameString3 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString3)) { this._TimeStamp_FirstFrameString3 = ""; } return this._TimeStamp_FirstFrameString3; } set { this._TimeStamp_FirstFrameString3 = value; } }
        public string TimeStamp_FirstFrameString4 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString4)) { this._TimeStamp_FirstFrameString4 = ""; } return this._TimeStamp_FirstFrameString4; } set { this._TimeStamp_FirstFrameString4 = value; } }
        public string TimeStamp_FirstFrameString5 { get { if (string.IsNullOrEmpty(this._TimeStamp_FirstFrameString5)) { this._TimeStamp_FirstFrameString5 = ""; } return this._TimeStamp_FirstFrameString5; } set { this._TimeStamp_FirstFrameString5 = value; } }
        public string TimeCode_FirstFrame { get { if (string.IsNullOrEmpty(this._TimeCode_FirstFrame)) { this._TimeCode_FirstFrame = ""; } return this._TimeCode_FirstFrame; } set { this._TimeCode_FirstFrame = value; } }
        public string TimeCode_Settings { get { if (string.IsNullOrEmpty(this._TimeCode_Settings)) { this._TimeCode_Settings = ""; } return this._TimeCode_Settings; } set { this._TimeCode_Settings = value; } }
        public string TimeCode_Source { get { if (string.IsNullOrEmpty(this._TimeCode_Source)) { this._TimeCode_Source = ""; } return this._TimeCode_Source; } set { this._TimeCode_Source = value; } }
        public string Gop_OpenClosed { get { if (string.IsNullOrEmpty(this._Gop_OpenClosed)) { this._Gop_OpenClosed = ""; } return this._Gop_OpenClosed; } set { this._Gop_OpenClosed = value; } }
        public string Gop_OpenClosedString { get { if (string.IsNullOrEmpty(this._Gop_OpenClosedString)) { this._Gop_OpenClosedString = ""; } return this._Gop_OpenClosedString; } set { this._Gop_OpenClosedString = value; } }
        public string Gop_OpenClosed_FirstFrame { get { if (string.IsNullOrEmpty(this._Gop_OpenClosed_FirstFrame)) { this._Gop_OpenClosed_FirstFrame = ""; } return this._Gop_OpenClosed_FirstFrame; } set { this._Gop_OpenClosed_FirstFrame = value; } }
        public string Gop_OpenClosed_FirstFrameString { get { if (string.IsNullOrEmpty(this._Gop_OpenClosed_FirstFrameString)) { this._Gop_OpenClosed_FirstFrameString = ""; } return this._Gop_OpenClosed_FirstFrameString; } set { this._Gop_OpenClosed_FirstFrameString = value; } }
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
        public string Source_StreamSize { get { if (string.IsNullOrEmpty(this._Source_StreamSize)) { this._Source_StreamSize = ""; } return this._Source_StreamSize; } set { this._Source_StreamSize = value; } }
        public string Source_StreamSizeString { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString)) { this._Source_StreamSizeString = ""; } return this._Source_StreamSizeString; } set { this._Source_StreamSizeString = value; } }
        public string Source_StreamSizeString1 { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString1)) { this._Source_StreamSizeString1 = ""; } return this._Source_StreamSizeString1; } set { this._Source_StreamSizeString1 = value; } }
        public string Source_StreamSizeString2 { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString2)) { this._Source_StreamSizeString2 = ""; } return this._Source_StreamSizeString2; } set { this._Source_StreamSizeString2 = value; } }
        public string Source_StreamSizeString3 { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString3)) { this._Source_StreamSizeString3 = ""; } return this._Source_StreamSizeString3; } set { this._Source_StreamSizeString3 = value; } }
        public string Source_StreamSizeString4 { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString4)) { this._Source_StreamSizeString4 = ""; } return this._Source_StreamSizeString4; } set { this._Source_StreamSizeString4 = value; } }
        public string Source_StreamSizeString5 { get { if (string.IsNullOrEmpty(this._Source_StreamSizeString5)) { this._Source_StreamSizeString5 = ""; } return this._Source_StreamSizeString5; } set { this._Source_StreamSizeString5 = value; } }
        public string Source_StreamSize_Proportion { get { if (string.IsNullOrEmpty(this._Source_StreamSize_Proportion)) { this._Source_StreamSize_Proportion = ""; } return this._Source_StreamSize_Proportion; } set { this._Source_StreamSize_Proportion = value; } }
        public string StreamSize_Encoded { get { if (string.IsNullOrEmpty(this._StreamSize_Encoded)) { this._StreamSize_Encoded = ""; } return this._StreamSize_Encoded; } set { this._StreamSize_Encoded = value; } }
        public string StreamSize_EncodedString { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString)) { this._StreamSize_EncodedString = ""; } return this._StreamSize_EncodedString; } set { this._StreamSize_EncodedString = value; } }
        public string StreamSize_EncodedString1 { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString1)) { this._StreamSize_EncodedString1 = ""; } return this._StreamSize_EncodedString1; } set { this._StreamSize_EncodedString1 = value; } }
        public string StreamSize_EncodedString2 { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString2)) { this._StreamSize_EncodedString2 = ""; } return this._StreamSize_EncodedString2; } set { this._StreamSize_EncodedString2 = value; } }
        public string StreamSize_EncodedString3 { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString3)) { this._StreamSize_EncodedString3 = ""; } return this._StreamSize_EncodedString3; } set { this._StreamSize_EncodedString3 = value; } }
        public string StreamSize_EncodedString4 { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString4)) { this._StreamSize_EncodedString4 = ""; } return this._StreamSize_EncodedString4; } set { this._StreamSize_EncodedString4 = value; } }
        public string StreamSize_EncodedString5 { get { if (string.IsNullOrEmpty(this._StreamSize_EncodedString5)) { this._StreamSize_EncodedString5 = ""; } return this._StreamSize_EncodedString5; } set { this._StreamSize_EncodedString5 = value; } }
        public string StreamSize_Encoded_Proportion { get { if (string.IsNullOrEmpty(this._StreamSize_Encoded_Proportion)) { this._StreamSize_Encoded_Proportion = ""; } return this._StreamSize_Encoded_Proportion; } set { this._StreamSize_Encoded_Proportion = value; } }
        public string Source_StreamSize_Encoded { get { if (string.IsNullOrEmpty(this._Source_StreamSize_Encoded)) { this._Source_StreamSize_Encoded = ""; } return this._Source_StreamSize_Encoded; } set { this._Source_StreamSize_Encoded = value; } }
        public string Source_StreamSize_EncodedString { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString)) { this._Source_StreamSize_EncodedString = ""; } return this._Source_StreamSize_EncodedString; } set { this._Source_StreamSize_EncodedString = value; } }
        public string Source_StreamSize_EncodedString1 { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString1)) { this._Source_StreamSize_EncodedString1 = ""; } return this._Source_StreamSize_EncodedString1; } set { this._Source_StreamSize_EncodedString1 = value; } }
        public string Source_StreamSize_EncodedString2 { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString2)) { this._Source_StreamSize_EncodedString2 = ""; } return this._Source_StreamSize_EncodedString2; } set { this._Source_StreamSize_EncodedString2 = value; } }
        public string Source_StreamSize_EncodedString3 { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString3)) { this._Source_StreamSize_EncodedString3 = ""; } return this._Source_StreamSize_EncodedString3; } set { this._Source_StreamSize_EncodedString3 = value; } }
        public string Source_StreamSize_EncodedString4 { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString4)) { this._Source_StreamSize_EncodedString4 = ""; } return this._Source_StreamSize_EncodedString4; } set { this._Source_StreamSize_EncodedString4 = value; } }
        public string Source_StreamSize_EncodedString5 { get { if (string.IsNullOrEmpty(this._Source_StreamSize_EncodedString5)) { this._Source_StreamSize_EncodedString5 = ""; } return this._Source_StreamSize_EncodedString5; } set { this._Source_StreamSize_EncodedString5 = value; } }
        public string Source_StreamSize_Encoded_Proportion { get { if (string.IsNullOrEmpty(this._Source_StreamSize_Encoded_Proportion)) { this._Source_StreamSize_Encoded_Proportion = ""; } return this._Source_StreamSize_Encoded_Proportion; } set { this._Source_StreamSize_Encoded_Proportion = value; } }
        public string Alignment { get { if (string.IsNullOrEmpty(this._Alignment)) { this._Alignment = ""; } return this._Alignment; } set { this._Alignment = value; } }
        public string AlignmentString { get { if (string.IsNullOrEmpty(this._AlignmentString)) { this._AlignmentString = ""; } return this._AlignmentString; } set { this._AlignmentString = value; } }
        public string Title { get { if (string.IsNullOrEmpty(this._Title)) { this._Title = ""; } return this._Title; } set { this._Title = value; } }
        public string Encoded_Application { get { if (string.IsNullOrEmpty(this._Encoded_Application)) { this._Encoded_Application = ""; } return this._Encoded_Application; } set { this._Encoded_Application = value; } }
        public string Encoded_ApplicationString { get { if (string.IsNullOrEmpty(this._Encoded_ApplicationString)) { this._Encoded_ApplicationString = ""; } return this._Encoded_ApplicationString; } set { this._Encoded_ApplicationString = value; } }
        public string Encoded_Application_CompanyName { get { if (string.IsNullOrEmpty(this._Encoded_Application_CompanyName)) { this._Encoded_Application_CompanyName = ""; } return this._Encoded_Application_CompanyName; } set { this._Encoded_Application_CompanyName = value; } }
        public string Encoded_Application_Name { get { if (string.IsNullOrEmpty(this._Encoded_Application_Name)) { this._Encoded_Application_Name = ""; } return this._Encoded_Application_Name; } set { this._Encoded_Application_Name = value; } }
        public string Encoded_Application_Version { get { if (string.IsNullOrEmpty(this._Encoded_Application_Version)) { this._Encoded_Application_Version = ""; } return this._Encoded_Application_Version; } set { this._Encoded_Application_Version = value; } }
        public string Encoded_Application_Url { get { if (string.IsNullOrEmpty(this._Encoded_Application_Url)) { this._Encoded_Application_Url = ""; } return this._Encoded_Application_Url; } set { this._Encoded_Application_Url = value; } }
        public string Encoded_Library { get { if (string.IsNullOrEmpty(this._Encoded_Library)) { this._Encoded_Library = ""; } return this._Encoded_Library; } set { this._Encoded_Library = value; } }
        public string Encoded_LibraryString { get { if (string.IsNullOrEmpty(this._Encoded_LibraryString)) { this._Encoded_LibraryString = ""; } return this._Encoded_LibraryString; } set { this._Encoded_LibraryString = value; } }
        public string Encoded_Library_CompanyName { get { if (string.IsNullOrEmpty(this._Encoded_Library_CompanyName)) { this._Encoded_Library_CompanyName = ""; } return this._Encoded_Library_CompanyName; } set { this._Encoded_Library_CompanyName = value; } }
        public string Encoded_Library_Name { get { if (string.IsNullOrEmpty(this._Encoded_Library_Name)) { this._Encoded_Library_Name = ""; } return this._Encoded_Library_Name; } set { this._Encoded_Library_Name = value; } }
        public string Encoded_Library_Version { get { if (string.IsNullOrEmpty(this._Encoded_Library_Version)) { this._Encoded_Library_Version = ""; } return this._Encoded_Library_Version; } set { this._Encoded_Library_Version = value; } }
        public string Encoded_Library_Date { get { if (string.IsNullOrEmpty(this._Encoded_Library_Date)) { this._Encoded_Library_Date = ""; } return this._Encoded_Library_Date; } set { this._Encoded_Library_Date = value; } }
        public string Encoded_Library_Settings { get { if (string.IsNullOrEmpty(this._Encoded_Library_Settings)) { this._Encoded_Library_Settings = ""; } return this._Encoded_Library_Settings; } set { this._Encoded_Library_Settings = value; } }
        public string Encoded_OperatingSystem { get { if (string.IsNullOrEmpty(this._Encoded_OperatingSystem)) { this._Encoded_OperatingSystem = ""; } return this._Encoded_OperatingSystem; } set { this._Encoded_OperatingSystem = value; } }
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
        public string Encoded_Date { get { if (string.IsNullOrEmpty(this._Encoded_Date)) { this._Encoded_Date = ""; } return this._Encoded_Date; } set { this._Encoded_Date = value; } }
        public string Tagged_Date { get { if (string.IsNullOrEmpty(this._Tagged_Date)) { this._Tagged_Date = ""; } return this._Tagged_Date; } set { this._Tagged_Date = value; } }
        public string Encryption { get { if (string.IsNullOrEmpty(this._Encryption)) { this._Encryption = ""; } return this._Encryption; } set { this._Encryption = value; } }
        public string BufferSize { get { if (string.IsNullOrEmpty(this._BufferSize)) { this._BufferSize = ""; } return this._BufferSize; } set { this._BufferSize = value; } }
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

