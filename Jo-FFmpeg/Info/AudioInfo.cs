using System;

namespace JoFFmpeg
{
	public class AudioInfo
	{
		string CodecName { get; set;} 
		string CodecLongName { get; set;} 
		string Profile { get; set;} 
		string CodecTimeBase { get; set;} 
		string CodecTagString { get; set;} 
		string CodecTag { get; set;} 

		string Channels { get; set;} 
		string ChannelLayout { get; set;} 

		string Duration { get; set;} 
		string BitRate { get; set;} 

		public AudioInfo (string CodecName,string CodecLongName,string Profile,string CodecTimeBase,string CodecTagString
			,string CodecTag,string Channels,string ChannelLayout,string Duration,string BitRate)
		{

			this.CodecName = CodecName;
			this.CodecLongName = CodecLongName;
			this.Profile = Profile;
			this.CodecTimeBase = CodecTimeBase;
			this.CodecTagString = CodecTagString;
			this.CodecTag = CodecTag;
						
			this.Channels = Channels;
			this.ChannelLayout = ChannelLayout;					

			this.Duration = Duration;
			this.BitRate = BitRate;
		}
		public override string ToString ()
		{
			return string.Format ("[AudioInfo]\n" +
				$"\tCodecName : {CodecName}\n" +
				$"\tCodecLongName : {CodecLongName}\n" +
				$"\tProfile : {Profile}\n" +
				$"\tCodecTimeBase : {CodecTimeBase}\n" +
				$"\tCodecTagString : {CodecTagString}\n" +
				$"\tCodecTag : {CodecTag}\n" +
				$"\tChannels : {Channels}\n" +
				$"\tChannelLayout : {ChannelLayout}\n" +
				$"\tDuration : {Duration}\n" +
				$"\tBitRate : {BitRate}"
			);
		}
	}
}

