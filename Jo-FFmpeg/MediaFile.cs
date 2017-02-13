using System;

namespace JoFFmpeg
{
	public class MediaFile
	{
		string FileName { get; set;}

		string FFprobePath { get; set;}

		string exec;
		
		public MediaFile ()
		{
			SetVaribles (string.Empty , "ffprobe");
		}
		public MediaFile (string filename)
		{
			SetVaribles (filename, "ffprobe");
		}

		public MediaFile (string filename,string ffprobePath)
		{
				SetVaribles(filename,ffprobePath);
		}

		void SetVaribles(string filename,string ffprobePath){
			FFprobePath = ffprobePath;
			FileName = filename;
			Buildexec ();
		}

		void Buildexec(){
            exec = FFprobePath + " -i " + FileName;
            exec +=  " -v quiet -print_format json -show_format -show_streams -hide_banner";
		}
	}
}

