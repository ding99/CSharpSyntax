using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;

namespace MyEBookReader {
	public partial class MainForm : Form {
		static string theEBook = string.Empty;

		public MainForm() {
			InitializeComponent();
		}

		private void btnDownload_Click(object sender, EventArgs e) {
			string uri = @"http://www.gutenberg.org/files/98/98-8.txt";
			WebClient wc = new WebClient();
			wc.DownloadStringCompleted += (s, eArgs) => {
				theEBook = eArgs.Result;
				txtBook.Text = theEBook;
			};

			//The project Gutenberg EBook of A Tale of Two Cities, by Charles Disckens
			wc.DownloadStringAsync(new Uri(uri));
		}

		private void btnGetStart_Click(object sender, EventArgs e) {
			string[] words = theEBook.Split(new char[] {' ','\u000A',',','.',';','：','-','?','/'}, StringSplitOptions.RemoveEmptyEntries);
			//string[] tenMostCommon = FindTenMostCommon(words);
			//string longestWord = FindLongestWord(words);
			string[] tenMostCommon = null;
			string longestWord = string.Empty;

			Parallel.Invoke(
				() => { tenMostCommon = FindTenMostCommon(words); },
				() => { longestWord = FindLongestWord(words); }
			);

			StringBuilder bookStats = new StringBuilder("Ten Most Common Words are:\n");
			foreach (string s in tenMostCommon)
				bookStats.AppendLine(s);
			bookStats.AppendFormat("Longest word is: {0}", longestWord);
			bookStats.AppendLine();
			bookStats.AppendLine($"Longest word is: {longestWord}");
			MessageBox.Show(bookStats.ToString(), "Book info");
		}

		private string[] FindTenMostCommon(string[] words) {
			var frequencyOrder = from word in words where word.Length > 6 group word by word into g orderby g.Count() descending select $"{g.Key} {g.Count()}";
			string[] commonWords = (frequencyOrder.Take(10)).ToArray();
			return commonWords;
		}

		private string FindLongestWord(string[] words) {
			return (from w in words orderby w.Length descending select w).FirstOrDefault();
		}
	}
}
