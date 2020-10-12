using CommonSnappableTypes;
using System.Windows.Forms;

namespace CSharpSnapIn {
	[CompanyInfo(CompanyName = "FooBar", CompanyUrl = "www.FooBar.com")]
    public class CSharpModule : IAppFunctionality
    {
        void IAppFunctionality.DoIt() {
            MessageBox.Show("You have just used the C# snap-in!");
		}
    }
}
