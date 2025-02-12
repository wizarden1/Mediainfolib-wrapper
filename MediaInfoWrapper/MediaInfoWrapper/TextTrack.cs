namespace MediaInfoWrapper
{
    using System;

    public class TextTrack
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
        private string _Format_Settings_Wrapping;  //Wrapping mode set for format (e.g. Frame, Clip)
        private string _Format_AdditionalFeatures;  //Features from the format that are required to fully support the file content
        private string _InternetMediaType;  //Internet Media Type (aka MIME Type, Content-Type)
        private string _MuxingMode;  //How this file is muxed in the container (e.g. Muxed in Video #1)
        private string _MuxingMode_MoreInfo;  //More information about MuxingMode
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
        private string _CodecCC;  //Deprecated
        private string _Duration;  //Play time of the stream, in ms
        private string _DurationString;  //Play time of the stream in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _DurationString1;  //Play time of the stream in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _DurationString2;  //Play time of the stream in format XXx YYy, with YYy omitted if value is zero
        private string _DurationString3;  //Play time of the stream in format HH:MM:SS.mmm (e.g. 01:40:00.000)
        private string _DurationString4;  //Play time of the stream in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _DurationString5;  //Play time  of the streamin format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start2End;  //Play time from first display to last display, in ms
        private string _Duration_Start2EndString;  //Play time from first display to last display in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _Duration_Start2EndString1;  //Play time from first display to last display in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_Start2EndString2;  //Play time from first display to last display in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_Start2EndString3;  //Play time from first display to last display in format HH:MM:SS.mmm
        private string _Duration_Start2EndString4;  //Play time from first display to last display in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_Start2EndString5;  //Play time from first display to last display in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start_Command;  //Timestamp of first command, in ms
        private string _Duration_Start_CommandString;  //Timestamp of first command in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _Duration_Start_CommandString1;  //Timestamp of first command in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_Start_CommandString2;  //Timestamp of first command in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_Start_CommandString3;  //Timestamp of first command in format HH:MM:SS.mmm
        private string _Duration_Start_CommandString4;  //Timestamp of first command in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_Start_CommandString5;  //Timestamp of first command in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start;  //Timestamp of first display, in ms
        private string _Duration_StartString;  //Timestamp of first display in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _Duration_StartString1;  //Timestamp of first display in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_StartString2;  //Timestamp of first display in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_StartString3;  //Timestamp of first display in format HH:MM:SS.mmm
        private string _Duration_StartString4;  //Timestamp of first display in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_StartString5;  //Timestamp of first display in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_End;  //Play time of the stream, in s (ms for text output)
        private string _Duration_EndString;  //Play time in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _Duration_EndString1;  //Play time in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_EndString2;  //Play time in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_EndString3;  //Play time in format HH:MM:SS.mmm
        private string _Duration_EndString4;  //Play time in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_EndString5;  //Play time in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_End_Command;  //Play time of the stream, in s (ms for text output)
        private string _Duration_End_CommandString;  //Play time in format XXx YYy, with YYy value omitted if zero (e.g. 1 h 40 min)
        private string _Duration_End_CommandString1;  //Play time in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_End_CommandString2;  //Play time in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_End_CommandString3;  //Play time in format HH:MM:SS.mmm
        private string _Duration_End_CommandString4;  //Play time in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_End_CommandString5;  //Play time in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_FirstFrame;  //Duration of the first frame (if different than other frames), in ms
        private string _Duration_FirstFrameString;  //Duration of the first frame (if different than other frames), in format XXx YYy, with YYy value omitted if zero
        private string _Duration_FirstFrameString1;  //Duration of the first frame (if different than other frames), in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_FirstFrameString2;  //Duration of the first frame (if different than other frames), in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_FirstFrameString3;  //Duration of the first frame (if different than other frames), in format HH:MM:SS.mmm
        private string _Duration_FirstFrameString4;  //Duration of the first frame (if different than other frames), in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_FirstFrameString5;  //Duration of the first frame (if different than other frames), in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_LastFrame;  //Duration of the last frame (if different than other frames), in ms
        private string _Duration_LastFrameString;  //Duration of the last frame (if different than other frames), in format XXx YYy, with YYy value omitted if zero
        private string _Duration_LastFrameString1;  //Duration of the last frame (if different than other frames), in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Duration_LastFrameString2;  //Duration of the last frame (if different than other frames), in format XXx YYy, with YYy omitted if value is zero
        private string _Duration_LastFrameString3;  //Duration of the last frame (if different than other frames), in format HH:MM:SS.mmm
        private string _Duration_LastFrameString4;  //Duration of the last frame (if different than other frames), in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Duration_LastFrameString5;  //Duration of the last frame (if different than other frames), in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Base;  //Temporal coordinate system used for timestamps
        private string _Source_Duration;  //Duration of content stored in the file (if different than duration), in ms
        private string _Source_DurationString;  //Duration of content stored in the file (if different than duration), in format XXx YYy, with YYy value omitted if zero
        private string _Source_DurationString1;  //Duration of content stored in the file (if different than duration), in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Source_DurationString2;  //Duration of content stored in the file (if different than duration), in format XXx YYy, with YYy omitted if value is zero
        private string _Source_DurationString3;  //Duration of content stored in the file (if different than duration), in format HH:MM:SS.mmm
        private string _Source_DurationString4;  //Duration of content stored in the file (if different than duration), in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Source_DurationString5;  //Duration of content stored in the file (if different than duration), in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Source_Duration_FirstFrame;  //Duration of the first frame of content stored in the file (if different than other frames),in ms
        private string _Source_Duration_FirstFrameString;  //Duration of the first frame of content stored in the file (if different than other frames),in format XXx YYy, with YYy value omitted if zero
        private string _Source_Duration_FirstFrameString1;  //Duration of the first frame of content stored in the file (if different than other frames),in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Source_Duration_FirstFrameString2;  //Duration of the first frame of content stored in the file (if different than other frames),in format XXx YYy, with YYy omitted if value is zero
        private string _Source_Duration_FirstFrameString3;  //Duration of the first frame of content stored in the file (if different than other frames),in format HH:MM:SS.mmm
        private string _Source_Duration_FirstFrameString4;  //Duration of the first frame of content stored in the file (if different than other frames),in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Source_Duration_FirstFrameString5;  //Duration of the first frame of content stored in the file (if different than other frames),in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Source_Duration_LastFrame;  //Duration of the last frame of content stored in the file (if different than other frames),in ms
        private string _Source_Duration_LastFrameString;  //Duration of the last frame of content stored in the file (if different than other frames),in format XXx YYy, with YYy value omitted if zero
        private string _Source_Duration_LastFrameString1;  //Duration of the last frame of content stored in the file (if different than other frames), in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Source_Duration_LastFrameString2;  //Duration of the last frame of content stored in the file (if different than other frames), in format XXx YYy, with YYy omitted if value is zero
        private string _Source_Duration_LastFrameString3;  //Duration of the last frame of content stored in the file (if different than other frames), in format HH:MM:SS.mmm
        private string _Source_Duration_LastFrameString4;  //Duration of the last frame of content stored in the file (if different than other frames), in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Source_Duration_LastFrameString5;  //Duration of the last frame of content stored in the file (if different than other frames), in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _BitRate_Mode;  //Bit rate mode of this stream (CBR, VBR)
        private string _BitRate_ModeString;  //Bit rate mode of this stream, as word (Variable, Constant)
        private string _BitRate;  //Bit rate of this stream, in bps
        private string _BitRateString;  //Bit rate of this stream, with measurement (e.g. 128 kb/s)
        private string _BitRate_Minimum;  //Minimum bit rate of this stream, in bps
        private string _BitRate_MinimumString;  //Minimum bit rate of this stream, with measurement
        private string _BitRate_Nominal;  //Nominal bit rate of this stream, in bps
        private string _BitRate_NominalString;  //Nominal bit rate of this stream, with measurement
        private string _BitRate_Maximum;  //Maximum bit rate of this stream, in bps
        private string _BitRate_MaximumString;  //Maximum bit rate of this stream, with measurement
        private string _BitRate_Encoded;  //Encoded bit rate (with forced padding), if container padding is present, in bps
        private string _BitRate_EncodedString;  //Encoded bit rate (with forced padding), if container padding is present, in bps
        private string _Width;  //Width of frame (trimmed to "clean aperture" size if present) in characters
        private string _WidthString;  //Width of frame (trimmed to "clean aperture" size if present) in characters, presented in SI unit digit spacing style, with measurement
        private string _Height;  //Height of frame (including aperture size if present) in characters
        private string _HeightString;  //Height of frame (including aperture size if present) in characters, present in SI unit digit spacing style, with measurement
        private string _DisplayAspectRatio;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatioString;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatio_Original;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _DisplayAspectRatio_OriginalString;  //The proportional relationship between the width and height of a frame (e.g. 4:3)
        private string _FrameRate_Mode;  //Frame rate mode, as acronym (e.g. CFR, VFR)
        private string _FrameRate_ModeString;  //Frame rate mode, as word (e.g. Constant, Variable)
        private string _FrameRate_Mode_Original;  //Frame rate mode, as acronym (e.g. CFR, VFR)
        private string _FrameRate_Mode_OriginalString;  //Frame rate mode, as word (e.g. Constant, Variable)
        private string _FrameRate;  //Frames per second, as float (e.g. 29.970)
        private string _FrameRateString;  //Frames per second, with measurement (e.g. 29.970 (29970/1000) FPS)
        private string _FrameRate_Num;  //Numerator for determined frames per second (e.g. 29970)
        private string _FrameRate_Den;  //Denominator for determined frames per second (e.g. 1000)
        private string _FrameRate_Minimum;  //Minimum frames per second (e.g. 25.000)
        private string _FrameRate_MinimumString;  //Minimum frames per second, with measurement (e.g. 25.000 FPS)
        private string _FrameRate_Nominal;  //Frames per second rounded to closest standard (e.g. 29.97)
        private string _FrameRate_NominalString;  //Frames per second rounded to closest standard, with measurement (e.g. 29.97 fps)
        private string _FrameRate_Maximum;  //Maximum frames per second
        private string _FrameRate_MaximumString;  //Maximum frames per second, with measurement
        private string _FrameRate_Original;  //Frames per second
        private string _FrameRate_OriginalString;  //Frames per second, with measurement
        private string _FrameRate_Original_Num;  //Frames per second, numerator
        private string _FrameRate_Original_Den;  //Frames per second, denominator
        private string _FrameCount;  //Numer of frames
        private string _ElementCount;  //Number of displayed elements
        private string _Source_FrameCount;  //Number of frames according to media header (media/stts atom) data
        private string _ColorSpace;  //Color profile of the image (e.g. YUV)
        private string _ChromaSubsampling;  //Ratio of chroma to luma in encoded image (e.g. 4:2:2)
        private string _Resolution;  //Deprecated, do not use in new projects
        private string _ResolutionString;  //Deprecated, do not use in new projects
        private string _BitDepth;  //Color information stored in the video frames, as integer (e.g. 10)
        private string _BitDepthString;  //Color information stored in the video frames, as string (e.g. 10 bits)
        private string _Compression_Mode;  //Compression mode (Lossy, Lossless)
        private string _Compression_ModeString;  //Compression mode (Lossy, Lossless)
        private string _Compression_Ratio;  //Stream size divided by uncompressed stream size
        private string _Delay;  //Delay fixed in the stream (relative), in ms
        private string _DelayString;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString1;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString2;  //Delay fixed in the stream (relative), with measurement
        private string _DelayString3;  //Delay fixed in the stream (relative) in format HH:MM:SS.mmm, with measurement
        private string _DelayString4;  //Delay in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _DelayString5;  //Delay in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Settings;  //Delay settings (e.g. in case of timecode)
        private string _Delay_DropFrame;  //Delay drop frame information
        private string _Delay_Source;  //Source location of the Delay (e.g. Container, Stream, empty)
        private string _Delay_SourceString;  //Source location of the Delay (e.g. Container, Stream, empty)
        private string _Delay_Original;  //Delay, in ms
        private string _Delay_OriginalString;  //Delay, with measurement
        private string _Delay_OriginalString1;  //Delay, with measurement
        private string _Delay_OriginalString2;  //Delay, with measurement
        private string _Delay_OriginalString3;  //Delay, in format HH:MM:SS.mmm
        private string _Delay_OriginalString4;  //Delay, in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Delay_OriginalString5;  //Delay, in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Original_Settings;  //Delay settings (e.g. in case of timecode)
        private string _Delay_Original_DropFrame;  //Delay drop frame information
        private string _Delay_Original_Source;  //Delay source (e.g. Container, Stream, empty)
        private string _Video_Delay;  //Delay fixed in the stream relative to video, in ms (e.g. -80)
        private string _Video_DelayString;  //Delay fixed in the stream relative to video, in ms, with measurement (e.g. -80 ms)
        private string _Video_DelayString1;  //Delay fixed in the stream relative to video, in ms, with measurement (e.g. -80 ms)
        private string _Video_DelayString2;  //Delay fixed in the stream relative to video, in ms, with measurement (e.g. -80 ms)
        private string _Video_DelayString3;  //Delay fixed in the stream relative to video, in format HH:MM:SS.mmm (e.g. -00:00:00.080)
        private string _Video_DelayString4;  //Delay in format HH:MM:SS:FF, with the last colon replaced by semicolon for drop frame if available
        private string _Video_DelayString5;  //Delay fixed in the stream relative to video, in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Video0_Delay;  //Deprecated, do not use in new projects
        private string _Video0_DelayString;  //Deprecated, do not use in new projects
        private string _Video0_DelayString1;  //Deprecated, do not use in new projects
        private string _Video0_DelayString2;  //Deprecated, do not use in new projects
        private string _Video0_DelayString3;  //Deprecated, do not use in new projects
        private string _Video0_DelayString4;  //Deprecated, do not use in new projects
        private string _Video0_DelayString5;  //Deprecated, do not use in new projects
        private string _TimeCode_FirstFrame;  //Time code for first frame in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _TimeCode_LastFrame;  //Time code for last frame (excluding the duration of the last frame) in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _TimeCode_DropFrame;  //Time code drop frame
        private string _TimeCode_Settings;  //Additional time code settings
        private string _TimeCode_Source;  //Time code source (Container, Stream, SystemScheme1, SDTI, ANC, etc.)
        private string _TimeCode_MaxFrameNumber;  //Maximum frame number in time codes
        private string _TimeCode_MaxFrameNumber_Theory;  //Theoritical maximum frame number in time codes
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
        private string _Source_StreamSize;  //Size of content stored in the file, in bytes
        private string _Source_StreamSizeString;  //Size of content stored in the file, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _Source_StreamSizeString1;  //Size of content stored in the file, with measurement (measured in powers of 1024) rounded to the nearest integer (e.g. 11 MiB)
        private string _Source_StreamSizeString2;  //Size of content stored in the file, measurement (measured in powers of 1024) rounded to the two most significant digits (e.g. 11 MiB)
        private string _Source_StreamSizeString3;  //Size of content stored in the file, measurement (measured in powers of 1024) rounded to the three most significant digits (e.g. 10.5 MiB)
        private string _Source_StreamSizeString4;  //Size of content stored in the file, measurement (measured in powers of 1024) rounded to the four most significant digits (e.g. 10.50 MiB)
        private string _Source_StreamSizeString5;  //Size of content stored in the file, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _Source_StreamSize_Proportion;  //Size of this stream divided by total file size
        private string _StreamSize_Encoded;  //Size of this stream when encoded, in bytes
        private string _StreamSize_EncodedString;  //Size of this stream when encoded, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _StreamSize_EncodedString1;  //Size of this stream when encoded, with measurement (measured in powers of 1024) rounded to the nearest integer (e.g. 11 MiB)
        private string _StreamSize_EncodedString2;  //Size of this stream when encoded, measurement (measured in powers of 1024) rounded to the two most significant digits (e.g. 11 MiB)
        private string _StreamSize_EncodedString3;  //Size of this stream when encoded, measurement (measured in powers of 1024) rounded to the three most significant digits (e.g. 10.5 MiB)
        private string _StreamSize_EncodedString4;  //Size of this stream when encoded, measurement (measured in powers of 1024) rounded to the four most significant digits (e.g. 10.50 MiB)
        private string _StreamSize_EncodedString5;  //Size of this stream when encoded, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _StreamSize_Encoded_Proportion;  //Encoded Stream size divided by file size
        private string _Source_StreamSize_Encoded;  //Size of content stored in the file when encoded, in bytes
        private string _Source_StreamSize_EncodedString;  //Size of content stored in the file when encoded, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _Source_StreamSize_EncodedString1;  //Size of content stored in the file when encoded, with measurement (measured in powers of 1024) rounded to the nearest integer (e.g. 11 MiB)
        private string _Source_StreamSize_EncodedString2;  //Size of content stored in the file when encoded, measurement (measured in powers of 1024) rounded to the two most significant digits (e.g. 11 MiB)
        private string _Source_StreamSize_EncodedString3;  //Size of content stored in the file when encoded, measurement (measured in powers of 1024) rounded to the three most significant digits (e.g. 10.5 MiB)
        private string _Source_StreamSize_EncodedString4;  //Size of content stored in the file when encoded, measurement (measured in powers of 1024) rounded to the four most significant digits (e.g. 10.50 MiB)
        private string _Source_StreamSize_EncodedString5;  //Size of content stored in the file when encoded, with measurement (measured in powers of 1024) and percentage value (e.g. 10.5 MiB (98%))
        private string _Source_StreamSize_Encoded_Proportion;  //Source Encoded Stream size divided by file size
        private string _Title;  //Title of file
        private string _Encoded_Application;  //Name of the software package used to create the file (e.g. Microsoft WaveEdiTY)
        private string _Encoded_ApplicationString;  //Name of the software package used to create the file, in the format "CompanyName ProductName (OperatingSystem) Version (Date)"
        private string _Encoded_Application_CompanyName;  //Name of the company of the encoding application
        private string _Encoded_Application_Name;  //Name of the encoding product
        private string _Encoded_Application_Version;  //Version of the encoding product
        private string _Encoded_Application_Url;  //URL associated with the encoding software
        private string _Encoded_Library;  //Software used to create the file
        private string _Encoded_LibraryString;  //Software used to create the file, in the format "CompanyName ProductName (OperatingSystem) Version (Date)"
        private string _Encoded_Library_CompanyName;  //Name of the encoding software company
        private string _Encoded_Library_Name;  //Name of the encoding software
        private string _Encoded_Library_Version;  //Version of the encoding software
        private string _Encoded_Library_Date;  //Release date of the encoding software, in UTC
        private string _Encoded_Library_Settings;  //Parameters used by the encoding software
        private string _Encoded_OperatingSystem;  //Operating System of the encoding software
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
        private string _Encoded_Date;  //Time/date/year that the encoding of this content was completed
        private string _Tagged_Date;  //Time/date/year that the tags were added to this content
        private string _Encryption;  //Whether this stream is encrypted and, if available, how it is encrypted
        private string _Events_Total;  //
        private string _Events_MinDuration;  //Minimum duration per event, in ms
        private string _Events_MinDurationString;  //Minimum duration per event in format XXx YYy, with YYy value omitted if zero
        private string _Events_MinDurationString1;  //Minimum duration per event in format HHh MMmn SSs MMMms, with any fields omitted if zero
        private string _Events_MinDurationString2;  //Minimum duration per event in format XXx YYy, with YYy omitted if value is zero
        private string _Events_MinDurationString3;  //Minimum duration per event in format HH:MM:SS.mmm
        private string _Events_MinDurationString4;  //Minimum duration per event in format HH:MM:SS:FF, with last colon replaced by semicolon for drop frame if available
        private string _Events_MinDurationString5;  //Minimum duration per event in format HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Events_PopOn;  //
        private string _Events_RollUp;  //
        private string _Events_PaintOn;  //
        private string _Lines_Count;  //
        private string _Lines_MaxCountPerEvent;  //
        private string _Lines_MaxCharacterCount;  //
        private string _FirstDisplay_Delay_Frames;  //
        private string _FirstDisplay_Type;  //

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
        public string Format_Settings_Wrapping { get { if (string.IsNullOrEmpty(this._Format_Settings_Wrapping)) { this._Format_Settings_Wrapping = ""; } return this._Format_Settings_Wrapping; } set { this._Format_Settings_Wrapping = value; } }
        public string Format_AdditionalFeatures { get { if (string.IsNullOrEmpty(this._Format_AdditionalFeatures)) { this._Format_AdditionalFeatures = ""; } return this._Format_AdditionalFeatures; } set { this._Format_AdditionalFeatures = value; } }
        public string InternetMediaType { get { if (string.IsNullOrEmpty(this._InternetMediaType)) { this._InternetMediaType = ""; } return this._InternetMediaType; } set { this._InternetMediaType = value; } }
        public string MuxingMode { get { if (string.IsNullOrEmpty(this._MuxingMode)) { this._MuxingMode = ""; } return this._MuxingMode; } set { this._MuxingMode = value; } }
        public string MuxingMode_MoreInfo { get { if (string.IsNullOrEmpty(this._MuxingMode_MoreInfo)) { this._MuxingMode_MoreInfo = ""; } return this._MuxingMode_MoreInfo; } set { this._MuxingMode_MoreInfo = value; } }
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
        public string CodecCC { get { if (string.IsNullOrEmpty(this._CodecCC)) { this._CodecCC = ""; } return this._CodecCC; } set { this._CodecCC = value; } }
        public string Duration { get { if (string.IsNullOrEmpty(this._Duration)) { this._Duration = ""; } return this._Duration; } set { this._Duration = value; } }
        public string DurationString { get { if (string.IsNullOrEmpty(this._DurationString)) { this._DurationString = ""; } return this._DurationString; } set { this._DurationString = value; } }
        public string DurationString1 { get { if (string.IsNullOrEmpty(this._DurationString1)) { this._DurationString1 = ""; } return this._DurationString1; } set { this._DurationString1 = value; } }
        public string DurationString2 { get { if (string.IsNullOrEmpty(this._DurationString2)) { this._DurationString2 = ""; } return this._DurationString2; } set { this._DurationString2 = value; } }
        public string DurationString3 { get { if (string.IsNullOrEmpty(this._DurationString3)) { this._DurationString3 = ""; } return this._DurationString3; } set { this._DurationString3 = value; } }
        public string DurationString4 { get { if (string.IsNullOrEmpty(this._DurationString4)) { this._DurationString4 = ""; } return this._DurationString4; } set { this._DurationString4 = value; } }
        public string DurationString5 { get { if (string.IsNullOrEmpty(this._DurationString5)) { this._DurationString5 = ""; } return this._DurationString5; } set { this._DurationString5 = value; } }
        public string Duration_Start2End { get { if (string.IsNullOrEmpty(this._Duration_Start2End)) { this._Duration_Start2End = ""; } return this._Duration_Start2End; } set { this._Duration_Start2End = value; } }
        public string Duration_Start2EndString { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString)) { this._Duration_Start2EndString = ""; } return this._Duration_Start2EndString; } set { this._Duration_Start2EndString = value; } }
        public string Duration_Start2EndString1 { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString1)) { this._Duration_Start2EndString1 = ""; } return this._Duration_Start2EndString1; } set { this._Duration_Start2EndString1 = value; } }
        public string Duration_Start2EndString2 { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString2)) { this._Duration_Start2EndString2 = ""; } return this._Duration_Start2EndString2; } set { this._Duration_Start2EndString2 = value; } }
        public string Duration_Start2EndString3 { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString3)) { this._Duration_Start2EndString3 = ""; } return this._Duration_Start2EndString3; } set { this._Duration_Start2EndString3 = value; } }
        public string Duration_Start2EndString4 { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString4)) { this._Duration_Start2EndString4 = ""; } return this._Duration_Start2EndString4; } set { this._Duration_Start2EndString4 = value; } }
        public string Duration_Start2EndString5 { get { if (string.IsNullOrEmpty(this._Duration_Start2EndString5)) { this._Duration_Start2EndString5 = ""; } return this._Duration_Start2EndString5; } set { this._Duration_Start2EndString5 = value; } }
        public string Duration_Start_Command { get { if (string.IsNullOrEmpty(this._Duration_Start_Command)) { this._Duration_Start_Command = ""; } return this._Duration_Start_Command; } set { this._Duration_Start_Command = value; } }
        public string Duration_Start_CommandString { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString)) { this._Duration_Start_CommandString = ""; } return this._Duration_Start_CommandString; } set { this._Duration_Start_CommandString = value; } }
        public string Duration_Start_CommandString1 { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString1)) { this._Duration_Start_CommandString1 = ""; } return this._Duration_Start_CommandString1; } set { this._Duration_Start_CommandString1 = value; } }
        public string Duration_Start_CommandString2 { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString2)) { this._Duration_Start_CommandString2 = ""; } return this._Duration_Start_CommandString2; } set { this._Duration_Start_CommandString2 = value; } }
        public string Duration_Start_CommandString3 { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString3)) { this._Duration_Start_CommandString3 = ""; } return this._Duration_Start_CommandString3; } set { this._Duration_Start_CommandString3 = value; } }
        public string Duration_Start_CommandString4 { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString4)) { this._Duration_Start_CommandString4 = ""; } return this._Duration_Start_CommandString4; } set { this._Duration_Start_CommandString4 = value; } }
        public string Duration_Start_CommandString5 { get { if (string.IsNullOrEmpty(this._Duration_Start_CommandString5)) { this._Duration_Start_CommandString5 = ""; } return this._Duration_Start_CommandString5; } set { this._Duration_Start_CommandString5 = value; } }
        public string Duration_Start { get { if (string.IsNullOrEmpty(this._Duration_Start)) { this._Duration_Start = ""; } return this._Duration_Start; } set { this._Duration_Start = value; } }
        public string Duration_StartString { get { if (string.IsNullOrEmpty(this._Duration_StartString)) { this._Duration_StartString = ""; } return this._Duration_StartString; } set { this._Duration_StartString = value; } }
        public string Duration_StartString1 { get { if (string.IsNullOrEmpty(this._Duration_StartString1)) { this._Duration_StartString1 = ""; } return this._Duration_StartString1; } set { this._Duration_StartString1 = value; } }
        public string Duration_StartString2 { get { if (string.IsNullOrEmpty(this._Duration_StartString2)) { this._Duration_StartString2 = ""; } return this._Duration_StartString2; } set { this._Duration_StartString2 = value; } }
        public string Duration_StartString3 { get { if (string.IsNullOrEmpty(this._Duration_StartString3)) { this._Duration_StartString3 = ""; } return this._Duration_StartString3; } set { this._Duration_StartString3 = value; } }
        public string Duration_StartString4 { get { if (string.IsNullOrEmpty(this._Duration_StartString4)) { this._Duration_StartString4 = ""; } return this._Duration_StartString4; } set { this._Duration_StartString4 = value; } }
        public string Duration_StartString5 { get { if (string.IsNullOrEmpty(this._Duration_StartString5)) { this._Duration_StartString5 = ""; } return this._Duration_StartString5; } set { this._Duration_StartString5 = value; } }
        public string Duration_End { get { if (string.IsNullOrEmpty(this._Duration_End)) { this._Duration_End = ""; } return this._Duration_End; } set { this._Duration_End = value; } }
        public string Duration_EndString { get { if (string.IsNullOrEmpty(this._Duration_EndString)) { this._Duration_EndString = ""; } return this._Duration_EndString; } set { this._Duration_EndString = value; } }
        public string Duration_EndString1 { get { if (string.IsNullOrEmpty(this._Duration_EndString1)) { this._Duration_EndString1 = ""; } return this._Duration_EndString1; } set { this._Duration_EndString1 = value; } }
        public string Duration_EndString2 { get { if (string.IsNullOrEmpty(this._Duration_EndString2)) { this._Duration_EndString2 = ""; } return this._Duration_EndString2; } set { this._Duration_EndString2 = value; } }
        public string Duration_EndString3 { get { if (string.IsNullOrEmpty(this._Duration_EndString3)) { this._Duration_EndString3 = ""; } return this._Duration_EndString3; } set { this._Duration_EndString3 = value; } }
        public string Duration_EndString4 { get { if (string.IsNullOrEmpty(this._Duration_EndString4)) { this._Duration_EndString4 = ""; } return this._Duration_EndString4; } set { this._Duration_EndString4 = value; } }
        public string Duration_EndString5 { get { if (string.IsNullOrEmpty(this._Duration_EndString5)) { this._Duration_EndString5 = ""; } return this._Duration_EndString5; } set { this._Duration_EndString5 = value; } }
        public string Duration_End_Command { get { if (string.IsNullOrEmpty(this._Duration_End_Command)) { this._Duration_End_Command = ""; } return this._Duration_End_Command; } set { this._Duration_End_Command = value; } }
        public string Duration_End_CommandString { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString)) { this._Duration_End_CommandString = ""; } return this._Duration_End_CommandString; } set { this._Duration_End_CommandString = value; } }
        public string Duration_End_CommandString1 { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString1)) { this._Duration_End_CommandString1 = ""; } return this._Duration_End_CommandString1; } set { this._Duration_End_CommandString1 = value; } }
        public string Duration_End_CommandString2 { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString2)) { this._Duration_End_CommandString2 = ""; } return this._Duration_End_CommandString2; } set { this._Duration_End_CommandString2 = value; } }
        public string Duration_End_CommandString3 { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString3)) { this._Duration_End_CommandString3 = ""; } return this._Duration_End_CommandString3; } set { this._Duration_End_CommandString3 = value; } }
        public string Duration_End_CommandString4 { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString4)) { this._Duration_End_CommandString4 = ""; } return this._Duration_End_CommandString4; } set { this._Duration_End_CommandString4 = value; } }
        public string Duration_End_CommandString5 { get { if (string.IsNullOrEmpty(this._Duration_End_CommandString5)) { this._Duration_End_CommandString5 = ""; } return this._Duration_End_CommandString5; } set { this._Duration_End_CommandString5 = value; } }
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
        public string Duration_Base { get { if (string.IsNullOrEmpty(this._Duration_Base)) { this._Duration_Base = ""; } return this._Duration_Base; } set { this._Duration_Base = value; } }
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
        public string Height { get { if (string.IsNullOrEmpty(this._Height)) { this._Height = ""; } return this._Height; } set { this._Height = value; } }
        public string HeightString { get { if (string.IsNullOrEmpty(this._HeightString)) { this._HeightString = ""; } return this._HeightString; } set { this._HeightString = value; } }
        public string DisplayAspectRatio { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio)) { this._DisplayAspectRatio = ""; } return this._DisplayAspectRatio; } set { this._DisplayAspectRatio = value; } }
        public string DisplayAspectRatioString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatioString)) { this._DisplayAspectRatioString = ""; } return this._DisplayAspectRatioString; } set { this._DisplayAspectRatioString = value; } }
        public string DisplayAspectRatio_Original { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_Original)) { this._DisplayAspectRatio_Original = ""; } return this._DisplayAspectRatio_Original; } set { this._DisplayAspectRatio_Original = value; } }
        public string DisplayAspectRatio_OriginalString { get { if (string.IsNullOrEmpty(this._DisplayAspectRatio_OriginalString)) { this._DisplayAspectRatio_OriginalString = ""; } return this._DisplayAspectRatio_OriginalString; } set { this._DisplayAspectRatio_OriginalString = value; } }
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
        public string ElementCount { get { if (string.IsNullOrEmpty(this._ElementCount)) { this._ElementCount = ""; } return this._ElementCount; } set { this._ElementCount = value; } }
        public string Source_FrameCount { get { if (string.IsNullOrEmpty(this._Source_FrameCount)) { this._Source_FrameCount = ""; } return this._Source_FrameCount; } set { this._Source_FrameCount = value; } }
        public string ColorSpace { get { if (string.IsNullOrEmpty(this._ColorSpace)) { this._ColorSpace = ""; } return this._ColorSpace; } set { this._ColorSpace = value; } }
        public string ChromaSubsampling { get { if (string.IsNullOrEmpty(this._ChromaSubsampling)) { this._ChromaSubsampling = ""; } return this._ChromaSubsampling; } set { this._ChromaSubsampling = value; } }
        public string Resolution { get { if (string.IsNullOrEmpty(this._Resolution)) { this._Resolution = ""; } return this._Resolution; } set { this._Resolution = value; } }
        public string ResolutionString { get { if (string.IsNullOrEmpty(this._ResolutionString)) { this._ResolutionString = ""; } return this._ResolutionString; } set { this._ResolutionString = value; } }
        public string BitDepth { get { if (string.IsNullOrEmpty(this._BitDepth)) { this._BitDepth = ""; } return this._BitDepth; } set { this._BitDepth = value; } }
        public string BitDepthString { get { if (string.IsNullOrEmpty(this._BitDepthString)) { this._BitDepthString = ""; } return this._BitDepthString; } set { this._BitDepthString = value; } }
        public string Compression_Mode { get { if (string.IsNullOrEmpty(this._Compression_Mode)) { this._Compression_Mode = ""; } return this._Compression_Mode; } set { this._Compression_Mode = value; } }
        public string Compression_ModeString { get { if (string.IsNullOrEmpty(this._Compression_ModeString)) { this._Compression_ModeString = ""; } return this._Compression_ModeString; } set { this._Compression_ModeString = value; } }
        public string Compression_Ratio { get { if (string.IsNullOrEmpty(this._Compression_Ratio)) { this._Compression_Ratio = ""; } return this._Compression_Ratio; } set { this._Compression_Ratio = value; } }
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
        public string TimeCode_FirstFrame { get { if (string.IsNullOrEmpty(this._TimeCode_FirstFrame)) { this._TimeCode_FirstFrame = ""; } return this._TimeCode_FirstFrame; } set { this._TimeCode_FirstFrame = value; } }
        public string TimeCode_LastFrame { get { if (string.IsNullOrEmpty(this._TimeCode_LastFrame)) { this._TimeCode_LastFrame = ""; } return this._TimeCode_LastFrame; } set { this._TimeCode_LastFrame = value; } }
        public string TimeCode_DropFrame { get { if (string.IsNullOrEmpty(this._TimeCode_DropFrame)) { this._TimeCode_DropFrame = ""; } return this._TimeCode_DropFrame; } set { this._TimeCode_DropFrame = value; } }
        public string TimeCode_Settings { get { if (string.IsNullOrEmpty(this._TimeCode_Settings)) { this._TimeCode_Settings = ""; } return this._TimeCode_Settings; } set { this._TimeCode_Settings = value; } }
        public string TimeCode_Source { get { if (string.IsNullOrEmpty(this._TimeCode_Source)) { this._TimeCode_Source = ""; } return this._TimeCode_Source; } set { this._TimeCode_Source = value; } }
        public string TimeCode_MaxFrameNumber { get { if (string.IsNullOrEmpty(this._TimeCode_MaxFrameNumber)) { this._TimeCode_MaxFrameNumber = ""; } return this._TimeCode_MaxFrameNumber; } set { this._TimeCode_MaxFrameNumber = value; } }
        public string TimeCode_MaxFrameNumber_Theory { get { if (string.IsNullOrEmpty(this._TimeCode_MaxFrameNumber_Theory)) { this._TimeCode_MaxFrameNumber_Theory = ""; } return this._TimeCode_MaxFrameNumber_Theory; } set { this._TimeCode_MaxFrameNumber_Theory = value; } }
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
        public string Summary { get { if (string.IsNullOrEmpty(this._Summary)) { this._Summary = ""; } return this._Summary; } set { this._Summary = value; } }
        public string Encoded_Date { get { if (string.IsNullOrEmpty(this._Encoded_Date)) { this._Encoded_Date = ""; } return this._Encoded_Date; } set { this._Encoded_Date = value; } }
        public string Tagged_Date { get { if (string.IsNullOrEmpty(this._Tagged_Date)) { this._Tagged_Date = ""; } return this._Tagged_Date; } set { this._Tagged_Date = value; } }
        public string Encryption { get { if (string.IsNullOrEmpty(this._Encryption)) { this._Encryption = ""; } return this._Encryption; } set { this._Encryption = value; } }
        public string Events_Total { get { if (string.IsNullOrEmpty(this._Events_Total)) { this._Events_Total = ""; } return this._Events_Total; } set { this._Events_Total = value; } }
        public string Events_MinDuration { get { if (string.IsNullOrEmpty(this._Events_MinDuration)) { this._Events_MinDuration = ""; } return this._Events_MinDuration; } set { this._Events_MinDuration = value; } }
        public string Events_MinDurationString { get { if (string.IsNullOrEmpty(this._Events_MinDurationString)) { this._Events_MinDurationString = ""; } return this._Events_MinDurationString; } set { this._Events_MinDurationString = value; } }
        public string Events_MinDurationString1 { get { if (string.IsNullOrEmpty(this._Events_MinDurationString1)) { this._Events_MinDurationString1 = ""; } return this._Events_MinDurationString1; } set { this._Events_MinDurationString1 = value; } }
        public string Events_MinDurationString2 { get { if (string.IsNullOrEmpty(this._Events_MinDurationString2)) { this._Events_MinDurationString2 = ""; } return this._Events_MinDurationString2; } set { this._Events_MinDurationString2 = value; } }
        public string Events_MinDurationString3 { get { if (string.IsNullOrEmpty(this._Events_MinDurationString3)) { this._Events_MinDurationString3 = ""; } return this._Events_MinDurationString3; } set { this._Events_MinDurationString3 = value; } }
        public string Events_MinDurationString4 { get { if (string.IsNullOrEmpty(this._Events_MinDurationString4)) { this._Events_MinDurationString4 = ""; } return this._Events_MinDurationString4; } set { this._Events_MinDurationString4 = value; } }
        public string Events_MinDurationString5 { get { if (string.IsNullOrEmpty(this._Events_MinDurationString5)) { this._Events_MinDurationString5 = ""; } return this._Events_MinDurationString5; } set { this._Events_MinDurationString5 = value; } }
        public string Events_PopOn { get { if (string.IsNullOrEmpty(this._Events_PopOn)) { this._Events_PopOn = ""; } return this._Events_PopOn; } set { this._Events_PopOn = value; } }
        public string Events_RollUp { get { if (string.IsNullOrEmpty(this._Events_RollUp)) { this._Events_RollUp = ""; } return this._Events_RollUp; } set { this._Events_RollUp = value; } }
        public string Events_PaintOn { get { if (string.IsNullOrEmpty(this._Events_PaintOn)) { this._Events_PaintOn = ""; } return this._Events_PaintOn; } set { this._Events_PaintOn = value; } }
        public string Lines_Count { get { if (string.IsNullOrEmpty(this._Lines_Count)) { this._Lines_Count = ""; } return this._Lines_Count; } set { this._Lines_Count = value; } }
        public string Lines_MaxCountPerEvent { get { if (string.IsNullOrEmpty(this._Lines_MaxCountPerEvent)) { this._Lines_MaxCountPerEvent = ""; } return this._Lines_MaxCountPerEvent; } set { this._Lines_MaxCountPerEvent = value; } }
        public string Lines_MaxCharacterCount { get { if (string.IsNullOrEmpty(this._Lines_MaxCharacterCount)) { this._Lines_MaxCharacterCount = ""; } return this._Lines_MaxCharacterCount; } set { this._Lines_MaxCharacterCount = value; } }
        public string FirstDisplay_Delay_Frames { get { if (string.IsNullOrEmpty(this._FirstDisplay_Delay_Frames)) { this._FirstDisplay_Delay_Frames = ""; } return this._FirstDisplay_Delay_Frames; } set { this._FirstDisplay_Delay_Frames = value; } }
        public string FirstDisplay_Type { get { if (string.IsNullOrEmpty(this._FirstDisplay_Type)) { this._FirstDisplay_Type = ""; } return this._FirstDisplay_Type; } set { this._FirstDisplay_Type = value; } }
    }
}

