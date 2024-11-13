using System.Drawing;
using System.Windows.Forms;

namespace RecordingSystem
{
    partial class ViewMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.pupilName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.recordedOn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarkAsRead = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.informationBox = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recorded on";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(920, 514);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.86146F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.13854F));
            this.tableLayoutPanel3.Controls.Add(this.subjectLabel, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pupilName, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(914, 30);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // subjectLabel
            // 
            this.subjectLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Location = new System.Drawing.Point(28, 7);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(79, 16);
            this.subjectLabel.TabIndex = 0;
            this.subjectLabel.Text = "{SUBJECT}";
            // 
            // pupilName
            // 
            this.pupilName.BackColor = System.Drawing.Color.White;
            this.pupilName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pupilName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pupilName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pupilName.Location = new System.Drawing.Point(138, 3);
            this.pupilName.Name = "pupilName";
            this.pupilName.ReadOnly = true;
            this.pupilName.Size = new System.Drawing.Size(773, 27);
            this.pupilName.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.15596F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.84404F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.recordedOn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.teacher, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(914, 30);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // recordedOn
            // 
            this.recordedOn.BackColor = System.Drawing.Color.White;
            this.recordedOn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordedOn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recordedOn.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recordedOn.Location = new System.Drawing.Point(137, 3);
            this.recordedOn.Name = "recordedOn";
            this.recordedOn.ReadOnly = true;
            this.recordedOn.Size = new System.Drawing.Size(353, 27);
            this.recordedOn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(502, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "by";
            // 
            // teacher
            // 
            this.teacher.BackColor = System.Drawing.Color.White;
            this.teacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.teacher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacher.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.teacher.Location = new System.Drawing.Point(536, 3);
            this.teacher.Name = "teacher";
            this.teacher.ReadOnly = true;
            this.teacher.Size = new System.Drawing.Size(375, 27);
            this.teacher.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.btnMarkAsRead);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(275, 447);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 63);
            this.panel1.TabIndex = 3;
            // 
            // btnMarkAsRead
            // 
            this.btnMarkAsRead.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarkAsRead.Location = new System.Drawing.Point(69, 18);
            this.btnMarkAsRead.Name = "btnMarkAsRead";
            this.btnMarkAsRead.Size = new System.Drawing.Size(120, 25);
            this.btnMarkAsRead.TabIndex = 5;
            this.btnMarkAsRead.Text = "Mark as Read";
            this.btnMarkAsRead.UseVisualStyleBackColor = true;
            this.btnMarkAsRead.Click += new System.EventHandler(this.btnMarkAsRead_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClose.Location = new System.Drawing.Point(197, 18);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.informationBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(914, 366);
            this.panel2.TabIndex = 4;
            // 
            // informationBox
            // 
            this.informationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.informationBox.BackColor = System.Drawing.Color.White;
            this.informationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.informationBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.informationBox.Location = new System.Drawing.Point(9, 12);
            this.informationBox.Name = "informationBox";
            this.informationBox.ReadOnly = true;
            this.informationBox.Size = new System.Drawing.Size(896, 339);
            this.informationBox.TabIndex = 3;
            this.informationBox.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tableLayoutPanel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(10, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 514);
            this.panel3.TabIndex = 2;
            // 
            // ViewMessage
            // 
            this.AcceptButton = this.btnMarkAsRead;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(940, 534);
            this.Controls.Add(this.panel3);
            this.Name = "ViewMessage";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Recording System :: View Message";
            this.Load += new System.EventHandler(this.ViewMessage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label subjectLabel;
        private TextBox pupilName;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox recordedOn;
        private Label label3;
        private TextBox teacher;
        private Panel panel1;
        private Button btnMarkAsRead;
        private Button btnClose;
        private Panel panel2;
        private RichTextBox informationBox;
        private Panel panel3;
    }
}