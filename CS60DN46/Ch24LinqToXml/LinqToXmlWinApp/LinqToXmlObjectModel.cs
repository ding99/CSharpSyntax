using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LinqToXmlWinApp {
	public class LinqToXmlObjectModel {
		public static XDocument GetXmlInventory() {
			try {
				XDocument inventory = XDocument.Load("Inventory.xml");
				return inventory;
			}
			catch(System.IO.FileNotFoundException ex) {
				MessageBox.Show(ex.Message);
				return null;
			}
		}
	}
}
