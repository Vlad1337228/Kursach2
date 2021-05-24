namespace kursach_2
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.searchLine = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.enterBTN = new System.Windows.Forms.Button();
            this.submitBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.filterBTN = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.exitBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deleteAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(-10, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1133, 185);
            this.label1.TabIndex = 1;
            // 
            // searchLine
            // 
            this.searchLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLine.Location = new System.Drawing.Point(209, 100);
            this.searchLine.Margin = new System.Windows.Forms.Padding(200);
            this.searchLine.Multiline = true;
            this.searchLine.Name = "searchLine";
            this.searchLine.Size = new System.Drawing.Size(517, 34);
            this.searchLine.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(72)))), ((int)(((byte)(133)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(5, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // searchBTN
            // 
            this.searchBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchBTN.BackgroundImage")));
            this.searchBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBTN.Location = new System.Drawing.Point(732, 100);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(37, 34);
            this.searchBTN.TabIndex = 14;
            this.searchBTN.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(8)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(-1, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1114, 354);
            this.label2.TabIndex = 17;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // enterBTN
            // 
            this.enterBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.enterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBTN.Location = new System.Drawing.Point(962, 17);
            this.enterBTN.Name = "enterBTN";
            this.enterBTN.Size = new System.Drawing.Size(60, 23);
            this.enterBTN.TabIndex = 18;
            this.enterBTN.Text = "Вход";
            this.enterBTN.UseVisualStyleBackColor = true;
            this.enterBTN.Click += new System.EventHandler(this.enterBTN_Click);
            // 
            // submitBTN
            // 
            this.submitBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitBTN.Location = new System.Drawing.Point(962, 46);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(134, 23);
            this.submitBTN.TabIndex = 19;
            this.submitBTN.Text = "Подать объявление";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.SubmitBTN_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clearBTN.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clearBTN.BackgroundImage")));
            this.clearBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clearBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBTN.Location = new System.Drawing.Point(688, 100);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(38, 34);
            this.clearBTN.TabIndex = 20;
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(206, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(475, 66);
            this.label4.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(321, 380);
            this.label6.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(391, 572);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(321, 380);
            this.label7.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(775, 572);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 380);
            this.label8.TabIndex = 29;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox3.Location = new System.Drawing.Point(71, 777);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(210, 31);
            this.textBox3.TabIndex = 33;
            this.textBox3.Text = "Доделать предложку";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox4.Location = new System.Drawing.Point(450, 777);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(210, 31);
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = "Доделать предложку";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.textBox5.Location = new System.Drawing.Point(828, 777);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(210, 31);
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = "Доделать предложку";
            // 
            // filterBTN
            // 
            this.filterBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(8)))), ((int)(((byte)(133)))));
            this.filterBTN.FlatAppearance.BorderSize = 0;
            this.filterBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.filterBTN.ForeColor = System.Drawing.Color.White;
            this.filterBTN.Location = new System.Drawing.Point(828, 461);
            this.filterBTN.Name = "filterBTN";
            this.filterBTN.Size = new System.Drawing.Size(255, 46);
            this.filterBTN.TabIndex = 37;
            this.filterBTN.Text = "Поиск по фильтрам";
            this.filterBTN.UseVisualStyleBackColor = false;
            this.filterBTN.Click += new System.EventHandler(this.FilterBTN_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label9.Location = new System.Drawing.Point(990, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 15);
            this.label9.TabIndex = 38;
            this.label9.Text = "Все предложения";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // exitBTN
            // 
            this.exitBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBTN.Location = new System.Drawing.Point(1036, 17);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(60, 23);
            this.exitBTN.TabIndex = 39;
            this.exitBTN.Text = "Выход";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(12, 541);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 40;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deleteAuto
            // 
            this.deleteAuto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteAuto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAuto.Location = new System.Drawing.Point(962, 75);
            this.deleteAuto.Name = "deleteAuto";
            this.deleteAuto.Size = new System.Drawing.Size(134, 23);
            this.deleteAuto.TabIndex = 42;
            this.deleteAuto.Text = "Удалить объявление";
            this.deleteAuto.UseVisualStyleBackColor = true;
            this.deleteAuto.Click += new System.EventHandler(this.DeleteAuto_Click);
            // 
            // mainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 961);
            this.Controls.Add(this.deleteAuto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.filterBTN);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.enterBTN);
            this.Controls.Add(this.searchBTN);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1124, 1000);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "АвтоДрайв";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button filterBTN;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button enterBTN;
        public System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button deleteAuto;
    }
}

