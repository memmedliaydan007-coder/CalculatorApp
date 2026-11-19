namespace CalculatorApp
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
            txtA = new TextBox();
            txtB = new TextBox();
            btnAdd = new Button();
            btnSub = new Button();
            btnMul = new Button();
            btnDiv = new Button();
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // txtA
            // 
            txtA.Location = new Point(12, 55);
            txtA.Name = "txtA";
            txtA.Size = new Size(267, 23);
            txtA.TabIndex = 0;
            // 
            // txtB
            // 
            txtB.Location = new Point(371, 55);
            txtB.Name = "txtB";
            txtB.Size = new Size(266, 23);
            txtB.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 141);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(193, 141);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 3;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new Point(371, 141);
            btnMul.Name = "btnMul";
            btnMul.Size = new Size(75, 23);
            btnMul.TabIndex = 4;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new Point(576, 141);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(75, 23);
            btnDiv.TabIndex = 5;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(371, 18);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "label2";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(12, 232);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(38, 15);
            lblResult.TabIndex = 8;
            lblResult.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnAdd);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtA;
        private TextBox txtB;
        private Button btnAdd;
        private Button btnSub;
        private Button btnMul;
        private Button btnDiv;
        private Label label1;
        private Label label2;
        private Label lblResult;
    }
}
