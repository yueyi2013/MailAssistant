namespace MailAssistant
{
    partial class frmBodyEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private WinHtmlEditor.HtmlEditor heMaxBodyEditor;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.heMaxBodyEditor = new WinHtmlEditor.HtmlEditor();
            this.SuspendLayout();
            // 
            // heMaxBodyEditor
            // 
            this.heMaxBodyEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.heMaxBodyEditor.BodyFont = new WinHtmlEditor.HtmlFontProperty("宋体", WinHtmlEditor.HtmlFontSize.xxSmall, false, false, false, false, false, false);
            this.heMaxBodyEditor.BodyInnerHTML = null;
            this.heMaxBodyEditor.BodyInnerText = null;
            this.heMaxBodyEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heMaxBodyEditor.EnterToBR = false;
            this.heMaxBodyEditor.FontSize = WinHtmlEditor.FontSize.Three;
            this.heMaxBodyEditor.Location = new System.Drawing.Point(0, 0);
            this.heMaxBodyEditor.Name = "heMaxBodyEditor";
            this.heMaxBodyEditor.ShowStatusBar = true;
            this.heMaxBodyEditor.ShowToolBar = true;
            this.heMaxBodyEditor.ShowWb = true;
            this.heMaxBodyEditor.Size = new System.Drawing.Size(1019, 554);
            this.heMaxBodyEditor.TabIndex = 0;
            this.heMaxBodyEditor.WebBrowserShortcutsEnabled = true;
            // 
            // frmBodyEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1019, 554);
            this.Controls.Add(this.heMaxBodyEditor);
            this.Name = "frmBodyEditor";
            this.Text = "邮件主体";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBodyEditor_FormClosed);
            this.Shown += new System.EventHandler(this.frmBodyEditor_Shown);
            this.ResumeLayout(false);

        }

        #endregion
    }
}