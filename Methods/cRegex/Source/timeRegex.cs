using System;
using System.Text.RegularExpressions;

namespace CRegex {
	public class MediaTime {
		public int hour;
		public int minute;
		public int second;
		public int millisecond;

		public MediaTime() {
			hour = minute = second = millisecond = 0;
		}

		public MediaTime(string time) {
			Regex reg = new Regex("[0-9]?[0-9][0-9]");
			Match match = reg.Match(time);
			int count = 0;

			while(match.Success) {
				switch(count) {
				case 0:
					hour = Convert.ToInt32(match.Captures[0].Value);
					break;
				case 1:
					minute = Convert.ToInt32(match.Captures[0].Value);
					break;
				case 2:
					second = Convert.ToInt32(match.Captures[0].Value);
					break;
				case 3:
					millisecond = Convert.ToInt32(match.Captures[0].Value);
					break;
				}
				match = match.NextMatch();
				count++;
			}

			if(count != 4) {
				hour = minute = second = millisecond = -1;
				return;
			}
		}

		public double ToSeconds() {
			return (hour * 60 + minute) * 60 + second + millisecond / 1000.0;
		}

		static public double GetDuration(MediaTime start, MediaTime end) {
			return end.ToSeconds() - start.ToSeconds();
		}

		public static MediaTime FromSeconds(double seconds) {
			MediaTime mt = new MediaTime();
			mt.hour = (int)seconds / 3600;
			seconds -= mt.hour * 3600;
			mt.minute = (int)seconds / 60;
			seconds -= mt.minute * 60;
			mt.second = (int)seconds;
			mt.millisecond = (int)((seconds - mt.second) * 1000 + 0.5);

			return mt;
		}

		public MediaTime AddSeconds(double seconds) {
			return FromSeconds(ToSeconds() + seconds);
		}

		public static double AlignSecToFrame(double sec, double fr) {
			double rounded = Math.Round(sec * fr) / fr;
			rounded = Math.Round(rounded * 1000) / 1000;
			while(rounded * fr > Math.Round(sec * fr))
				rounded -= 0.001; // make sure it is just below frame boundary
			return rounded;
		}

		public MediaTime AddSecondsAligned(double seconds, double fr) {
			double sec = ToSeconds() + seconds;

			return FromSeconds(AlignSecToFrame(sec, fr));
		}

		public override String ToString() {
			return String.Format("{0:D2}:{1:D2}:{2:D2}.{3:D3}", hour, minute, second, millisecond);
		}

		public String ToSrtString() {
			return String.Format("{0:D2}:{1:D2}:{2:D2},{3:D3}", hour, minute, second, millisecond);
		}

		public static MediaTime FromNorminalTime(string time) {
			int index = -1;
			time = time.Trim();
			MediaTime mt = null;
			int hour = 0, minute = 0, sec = 0;
			bool token_found = false;

			try {
				if((index = time.IndexOf("h")) >= 0) {
					string s = time.Substring(0, index).Trim();
					hour = Convert.ToInt32(s);
					time = time.Substring(index + 1);
					token_found = true;
				}
				if((index = time.IndexOf("mn")) >= 0) {
					string s = time.Substring(0, index).Trim();
					minute = Convert.ToInt32(s);
					time = time.Substring(index + 2);
					token_found = true;
				}
				if((index = time.IndexOf("s")) >= 0) {
					string s = time.Substring(0, index).Trim();
					minute = Convert.ToInt32(s);
					time = time.Substring(index + 1);
					token_found = true;
				}
				if(token_found) {
					mt = new MediaTime();
					mt.hour = hour;
					mt.minute = minute;
					mt.second = sec;
					mt.millisecond = 0;
				}
			}
			catch(Exception) {
			}
			return mt;
		}

		#region vtt
		private bool vttTime(string s) {
			if(s.Length < 29 || s.IndexOf("-->") != 13)
				return false;

			MatchCollection ms = new Regex(@"\d{2}:\d{2}:\d{2}.\d{3}").Matches(s);
			return ms.Count > 1 && ms[0].Index == 0 && ms[1].Index == 17;
		}
		private void testTime(string s) {
			Console.WriteLine("[" + s + "] " + this.vttTime(s));
		}
		public void vttTests() {
			this.testTime("01:00:11.267 --> 01:00:g3.233");
			this.testTime("01:00:11.267 --> 01:00:13.233");
			this.testTime("01:00:11.267 --> 01:00:13.23");
			this.testTime("01:00:11.26 --> 01:00:13.233");
			this.testTime("01:0:11.267 --> 01:00:13.233");
			this.testTime("01:00:11.267 --> 01:00:13.233 size:50%");
			this.testTime("01:00:11.267 --> 01:00:13.23size:50%");
		}
		#endregion
	}
}