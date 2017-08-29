namespace PCStore
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.passVisibleBut = new System.Windows.Forms.Button();
            this.loginBut = new System.Windows.Forms.Button();
            this.registerBut = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClearBut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль:";
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(12, 63);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(460, 38);
            this.loginTB.TabIndex = 2;
            this.loginTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(18, 192);
            this.passTB.Name = "passTB";
            this.passTB.PasswordChar = '*';
            this.passTB.Size = new System.Drawing.Size(454, 38);
            this.passTB.TabIndex = 3;
            this.passTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passVisibleBut
            // 
            this.passVisibleBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passVisibleBut.Location = new System.Drawing.Point(425, 129);
            this.passVisibleBut.Name = "passVisibleBut";
            this.passVisibleBut.Size = new System.Drawing.Size(47, 38);
            this.passVisibleBut.TabIndex = 4;
            this.passVisibleBut.Text = "L";
            this.passVisibleBut.UseVisualStyleBackColor = true;
            this.passVisibleBut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.passVisibleBut_MouseDown);
            this.passVisibleBut.MouseUp += new System.Windows.Forms.MouseEventHandler(this.passVisibleBut_MouseUp);
            // 
            // loginBut
            // 
            this.loginBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBut.Location = new System.Drawing.Point(18, 404);
            this.loginBut.Name = "loginBut";
            this.loginBut.Size = new System.Drawing.Size(454, 52);
            this.loginBut.TabIndex = 5;
            this.loginBut.Text = "Вход";
            this.loginBut.UseVisualStyleBackColor = true;
            this.loginBut.Click += new System.EventHandler(this.loginBut_Click);
            // 
            // registerBut
            // 
            this.registerBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerBut.Location = new System.Drawing.Point(18, 485);
            this.registerBut.Name = "registerBut";
            this.registerBut.Size = new System.Drawing.Size(454, 52);
            this.registerBut.TabIndex = 6;
            this.registerBut.Text = "Регистрация";
            this.registerBut.UseVisualStyleBackColor = true;
            this.registerBut.Click += new System.EventHandler(this.registerBut_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Image = global::PCStore.Properties.Resources.intro_wall;
            this.pictureBox1.Location = new System.Drawing.Point(491, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(746, 474);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ClearBut
            // 
            this.ClearBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearBut.Location = new System.Drawing.Point(361, 129);
            this.ClearBut.Name = "ClearBut";
            this.ClearBut.Size = new System.Drawing.Size(47, 38);
            this.ClearBut.TabIndex = 8;
            this.ClearBut.Text = "C";
            this.ClearBut.UseVisualStyleBackColor = true;
            this.ClearBut.Click += new System.EventHandler(this.ClearBut_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 607);
            this.Controls.Add(this.ClearBut);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerBut);
            this.Controls.Add(this.loginBut);
            this.Controls.Add(this.passVisibleBut);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Button passVisibleBut;
        private System.Windows.Forms.Button loginBut;
        private System.Windows.Forms.Button registerBut;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ClearBut;
    }
}

