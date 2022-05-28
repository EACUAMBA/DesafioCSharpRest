using DesafioCSharpRest.Views;

namespace DesafioCSharpRest
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Location = new System.Drawing.Point(12, 12);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1092, 449);
            this.panelControl.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1116, 473);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Desafio CSharp Rest";
            this.ResumeLayout(false);
            this.panelControl.Controls.Add(Welcome.getInstance());
        }
        #region Views
       
        #endregion
        private Panel panelControl;
        #endregion
    }
}