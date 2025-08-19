namespace NFSU2_Money_Cheat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            // Allow one decimal point
            if (e.KeyChar == '.' && !txt.Text.Contains("."))
                return;

            // Block everything else
            e.Handled = true;
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal value))
            {
                txtAmount.Text = value.ToString("F2");
            }
            else
            {
                // Optional fallback for invalid input
                txtAmount.Text = "0.00";
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
    }
}
