using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Recording_System
{
    public partial class SelectMessage : Form
    {
        public SelectMessage()
        {
            InitializeComponent();
        }

        private int currentLength = 0;


        private void SelectMessage_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.applicationName + " :: Select Message";
            ColumnHeader c = new ColumnHeader();
            c.Text = Properties.Resources.subjectString;
            c.Width = 170;
            listView1.Columns.Add(c);

            c = new ColumnHeader();
            c.Text = Properties.Resources.reporterString;
            c.Width = 170;
            listView1.Columns.Add(c);

            loadMessages();
        }

        private void loadMessages()
        {
            var s = new XmlSerializer(typeof(SerialisableFile));

            listView1.Items.Clear();

            string[] fileEntries = Directory.GetFiles(Program.PROGRAM_PATH);
            currentLength = fileEntries.Length;
            foreach (string fileName in fileEntries)
            {
                try
                {

                    //Read the file in
                    var fs = new FileStream(fileName, FileMode.Open);
                    //Deserialise the XML
                    var messageObject = (SerialisableFile)s.Deserialize(fs);
                    ListViewItem l = new ListViewItem(AESEncryption.Decrypt(messageObject.date, Program.CIPHER).TrimEnd());
                    l.Tag = Path.GetFileName(fileName);
                    l.SubItems.Add(AESEncryption.Decrypt(messageObject.pupilName, Program.CIPHER).TrimEnd());
                    l.SubItems.Add(AESEncryption.Decrypt(messageObject.teacherName, Program.CIPHER).TrimEnd());
                    if(messageObject.read == true)
                    {
                        l.ForeColor = Color.FromArgb(0, 200, 0);
                    }
                    listView1.Items.Add(l);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    listView1.Items.Add(Path.GetFileName(fileName));
                    listView1.Items[listView1.Items.Count - 1].Tag = Path.GetFileName(fileName);
                }



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count < 1)
            {
                MessageBox.Show("Please select at least one item to view");
                return;
            }
            
            new ViewMessage((string)listView1.Items[listView1.SelectedIndices[0]].Tag).Visible = true;
                
            
        }

        private void SelectMessage_Close(object sender, FormClosingEventArgs e)
        {
            new StartupSelector().Show();
        }

        private void checkForMessages_Tick(object sender, EventArgs e)
        {
            //A simple polling system that checks to see if any new messages have been received
            string[] fileEntries = Directory.GetFiles(Program.PROGRAM_PATH);
            if (fileEntries.Length > currentLength)
            {
                loadMessages();
                MessageBox.Show("New messages received.", "Messages received", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
