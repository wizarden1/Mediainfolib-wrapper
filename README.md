"# Mediainfolib-wrapper" 
Required Mediainfo DLL Lib which can be downloaded form https://mediaarea.net

x86 vesion of mediainfo.dll has to be named as MediaInfo.dll
x64 vesion of mediainfo.dll has to be named as MediaInfo_x64.dll

Depending of which platform you going to use, you have to change MediaInfoDLL.cs
in MediaInfoWrapper\MediaInfoLib
MediaInfoDLL.cs - for x64
MediaInfoDLL.cs.original - for x86

C# compiler
C:\Windows\Microsoft.NET\Framework\v4.0.30319 - for 32-bit compiler
C:\Windows\Microsoft.NET\Framework64\v4.0.30319 - for 64-bit compiler

or any other c# compiler

For usage mediainfo.dll has to be in the same directory as wrapper