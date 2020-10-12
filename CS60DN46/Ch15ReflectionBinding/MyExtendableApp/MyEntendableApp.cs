using CommonSnappableTypes;
using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace MyExtendableApp {
	public partial class MyEntendableApp : Form {
		public MyEntendableApp() {
			InitializeComponent();
		}

		private void snapInModuleToolStripMenuItem_Click(object sender, EventArgs e) {
			// Allow user to select an assembly to load.
			OpenFileDialog dlg = new OpenFileDialog();
			if (dlg.ShowDialog() == DialogResult.OK) {
				if (dlg.FileName.Contains("CommonSnappableTypes"))
					MessageBox.Show("CommonSnappableTypes has no snap-ins!");
				else if (!LoadExternalModule(dlg.FileName))
					MessageBox.Show("Nothing implements IAppFunctionality!");
			}
		}

		private bool LoadExternalModule(string path) {
			bool foundSnapIn = false;
			Assembly theSnapInAsm = null;

			try {
				theSnapInAsm = Assembly.LoadFrom(path);
			}
			catch (Exception e) {
				MessageBox.Show(e.Message);
				return foundSnapIn;
			}

			var theClassTypes = from t in theSnapInAsm.GetTypes()
								where t.IsClass &&
								(t.GetInterface("IAppFunctionality") != null)
								select t;
			foreach (Type t in theClassTypes) {
				foundSnapIn = true;
				IAppFunctionality itfApp = (IAppFunctionality)theSnapInAsm.CreateInstance(t.FullName, true);
				itfApp.DoIt();
				lstLoadedSnapIns.Items.Add(t.FullName);
			}

			return foundSnapIn;
		}
	}
}
