namespace kursach_2
{
    partial class enterForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.nubmerEnterTextBox = new System.Windows.Forms.TextBox();
            this.passwordEnterTextBox = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 452);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(106, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Войти";
            // 
            // nubmerEnterTextBox
            // 
            this.nubmerEnterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nubmerEnterTextBox.Location = new System.Drawing.Point(106, 182);
            this.nubmerEnterTextBox.Multiline = true;
            this.nubmerEnterTextBox.Name = "nubmerEnterTextBox";
            this.nubmerEnterTextBox.Size = new System.Drawing.Size(228, 28);
            this.nubmerEnterTextBox.TabIndex = 2;
            this.nubmerEnterTextBox.TextChanged += new System.EventHandler(this.NubmerEnterTextBox_TextChanged);
            this.nubmerEnterTextBox.Enter += new System.EventHandler(this.nubmerEnterTextBox_Enter);
            this.nubmerEnterTextBox.Leave += new System.EventHandler(this.nubmerEnterTextBox_Leave);
            // 
            // passwordEnterTextBox
            // 
            this.passwordEnterTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.passwordEnterTextBox.Location = new System.Drawing.Point(106, 228);
            this.passwordEnterTextBox.Name = "passwordEnterTextBox";
            this.passwordEnterTextBox.Size = new System.Drawing.Size(228, 31);
            this.passwordEnterTextBox.TabIndex = 3;
            this.passwordEnterTextBox.TextChanged += new System.EventHandler(this.PasswordEnterTextBox_TextChanged);
            this.passwordEnterTextBox.Enter += new System.EventHandler(this.passwordEnterTextBox_Enter);
            this.passwordEnterTextBox.Leave += new System.EventHandler(this.passwordEnterTextBox_Leave);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(106, 283);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 4;
            this.enterButton.Text = "Вход";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(111, 262);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Нет аккаунта?";
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // enterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.passwordEnterTextBox);
            this.Controls.Add(this.nubmerEnterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(374, 489);
            this.Name = "enterForm";
            this.Text = "enterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nubmerEnterTextBox;
        private System.Windows.Forms.TextBox passwordEnterTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}