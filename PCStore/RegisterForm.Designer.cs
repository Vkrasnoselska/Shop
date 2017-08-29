namespace PCStore
{
    partial class RegisterForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearAllBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.birthDP = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.manRB = new System.Windows.Forms.RadioButton();
            this.womanRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mnameTB = new System.Windows.Forms.TextBox();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.confirmPassTB = new System.Windows.Forms.TextBox();
            this.createProfileBut = new System.Windows.Forms.Button();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.clearAllBut);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 62);
            this.panel1.TabIndex = 0;
            // 
            // clearAllBut
            // 
            this.clearAllBut.Location = new System.Drawing.Point(447, 5);
            this.clearAllBut.Name = "clearAllBut";
            this.clearAllBut.Size = new System.Drawing.Size(134, 47);
            this.clearAllBut.TabIndex = 27;
            this.clearAllBut.Text = "Очистить";
            this.clearAllBut.UseVisualStyleBackColor = true;
            this.clearAllBut.Click += new System.EventHandler(this.clearAllBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Регистрация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя:";
            // 
            // fnameTB
            // 
            this.fnameTB.Location = new System.Drawing.Point(215, 76);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(366, 29);
            this.fnameTB.TabIndex = 2;
            this.fnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // birthDP
            // 
            this.birthDP.Location = new System.Drawing.Point(215, 246);
            this.birthDP.Name = "birthDP";
            this.birthDP.Size = new System.Drawing.Size(366, 29);
            this.birthDP.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.manRB);
            this.panel2.Controls.Add(this.womanRB);
            this.panel2.Location = new System.Drawing.Point(215, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 54);
            this.panel2.TabIndex = 4;
            // 
            // manRB
            // 
            this.manRB.AutoSize = true;
            this.manRB.Location = new System.Drawing.Point(116, 9);
            this.manRB.Name = "manRB";
            this.manRB.Size = new System.Drawing.Size(108, 28);
            this.manRB.TabIndex = 6;
            this.manRB.Text = "Мужской";
            this.manRB.UseVisualStyleBackColor = true;
            // 
            // womanRB
            // 
            this.womanRB.AutoSize = true;
            this.womanRB.Checked = true;
            this.womanRB.Location = new System.Drawing.Point(3, 9);
            this.womanRB.Name = "womanRB";
            this.womanRB.Size = new System.Drawing.Size(107, 28);
            this.womanRB.TabIndex = 5;
            this.womanRB.TabStop = true;
            this.womanRB.Text = "Женский";
            this.womanRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Отчество:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Фамилия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Дата рождения:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Пол:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 356);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Адрес:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 414);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Телефон:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 24);
            this.label10.TabIndex = 13;
            this.label10.Text = "Пароль:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 578);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 24);
            this.label11.TabIndex = 14;
            this.label11.Text = "Подтверждение ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 602);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 24);
            this.label12.TabIndex = 15;
            this.label12.Text = "пароля :";
            // 
            // mnameTB
            // 
            this.mnameTB.Location = new System.Drawing.Point(215, 134);
            this.mnameTB.Name = "mnameTB";
            this.mnameTB.Size = new System.Drawing.Size(366, 29);
            this.mnameTB.TabIndex = 16;
            this.mnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lnameTB
            // 
            this.lnameTB.Location = new System.Drawing.Point(215, 189);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(366, 29);
            this.lnameTB.TabIndex = 17;
            this.lnameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(215, 356);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(366, 29);
            this.adressTB.TabIndex = 18;
            this.adressTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(215, 414);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(366, 29);
            this.emailTB.TabIndex = 19;
            this.emailTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(215, 515);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(366, 29);
            this.passTB.TabIndex = 21;
            this.passTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmPassTB
            // 
            this.confirmPassTB.Location = new System.Drawing.Point(215, 578);
            this.confirmPassTB.Name = "confirmPassTB";
            this.confirmPassTB.PasswordChar = '*';
            this.confirmPassTB.Size = new System.Drawing.Size(366, 29);
            this.confirmPassTB.TabIndex = 22;
            this.confirmPassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // createProfileBut
            // 
            this.createProfileBut.Location = new System.Drawing.Point(27, 654);
            this.createProfileBut.Name = "createProfileBut";
            this.createProfileBut.Size = new System.Drawing.Size(554, 55);
            this.createProfileBut.TabIndex = 26;
            this.createProfileBut.Text = "Зарегистрироваться";
            this.createProfileBut.UseVisualStyleBackColor = true;
            this.createProfileBut.Click += new System.EventHandler(this.createProfileBut_Click);
            // 
            // phoneTB
            // 
            this.phoneTB.Location = new System.Drawing.Point(215, 465);
            this.phoneTB.MaxLength = 10;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(366, 29);
            this.phoneTB.TabIndex = 20;
            this.phoneTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 741);
            this.Controls.Add(this.phoneTB);
            this.Controls.Add(this.createProfileBut);
            this.Controls.Add(this.confirmPassTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.lnameTB);
            this.Controls.Add(this.mnameTB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.birthDP);
            this.Controls.Add(this.fnameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.DateTimePicker birthDP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton womanRB;
        private System.Windows.Forms.RadioButton manRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox mnameTB;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox confirmPassTB;
        private System.Windows.Forms.Button createProfileBut;
        private System.Windows.Forms.Button clearAllBut;
        private System.Windows.Forms.TextBox phoneTB;
    }
}