using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailAssistant
{
    public partial class frmBodyEditor : Form
    {
        public frmBodyEditor()
        {
            InitializeComponent();
        }

        public static string htmlBody = "";
        private void frmBodyEditor_Shown(object sender, EventArgs e)
        {
            this.heMaxBodyEditor.BodyHtml = htmlBody;
        }

        private void frmBodyEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            htmlBody = this.heMaxBodyEditor.BodyInnerHTML; ;
        }
    }
}
