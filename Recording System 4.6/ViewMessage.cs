using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Recording_System_3._5
{
    public partial class ViewMessage : Form
    {

        SerialisableFile messageObject;
        string currentFile = "";

        public ViewMessage(string filename)
        {
            InitializeComponent();

            loadFile(filename);
        }

        public void loadFile(string filename)
        {
            var s = new XmlSerializer(typeof(SerialisableFile));

            //Read the file in
            var fs = new FileStream(Program.PROGRAM_PATH + filename, FileMode.Open);
            //Deserialise the XML
            messageObject = (SerialisableFile)s.Deserialize(fs);

            if (messageObject != null)
            {
                pupilName.Text = AESEncryption.Decrypt(messageObject.pupilName, Program.CIPHER).TrimEnd();
                recordedOn.Text = AESEncryption.Decrypt(messageObject.date, Program.CIPHER).TrimEnd();
                teacher.Text = AESEncryption.Decrypt(messageObject.teacherName, Program.CIPHER).TrimEnd();
                informationBox.Rtf = AESEncryption.Decrypt(messageObject.comment, Program.CIPHER).TrimEnd();
                currentFile = filename;
            }
            else
            {
                MessageBox.Show("An error has occurred when reading a message");
            }
        }

        private void btnMarkAsRead_Click(object sender, EventArgs e)
        {
            if (messageObject != null)
            {
                messageObject.read = true;
                XmlSerializer mySerializer = new XmlSerializer(typeof(SerialisableFile));
                StreamWriter myWriter = new StreamWriter(Program.PROGRAM_PATH + currentFile);
                mySerializer.Serialize(myWriter, messageObject);
                myWriter.Close();

                this.Visible = false;
                this.Dispose();

            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            SelectMessage.currentMessage = null;
            this.Visible = false;
            this.Dispose();
        }

        private void ViewMessage_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.applicationName + " :: View Message";
            subjectLabel.Text = Properties.Resources.subjectString;
        }
    }
}
