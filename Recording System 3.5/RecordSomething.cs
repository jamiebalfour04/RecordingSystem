using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Recording_System_3._5
{
    public partial class RecordSomething : Form
    {
        public RecordSomething()
        {
            InitializeComponent();
        }

        private void RecordSomething_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.applicationName + " :: Recording System";
            subjectLabel.Text = Properties.Resources.subjectString;
            reporterLabel.Text = Properties.Resources.reporterString;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            new StartupSelector().Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private string pad(string txt)
        {
            while (txt.Length % 32 != 0)
            {
                txt = txt + " ";
            }
            return txt;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Aes aes = Aes.Create();



            SerialisableFile f = new SerialisableFile();
            f.comment = AESEncryption.Encrypt(pad(richTextBox3.Rtf), Program.CIPHER);
            f.pupilName = AESEncryption.Encrypt(pad(pupilName.Text), Program.CIPHER);
            f.teacherName = AESEncryption.Encrypt(pad(teacherName.Text), Program.CIPHER);
            f.date = AESEncryption.Encrypt(pad(DateTime.Now.ToString("d/M/yyyy H:m")), Program.CIPHER);
            f.read = false;
            // Insert code to set properties and fields of the object.  
            XmlSerializer mySerializer = new XmlSerializer(typeof(SerialisableFile));
            // To write to a file, create a StreamWriter object.  
            String fPath = DateTime.Now.ToString("M_d_yyyy_H_m");
            StreamWriter myWriter = new StreamWriter(Program.PROGRAM_PATH + fPath + ".xml");
            mySerializer.Serialize(myWriter, f);
            myWriter.Close();

            MessageBox.Show("Successfully saved your recording.");
            new StartupSelector().Visible = true;
            this.Visible = false;
            this.Dispose();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.Paste();
        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.Copy();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.Cut();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
        }

        private void boldToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectionFont = new Font(richTextBox3.Font.FontFamily, richTextBox3.Font.Size, FontStyle.Bold);
        }

        private void italicToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectionFont = new Font(richTextBox3.Font.FontFamily, richTextBox3.Font.Size, FontStyle.Italic);
        }

        private void underlineToolStripButton_Click(object sender, EventArgs e)
        {
            richTextBox3.SelectionFont = new Font(richTextBox3.Font.FontFamily, richTextBox3.Font.Size, FontStyle.Underline);
        }

    }
}
