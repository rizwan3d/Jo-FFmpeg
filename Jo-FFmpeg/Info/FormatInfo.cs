using System;

namespace JoFFmpeg
{
	public class FormatInfo
	{

		string FormatName { get; set;} 
		string FormatLongName { get; set;} 
		string Duration { get; set;} 
		string Size { get; set;} 
		string Encoder { get; set;} 

		public FormatInfo (string FormatName,string FormatLongName,string Duration,string Size,string Encoder)
		{
			this.FormatName =FormatName;
			this.FormatLongName =FormatLongName;
			this.Duration =Duration;
			this.Size =Size;
			this.Encoder =Encoder;
		}
			
		public override string ToString ()
		{
			return string.Format ("[FormatInfo]\n" +
				$"\tFormatName : {FormatName}\n" +
				$"\tFormatLongName : {FormatLongName}\n" +
				$"\tDuration : {Duration}\n" +
				$"\tSize : {Size}\n" +
				$"\tEncoder : {Encoder}");
		}
	}
}

