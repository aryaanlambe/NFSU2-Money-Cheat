using System.Globalization;

namespace NFSU2_Money_Cheat
{
    public partial class Form1 : Form
    {
        #region Declarations. Click to Expand.

        const long NFSU2_MONEY_FILE_OFFSET = 0xA16A;
        private string _saveFileLocation; // Used to store where the save file is located

        public Form1()
        {
            InitializeComponent();
        }

        #endregion

        #region Getters & Setters. Click to Expand.

        public string GetSaveFileLocation()
        {
            return _saveFileLocation;
        }

        public void SetSaveFileLocation(string saveFileLocation)
        {
            _saveFileLocation = saveFileLocation;
        }

        #endregion

        static void PrintCurrentMoney(string saveFile)
        {
            try
            {
                using var fs = new FileStream(saveFile, FileMode.Open, FileAccess.Read);
                fs.Seek(NFSU2_MONEY_FILE_OFFSET, SeekOrigin.Begin);
                byte[] moneyArr = new byte[4];
                fs.Read(moneyArr, 0, 4);
                int moneyStored = BitConverter.ToInt32(moneyArr, 0);
                MessageBox.Show($"Money stored within save file = {moneyStored}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading save file '{saveFile}': {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void BackupSaveFile(string origSaveFile)
        {
            try
            {
                var dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH.mm.ss", CultureInfo.InvariantCulture);
                var backupFilePath = $"{origSaveFile}.{dateTime}.backup";

                if (!File.Exists(origSaveFile))
                    throw new FileNotFoundException("Save file not found.");

                File.Copy(origSaveFile, backupFilePath);
                Console.WriteLine("Save file backed up at:  " + backupFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error backing up save file '{origSaveFile}': {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void EditMoneySaveFile(uint money, string saveFile)
        {
            try
            {
                using var fs = new FileStream(saveFile, FileMode.Open, FileAccess.Write);
                fs.Seek(NFSU2_MONEY_FILE_OFFSET, SeekOrigin.Begin);
                byte[] moneyArr = BitConverter.GetBytes(money);
                fs.Write(moneyArr, 0, 4);
                MessageBox.Show($"Balance in your NFSU2 bank is now {money}. Enjoy!", "NFSU2 Bank Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to save file '{saveFile}': {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Default Form Handlers. Click to Expand.

        private void btnSelectSaveFile_Click(object sender, EventArgs e)
        {
            // Get the full path to AppData\Local\NFS Underground 2
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string nfsu2Path = Path.Combine(localAppData, "NFS Underground 2");

            // Create and configure the OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = Directory.Exists(nfsu2Path) ? nfsu2Path : localAppData,
                Title = "Select NFSU2 Save File",
                Filter = "All Files (*.*)|*.*",
                RestoreDirectory = true
            };

            // Show the dialog and capture the result
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the entire path to a variable, this will be used actually perform the money hack to save file
                SetSaveFileLocation(openFileDialog.FileName);
                // Set the selected file path to Save File Path label
                lblSaveFilePath.Text = openFileDialog.FileName;
                // Set focus to amount field to allow user to enter some amount.
                txtAmount.SelectAll();
                txtAmount.Focus();
            }

        }

        private void btnApplyCheat_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtAmount.Text, out int moneyInt) || moneyInt < 0)
            {
                MessageBox.Show("Money must be a non-negative integer", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmount.SelectAll();
                txtAmount.Focus();
                return; // Break out of function
            }
            else
            {
                BackupSaveFile(GetSaveFileLocation());
                EditMoneySaveFile((uint)moneyInt, GetSaveFileLocation());
                txtAmount.Clear(); // Clear input once processed
                txtAmount.SelectAll();
                txtAmount.Focus(); // Change focus back to amount entry in case user wants to change amount
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) =>
            Application.Exit();


        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = sender as TextBox;

            // Allow control keys (e.g., Backspace)
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Block everything else
            e.Handled = true;
        }


        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal value))
            {
                txtAmount.Text = value.ToString();
            }
            else
            {
                // Optional fallback for invalid input
                txtAmount.Text = "0";
            }
        }


        private void General_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (btnCancel.Enabled == true)
                {
                    btnCancel.PerformClick();
                }
            }
            else if (e.KeyCode == Keys.Enter && txtAmount.Focused)
            {
                btnApplyCheat.Focus();
            }
            else if (e.KeyCode == Keys.F12)
            {
                if (btnApplyCheat.Enabled == true)
                {
                    btnApplyCheat.PerformClick();
                }
            }
        }


        private void lblSaveFilePath_TextChanged(object sender, EventArgs e) =>
            PrintCurrentMoney(GetSaveFileLocation());

        #endregion
    }
}
