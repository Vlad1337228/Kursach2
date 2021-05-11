namespace kursach_2
{
    partial class registerForm
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
            this.secondNameBoxRegister = new System.Windows.Forms.TextBox();
            this.nameBoxRegister = new System.Windows.Forms.TextBox();
            this.numberBoxRegister = new System.Windows.Forms.TextBox();
            this.passwordBoxRegister = new System.Windows.Forms.TextBox();
            this.registerBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 452);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label2.Location = new System.Drawing.Point(116, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Регистрация";
            // 
            // secondNameBoxRegister
            // 
            this.secondNameBoxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.secondNameBoxRegister.Location = new System.Drawing.Point(121, 146);
            this.secondNameBoxRegister.Multiline = true;
            this.secondNameBoxRegister.Name = "secondNameBoxRegister";
            this.secondNameBoxRegister.Size = new System.Drawing.Size(227, 28);
            this.secondNameBoxRegister.TabIndex = 2;
            this.secondNameBoxRegister.Enter += new System.EventHandler(this.secondNameBoxRegister_Enter);
            this.secondNameBoxRegister.Leave += new System.EventHandler(this.secondNameBoxRegister_Leave);
            // 
            // nameBoxRegister
            // 
            this.nameBoxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.nameBoxRegister.Location = new System.Drawing.Point(121, 196);
            this.nameBoxRegister.Multiline = true;
            this.nameBoxRegister.Name = "nameBoxRegister";
            this.nameBoxRegister.Size = new System.Drawing.Size(227, 28);
            this.nameBoxRegister.TabIndex = 3;
            this.nameBoxRegister.Enter += new System.EventHandler(this.nameBoxRegister_Enter);
            this.nameBoxRegister.Leave += new System.EventHandler(this.nameBoxRegister_Leave);
            // 
            // numberBoxRegister
            // 
            this.numberBoxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.numberBoxRegister.Location = new System.Drawing.Point(121, 245);
            this.numberBoxRegister.Multiline = true;
            this.numberBoxRegister.Name = "numberBoxRegister";
            this.numberBoxRegister.Size = new System.Drawing.Size(227, 28);
            this.numberBoxRegister.TabIndex = 4;
            this.numberBoxRegister.Enter += new System.EventHandler(this.numberBoxRegister_Enter);
            this.numberBoxRegister.Leave += new System.EventHandler(this.numberBoxRegister_Leave);
            // 
            // passwordBoxRegister
            // 
            this.passwordBoxRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.passwordBoxRegister.Location = new System.Drawing.Point(121, 294);
            this.passwordBoxRegister.Name = "passwordBoxRegister";
            this.passwordBoxRegister.Size = new System.Drawing.Size(227, 31);
            this.passwordBoxRegister.TabIndex = 5;
            this.passwordBoxRegister.Enter += new System.EventHandler(this.passwordBoxRegister_Enter);
            this.passwordBoxRegister.Leave += new System.EventHandler(this.passwordBoxRegister_Leave);
            // 
            // registerBTN
            // 
            this.registerBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.registerBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBTN.Location = new System.Drawing.Point(121, 345);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(75, 23);
            this.registerBTN.TabIndex = 6;
            this.registerBTN.Text = "OK";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // registerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.passwordBoxRegister);
            this.Controls.Add(this.numberBoxRegister);
            this.Controls.Add(this.nameBoxRegister);
            this.Controls.Add(this.secondNameBoxRegister);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(457, 489);
            this.MinimumSize = new System.Drawing.Size(457, 489);
            this.Name = "registerForm";
            this.Text = "registerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secondNameBoxRegister;
        private System.Windows.Forms.TextBox nameBoxRegister;
        private System.Windows.Forms.TextBox numberBoxRegister;
        private System.Windows.Forms.TextBox passwordBoxRegister;
        private System.Windows.Forms.Button registerBTN;
    }
}