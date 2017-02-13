using System;

namespace JoFFmpeg
{
	public class MediaInfo
	{
		VideoInfo videoinfo { get; set;}
		AudioInfo audioinfo { get; set;}
		FormatInfo formatinfo { get; set;}

		public MediaInfo ()
		{
		}

		public override string ToString ()
		{
			return string.Format ($"[MediaInfo]\n {videoinfo.ToString ()} \n {audioinfo.ToString ()} \n {formatinfo.ToString ()} ");
		}
	}
}

