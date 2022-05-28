using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioCSharpRest.Views
{
    public partial class Welcome : UserControl
    {
        private static Welcome? welcome; 
        public Welcome()
        {
            InitializeComponent();
            this.refreshDataGridViewData();
        }

        public static Welcome getInstance()
        {
            if (welcome == null)
                welcome = new Welcome();
            return welcome;
        }
    }
}
