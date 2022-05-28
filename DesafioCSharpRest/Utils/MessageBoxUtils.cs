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

        public static bool showQuestionBox(IWin32Window owner, string question = "Questão", string title = "Questão?")
        {
            DialogResult dialogResult = MessageBox.Show(owner, question, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult.Equals(DialogResult.Yes))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void showInformationBox(string question = "Informação", string title = "Informação!")
        {
            DialogResult dialogResult = MessageBox.Show(question, title,MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showInformationBox(IWin32Window owner, string question = "Informação", string title = "Informação!")
        {
            DialogResult dialogResult = MessageBox.Show(owner, question, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void showErrorBox(IWin32Window owner, string question = "Informação", string title = "Erro!")
        {
            DialogResult dialogResult = MessageBox.Show(owner, question, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void showWarningBox(IWin32Window owner, string question = "Informação", string title = "Erro!")
        {
            DialogResult dialogResult = MessageBox.Show(owner, question, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
