using System;

namespace JoFFmpeg
{
	public class VideoInfo
	{
		string CodecName { get; set;} 
		string CodecLongName { get; set;} 
		string Profile { get; set;} 
		string CodecTimeBase { get; set;} 
		string CodecTagString { get; set;} 
		string CodecTag { get; set;} 

		string Width { get; set;} 
		string Height { get; set;} 

		string SampleAspectRatio { get; set;} 
		string DisplayAspectRatio { get; set;} 
		string AvgFrameRate { get; set;} 
		string Duration { get; set;} 
		string BitRate { get; set;} 

		public VideoInfo (string CodecName,string CodecLongName,string Profile,string CodecTimeBase,string CodecTagString
			,string CodecTag,string Width,string Height,string SampleAspectRatio,string DisplayAspectRatio,string AvgFrameRate,string Duration,string BitRate)
		{

			this.CodecName = CodecName;
			this.CodecLongName = CodecLongName;
			this.Profile = Profile;
			this.CodecTimeBase = CodecTimeBase;
			this.CodecTagString = CodecTagString;
			this.CodecTag = CodecTag;

			this.Width = Width;
			this.Height = Height;		

			this.SampleAspectRatio = SampleAspectRatio;
			this.DisplayAspectRatio =DisplayAspectRatio;
			this.AvgFrameRate =  AvgFrameRate;
			this.Duration = Duration;
			this.BitRate = BitRate;
		}
		public override string ToString ()
		{
			return string.Format ("[VideoInfo]\n" +
				$"\tCodecName : {CodecName}\n" +
				$"\tCodecLongName : {CodecLongName}\n" +
				$"\tProfile : {Profile}\n" +
				$"\tCodecTimeBase : {CodecTimeBase}\n" +
				$"\tCodecTagString : {CodecTagString}\n" +
				$"\tCodecTag : {CodecTag}\n" +
				$"\tChannels : {Channels}\n" +
				$"\tChannelLayout : {ChannelLayout}\n" +
				$"\tSampleAspectRatio : {SampleAspectRatio}\n" +
				$"\tDisplayAspectRatio : {DisplayAspectRatio}\n" +
				$"\tAvgFrameRate : {AvgFrameRate}\n" +
				$"\tDuration : {Duration}\n" +
				$"\tBitRate : {BitRate}"
			);
		}
	}
}

