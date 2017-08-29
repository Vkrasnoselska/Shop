namespace PCStore
{
    partial class ChangePassForm
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
            this.notifyLabel = new System.Windows.Forms.Label();
            this.savePassTB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmNewTB = new System.Windows.Forms.TextBox();
            this.newPassTB = new System.Windows.Forms.TextBox();
            this.oldPassTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // notifyLabel
            // 
            this.notifyLabel.AutoSize = true;
            this.notifyLabel.Location = new System.Drawing.Point(15, 274);
            this.notifyLabel.Name = "notifyLabel";
            this.notifyLabel.Size = new System.Drawing.Size(56, 24);
            this.notifyLabel.TabIndex = 15;
            this.notifyLabel.Text = "Notify";
            this.notifyLabel.Visible = false;
            // 
            // savePassTB
            // 
            this.savePassTB.Location = new System.Drawing.Point(15, 317);
            this.savePassTB.Name = "savePassTB";
            this.savePassTB.Size = new System.Drawing.Size(354, 50);
            this.savePassTB.TabIndex = 14;
            this.savePassTB.Text = "Сохранить изменения";
            this.savePassTB.UseVisualStyleBackColor = true;
            this.savePassTB.Click += new System.EventHandler(this.savePassTB_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторите новый пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Введите новый пароль:";
            // 
            // confirmNewTB
            // 
            this.confirmNewTB.Location = new System.Drawing.Point(15, 221);
            this.confirmNewTB.Margin = new System.Windows.Forms.Padding(6);
            this.confirmNewTB.Name = "confirmNewTB";
            this.confirmNewTB.PasswordChar = '*';
            this.confirmNewTB.Size = new System.Drawing.Size(354, 29);
            this.confirmNewTB.TabIndex = 11;
            // 
            // newPassTB
            // 
            this.newPassTB.Location = new System.Drawing.Point(15, 134);
            this.newPassTB.Margin = new System.Windows.Forms.Padding(6);
            this.newPassTB.Name = "newPassTB";
            this.newPassTB.PasswordChar = '*';
            this.newPassTB.Size = new System.Drawing.Size(354, 29);
            this.newPassTB.TabIndex = 10;
            // 
            // oldPassTB
            // 
            this.oldPassTB.Location = new System.Drawing.Point(15, 49);
            this.oldPassTB.Margin = new System.Windows.Forms.Padding(6);
            this.oldPassTB.Name = "oldPassTB";
            this.oldPassTB.PasswordChar = '*';
            this.oldPassTB.Size = new System.Drawing.Size(354, 29);
            this.oldPassTB.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Введите старый пароль:";
            // 
            // ChangePassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 387);
            this.Controls.Add(this.notifyLabel);
            this.Controls.Add(this.savePassTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.confirmNewTB);
            this.Controls.Add(this.newPassTB);
            this.Controls.Add(this.oldPassTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePassForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notifyLabel;
        private System.Windows.Forms.Button savePassTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirmNewTB;
        private System.Windows.Forms.TextBox newPassTB;
        private System.Windows.Forms.TextBox oldPassTB;
        private System.Windows.Forms.Label label1;
    }
}