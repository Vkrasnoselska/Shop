namespace PCStore
{
    partial class OrderForm
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
            this.orderGoodPB = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.paymentCB = new System.Windows.Forms.ComboBox();
            this.deliveryCB = new System.Windows.Forms.ComboBox();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.buyBut = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.deliveryTB = new System.Windows.Forms.TextBox();
            this.costTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sizeTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.orderGoodPB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderGoodPB
            // 
            this.orderGoodPB.BackColor = System.Drawing.SystemColors.ControlDark;
            this.orderGoodPB.Location = new System.Drawing.Point(12, 68);
            this.orderGoodPB.Name = "orderGoodPB";
            this.orderGoodPB.Size = new System.Drawing.Size(577, 293);
            this.orderGoodPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderGoodPB.TabIndex = 0;
            this.orderGoodPB.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 63);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(167, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Оформление заказа";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 427);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Тип оплаты:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 488);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип доставки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 543);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Адрес:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(37, 575);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(530, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "(оставьте поле пустым если хотите использовать адрес профайла)";
            // 
            // paymentCB
            // 
            this.paymentCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.paymentCB.FormattingEnabled = true;
            this.paymentCB.Items.AddRange(new object[] {
            "Онлайн-оплата картой",
            "Наличными"});
            this.paymentCB.Location = new System.Drawing.Point(162, 424);
            this.paymentCB.Name = "paymentCB";
            this.paymentCB.Size = new System.Drawing.Size(427, 32);
            this.paymentCB.TabIndex = 8;
            // 
            // deliveryCB
            // 
            this.deliveryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deliveryCB.FormattingEnabled = true;
            this.deliveryCB.Items.AddRange(new object[] {
            "Курьерская",
            "Самовывоз"});
            this.deliveryCB.Location = new System.Drawing.Point(162, 485);
            this.deliveryCB.Name = "deliveryCB";
            this.deliveryCB.Size = new System.Drawing.Size(427, 32);
            this.deliveryCB.TabIndex = 9;
            // 
            // adressTB
            // 
            this.adressTB.Location = new System.Drawing.Point(162, 543);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(427, 29);
            this.adressTB.TabIndex = 12;
            // 
            // buyBut
            // 
            this.buyBut.Location = new System.Drawing.Point(12, 708);
            this.buyBut.Name = "buyBut";
            this.buyBut.Size = new System.Drawing.Size(577, 60);
            this.buyBut.TabIndex = 13;
            this.buyBut.Text = "Отправить заказ";
            this.buyBut.UseVisualStyleBackColor = true;
            this.buyBut.Click += new System.EventHandler(this.buyBut_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 659);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Итого:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 619);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "Доставка:";
            // 
            // deliveryTB
            // 
            this.deliveryTB.Enabled = false;
            this.deliveryTB.Location = new System.Drawing.Point(162, 616);
            this.deliveryTB.Name = "deliveryTB";
            this.deliveryTB.Size = new System.Drawing.Size(427, 29);
            this.deliveryTB.TabIndex = 16;
            this.deliveryTB.Text = "70";
            // 
            // costTB
            // 
            this.costTB.Enabled = false;
            this.costTB.Location = new System.Drawing.Point(162, 659);
            this.costTB.Name = "costTB";
            this.costTB.Size = new System.Drawing.Size(427, 29);
            this.costTB.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "Размер:";
            // 
            // sizeTB
            // 
            this.sizeTB.Enabled = false;
            this.sizeTB.Location = new System.Drawing.Point(162, 375);
            this.sizeTB.Name = "sizeTB";
            this.sizeTB.Size = new System.Drawing.Size(427, 29);
            this.sizeTB.TabIndex = 19;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 780);
            this.Controls.Add(this.sizeTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.costTB);
            this.Controls.Add(this.deliveryTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buyBut);
            this.Controls.Add(this.adressTB);
            this.Controls.Add(this.deliveryCB);
            this.Controls.Add(this.paymentCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.orderGoodPB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OrderForm_FormClosed);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderGoodPB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox orderGoodPB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox paymentCB;
        private System.Windows.Forms.ComboBox deliveryCB;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.Button buyBut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deliveryTB;
        private System.Windows.Forms.TextBox costTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sizeTB;
    }
}