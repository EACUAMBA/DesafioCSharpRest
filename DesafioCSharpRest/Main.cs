using DesafioCSharpRest.Views;
using System.Globalization;
using DesafioCSharpRest.Utils;

namespace DesafioCSharpRest
{
    public partial class Main : Form
    {
        public Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-MZ");
            InitializeComponent();
            panelControl.Controls.Add(Welcome.getInstance());
            SyncUtils.startSync();
        }
    }
}