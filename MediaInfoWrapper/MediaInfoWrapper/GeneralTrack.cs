namespace MediaInfoWrapper
{
    using System;

    public class GeneralTrack
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
        private string _GeneralCount;  //Number of general streams
        private string _VideoCount;  //Number of video streams
        private string _AudioCount;  //Number of audio streams
        private string _TextCount;  //Number of text streams
        private string _OtherCount;  //Number of other streams
        private string _ImageCount;  //Number of image streams
        private string _MenuCount;  //Number of menu streams
        private string _Video_Format_List;  //Video Codecs in this file, separated by /
        private string _Video_Format_WithHint_List;  //Video Codecs in this file with popular name (hint), separated by /
        private string _Video_Codec_List;  //Deprecated, do not use in new projects
        private string _Video_Language_List;  //Video languagesin this file, full names, separated by /
        private string _Audio_Format_List;  //Audio Codecs in this file,separated by /
        private string _Audio_Format_WithHint_List;  //Audio Codecs in this file with popular name (hint), separated by /
        private string _Audio_Codec_List;  //Deprecated, do not use in new projects
        private string _Audio_Language_List;  //Audio languages in this file separated by /
        private string _Text_Format_List;  //Text Codecs in this file, separated by /
        private string _Text_Format_WithHint_List;  //Text Codecs in this file with popular name (hint),separated by /
        private string _Text_Codec_List;  //Deprecated, do not use in new projects
        private string _Text_Language_List;  //Text languages in this file, separated by /
        private string _Other_Format_List;  //Other formats in this file, separated by /
        private string _Other_Format_WithHint_List;  //Other formats in this file with popular name (hint), separated by /
        private string _Other_Codec_List;  //Deprecated, do not use in new projects
        private string _Other_Language_List;  //Chapters languages in this file, separated by /
        private string _Image_Format_List;  //Image Codecs in this file, separated by /
        private string _Image_Format_WithHint_List;  //Image Codecs in this file with popular name (hint), separated by /
        private string _Image_Codec_List;  //Deprecated, do not use in new projects
        private string _Image_Language_List;  //Image languages in this file, separated by /
        private string _Menu_Format_List;  //Menu Codecsin this file, separated by /
        private string _Menu_Format_WithHint_List;  //Menu Codecs in this file with popular name (hint),separated by /
        private string _Menu_Codec_List;  //Deprecated, do not use in new projects
        private string _Menu_Language_List;  //Menu languages in this file, separated by /
        private string _CompleteName;  //Complete name (Folder+Name+Extension)
        private string _FolderName;  //Folder name only
        private string _FileName;  //File name only
        private string _FileExtension;  //File extension only
        private string _CompleteName_Last;  //Complete name (Folder+Name+Extension) of the last file (in the case of a sequence of files)
        private string _FolderName_Last;  //Folder name only of the last file (in the case of a sequence of files)
        private string _FileName_Last;  //File name only of the last file (in the case of a sequence of files)
        private string _FileExtension_Last;  //File extension only of the last file (in the case of a sequence of files)
        private string _Format;  //Format used
        private string _FormatString;  //Deprecated, do not use in new projects
        private string _FormatInfo;  //Info about this Format
        private string _FormatUrl;  //Link to a description of this format
        private string _FormatExtensions;  //Known extensions of this format
        private string _Format_Commercial;  //Commercial name used by vendor for theses setings or Format field if there is no difference
        private string _Format_Commercial_IfAny;  //Commercial name used by vendor for theses setings if there is one
        private string _Format_Version;  //Version of this format
        private string _Format_Profile;  //Profile of the Format (old XML: 'Profile@Level' format
        private string _Format_Level;  //Level of the Format (only MIXML)
        private string _Format_Compression;  //Compression method used
        private string _Format_Settings;  //Settings needed for decoder used
        private string _InternetMediaType;  //Internet Media Type (aka MIME Type, Content-Type)
        private string _CodecID;  //Codec ID (found in some containers)
        private string _CodecIDString;  //Codec ID (found in some containers)
        private string _CodecIDInfo;  //Info about this codec
        private string _CodecIDHint;  //A hint/popular name for this codec
        private string _CodecIDUrl;  //A link to more details about this codec ID
        private string _CodecID_Description;  //Manual description given by the container
        private string _CodecID_Version;  //Version of the CodecID
        private string _CodecID_Compatible;  //Compatible CodecIDs
        private string _Interleaved;  //If Audio and video are muxed
        private string _Codec;  //Deprecated, do not use in new projects
        private string _CodecString;  //Deprecated, do not use in new projects
        private string _CodecInfo;  //Deprecated, do not use in new projects
        private string _CodecUrl;  //Deprecated, do not use in new projects
        private string _CodecExtensions;  //Deprecated, do not use in new projects
        private string _Codec_Settings;  //Deprecated, do not use in new projects
        private string _Codec_Settings_Automatic;  //Deprecated, do not use in new projects
        private string _FileSize;  //File size in bytes
        private string _FileSizeString;  //File size (with measure)
        private string _FileSizeString1;  //File size (with measure, 1 digit mini)
        private string _FileSizeString2;  //File size (with measure, 2 digit mini)
        private string _FileSizeString3;  //File size (with measure, 3 digit mini)
        private string _FileSizeString4;  //File size (with measure, 4 digit mini)
        private string _Duration;  //Play time of the stream in ms
        private string _DurationString;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString1;  //Play time in format : HHh MMmn SSs MMMms, XX omited if zero
        private string _DurationString2;  //Play time in format : XXx YYy only, YYy omited if zero
        private string _DurationString3;  //Play time in format : HH:MM:SS.MMM
        private string _DurationString4;  //Play time in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _DurationString5;  //Play time in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Duration_Start;  //
        private string _Duration_End;  //
        private string _OverallBitRate_Mode;  //Bit rate mode of all streams (VBR, CBR)
        private string _OverallBitRate_ModeString;  //Bit rate mode of all streams (Variable, Constant)
        private string _OverallBitRate;  //Bit rate of all streams in bps
        private string _OverallBitRateString;  //Bit rate of all streams (with measure)
        private string _OverallBitRate_Minimum;  //Minimum Bit rate in bps
        private string _OverallBitRate_MinimumString;  //Minimum Bit rate (with measurement)
        private string _OverallBitRate_Nominal;  //Nominal Bit rate in bps
        private string _OverallBitRate_NominalString;  //Nominal Bit rate (with measurement)
        private string _OverallBitRate_Maximum;  //Maximum Bit rate in bps
        private string _OverallBitRate_MaximumString;  //Maximum Bit rate (with measurement)
        private string _FrameRate;  //Frames per second
        private string _FrameRateString;  //Frames per second (with measurement)
        private string _FrameRate_Num;  //Frames per second, numerator
        private string _FrameRate_Den;  //Frames per second, denominator
        private string _FrameCount;  //Frame count (a frame contains a count of samples depends of the format)
        private string _Delay;  //Delay fixed in the stream (relative) IN MS
        private string _DelayString;  //Delay with measurement
        private string _DelayString1;  //Delay with measurement
        private string _DelayString2;  //Delay with measurement
        private string _DelayString3;  //format : HH:MM:SS.MMM
        private string _DelayString4;  //Delay in format : HH:MM:SS:FF, last colon replaced by semicolon for drop frame if available
        private string _DelayString5;  //Delay in format : HH:MM:SS.mmm (HH:MM:SS:FF)
        private string _Delay_Settings;  //Delay settings (in case of timecode for example)
        private string _Delay_DropFrame;  //Delay drop frame
        private string _Delay_Source;  //Delay source (Container or Stream or empty)
        private string _Delay_SourceString;  //Delay source (Container or Stream or empty)
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
        private string _HeaderSize;  //
        private string _DataSize;  //
        private string _FooterSize;  //
        private string _IsStreamable;  //
        private string _Album_ReplayGain_Gain;  //The gain to apply to reach 89dB SPL on playback
        private string _Album_ReplayGain_GainString;  //
        private string _Album_ReplayGain_Peak;  //The maximum absolute peak value of the item
        private string _Encryption;  //
        private string _Encryption_Format;  //
        private string _Encryption_Length;  //
        private string _Encryption_Method;  //
        private string _Encryption_Mode;  //
        private string _Encryption_Padding;  //
        private string _Encryption_InitializationVector;  //
        private string _UniversalAdIDString;  //Universal Ad ID, see https://ad-id.org
        private string _UniversalAdID_Registry;  //Universal Ad ID registry
        private string _UniversalAdID_Value;  //Universal Ad ID value
        private string _Title;  //(Generic)Title of file
        private string _Title_More;  //(Generic)More info about the title of file
        private string _TitleUrl;  //(Generic)Url
        private string _Domain;  //Univers movies belong to, e.g. Starwars, Stargate, Buffy, Dragonballs
        private string _Collection;  //Name of the series, e.g. Starwars movies, Stargate SG-1, Stargate Atlantis, Buffy, Angel
        private string _Season;  //Name of the season, e.g. Strawars first Trilogy, Season 1
        private string _Season_Position;  //Number of the Season
        private string _Season_Position_Total;  //Place of the season e.g. 2 of 7
        private string _Movie;  //Name of the movie. Eg : Starwars, a new hope
        private string _Movie_More;  //More infos about the movie
        private string _MovieCountry;  //Country, where the movie was procuced
        private string _MovieUrl;  //Homepage for the movie
        private string _Album;  //Name of an audio-album. Eg : The joshua tree
        private string _Album_More;  //More infos about the album
        private string _AlbumSort;  //
        private string _AlbumPerformer;  //Album performer/artist of this file
        private string _AlbumPerformerSort;  //
        private string _AlbumPerformerUrl;  //Homepage of the album performer/artist
        private string _Comic;  //Name of the comic.
        private string _Comic_More;  //
        private string _ComicPosition_Total;  //
        private string _Part;  //Name of the part. e.g. CD1, CD2
        private string _PartPosition;  //Number of the part
        private string _PartPosition_Total;  //Place of the part e.g. 2 of 3
        private string _Track;  //Name of the track. e.g. track1, track 2
        private string _Track_More;  //More infos about the track
        private string _TrackUrl;  //Link to a site about this track
        private string _TrackSort;  //
        private string _TrackPosition;  //Number of this track
        private string _TrackPosition_Total;  //Place of this track, e.g. 3 of 15
        private string _PackageName;  //Package name i.e. technical flavor of the content
        private string _Grouping;  //iTunes grouping
        private string _Chapter;  //Name of the chapter.
        private string _SubTrack;  //Name of the subtrack.
        private string _OriginalAlbum;  //Original name of album, serie...
        private string _OriginalMovie;  //Original name of the movie
        private string _OriginalPart;  //Original name of the part in the original support
        private string _OriginalTrack;  //Original name of the track in the original support
        private string _Compilation;  //iTunes compilation
        private string _CompilationString;  //iTunes compilation
        private string _Performer;  //Main performer/artist of this file
        private string _PerformerSort;  //
        private string _PerformerUrl;  //Homepage of the performer/artist
        private string _OriginalPerformer;  //Original artist(s)/performer(s).
        private string _Accompaniment;  //Band/orchestra/accompaniment/musician.
        private string _Composer;  //Name of the original composer.
        private string _ComposerNationality;  //Nationality of the main composer of the item, mostly for classical music.
        private string _ComposerSort;  //
        private string _Arranger;  //The person who arranged the piece. e.g. Ravel.
        private string _Lyricist;  //The person who wrote the lyrics for a musical item.
        private string _OriginalLyricist;  //Original lyricist(s)/text writer(s).
        private string _Conductor;  //The artist(s) who performed the work. In classical music this would be the conductor, orchestra, soloists.
        private string _Director;  //Name of the director.
        private string _CoDirector;  //Name of the codirector.
        private string _AssistantDirector;  //Name of the assistant director.
        private string _DirectorOfPhotography;  //The name of the director of photography, also known as cinematographer.
        private string _SoundEngineer;  //The name of the sound engineer or sound recordist.
        private string _ArtDirector;  //The person who oversees the artists and craftspeople who build the sets.
        private string _ProductionDesigner;  //The person responsible for designing the Overall visual appearance of a movie.
        private string _Choregrapher;  //The name of the choregrapher.
        private string _CostumeDesigner;  //The name of the costume designer.
        private string _Actor;  //Real name of an actor or actress playing a role in the movie.
        private string _Actor_Character;  //Name of the character an actor or actress plays in this movie.
        private string _WrittenBy;  //The author of the story or script.
        private string _ScreenplayBy;  //The author of the screenplay or scenario (used for movies and TV shows).
        private string _EditedBy;  //Editors name
        private string _CommissionedBy;  //name of the person or organization that commissioned the subject of the file
        private string _Producer;  //Name of the producer of the movie.
        private string _CoProducer;  //The name of a co-producer.
        private string _ExecutiveProducer;  //The name of an executive producer.
        private string _MusicBy;  //Main music-artist for a movie
        private string _DistributedBy;  //Company the item is mainly distributed by 
        private string _OriginalSourceFormDistributedBy;  //Name of the person or organization who supplied the original subjecTY
        private string _MasteredBy;  //The engineer who mastered the content for a physical medium or for digital distribution.
        private string _EncodedBy;  //Name of the person or organisation that encoded/ripped the audio file.
        private string _RemixedBy;  //Name of the artist(s), that interpreted, remixed, or otherwise modified the item.
        private string _ProductionStudio;  //Main production studio 
        private string _ThanksTo;  //A very general tag for everyone else that wants to be listed.
        private string _Publisher;  //Name of the organization publishing the album (i.e. the 'record label') or movie.
        private string _PublisherURL;  //Publishers official webpage.
        private string _Label;  //Brand or trademark associated with the marketing of music recordings and music videos.
        private string _Genre;  //The main genre of the audio or video. e.g. classical, ambient-house, synthpop, sci-fi, drama, etc.
        private string _PodcastCategory;  //Podcast category
        private string _Mood;  //Intended to reflect the mood of the item with a few keywords, e.g. Romantic, Sad, Uplifting, etc.
        private string _ContentType;  //The type of the item. e.g. Documentary, Feature Film, Cartoon, Music Video, Music, Sound FX, etc.
        private string _Subject;  //Describes the topic of the file, such as Aerial view of Seattle..
        private string _Description;  //A short description of the contents, such as Two birds flying.
        private string _Keywords;  //Keywords to the item separated by a comma, used for searching.
        private string _Summary;  //A plot outline or a summary of the story.
        private string _Synopsis;  //A description of the story line of the item.
        private string _Period;  //Describes the period that the piece is from or about. e.g. Renaissance.
        private string _LawRating;  //Depending on the country it's the format of the rating of a movie (P, R, X in the USA, an age in other countries or a URI defining a logo).
        private string _LawRating_Reason;  //Reason for the law rating
        private string _ICRA;  //The ICRA rating. (Previously RSACi)
        private string _Released_Date;  //The date/year that the item was released.
        private string _OriginalReleased_Date;  //The date/year that the item was originaly released.
        private string _Recorded_Date;  //The time/date/year that the recording began.
        private string _Encoded_Date;  //The time/date/year that the encoding of this item was completed began.
        private string _Tagged_Date;  //The time/date/year that the tags were done for this item.
        private string _Written_Date;  //The time/date/year that the composition of the music/script began.
        private string _Mastered_Date;  //The time/date/year that the item was tranfered to a digitalmedium.
        private string _File_Created_Date;  //The time that the file was created on the file system
        private string _File_Created_Date_Local;  //The time that the file was created on the file system (Warning: this field depends of local configuration, do not use it in an international database)
        private string _File_Modified_Date;  //The time that the file was modified on the file system
        private string _File_Modified_Date_Local;  //The time that the file was modified on the file system (Warning: this field depends of local configuration, do not use it in an international database)
        private string _Recorded_Location;  //Location where track was recorded. (See COMPOSITION_LOCATION for format)
        private string _Written_Location;  //Location that the item was originaly designed/written. Information should be stored in the following format: country code, state/province, city where the coutry code is the same 2 octets as in Internet domains, or possibly ISO-3166. e.g. US, Texas, Austin or US, , Austin.
        private string _Archival_Location;  //Location, where an item is archived, e.eg. Louvre,Paris,France
        private string _Encoded_Application;  //Name of the software package used to create the file, such as Microsoft WaveEdiTY
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
        private string _Cropped;  //Describes whether an image has been cropped and, if so, how it was cropped.
        private string _Dimensions;  //Specifies the size of the original subject of the file. eg 8.5 in h, 11 in w
        private string _DotsPerInch;  //Stores dots per inch setting of the digitizer used to produce the file
        private string _Lightness;  //Describes the changes in lightness settings on the digitizer required to produce the file
        private string _OriginalSourceMedium;  //Original medium of the material, e.g. vinyl, Audio-CD, Super8 or BetaMax
        private string _OriginalSourceForm;  //Original form of the material, e.g. slide, paper, map
        private string _OriginalSourceFormNumColors;  //Number of colors requested when digitizing, e.g. 256 for images or 32 bit RGB for video
        private string _OriginalSourceFormName;  //Name of the product the file was originally intended for
        private string _OriginalSourceFormCropped;  //Describes whether an image has been cropped and, if so, how it was cropped. e.g. 16:9 to 4:3, top and bottom
        private string _OriginalSourceFormSharpness;  //Identifies the changes in sharpness for the digitizer requiered to produce the file
        private string _Tagged_Application;  //Software used to tag this file
        private string _BPM;  //Average number of beats per minute
        private string _ISRC;  //International Standard Recording Code, excluding the ISRC prefix and including hyphens.
        private string _ISBN;  //International Standard Book Number.
        private string _BarCode;  //EAN-13 (13-digit European Article Numbering) or UPC-A (12-digit Universal Product Code) bar code identifier.
        private string _LCCN;  //Library of Congress Control Number.
        private string _CatalogNumber;  //A label-specific catalogue number used to identify the release. e.g. TIC 01.
        private string _LabelCode;  //A 4-digit or 5-digit number to identify the record label, typically printed as (LC) xxxx or (LC) 0xxxx on CDs medias or covers, with only the number being stored.
        private string _Owner;  //Owner of the file
        private string _Copyright;  //Copyright attribution.
        private string _CopyrightUrl;  //Link to a site with copyright/legal information.
        private string _Producer_Copyright;  //The copyright information as per the productioncopyright holder.
        private string _TermsOfUse;  //License information, e.g., All Rights Reserved,Any Use Permitted.
        private string _ServiceName;  //
        private string _ServiceChannel;  //
        private string _ServiceUrl;  //
        private string _ServiceProvider;  //
        private string _ServiceProviderUrl;  //
        private string _ServiceType;  //
        private string _NetworkName;  //
        private string _OriginalNetworkName;  //
        private string _Country;  //
        private string _TimeZone;  //
        private string _Cover;  //Is there a cover
        private string _Cover_Description;  //short descriptio, e.g. Earth in space
        private string _Cover_Type;  //
        private string _Cover_Mime;  //
        private string _Cover_Data;  //Cover, in binary format encoded BASE64
        private string _Lyrics;  //Text of a song
        private string _Comment;  //Any comment related to the content.
        private string _Rating;  //A numeric value defining how much a person likes the song/movie. The number is between 0 and 5 with decimal values possible (e.g. 2.7), 5(.0) being the highest possible rating.
        private string _Added_Date;  //Date/year the item was added to the owners collection
        private string _Played_First_Date;  //The date, the owner first played an item
        private string _Played_Last_Date;  //The date, the owner last played an item
        private string _Played_Count;  //Number of times an item was played
        private string _EPG_Positions_Begin;  //
        private string _EPG_Positions_End;  //

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
        public string GeneralCount { get { if (string.IsNullOrEmpty(this._GeneralCount)) { this._GeneralCount = ""; } return this._GeneralCount; } set { this._GeneralCount = value; } }
        public string VideoCount { get { if (string.IsNullOrEmpty(this._VideoCount)) { this._VideoCount = ""; } return this._VideoCount; } set { this._VideoCount = value; } }
        public string AudioCount { get { if (string.IsNullOrEmpty(this._AudioCount)) { this._AudioCount = ""; } return this._AudioCount; } set { this._AudioCount = value; } }
        public string TextCount { get { if (string.IsNullOrEmpty(this._TextCount)) { this._TextCount = ""; } return this._TextCount; } set { this._TextCount = value; } }
        public string OtherCount { get { if (string.IsNullOrEmpty(this._OtherCount)) { this._OtherCount = ""; } return this._OtherCount; } set { this._OtherCount = value; } }
        public string ImageCount { get { if (string.IsNullOrEmpty(this._ImageCount)) { this._ImageCount = ""; } return this._ImageCount; } set { this._ImageCount = value; } }
        public string MenuCount { get { if (string.IsNullOrEmpty(this._MenuCount)) { this._MenuCount = ""; } return this._MenuCount; } set { this._MenuCount = value; } }
        public string Video_Format_List { get { if (string.IsNullOrEmpty(this._Video_Format_List)) { this._Video_Format_List = ""; } return this._Video_Format_List; } set { this._Video_Format_List = value; } }
        public string Video_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Video_Format_WithHint_List)) { this._Video_Format_WithHint_List = ""; } return this._Video_Format_WithHint_List; } set { this._Video_Format_WithHint_List = value; } }
        public string Video_Codec_List { get { if (string.IsNullOrEmpty(this._Video_Codec_List)) { this._Video_Codec_List = ""; } return this._Video_Codec_List; } set { this._Video_Codec_List = value; } }
        public string Video_Language_List { get { if (string.IsNullOrEmpty(this._Video_Language_List)) { this._Video_Language_List = ""; } return this._Video_Language_List; } set { this._Video_Language_List = value; } }
        public string Audio_Format_List { get { if (string.IsNullOrEmpty(this._Audio_Format_List)) { this._Audio_Format_List = ""; } return this._Audio_Format_List; } set { this._Audio_Format_List = value; } }
        public string Audio_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Audio_Format_WithHint_List)) { this._Audio_Format_WithHint_List = ""; } return this._Audio_Format_WithHint_List; } set { this._Audio_Format_WithHint_List = value; } }
        public string Audio_Codec_List { get { if (string.IsNullOrEmpty(this._Audio_Codec_List)) { this._Audio_Codec_List = ""; } return this._Audio_Codec_List; } set { this._Audio_Codec_List = value; } }
        public string Audio_Language_List { get { if (string.IsNullOrEmpty(this._Audio_Language_List)) { this._Audio_Language_List = ""; } return this._Audio_Language_List; } set { this._Audio_Language_List = value; } }
        public string Text_Format_List { get { if (string.IsNullOrEmpty(this._Text_Format_List)) { this._Text_Format_List = ""; } return this._Text_Format_List; } set { this._Text_Format_List = value; } }
        public string Text_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Text_Format_WithHint_List)) { this._Text_Format_WithHint_List = ""; } return this._Text_Format_WithHint_List; } set { this._Text_Format_WithHint_List = value; } }
        public string Text_Codec_List { get { if (string.IsNullOrEmpty(this._Text_Codec_List)) { this._Text_Codec_List = ""; } return this._Text_Codec_List; } set { this._Text_Codec_List = value; } }
        public string Text_Language_List { get { if (string.IsNullOrEmpty(this._Text_Language_List)) { this._Text_Language_List = ""; } return this._Text_Language_List; } set { this._Text_Language_List = value; } }
        public string Other_Format_List { get { if (string.IsNullOrEmpty(this._Other_Format_List)) { this._Other_Format_List = ""; } return this._Other_Format_List; } set { this._Other_Format_List = value; } }
        public string Other_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Other_Format_WithHint_List)) { this._Other_Format_WithHint_List = ""; } return this._Other_Format_WithHint_List; } set { this._Other_Format_WithHint_List = value; } }
        public string Other_Codec_List { get { if (string.IsNullOrEmpty(this._Other_Codec_List)) { this._Other_Codec_List = ""; } return this._Other_Codec_List; } set { this._Other_Codec_List = value; } }
        public string Other_Language_List { get { if (string.IsNullOrEmpty(this._Other_Language_List)) { this._Other_Language_List = ""; } return this._Other_Language_List; } set { this._Other_Language_List = value; } }
        public string Image_Format_List { get { if (string.IsNullOrEmpty(this._Image_Format_List)) { this._Image_Format_List = ""; } return this._Image_Format_List; } set { this._Image_Format_List = value; } }
        public string Image_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Image_Format_WithHint_List)) { this._Image_Format_WithHint_List = ""; } return this._Image_Format_WithHint_List; } set { this._Image_Format_WithHint_List = value; } }
        public string Image_Codec_List { get { if (string.IsNullOrEmpty(this._Image_Codec_List)) { this._Image_Codec_List = ""; } return this._Image_Codec_List; } set { this._Image_Codec_List = value; } }
        public string Image_Language_List { get { if (string.IsNullOrEmpty(this._Image_Language_List)) { this._Image_Language_List = ""; } return this._Image_Language_List; } set { this._Image_Language_List = value; } }
        public string Menu_Format_List { get { if (string.IsNullOrEmpty(this._Menu_Format_List)) { this._Menu_Format_List = ""; } return this._Menu_Format_List; } set { this._Menu_Format_List = value; } }
        public string Menu_Format_WithHint_List { get { if (string.IsNullOrEmpty(this._Menu_Format_WithHint_List)) { this._Menu_Format_WithHint_List = ""; } return this._Menu_Format_WithHint_List; } set { this._Menu_Format_WithHint_List = value; } }
        public string Menu_Codec_List { get { if (string.IsNullOrEmpty(this._Menu_Codec_List)) { this._Menu_Codec_List = ""; } return this._Menu_Codec_List; } set { this._Menu_Codec_List = value; } }
        public string Menu_Language_List { get { if (string.IsNullOrEmpty(this._Menu_Language_List)) { this._Menu_Language_List = ""; } return this._Menu_Language_List; } set { this._Menu_Language_List = value; } }
        public string CompleteName { get { if (string.IsNullOrEmpty(this._CompleteName)) { this._CompleteName = ""; } return this._CompleteName; } set { this._CompleteName = value; } }
        public string FolderName { get { if (string.IsNullOrEmpty(this._FolderName)) { this._FolderName = ""; } return this._FolderName; } set { this._FolderName = value; } }
        public string FileName { get { if (string.IsNullOrEmpty(this._FileName)) { this._FileName = ""; } return this._FileName; } set { this._FileName = value; } }
        public string FileExtension { get { if (string.IsNullOrEmpty(this._FileExtension)) { this._FileExtension = ""; } return this._FileExtension; } set { this._FileExtension = value; } }
        public string CompleteName_Last { get { if (string.IsNullOrEmpty(this._CompleteName_Last)) { this._CompleteName_Last = ""; } return this._CompleteName_Last; } set { this._CompleteName_Last = value; } }
        public string FolderName_Last { get { if (string.IsNullOrEmpty(this._FolderName_Last)) { this._FolderName_Last = ""; } return this._FolderName_Last; } set { this._FolderName_Last = value; } }
        public string FileName_Last { get { if (string.IsNullOrEmpty(this._FileName_Last)) { this._FileName_Last = ""; } return this._FileName_Last; } set { this._FileName_Last = value; } }
        public string FileExtension_Last { get { if (string.IsNullOrEmpty(this._FileExtension_Last)) { this._FileExtension_Last = ""; } return this._FileExtension_Last; } set { this._FileExtension_Last = value; } }
        public string Format { get { if (string.IsNullOrEmpty(this._Format)) { this._Format = ""; } return this._Format; } set { this._Format = value; } }
        public string FormatString { get { if (string.IsNullOrEmpty(this._FormatString)) { this._FormatString = ""; } return this._FormatString; } set { this._FormatString = value; } }
        public string FormatInfo { get { if (string.IsNullOrEmpty(this._FormatInfo)) { this._FormatInfo = ""; } return this._FormatInfo; } set { this._FormatInfo = value; } }
        public string FormatUrl { get { if (string.IsNullOrEmpty(this._FormatUrl)) { this._FormatUrl = ""; } return this._FormatUrl; } set { this._FormatUrl = value; } }
        public string FormatExtensions { get { if (string.IsNullOrEmpty(this._FormatExtensions)) { this._FormatExtensions = ""; } return this._FormatExtensions; } set { this._FormatExtensions = value; } }
        public string Format_Commercial { get { if (string.IsNullOrEmpty(this._Format_Commercial)) { this._Format_Commercial = ""; } return this._Format_Commercial; } set { this._Format_Commercial = value; } }
        public string Format_Commercial_IfAny { get { if (string.IsNullOrEmpty(this._Format_Commercial_IfAny)) { this._Format_Commercial_IfAny = ""; } return this._Format_Commercial_IfAny; } set { this._Format_Commercial_IfAny = value; } }
        public string Format_Version { get { if (string.IsNullOrEmpty(this._Format_Version)) { this._Format_Version = ""; } return this._Format_Version; } set { this._Format_Version = value; } }
        public string Format_Profile { get { if (string.IsNullOrEmpty(this._Format_Profile)) { this._Format_Profile = ""; } return this._Format_Profile; } set { this._Format_Profile = value; } }
        public string Format_Level { get { if (string.IsNullOrEmpty(this._Format_Level)) { this._Format_Level = ""; } return this._Format_Level; } set { this._Format_Level = value; } }
        public string Format_Compression { get { if (string.IsNullOrEmpty(this._Format_Compression)) { this._Format_Compression = ""; } return this._Format_Compression; } set { this._Format_Compression = value; } }
        public string Format_Settings { get { if (string.IsNullOrEmpty(this._Format_Settings)) { this._Format_Settings = ""; } return this._Format_Settings; } set { this._Format_Settings = value; } }
        public string InternetMediaType { get { if (string.IsNullOrEmpty(this._InternetMediaType)) { this._InternetMediaType = ""; } return this._InternetMediaType; } set { this._InternetMediaType = value; } }
        public string CodecID { get { if (string.IsNullOrEmpty(this._CodecID)) { this._CodecID = ""; } return this._CodecID; } set { this._CodecID = value; } }
        public string CodecIDString { get { if (string.IsNullOrEmpty(this._CodecIDString)) { this._CodecIDString = ""; } return this._CodecIDString; } set { this._CodecIDString = value; } }
        public string CodecIDInfo { get { if (string.IsNullOrEmpty(this._CodecIDInfo)) { this._CodecIDInfo = ""; } return this._CodecIDInfo; } set { this._CodecIDInfo = value; } }
        public string CodecIDHint { get { if (string.IsNullOrEmpty(this._CodecIDHint)) { this._CodecIDHint = ""; } return this._CodecIDHint; } set { this._CodecIDHint = value; } }
        public string CodecIDUrl { get { if (string.IsNullOrEmpty(this._CodecIDUrl)) { this._CodecIDUrl = ""; } return this._CodecIDUrl; } set { this._CodecIDUrl = value; } }
        public string CodecID_Description { get { if (string.IsNullOrEmpty(this._CodecID_Description)) { this._CodecID_Description = ""; } return this._CodecID_Description; } set { this._CodecID_Description = value; } }
        public string CodecID_Version { get { if (string.IsNullOrEmpty(this._CodecID_Version)) { this._CodecID_Version = ""; } return this._CodecID_Version; } set { this._CodecID_Version = value; } }
        public string CodecID_Compatible { get { if (string.IsNullOrEmpty(this._CodecID_Compatible)) { this._CodecID_Compatible = ""; } return this._CodecID_Compatible; } set { this._CodecID_Compatible = value; } }
        public string Interleaved { get { if (string.IsNullOrEmpty(this._Interleaved)) { this._Interleaved = ""; } return this._Interleaved; } set { this._Interleaved = value; } }
        public string Codec { get { if (string.IsNullOrEmpty(this._Codec)) { this._Codec = ""; } return this._Codec; } set { this._Codec = value; } }
        public string CodecString { get { if (string.IsNullOrEmpty(this._CodecString)) { this._CodecString = ""; } return this._CodecString; } set { this._CodecString = value; } }
        public string CodecInfo { get { if (string.IsNullOrEmpty(this._CodecInfo)) { this._CodecInfo = ""; } return this._CodecInfo; } set { this._CodecInfo = value; } }
        public string CodecUrl { get { if (string.IsNullOrEmpty(this._CodecUrl)) { this._CodecUrl = ""; } return this._CodecUrl; } set { this._CodecUrl = value; } }
        public string CodecExtensions { get { if (string.IsNullOrEmpty(this._CodecExtensions)) { this._CodecExtensions = ""; } return this._CodecExtensions; } set { this._CodecExtensions = value; } }
        public string Codec_Settings { get { if (string.IsNullOrEmpty(this._Codec_Settings)) { this._Codec_Settings = ""; } return this._Codec_Settings; } set { this._Codec_Settings = value; } }
        public string Codec_Settings_Automatic { get { if (string.IsNullOrEmpty(this._Codec_Settings_Automatic)) { this._Codec_Settings_Automatic = ""; } return this._Codec_Settings_Automatic; } set { this._Codec_Settings_Automatic = value; } }
        public string FileSize { get { if (string.IsNullOrEmpty(this._FileSize)) { this._FileSize = ""; } return this._FileSize; } set { this._FileSize = value; } }
        public string FileSizeString { get { if (string.IsNullOrEmpty(this._FileSizeString)) { this._FileSizeString = ""; } return this._FileSizeString; } set { this._FileSizeString = value; } }
        public string FileSizeString1 { get { if (string.IsNullOrEmpty(this._FileSizeString1)) { this._FileSizeString1 = ""; } return this._FileSizeString1; } set { this._FileSizeString1 = value; } }
        public string FileSizeString2 { get { if (string.IsNullOrEmpty(this._FileSizeString2)) { this._FileSizeString2 = ""; } return this._FileSizeString2; } set { this._FileSizeString2 = value; } }
        public string FileSizeString3 { get { if (string.IsNullOrEmpty(this._FileSizeString3)) { this._FileSizeString3 = ""; } return this._FileSizeString3; } set { this._FileSizeString3 = value; } }
        public string FileSizeString4 { get { if (string.IsNullOrEmpty(this._FileSizeString4)) { this._FileSizeString4 = ""; } return this._FileSizeString4; } set { this._FileSizeString4 = value; } }
        public string Duration { get { if (string.IsNullOrEmpty(this._Duration)) { this._Duration = ""; } return this._Duration; } set { this._Duration = value; } }
        public string DurationString { get { if (string.IsNullOrEmpty(this._DurationString)) { this._DurationString = ""; } return this._DurationString; } set { this._DurationString = value; } }
        public string DurationString1 { get { if (string.IsNullOrEmpty(this._DurationString1)) { this._DurationString1 = ""; } return this._DurationString1; } set { this._DurationString1 = value; } }
        public string DurationString2 { get { if (string.IsNullOrEmpty(this._DurationString2)) { this._DurationString2 = ""; } return this._DurationString2; } set { this._DurationString2 = value; } }
        public string DurationString3 { get { if (string.IsNullOrEmpty(this._DurationString3)) { this._DurationString3 = ""; } return this._DurationString3; } set { this._DurationString3 = value; } }
        public string DurationString4 { get { if (string.IsNullOrEmpty(this._DurationString4)) { this._DurationString4 = ""; } return this._DurationString4; } set { this._DurationString4 = value; } }
        public string DurationString5 { get { if (string.IsNullOrEmpty(this._DurationString5)) { this._DurationString5 = ""; } return this._DurationString5; } set { this._DurationString5 = value; } }
        public string Duration_Start { get { if (string.IsNullOrEmpty(this._Duration_Start)) { this._Duration_Start = ""; } return this._Duration_Start; } set { this._Duration_Start = value; } }
        public string Duration_End { get { if (string.IsNullOrEmpty(this._Duration_End)) { this._Duration_End = ""; } return this._Duration_End; } set { this._Duration_End = value; } }
        public string OverallBitRate_Mode { get { if (string.IsNullOrEmpty(this._OverallBitRate_Mode)) { this._OverallBitRate_Mode = ""; } return this._OverallBitRate_Mode; } set { this._OverallBitRate_Mode = value; } }
        public string OverallBitRate_ModeString { get { if (string.IsNullOrEmpty(this._OverallBitRate_ModeString)) { this._OverallBitRate_ModeString = ""; } return this._OverallBitRate_ModeString; } set { this._OverallBitRate_ModeString = value; } }
        public string OverallBitRate { get { if (string.IsNullOrEmpty(this._OverallBitRate)) { this._OverallBitRate = ""; } return this._OverallBitRate; } set { this._OverallBitRate = value; } }
        public string OverallBitRateString { get { if (string.IsNullOrEmpty(this._OverallBitRateString)) { this._OverallBitRateString = ""; } return this._OverallBitRateString; } set { this._OverallBitRateString = value; } }
        public string OverallBitRate_Minimum { get { if (string.IsNullOrEmpty(this._OverallBitRate_Minimum)) { this._OverallBitRate_Minimum = ""; } return this._OverallBitRate_Minimum; } set { this._OverallBitRate_Minimum = value; } }
        public string OverallBitRate_MinimumString { get { if (string.IsNullOrEmpty(this._OverallBitRate_MinimumString)) { this._OverallBitRate_MinimumString = ""; } return this._OverallBitRate_MinimumString; } set { this._OverallBitRate_MinimumString = value; } }
        public string OverallBitRate_Nominal { get { if (string.IsNullOrEmpty(this._OverallBitRate_Nominal)) { this._OverallBitRate_Nominal = ""; } return this._OverallBitRate_Nominal; } set { this._OverallBitRate_Nominal = value; } }
        public string OverallBitRate_NominalString { get { if (string.IsNullOrEmpty(this._OverallBitRate_NominalString)) { this._OverallBitRate_NominalString = ""; } return this._OverallBitRate_NominalString; } set { this._OverallBitRate_NominalString = value; } }
        public string OverallBitRate_Maximum { get { if (string.IsNullOrEmpty(this._OverallBitRate_Maximum)) { this._OverallBitRate_Maximum = ""; } return this._OverallBitRate_Maximum; } set { this._OverallBitRate_Maximum = value; } }
        public string OverallBitRate_MaximumString { get { if (string.IsNullOrEmpty(this._OverallBitRate_MaximumString)) { this._OverallBitRate_MaximumString = ""; } return this._OverallBitRate_MaximumString; } set { this._OverallBitRate_MaximumString = value; } }
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
        public string HeaderSize { get { if (string.IsNullOrEmpty(this._HeaderSize)) { this._HeaderSize = ""; } return this._HeaderSize; } set { this._HeaderSize = value; } }
        public string DataSize { get { if (string.IsNullOrEmpty(this._DataSize)) { this._DataSize = ""; } return this._DataSize; } set { this._DataSize = value; } }
        public string FooterSize { get { if (string.IsNullOrEmpty(this._FooterSize)) { this._FooterSize = ""; } return this._FooterSize; } set { this._FooterSize = value; } }
        public string IsStreamable { get { if (string.IsNullOrEmpty(this._IsStreamable)) { this._IsStreamable = ""; } return this._IsStreamable; } set { this._IsStreamable = value; } }
        public string Album_ReplayGain_Gain { get { if (string.IsNullOrEmpty(this._Album_ReplayGain_Gain)) { this._Album_ReplayGain_Gain = ""; } return this._Album_ReplayGain_Gain; } set { this._Album_ReplayGain_Gain = value; } }
        public string Album_ReplayGain_GainString { get { if (string.IsNullOrEmpty(this._Album_ReplayGain_GainString)) { this._Album_ReplayGain_GainString = ""; } return this._Album_ReplayGain_GainString; } set { this._Album_ReplayGain_GainString = value; } }
        public string Album_ReplayGain_Peak { get { if (string.IsNullOrEmpty(this._Album_ReplayGain_Peak)) { this._Album_ReplayGain_Peak = ""; } return this._Album_ReplayGain_Peak; } set { this._Album_ReplayGain_Peak = value; } }
        public string Encryption { get { if (string.IsNullOrEmpty(this._Encryption)) { this._Encryption = ""; } return this._Encryption; } set { this._Encryption = value; } }
        public string Encryption_Format { get { if (string.IsNullOrEmpty(this._Encryption_Format)) { this._Encryption_Format = ""; } return this._Encryption_Format; } set { this._Encryption_Format = value; } }
        public string Encryption_Length { get { if (string.IsNullOrEmpty(this._Encryption_Length)) { this._Encryption_Length = ""; } return this._Encryption_Length; } set { this._Encryption_Length = value; } }
        public string Encryption_Method { get { if (string.IsNullOrEmpty(this._Encryption_Method)) { this._Encryption_Method = ""; } return this._Encryption_Method; } set { this._Encryption_Method = value; } }
        public string Encryption_Mode { get { if (string.IsNullOrEmpty(this._Encryption_Mode)) { this._Encryption_Mode = ""; } return this._Encryption_Mode; } set { this._Encryption_Mode = value; } }
        public string Encryption_Padding { get { if (string.IsNullOrEmpty(this._Encryption_Padding)) { this._Encryption_Padding = ""; } return this._Encryption_Padding; } set { this._Encryption_Padding = value; } }
        public string Encryption_InitializationVector { get { if (string.IsNullOrEmpty(this._Encryption_InitializationVector)) { this._Encryption_InitializationVector = ""; } return this._Encryption_InitializationVector; } set { this._Encryption_InitializationVector = value; } }
        public string UniversalAdIDString { get { if (string.IsNullOrEmpty(this._UniversalAdIDString)) { this._UniversalAdIDString = ""; } return this._UniversalAdIDString; } set { this._UniversalAdIDString = value; } }
        public string UniversalAdID_Registry { get { if (string.IsNullOrEmpty(this._UniversalAdID_Registry)) { this._UniversalAdID_Registry = ""; } return this._UniversalAdID_Registry; } set { this._UniversalAdID_Registry = value; } }
        public string UniversalAdID_Value { get { if (string.IsNullOrEmpty(this._UniversalAdID_Value)) { this._UniversalAdID_Value = ""; } return this._UniversalAdID_Value; } set { this._UniversalAdID_Value = value; } }
        public string Title { get { if (string.IsNullOrEmpty(this._Title)) { this._Title = ""; } return this._Title; } set { this._Title = value; } }
        public string Title_More { get { if (string.IsNullOrEmpty(this._Title_More)) { this._Title_More = ""; } return this._Title_More; } set { this._Title_More = value; } }
        public string TitleUrl { get { if (string.IsNullOrEmpty(this._TitleUrl)) { this._TitleUrl = ""; } return this._TitleUrl; } set { this._TitleUrl = value; } }
        public string Domain { get { if (string.IsNullOrEmpty(this._Domain)) { this._Domain = ""; } return this._Domain; } set { this._Domain = value; } }
        public string Collection { get { if (string.IsNullOrEmpty(this._Collection)) { this._Collection = ""; } return this._Collection; } set { this._Collection = value; } }
        public string Season { get { if (string.IsNullOrEmpty(this._Season)) { this._Season = ""; } return this._Season; } set { this._Season = value; } }
        public string Season_Position { get { if (string.IsNullOrEmpty(this._Season_Position)) { this._Season_Position = ""; } return this._Season_Position; } set { this._Season_Position = value; } }
        public string Season_Position_Total { get { if (string.IsNullOrEmpty(this._Season_Position_Total)) { this._Season_Position_Total = ""; } return this._Season_Position_Total; } set { this._Season_Position_Total = value; } }
        public string Movie { get { if (string.IsNullOrEmpty(this._Movie)) { this._Movie = ""; } return this._Movie; } set { this._Movie = value; } }
        public string Movie_More { get { if (string.IsNullOrEmpty(this._Movie_More)) { this._Movie_More = ""; } return this._Movie_More; } set { this._Movie_More = value; } }
        public string MovieCountry { get { if (string.IsNullOrEmpty(this._MovieCountry)) { this._MovieCountry = ""; } return this._MovieCountry; } set { this._MovieCountry = value; } }
        public string MovieUrl { get { if (string.IsNullOrEmpty(this._MovieUrl)) { this._MovieUrl = ""; } return this._MovieUrl; } set { this._MovieUrl = value; } }
        public string Album { get { if (string.IsNullOrEmpty(this._Album)) { this._Album = ""; } return this._Album; } set { this._Album = value; } }
        public string Album_More { get { if (string.IsNullOrEmpty(this._Album_More)) { this._Album_More = ""; } return this._Album_More; } set { this._Album_More = value; } }
        public string AlbumSort { get { if (string.IsNullOrEmpty(this._AlbumSort)) { this._AlbumSort = ""; } return this._AlbumSort; } set { this._AlbumSort = value; } }
        public string AlbumPerformer { get { if (string.IsNullOrEmpty(this._AlbumPerformer)) { this._AlbumPerformer = ""; } return this._AlbumPerformer; } set { this._AlbumPerformer = value; } }
        public string AlbumPerformerSort { get { if (string.IsNullOrEmpty(this._AlbumPerformerSort)) { this._AlbumPerformerSort = ""; } return this._AlbumPerformerSort; } set { this._AlbumPerformerSort = value; } }
        public string AlbumPerformerUrl { get { if (string.IsNullOrEmpty(this._AlbumPerformerUrl)) { this._AlbumPerformerUrl = ""; } return this._AlbumPerformerUrl; } set { this._AlbumPerformerUrl = value; } }
        public string Comic { get { if (string.IsNullOrEmpty(this._Comic)) { this._Comic = ""; } return this._Comic; } set { this._Comic = value; } }
        public string Comic_More { get { if (string.IsNullOrEmpty(this._Comic_More)) { this._Comic_More = ""; } return this._Comic_More; } set { this._Comic_More = value; } }
        public string ComicPosition_Total { get { if (string.IsNullOrEmpty(this._ComicPosition_Total)) { this._ComicPosition_Total = ""; } return this._ComicPosition_Total; } set { this._ComicPosition_Total = value; } }
        public string Part { get { if (string.IsNullOrEmpty(this._Part)) { this._Part = ""; } return this._Part; } set { this._Part = value; } }
        public string PartPosition { get { if (string.IsNullOrEmpty(this._PartPosition)) { this._PartPosition = ""; } return this._PartPosition; } set { this._PartPosition = value; } }
        public string PartPosition_Total { get { if (string.IsNullOrEmpty(this._PartPosition_Total)) { this._PartPosition_Total = ""; } return this._PartPosition_Total; } set { this._PartPosition_Total = value; } }
        public string Track { get { if (string.IsNullOrEmpty(this._Track)) { this._Track = ""; } return this._Track; } set { this._Track = value; } }
        public string Track_More { get { if (string.IsNullOrEmpty(this._Track_More)) { this._Track_More = ""; } return this._Track_More; } set { this._Track_More = value; } }
        public string TrackUrl { get { if (string.IsNullOrEmpty(this._TrackUrl)) { this._TrackUrl = ""; } return this._TrackUrl; } set { this._TrackUrl = value; } }
        public string TrackSort { get { if (string.IsNullOrEmpty(this._TrackSort)) { this._TrackSort = ""; } return this._TrackSort; } set { this._TrackSort = value; } }
        public string TrackPosition { get { if (string.IsNullOrEmpty(this._TrackPosition)) { this._TrackPosition = ""; } return this._TrackPosition; } set { this._TrackPosition = value; } }
        public string TrackPosition_Total { get { if (string.IsNullOrEmpty(this._TrackPosition_Total)) { this._TrackPosition_Total = ""; } return this._TrackPosition_Total; } set { this._TrackPosition_Total = value; } }
        public string PackageName { get { if (string.IsNullOrEmpty(this._PackageName)) { this._PackageName = ""; } return this._PackageName; } set { this._PackageName = value; } }
        public string Grouping { get { if (string.IsNullOrEmpty(this._Grouping)) { this._Grouping = ""; } return this._Grouping; } set { this._Grouping = value; } }
        public string Chapter { get { if (string.IsNullOrEmpty(this._Chapter)) { this._Chapter = ""; } return this._Chapter; } set { this._Chapter = value; } }
        public string SubTrack { get { if (string.IsNullOrEmpty(this._SubTrack)) { this._SubTrack = ""; } return this._SubTrack; } set { this._SubTrack = value; } }
        public string OriginalAlbum { get { if (string.IsNullOrEmpty(this._OriginalAlbum)) { this._OriginalAlbum = ""; } return this._OriginalAlbum; } set { this._OriginalAlbum = value; } }
        public string OriginalMovie { get { if (string.IsNullOrEmpty(this._OriginalMovie)) { this._OriginalMovie = ""; } return this._OriginalMovie; } set { this._OriginalMovie = value; } }
        public string OriginalPart { get { if (string.IsNullOrEmpty(this._OriginalPart)) { this._OriginalPart = ""; } return this._OriginalPart; } set { this._OriginalPart = value; } }
        public string OriginalTrack { get { if (string.IsNullOrEmpty(this._OriginalTrack)) { this._OriginalTrack = ""; } return this._OriginalTrack; } set { this._OriginalTrack = value; } }
        public string Compilation { get { if (string.IsNullOrEmpty(this._Compilation)) { this._Compilation = ""; } return this._Compilation; } set { this._Compilation = value; } }
        public string CompilationString { get { if (string.IsNullOrEmpty(this._CompilationString)) { this._CompilationString = ""; } return this._CompilationString; } set { this._CompilationString = value; } }
        public string Performer { get { if (string.IsNullOrEmpty(this._Performer)) { this._Performer = ""; } return this._Performer; } set { this._Performer = value; } }
        public string PerformerSort { get { if (string.IsNullOrEmpty(this._PerformerSort)) { this._PerformerSort = ""; } return this._PerformerSort; } set { this._PerformerSort = value; } }
        public string PerformerUrl { get { if (string.IsNullOrEmpty(this._PerformerUrl)) { this._PerformerUrl = ""; } return this._PerformerUrl; } set { this._PerformerUrl = value; } }
        public string OriginalPerformer { get { if (string.IsNullOrEmpty(this._OriginalPerformer)) { this._OriginalPerformer = ""; } return this._OriginalPerformer; } set { this._OriginalPerformer = value; } }
        public string Accompaniment { get { if (string.IsNullOrEmpty(this._Accompaniment)) { this._Accompaniment = ""; } return this._Accompaniment; } set { this._Accompaniment = value; } }
        public string Composer { get { if (string.IsNullOrEmpty(this._Composer)) { this._Composer = ""; } return this._Composer; } set { this._Composer = value; } }
        public string ComposerNationality { get { if (string.IsNullOrEmpty(this._ComposerNationality)) { this._ComposerNationality = ""; } return this._ComposerNationality; } set { this._ComposerNationality = value; } }
        public string ComposerSort { get { if (string.IsNullOrEmpty(this._ComposerSort)) { this._ComposerSort = ""; } return this._ComposerSort; } set { this._ComposerSort = value; } }
        public string Arranger { get { if (string.IsNullOrEmpty(this._Arranger)) { this._Arranger = ""; } return this._Arranger; } set { this._Arranger = value; } }
        public string Lyricist { get { if (string.IsNullOrEmpty(this._Lyricist)) { this._Lyricist = ""; } return this._Lyricist; } set { this._Lyricist = value; } }
        public string OriginalLyricist { get { if (string.IsNullOrEmpty(this._OriginalLyricist)) { this._OriginalLyricist = ""; } return this._OriginalLyricist; } set { this._OriginalLyricist = value; } }
        public string Conductor { get { if (string.IsNullOrEmpty(this._Conductor)) { this._Conductor = ""; } return this._Conductor; } set { this._Conductor = value; } }
        public string Director { get { if (string.IsNullOrEmpty(this._Director)) { this._Director = ""; } return this._Director; } set { this._Director = value; } }
        public string CoDirector { get { if (string.IsNullOrEmpty(this._CoDirector)) { this._CoDirector = ""; } return this._CoDirector; } set { this._CoDirector = value; } }
        public string AssistantDirector { get { if (string.IsNullOrEmpty(this._AssistantDirector)) { this._AssistantDirector = ""; } return this._AssistantDirector; } set { this._AssistantDirector = value; } }
        public string DirectorOfPhotography { get { if (string.IsNullOrEmpty(this._DirectorOfPhotography)) { this._DirectorOfPhotography = ""; } return this._DirectorOfPhotography; } set { this._DirectorOfPhotography = value; } }
        public string SoundEngineer { get { if (string.IsNullOrEmpty(this._SoundEngineer)) { this._SoundEngineer = ""; } return this._SoundEngineer; } set { this._SoundEngineer = value; } }
        public string ArtDirector { get { if (string.IsNullOrEmpty(this._ArtDirector)) { this._ArtDirector = ""; } return this._ArtDirector; } set { this._ArtDirector = value; } }
        public string ProductionDesigner { get { if (string.IsNullOrEmpty(this._ProductionDesigner)) { this._ProductionDesigner = ""; } return this._ProductionDesigner; } set { this._ProductionDesigner = value; } }
        public string Choregrapher { get { if (string.IsNullOrEmpty(this._Choregrapher)) { this._Choregrapher = ""; } return this._Choregrapher; } set { this._Choregrapher = value; } }
        public string CostumeDesigner { get { if (string.IsNullOrEmpty(this._CostumeDesigner)) { this._CostumeDesigner = ""; } return this._CostumeDesigner; } set { this._CostumeDesigner = value; } }
        public string Actor { get { if (string.IsNullOrEmpty(this._Actor)) { this._Actor = ""; } return this._Actor; } set { this._Actor = value; } }
        public string Actor_Character { get { if (string.IsNullOrEmpty(this._Actor_Character)) { this._Actor_Character = ""; } return this._Actor_Character; } set { this._Actor_Character = value; } }
        public string WrittenBy { get { if (string.IsNullOrEmpty(this._WrittenBy)) { this._WrittenBy = ""; } return this._WrittenBy; } set { this._WrittenBy = value; } }
        public string ScreenplayBy { get { if (string.IsNullOrEmpty(this._ScreenplayBy)) { this._ScreenplayBy = ""; } return this._ScreenplayBy; } set { this._ScreenplayBy = value; } }
        public string EditedBy { get { if (string.IsNullOrEmpty(this._EditedBy)) { this._EditedBy = ""; } return this._EditedBy; } set { this._EditedBy = value; } }
        public string CommissionedBy { get { if (string.IsNullOrEmpty(this._CommissionedBy)) { this._CommissionedBy = ""; } return this._CommissionedBy; } set { this._CommissionedBy = value; } }
        public string Producer { get { if (string.IsNullOrEmpty(this._Producer)) { this._Producer = ""; } return this._Producer; } set { this._Producer = value; } }
        public string CoProducer { get { if (string.IsNullOrEmpty(this._CoProducer)) { this._CoProducer = ""; } return this._CoProducer; } set { this._CoProducer = value; } }
        public string ExecutiveProducer { get { if (string.IsNullOrEmpty(this._ExecutiveProducer)) { this._ExecutiveProducer = ""; } return this._ExecutiveProducer; } set { this._ExecutiveProducer = value; } }
        public string MusicBy { get { if (string.IsNullOrEmpty(this._MusicBy)) { this._MusicBy = ""; } return this._MusicBy; } set { this._MusicBy = value; } }
        public string DistributedBy { get { if (string.IsNullOrEmpty(this._DistributedBy)) { this._DistributedBy = ""; } return this._DistributedBy; } set { this._DistributedBy = value; } }
        public string OriginalSourceFormDistributedBy { get { if (string.IsNullOrEmpty(this._OriginalSourceFormDistributedBy)) { this._OriginalSourceFormDistributedBy = ""; } return this._OriginalSourceFormDistributedBy; } set { this._OriginalSourceFormDistributedBy = value; } }
        public string MasteredBy { get { if (string.IsNullOrEmpty(this._MasteredBy)) { this._MasteredBy = ""; } return this._MasteredBy; } set { this._MasteredBy = value; } }
        public string EncodedBy { get { if (string.IsNullOrEmpty(this._EncodedBy)) { this._EncodedBy = ""; } return this._EncodedBy; } set { this._EncodedBy = value; } }
        public string RemixedBy { get { if (string.IsNullOrEmpty(this._RemixedBy)) { this._RemixedBy = ""; } return this._RemixedBy; } set { this._RemixedBy = value; } }
        public string ProductionStudio { get { if (string.IsNullOrEmpty(this._ProductionStudio)) { this._ProductionStudio = ""; } return this._ProductionStudio; } set { this._ProductionStudio = value; } }
        public string ThanksTo { get { if (string.IsNullOrEmpty(this._ThanksTo)) { this._ThanksTo = ""; } return this._ThanksTo; } set { this._ThanksTo = value; } }
        public string Publisher { get { if (string.IsNullOrEmpty(this._Publisher)) { this._Publisher = ""; } return this._Publisher; } set { this._Publisher = value; } }
        public string PublisherURL { get { if (string.IsNullOrEmpty(this._PublisherURL)) { this._PublisherURL = ""; } return this._PublisherURL; } set { this._PublisherURL = value; } }
        public string Label { get { if (string.IsNullOrEmpty(this._Label)) { this._Label = ""; } return this._Label; } set { this._Label = value; } }
        public string Genre { get { if (string.IsNullOrEmpty(this._Genre)) { this._Genre = ""; } return this._Genre; } set { this._Genre = value; } }
        public string PodcastCategory { get { if (string.IsNullOrEmpty(this._PodcastCategory)) { this._PodcastCategory = ""; } return this._PodcastCategory; } set { this._PodcastCategory = value; } }
        public string Mood { get { if (string.IsNullOrEmpty(this._Mood)) { this._Mood = ""; } return this._Mood; } set { this._Mood = value; } }
        public string ContentType { get { if (string.IsNullOrEmpty(this._ContentType)) { this._ContentType = ""; } return this._ContentType; } set { this._ContentType = value; } }
        public string Subject { get { if (string.IsNullOrEmpty(this._Subject)) { this._Subject = ""; } return this._Subject; } set { this._Subject = value; } }
        public string Description { get { if (string.IsNullOrEmpty(this._Description)) { this._Description = ""; } return this._Description; } set { this._Description = value; } }
        public string Keywords { get { if (string.IsNullOrEmpty(this._Keywords)) { this._Keywords = ""; } return this._Keywords; } set { this._Keywords = value; } }
        public string Summary { get { if (string.IsNullOrEmpty(this._Summary)) { this._Summary = ""; } return this._Summary; } set { this._Summary = value; } }
        public string Synopsis { get { if (string.IsNullOrEmpty(this._Synopsis)) { this._Synopsis = ""; } return this._Synopsis; } set { this._Synopsis = value; } }
        public string Period { get { if (string.IsNullOrEmpty(this._Period)) { this._Period = ""; } return this._Period; } set { this._Period = value; } }
        public string LawRating { get { if (string.IsNullOrEmpty(this._LawRating)) { this._LawRating = ""; } return this._LawRating; } set { this._LawRating = value; } }
        public string LawRating_Reason { get { if (string.IsNullOrEmpty(this._LawRating_Reason)) { this._LawRating_Reason = ""; } return this._LawRating_Reason; } set { this._LawRating_Reason = value; } }
        public string ICRA { get { if (string.IsNullOrEmpty(this._ICRA)) { this._ICRA = ""; } return this._ICRA; } set { this._ICRA = value; } }
        public string Released_Date { get { if (string.IsNullOrEmpty(this._Released_Date)) { this._Released_Date = ""; } return this._Released_Date; } set { this._Released_Date = value; } }
        public string OriginalReleased_Date { get { if (string.IsNullOrEmpty(this._OriginalReleased_Date)) { this._OriginalReleased_Date = ""; } return this._OriginalReleased_Date; } set { this._OriginalReleased_Date = value; } }
        public string Recorded_Date { get { if (string.IsNullOrEmpty(this._Recorded_Date)) { this._Recorded_Date = ""; } return this._Recorded_Date; } set { this._Recorded_Date = value; } }
        public string Encoded_Date { get { if (string.IsNullOrEmpty(this._Encoded_Date)) { this._Encoded_Date = ""; } return this._Encoded_Date; } set { this._Encoded_Date = value; } }
        public string Tagged_Date { get { if (string.IsNullOrEmpty(this._Tagged_Date)) { this._Tagged_Date = ""; } return this._Tagged_Date; } set { this._Tagged_Date = value; } }
        public string Written_Date { get { if (string.IsNullOrEmpty(this._Written_Date)) { this._Written_Date = ""; } return this._Written_Date; } set { this._Written_Date = value; } }
        public string Mastered_Date { get { if (string.IsNullOrEmpty(this._Mastered_Date)) { this._Mastered_Date = ""; } return this._Mastered_Date; } set { this._Mastered_Date = value; } }
        public string File_Created_Date { get { if (string.IsNullOrEmpty(this._File_Created_Date)) { this._File_Created_Date = ""; } return this._File_Created_Date; } set { this._File_Created_Date = value; } }
        public string File_Created_Date_Local { get { if (string.IsNullOrEmpty(this._File_Created_Date_Local)) { this._File_Created_Date_Local = ""; } return this._File_Created_Date_Local; } set { this._File_Created_Date_Local = value; } }
        public string File_Modified_Date { get { if (string.IsNullOrEmpty(this._File_Modified_Date)) { this._File_Modified_Date = ""; } return this._File_Modified_Date; } set { this._File_Modified_Date = value; } }
        public string File_Modified_Date_Local { get { if (string.IsNullOrEmpty(this._File_Modified_Date_Local)) { this._File_Modified_Date_Local = ""; } return this._File_Modified_Date_Local; } set { this._File_Modified_Date_Local = value; } }
        public string Recorded_Location { get { if (string.IsNullOrEmpty(this._Recorded_Location)) { this._Recorded_Location = ""; } return this._Recorded_Location; } set { this._Recorded_Location = value; } }
        public string Written_Location { get { if (string.IsNullOrEmpty(this._Written_Location)) { this._Written_Location = ""; } return this._Written_Location; } set { this._Written_Location = value; } }
        public string Archival_Location { get { if (string.IsNullOrEmpty(this._Archival_Location)) { this._Archival_Location = ""; } return this._Archival_Location; } set { this._Archival_Location = value; } }
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
        public string Cropped { get { if (string.IsNullOrEmpty(this._Cropped)) { this._Cropped = ""; } return this._Cropped; } set { this._Cropped = value; } }
        public string Dimensions { get { if (string.IsNullOrEmpty(this._Dimensions)) { this._Dimensions = ""; } return this._Dimensions; } set { this._Dimensions = value; } }
        public string DotsPerInch { get { if (string.IsNullOrEmpty(this._DotsPerInch)) { this._DotsPerInch = ""; } return this._DotsPerInch; } set { this._DotsPerInch = value; } }
        public string Lightness { get { if (string.IsNullOrEmpty(this._Lightness)) { this._Lightness = ""; } return this._Lightness; } set { this._Lightness = value; } }
        public string OriginalSourceMedium { get { if (string.IsNullOrEmpty(this._OriginalSourceMedium)) { this._OriginalSourceMedium = ""; } return this._OriginalSourceMedium; } set { this._OriginalSourceMedium = value; } }
        public string OriginalSourceForm { get { if (string.IsNullOrEmpty(this._OriginalSourceForm)) { this._OriginalSourceForm = ""; } return this._OriginalSourceForm; } set { this._OriginalSourceForm = value; } }
        public string OriginalSourceFormNumColors { get { if (string.IsNullOrEmpty(this._OriginalSourceFormNumColors)) { this._OriginalSourceFormNumColors = ""; } return this._OriginalSourceFormNumColors; } set { this._OriginalSourceFormNumColors = value; } }
        public string OriginalSourceFormName { get { if (string.IsNullOrEmpty(this._OriginalSourceFormName)) { this._OriginalSourceFormName = ""; } return this._OriginalSourceFormName; } set { this._OriginalSourceFormName = value; } }
        public string OriginalSourceFormCropped { get { if (string.IsNullOrEmpty(this._OriginalSourceFormCropped)) { this._OriginalSourceFormCropped = ""; } return this._OriginalSourceFormCropped; } set { this._OriginalSourceFormCropped = value; } }
        public string OriginalSourceFormSharpness { get { if (string.IsNullOrEmpty(this._OriginalSourceFormSharpness)) { this._OriginalSourceFormSharpness = ""; } return this._OriginalSourceFormSharpness; } set { this._OriginalSourceFormSharpness = value; } }
        public string Tagged_Application { get { if (string.IsNullOrEmpty(this._Tagged_Application)) { this._Tagged_Application = ""; } return this._Tagged_Application; } set { this._Tagged_Application = value; } }
        public string BPM { get { if (string.IsNullOrEmpty(this._BPM)) { this._BPM = ""; } return this._BPM; } set { this._BPM = value; } }
        public string ISRC { get { if (string.IsNullOrEmpty(this._ISRC)) { this._ISRC = ""; } return this._ISRC; } set { this._ISRC = value; } }
        public string ISBN { get { if (string.IsNullOrEmpty(this._ISBN)) { this._ISBN = ""; } return this._ISBN; } set { this._ISBN = value; } }
        public string BarCode { get { if (string.IsNullOrEmpty(this._BarCode)) { this._BarCode = ""; } return this._BarCode; } set { this._BarCode = value; } }
        public string LCCN { get { if (string.IsNullOrEmpty(this._LCCN)) { this._LCCN = ""; } return this._LCCN; } set { this._LCCN = value; } }
        public string CatalogNumber { get { if (string.IsNullOrEmpty(this._CatalogNumber)) { this._CatalogNumber = ""; } return this._CatalogNumber; } set { this._CatalogNumber = value; } }
        public string LabelCode { get { if (string.IsNullOrEmpty(this._LabelCode)) { this._LabelCode = ""; } return this._LabelCode; } set { this._LabelCode = value; } }
        public string Owner { get { if (string.IsNullOrEmpty(this._Owner)) { this._Owner = ""; } return this._Owner; } set { this._Owner = value; } }
        public string Copyright { get { if (string.IsNullOrEmpty(this._Copyright)) { this._Copyright = ""; } return this._Copyright; } set { this._Copyright = value; } }
        public string CopyrightUrl { get { if (string.IsNullOrEmpty(this._CopyrightUrl)) { this._CopyrightUrl = ""; } return this._CopyrightUrl; } set { this._CopyrightUrl = value; } }
        public string Producer_Copyright { get { if (string.IsNullOrEmpty(this._Producer_Copyright)) { this._Producer_Copyright = ""; } return this._Producer_Copyright; } set { this._Producer_Copyright = value; } }
        public string TermsOfUse { get { if (string.IsNullOrEmpty(this._TermsOfUse)) { this._TermsOfUse = ""; } return this._TermsOfUse; } set { this._TermsOfUse = value; } }
        public string ServiceName { get { if (string.IsNullOrEmpty(this._ServiceName)) { this._ServiceName = ""; } return this._ServiceName; } set { this._ServiceName = value; } }
        public string ServiceChannel { get { if (string.IsNullOrEmpty(this._ServiceChannel)) { this._ServiceChannel = ""; } return this._ServiceChannel; } set { this._ServiceChannel = value; } }
        public string ServiceUrl { get { if (string.IsNullOrEmpty(this._ServiceUrl)) { this._ServiceUrl = ""; } return this._ServiceUrl; } set { this._ServiceUrl = value; } }
        public string ServiceProvider { get { if (string.IsNullOrEmpty(this._ServiceProvider)) { this._ServiceProvider = ""; } return this._ServiceProvider; } set { this._ServiceProvider = value; } }
        public string ServiceProviderUrl { get { if (string.IsNullOrEmpty(this._ServiceProviderUrl)) { this._ServiceProviderUrl = ""; } return this._ServiceProviderUrl; } set { this._ServiceProviderUrl = value; } }
        public string ServiceType { get { if (string.IsNullOrEmpty(this._ServiceType)) { this._ServiceType = ""; } return this._ServiceType; } set { this._ServiceType = value; } }
        public string NetworkName { get { if (string.IsNullOrEmpty(this._NetworkName)) { this._NetworkName = ""; } return this._NetworkName; } set { this._NetworkName = value; } }
        public string OriginalNetworkName { get { if (string.IsNullOrEmpty(this._OriginalNetworkName)) { this._OriginalNetworkName = ""; } return this._OriginalNetworkName; } set { this._OriginalNetworkName = value; } }
        public string Country { get { if (string.IsNullOrEmpty(this._Country)) { this._Country = ""; } return this._Country; } set { this._Country = value; } }
        public string TimeZone { get { if (string.IsNullOrEmpty(this._TimeZone)) { this._TimeZone = ""; } return this._TimeZone; } set { this._TimeZone = value; } }
        public string Cover { get { if (string.IsNullOrEmpty(this._Cover)) { this._Cover = ""; } return this._Cover; } set { this._Cover = value; } }
        public string Cover_Description { get { if (string.IsNullOrEmpty(this._Cover_Description)) { this._Cover_Description = ""; } return this._Cover_Description; } set { this._Cover_Description = value; } }
        public string Cover_Type { get { if (string.IsNullOrEmpty(this._Cover_Type)) { this._Cover_Type = ""; } return this._Cover_Type; } set { this._Cover_Type = value; } }
        public string Cover_Mime { get { if (string.IsNullOrEmpty(this._Cover_Mime)) { this._Cover_Mime = ""; } return this._Cover_Mime; } set { this._Cover_Mime = value; } }
        public string Cover_Data { get { if (string.IsNullOrEmpty(this._Cover_Data)) { this._Cover_Data = ""; } return this._Cover_Data; } set { this._Cover_Data = value; } }
        public string Lyrics { get { if (string.IsNullOrEmpty(this._Lyrics)) { this._Lyrics = ""; } return this._Lyrics; } set { this._Lyrics = value; } }
        public string Comment { get { if (string.IsNullOrEmpty(this._Comment)) { this._Comment = ""; } return this._Comment; } set { this._Comment = value; } }
        public string Rating { get { if (string.IsNullOrEmpty(this._Rating)) { this._Rating = ""; } return this._Rating; } set { this._Rating = value; } }
        public string Added_Date { get { if (string.IsNullOrEmpty(this._Added_Date)) { this._Added_Date = ""; } return this._Added_Date; } set { this._Added_Date = value; } }
        public string Played_First_Date { get { if (string.IsNullOrEmpty(this._Played_First_Date)) { this._Played_First_Date = ""; } return this._Played_First_Date; } set { this._Played_First_Date = value; } }
        public string Played_Last_Date { get { if (string.IsNullOrEmpty(this._Played_Last_Date)) { this._Played_Last_Date = ""; } return this._Played_Last_Date; } set { this._Played_Last_Date = value; } }
        public string Played_Count { get { if (string.IsNullOrEmpty(this._Played_Count)) { this._Played_Count = ""; } return this._Played_Count; } set { this._Played_Count = value; } }
        public string EPG_Positions_Begin { get { if (string.IsNullOrEmpty(this._EPG_Positions_Begin)) { this._EPG_Positions_Begin = ""; } return this._EPG_Positions_Begin; } set { this._EPG_Positions_Begin = value; } }
        public string EPG_Positions_End { get { if (string.IsNullOrEmpty(this._EPG_Positions_End)) { this._EPG_Positions_End = ""; } return this._EPG_Positions_End; } set { this._EPG_Positions_End = value; } }
    }
}

