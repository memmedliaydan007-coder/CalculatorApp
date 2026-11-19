using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "1-ci ədəd (A):";
            label2.Text = "2-ci ədəd (B):";
            lblResult.Text = "Nəticə:";

            btnAdd.Text = "+";
            btnSub.Text = "−";
            btnMul.Text = "×";
            btnDiv.Text = "÷";
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) || !int.TryParse(txtB.Text.Trim(), out int b))
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa yalnız tam ədəd daxil edin!";
                return;
            }

            int result = a + b;
            lblResult.Text = $"Nəticə: {a} + {b} = {result}";
        }

    
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) || !int.TryParse(txtB.Text.Trim(), out int b))
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa yalnız tam ədəd daxil edin!";
                return;
            }

            int result = a - b;
            lblResult.Text = $"Nəticə: {a} − {b} = {result}";
        }

   
        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) || !int.TryParse(txtB.Text.Trim(), out int b))
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa yalnız tam ədəd daxil edin!";
                return;
            }

            int result = a * b;
            lblResult.Text = $"Nəticə: {a} × {b} = {result}";
        }


        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text.Trim(), out int a) || !int.TryParse(txtB.Text.Trim(), out int b))
            {
                lblResult.Text = "Xəbərdarlıq: Zəhmət olmasa yalnız tam ədəd daxil edin!";
                return;
            }

            if (b == 0)
            {
                lblResult.Text = "Sıfıra bölmək olmaz!";
                return;
            }

            double result = (double)a / b;
            lblResult.Text = $"Nəticə: {a} ÷ {b} = {result:0.##}";
        }
    }
}