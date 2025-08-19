namespace NFSU2_Money_Cheat
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            dbPanelMain = new XChange_V1._0.DoubleBufferedPanel();
            dbPanelBottom = new XChange_V1._0.DoubleBufferedPanel();
            rtbCopyrightInfo = new RichTextBox();
            lblAboutMe = new Label();
            dbPanelMain.SuspendLayout();
            dbPanelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // dbPanelMain
            // 
            dbPanelMain.Controls.Add(dbPanelBottom);
            dbPanelMain.Controls.Add(rtbCopyrightInfo);
            dbPanelMain.Dock = DockStyle.Fill;
            dbPanelMain.Location = new Point(0, 0);
            dbPanelMain.Name = "dbPanelMain";
            dbPanelMain.Size = new Size(398, 355);
            dbPanelMain.TabIndex = 0;
            // 
            // dbPanelBottom
            // 
            dbPanelBottom.Controls.Add(lblAboutMe);
            dbPanelBottom.Dock = DockStyle.Bottom;
            dbPanelBottom.Location = new Point(0, 307);
            dbPanelBottom.Name = "dbPanelBottom";
            dbPanelBottom.Size = new Size(398, 48);
            dbPanelBottom.TabIndex = 1;
            // 
            // rtbCopyrightInfo
            // 
            rtbCopyrightInfo.Dock = DockStyle.Fill;
            rtbCopyrightInfo.Location = new Point(0, 0);
            rtbCopyrightInfo.Name = "rtbCopyrightInfo";
            rtbCopyrightInfo.Size = new Size(398, 355);
            rtbCopyrightInfo.TabIndex = 0;
            rtbCopyrightInfo.Text = resources.GetString("rtbCopyrightInfo.Text");
            rtbCopyrightInfo.KeyPress += rtbCopyrightInfo_KeyPress;
            // 
            // lblAboutMe
            // 
            lblAboutMe.Dock = DockStyle.Fill;
            lblAboutMe.Location = new Point(0, 0);
            lblAboutMe.Name = "lblAboutMe";
            lblAboutMe.Size = new Size(398, 48);
            lblAboutMe.TabIndex = 0;
            lblAboutMe.Text = "Made with ❤️ by Aryaan Lambe. | aryaanlambe.github.io";
            lblAboutMe.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 355);
            Controls.Add(dbPanelMain);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Need For Speed Underground 2 - Money Cheat";
            dbPanelMain.ResumeLayout(false);
            dbPanelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private XChange_V1._0.DoubleBufferedPanel dbPanelMain;
        private XChange_V1._0.DoubleBufferedPanel dbPanelBottom;
        private RichTextBox rtbCopyrightInfo;
        private Label lblAboutMe;
    }
}