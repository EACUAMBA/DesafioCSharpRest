using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCSharpRest.Utils
{
    internal sealed class MessageBoxUtils
    {
        private MessageBoxUtils() { }
        public static bool showQuestionBox(string question = "Questão", string title = "Questão?")
        {
            DialogResult dialogResult =MessageBox.Show(question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
