using DesafioCSharpRest.Views;
using System.Globalization;

namespace DesafioCSharpRest
{
    public partial class Main : Form
    {
        public Main()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("pt-MZ");
            InitializeComponent();
            panelControl.Controls.Add(Welcome.getInstance());
        }
    }
}