namespace NFSU2_Money_Cheat
{
    partial class Form1
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
            dbPanelMain = new XChange_V1._0.DoubleBufferedPanel();
            tlpMain = new TableLayoutPanel();
            lblEnterAmount = new Label();
            dbPanelSelectSaveFile = new XChange_V1._0.DoubleBufferedPanel();
            btnSelectSaveFile = new Button();
            dbPanelSaveFilePath = new XChange_V1._0.DoubleBufferedPanel();
            lblSaveFilePath = new Label();
            txtAmount = new TextBox();
            pbCoverArt = new PictureBox();
            dbPanelHeading = new XChange_V1._0.DoubleBufferedPanel();
            lblHeading = new Label();
            dbPanelControls = new XChange_V1._0.DoubleBufferedPanel();
            btnApplyCheat = new Button();
            btnCancel = new Button();
            lblAbout = new Label();
            dbPanelMain.SuspendLayout();
            tlpMain.SuspendLayout();
            dbPanelSelectSaveFile.SuspendLayout();
            dbPanelSaveFilePath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).BeginInit();
            dbPanelHeading.SuspendLayout();
            dbPanelControls.SuspendLayout();
            SuspendLayout();
            // 
            // dbPanelMain
            // 
            dbPanelMain.Controls.Add(tlpMain);
            dbPanelMain.Controls.Add(pbCoverArt);
            dbPanelMain.Controls.Add(dbPanelHeading);
            dbPanelMain.Controls.Add(dbPanelControls);
            dbPanelMain.Dock = DockStyle.Fill;
            dbPanelMain.Location = new Point(0, 0);
            dbPanelMain.Name = "dbPanelMain";
            dbPanelMain.Size = new Size(660, 268);
            dbPanelMain.TabIndex = 0;
            // 
            // tlpMain
            // 
            tlpMain.ColumnCount = 2;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.01222F));
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.98778F));
            tlpMain.Controls.Add(lblEnterAmount, 0, 1);
            tlpMain.Controls.Add(dbPanelSelectSaveFile, 0, 0);
            tlpMain.Controls.Add(dbPanelSaveFilePath, 1, 0);
            tlpMain.Controls.Add(txtAmount, 1, 1);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(169, 44);
            tlpMain.Name = "tlpMain";
            tlpMain.RowCount = 2;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMain.Size = new Size(491, 169);
            tlpMain.TabIndex = 0;
            // 
            // lblEnterAmount
            // 
            lblEnterAmount.Dock = DockStyle.Fill;
            lblEnterAmount.Location = new Point(3, 84);
            lblEnterAmount.Name = "lblEnterAmount";
            lblEnterAmount.Size = new Size(161, 85);
            lblEnterAmount.TabIndex = 2;
            lblEnterAmount.Text = "Enter Amount:";
            lblEnterAmount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dbPanelSelectSaveFile
            // 
            dbPanelSelectSaveFile.Controls.Add(btnSelectSaveFile);
            dbPanelSelectSaveFile.Dock = DockStyle.Fill;
            dbPanelSelectSaveFile.Location = new Point(3, 3);
            dbPanelSelectSaveFile.Name = "dbPanelSelectSaveFile";
            dbPanelSelectSaveFile.Size = new Size(161, 78);
            dbPanelSelectSaveFile.TabIndex = 0;
            // 
            // btnSelectSaveFile
            // 
            btnSelectSaveFile.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSelectSaveFile.Location = new Point(2, 19);
            btnSelectSaveFile.Name = "btnSelectSaveFile";
            btnSelectSaveFile.Size = new Size(157, 41);
            btnSelectSaveFile.TabIndex = 0;
            btnSelectSaveFile.Text = "&Select";
            btnSelectSaveFile.UseVisualStyleBackColor = true;
            btnSelectSaveFile.Click += btnSelectSaveFile_Click;
            btnSelectSaveFile.KeyDown += General_KeyDown;
            // 
            // dbPanelSaveFilePath
            // 
            dbPanelSaveFilePath.Controls.Add(lblSaveFilePath);
            dbPanelSaveFilePath.Dock = DockStyle.Fill;
            dbPanelSaveFilePath.Location = new Point(170, 3);
            dbPanelSaveFilePath.Name = "dbPanelSaveFilePath";
            dbPanelSaveFilePath.Size = new Size(318, 78);
            dbPanelSaveFilePath.TabIndex = 0;
            // 
            // lblSaveFilePath
            // 
            lblSaveFilePath.Dock = DockStyle.Fill;
            lblSaveFilePath.Location = new Point(0, 0);
            lblSaveFilePath.Name = "lblSaveFilePath";
            lblSaveFilePath.Size = new Size(318, 78);
            lblSaveFilePath.TabIndex = 1;
            lblSaveFilePath.Text = "<== SELECT SAVE FILE";
            lblSaveFilePath.TextAlign = ContentAlignment.MiddleLeft;
            lblSaveFilePath.TextChanged += lblSaveFilePath_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Anchor = AnchorStyles.None;
            txtAmount.Location = new Point(194, 109);
            txtAmount.Name = "txtAmount";
            txtAmount.PlaceholderText = "0.00";
            txtAmount.RightToLeft = RightToLeft.Yes;
            txtAmount.Size = new Size(269, 34);
            txtAmount.TabIndex = 3;
            txtAmount.KeyDown += General_KeyDown;
            txtAmount.KeyPress += txtAmount_KeyPress;
            txtAmount.Leave += txtAmount_Leave;
            // 
            // pbCoverArt
            // 
            pbCoverArt.BorderStyle = BorderStyle.Fixed3D;
            pbCoverArt.Dock = DockStyle.Left;
            pbCoverArt.Image = Properties.Resources.nfsu2_cover;
            pbCoverArt.Location = new Point(0, 44);
            pbCoverArt.Name = "pbCoverArt";
            pbCoverArt.Size = new Size(169, 169);
            pbCoverArt.SizeMode = PictureBoxSizeMode.Zoom;
            pbCoverArt.TabIndex = 2;
            pbCoverArt.TabStop = false;
            // 
            // dbPanelHeading
            // 
            dbPanelHeading.Controls.Add(lblHeading);
            dbPanelHeading.Dock = DockStyle.Top;
            dbPanelHeading.Location = new Point(0, 0);
            dbPanelHeading.Name = "dbPanelHeading";
            dbPanelHeading.Size = new Size(660, 44);
            dbPanelHeading.TabIndex = 1;
            // 
            // lblHeading
            // 
            lblHeading.Dock = DockStyle.Fill;
            lblHeading.Location = new Point(0, 0);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(660, 44);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Need For Speed Underground 2 Money Cheat";
            lblHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dbPanelControls
            // 
            dbPanelControls.BorderStyle = BorderStyle.FixedSingle;
            dbPanelControls.Controls.Add(lblAbout);
            dbPanelControls.Controls.Add(btnApplyCheat);
            dbPanelControls.Controls.Add(btnCancel);
            dbPanelControls.Dock = DockStyle.Bottom;
            dbPanelControls.Location = new Point(0, 213);
            dbPanelControls.Name = "dbPanelControls";
            dbPanelControls.Size = new Size(660, 55);
            dbPanelControls.TabIndex = 1;
            // 
            // btnApplyCheat
            // 
            btnApplyCheat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnApplyCheat.Location = new Point(313, 6);
            btnApplyCheat.Name = "btnApplyCheat";
            btnApplyCheat.Size = new Size(196, 41);
            btnApplyCheat.TabIndex = 0;
            btnApplyCheat.Text = "<F12> &Apply Cheat";
            btnApplyCheat.UseVisualStyleBackColor = true;
            btnApplyCheat.Click += btnApplyCheat_Click;
            btnApplyCheat.KeyDown += General_KeyDown;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCancel.Location = new Point(150, 6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(157, 41);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "<Esc> &Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            btnCancel.KeyDown += General_KeyDown;
            // 
            // lblAbout
            // 
            lblAbout.Dock = DockStyle.Right;
            lblAbout.Location = new Point(595, 0);
            lblAbout.Name = "lblAbout";
            lblAbout.Size = new Size(63, 53);
            lblAbout.TabIndex = 2;
            lblAbout.Text = "?";
            lblAbout.TextAlign = ContentAlignment.MiddleCenter;
            lblAbout.Click += lblAbout_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 268);
            Controls.Add(dbPanelMain);
            DoubleBuffered = true;
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Need For Speed Underground 2 - Money Cheat";
            dbPanelMain.ResumeLayout(false);
            tlpMain.ResumeLayout(false);
            tlpMain.PerformLayout();
            dbPanelSelectSaveFile.ResumeLayout(false);
            dbPanelSaveFilePath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCoverArt).EndInit();
            dbPanelHeading.ResumeLayout(false);
            dbPanelControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private XChange_V1._0.DoubleBufferedPanel dbPanelMain;
        private XChange_V1._0.DoubleBufferedPanel dbPanelControls;
        private Button btnApplyCheat;
        private Button btnCancel;
        private XChange_V1._0.DoubleBufferedPanel dbPanelHeading;
        private Label lblHeading;
        private PictureBox pbCoverArt;
        private TableLayoutPanel tlpMain;
        private Label lblEnterAmount;
        private XChange_V1._0.DoubleBufferedPanel dbPanelSelectSaveFile;
        private Button btnSelectSaveFile;
        private XChange_V1._0.DoubleBufferedPanel dbPanelSaveFilePath;
        private Label lblSaveFilePath;
        private TextBox txtAmount;
        private Label lblAbout;
    }
}
