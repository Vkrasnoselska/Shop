namespace PCStore
{
    partial class GeneralForm
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
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.HomeBut = new System.Windows.Forms.Button();
            this.ProfileBut = new System.Windows.Forms.Button();
            this.MyOrdersBut = new System.Windows.Forms.Button();
            this.ProfilePan = new System.Windows.Forms.Panel();
            this.adressTB = new System.Windows.Forms.TextBox();
            this.AvaPB = new System.Windows.Forms.PictureBox();
            this.phoneTB = new System.Windows.Forms.TextBox();
            this.changeAvaBut = new System.Windows.Forms.Button();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.editProfileBut = new System.Windows.Forms.Button();
            this.genderBut = new System.Windows.Forms.Button();
            this.saveChangedBut = new System.Windows.Forms.Button();
            this.genderTB = new System.Windows.Forms.TextBox();
            this.changePassBut = new System.Windows.Forms.Button();
            this.lnameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birthDP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.fnameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MyOrdersPan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.orderHistoryDGV = new System.Windows.Forms.DataGridView();
            this.HomePan = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.sizeCB = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.OrderBut = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.GoodPB = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.GoodsDGV = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.userPhotoOFD = new System.Windows.Forms.OpenFileDialog();
            this.storegoodsTableAdapter1 = new PCStore.FWDatasetTableAdapters.STOREGOODSTableAdapter();
            this.fwDataset1 = new PCStore.FWDataset();
            this.StatusStrip.SuspendLayout();
            this.ProfilePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvaPB)).BeginInit();
            this.MyOrdersPan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).BeginInit();
            this.HomePan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwDataset1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusStrip
            // 
            this.StatusStrip.AutoSize = false;
            this.StatusStrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 656);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StatusStrip.Size = new System.Drawing.Size(1264, 25);
            this.StatusStrip.TabIndex = 0;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(16, 20);
            this.StatusLabel.Text = "...";
            // 
            // HomeBut
            // 
            this.HomeBut.Location = new System.Drawing.Point(6, 12);
            this.HomeBut.Name = "HomeBut";
            this.HomeBut.Size = new System.Drawing.Size(136, 68);
            this.HomeBut.TabIndex = 1;
            this.HomeBut.Text = "Главная";
            this.HomeBut.UseVisualStyleBackColor = true;
            this.HomeBut.Click += new System.EventHandler(this.HomeBut_Click);
            // 
            // ProfileBut
            // 
            this.ProfileBut.Location = new System.Drawing.Point(6, 86);
            this.ProfileBut.Name = "ProfileBut";
            this.ProfileBut.Size = new System.Drawing.Size(136, 68);
            this.ProfileBut.TabIndex = 2;
            this.ProfileBut.Text = "Профиль";
            this.ProfileBut.UseVisualStyleBackColor = true;
            this.ProfileBut.Click += new System.EventHandler(this.ProfileBut_Click);
            // 
            // MyOrdersBut
            // 
            this.MyOrdersBut.Location = new System.Drawing.Point(6, 160);
            this.MyOrdersBut.Name = "MyOrdersBut";
            this.MyOrdersBut.Size = new System.Drawing.Size(136, 68);
            this.MyOrdersBut.TabIndex = 3;
            this.MyOrdersBut.Text = "Мои заказы";
            this.MyOrdersBut.UseVisualStyleBackColor = true;
            this.MyOrdersBut.Click += new System.EventHandler(this.MyOrdersBut_Click);
            // 
            // ProfilePan
            // 
            this.ProfilePan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ProfilePan.Controls.Add(this.adressTB);
            this.ProfilePan.Controls.Add(this.AvaPB);
            this.ProfilePan.Controls.Add(this.phoneTB);
            this.ProfilePan.Controls.Add(this.changeAvaBut);
            this.ProfilePan.Controls.Add(this.emailTB);
            this.ProfilePan.Controls.Add(this.editProfileBut);
            this.ProfilePan.Controls.Add(this.genderBut);
            this.ProfilePan.Controls.Add(this.saveChangedBut);
            this.ProfilePan.Controls.Add(this.genderTB);
            this.ProfilePan.Controls.Add(this.changePassBut);
            this.ProfilePan.Controls.Add(this.lnameTB);
            this.ProfilePan.Controls.Add(this.label2);
            this.ProfilePan.Controls.Add(this.mnameTB);
            this.ProfilePan.Controls.Add(this.label3);
            this.ProfilePan.Controls.Add(this.birthDP);
            this.ProfilePan.Controls.Add(this.label4);
            this.ProfilePan.Controls.Add(this.fnameTB);
            this.ProfilePan.Controls.Add(this.label5);
            this.ProfilePan.Controls.Add(this.label9);
            this.ProfilePan.Controls.Add(this.label6);
            this.ProfilePan.Controls.Add(this.label8);
            this.ProfilePan.Controls.Add(this.label7);
            this.ProfilePan.Location = new System.Drawing.Point(160, 12);
            this.ProfilePan.Name = "ProfilePan";
            this.ProfilePan.Size = new System.Drawing.Size(1092, 629);
            this.ProfilePan.TabIndex = 4;
            this.ProfilePan.Visible = false;
            // 
            // adressTB
            // 
            this.adressTB.Enabled = false;
            this.adressTB.Location = new System.Drawing.Point(381, 493);
            this.adressTB.Name = "adressTB";
            this.adressTB.Size = new System.Drawing.Size(660, 29);
            this.adressTB.TabIndex = 63;
            // 
            // AvaPB
            // 
            this.AvaPB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AvaPB.Location = new System.Drawing.Point(29, 17);
            this.AvaPB.Name = "AvaPB";
            this.AvaPB.Size = new System.Drawing.Size(305, 213);
            this.AvaPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AvaPB.TabIndex = 42;
            this.AvaPB.TabStop = false;
            // 
            // phoneTB
            // 
            this.phoneTB.Enabled = false;
            this.phoneTB.Location = new System.Drawing.Point(29, 493);
            this.phoneTB.MaxLength = 10;
            this.phoneTB.Name = "phoneTB";
            this.phoneTB.Size = new System.Drawing.Size(305, 29);
            this.phoneTB.TabIndex = 62;
            // 
            // changeAvaBut
            // 
            this.changeAvaBut.Location = new System.Drawing.Point(29, 236);
            this.changeAvaBut.Name = "changeAvaBut";
            this.changeAvaBut.Size = new System.Drawing.Size(305, 40);
            this.changeAvaBut.TabIndex = 43;
            this.changeAvaBut.Text = "Обновить фото";
            this.changeAvaBut.UseVisualStyleBackColor = true;
            this.changeAvaBut.Click += new System.EventHandler(this.changeAvaBut_Click);
            // 
            // emailTB
            // 
            this.emailTB.Enabled = false;
            this.emailTB.Location = new System.Drawing.Point(736, 406);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(305, 29);
            this.emailTB.TabIndex = 61;
            // 
            // editProfileBut
            // 
            this.editProfileBut.Location = new System.Drawing.Point(381, 571);
            this.editProfileBut.Name = "editProfileBut";
            this.editProfileBut.Size = new System.Drawing.Size(305, 40);
            this.editProfileBut.TabIndex = 44;
            this.editProfileBut.Text = "Редактировать профиль";
            this.editProfileBut.UseVisualStyleBackColor = true;
            this.editProfileBut.Click += new System.EventHandler(this.editProfileBut_Click);
            // 
            // genderBut
            // 
            this.genderBut.Enabled = false;
            this.genderBut.Location = new System.Drawing.Point(644, 405);
            this.genderBut.Name = "genderBut";
            this.genderBut.Size = new System.Drawing.Size(42, 29);
            this.genderBut.TabIndex = 60;
            this.genderBut.Text = "G";
            this.genderBut.UseVisualStyleBackColor = true;
            this.genderBut.Click += new System.EventHandler(this.genderBut_Click);
            // 
            // saveChangedBut
            // 
            this.saveChangedBut.Enabled = false;
            this.saveChangedBut.Location = new System.Drawing.Point(736, 571);
            this.saveChangedBut.Name = "saveChangedBut";
            this.saveChangedBut.Size = new System.Drawing.Size(305, 40);
            this.saveChangedBut.TabIndex = 45;
            this.saveChangedBut.Text = "Cохранить изменения";
            this.saveChangedBut.UseVisualStyleBackColor = true;
            this.saveChangedBut.Click += new System.EventHandler(this.saveChangedBut_Click);
            // 
            // genderTB
            // 
            this.genderTB.Enabled = false;
            this.genderTB.Location = new System.Drawing.Point(381, 405);
            this.genderTB.Name = "genderTB";
            this.genderTB.Size = new System.Drawing.Size(249, 29);
            this.genderTB.TabIndex = 59;
            // 
            // changePassBut
            // 
            this.changePassBut.Location = new System.Drawing.Point(29, 571);
            this.changePassBut.Name = "changePassBut";
            this.changePassBut.Size = new System.Drawing.Size(305, 40);
            this.changePassBut.TabIndex = 46;
            this.changePassBut.Text = "Изменить пароль";
            this.changePassBut.UseVisualStyleBackColor = true;
            this.changePassBut.Click += new System.EventHandler(this.changePassBut_Click);
            // 
            // lnameTB
            // 
            this.lnameTB.Enabled = false;
            this.lnameTB.Location = new System.Drawing.Point(736, 311);
            this.lnameTB.Name = "lnameTB";
            this.lnameTB.Size = new System.Drawing.Size(305, 29);
            this.lnameTB.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Имя:";
            // 
            // mnameTB
            // 
            this.mnameTB.Enabled = false;
            this.mnameTB.Location = new System.Drawing.Point(381, 311);
            this.mnameTB.Name = "mnameTB";
            this.mnameTB.Size = new System.Drawing.Size(305, 29);
            this.mnameTB.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Отчество:";
            // 
            // birthDP
            // 
            this.birthDP.Enabled = false;
            this.birthDP.Location = new System.Drawing.Point(29, 405);
            this.birthDP.Name = "birthDP";
            this.birthDP.Size = new System.Drawing.Size(305, 29);
            this.birthDP.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(732, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 24);
            this.label4.TabIndex = 49;
            this.label4.Text = "Фамилия:";
            // 
            // fnameTB
            // 
            this.fnameTB.Enabled = false;
            this.fnameTB.Location = new System.Drawing.Point(29, 311);
            this.fnameTB.Name = "fnameTB";
            this.fnameTB.Size = new System.Drawing.Size(305, 29);
            this.fnameTB.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 24);
            this.label5.TabIndex = 50;
            this.label5.Text = "Дата рождения:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 457);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 24);
            this.label9.TabIndex = 54;
            this.label9.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(377, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 51;
            this.label6.Text = "Пол:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(732, 369);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 24);
            this.label8.TabIndex = 53;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(377, 457);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 24);
            this.label7.TabIndex = 52;
            this.label7.Text = "Адрес:";
            // 
            // MyOrdersPan
            // 
            this.MyOrdersPan.BackColor = System.Drawing.Color.Tomato;
            this.MyOrdersPan.Controls.Add(this.label1);
            this.MyOrdersPan.Controls.Add(this.orderHistoryDGV);
            this.MyOrdersPan.Location = new System.Drawing.Point(160, 12);
            this.MyOrdersPan.Name = "MyOrdersPan";
            this.MyOrdersPan.Size = new System.Drawing.Size(1092, 629);
            this.MyOrdersPan.TabIndex = 5;
            this.MyOrdersPan.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(492, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Мои заказы:";
            // 
            // orderHistoryDGV
            // 
            this.orderHistoryDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderHistoryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderHistoryDGV.Location = new System.Drawing.Point(18, 74);
            this.orderHistoryDGV.Name = "orderHistoryDGV";
            this.orderHistoryDGV.ReadOnly = true;
            this.orderHistoryDGV.Size = new System.Drawing.Size(1056, 537);
            this.orderHistoryDGV.TabIndex = 0;
            // 
            // HomePan
            // 
            this.HomePan.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.HomePan.Controls.Add(this.label22);
            this.HomePan.Controls.Add(this.textBox12);
            this.HomePan.Controls.Add(this.label17);
            this.HomePan.Controls.Add(this.textBox8);
            this.HomePan.Controls.Add(this.textBox11);
            this.HomePan.Controls.Add(this.label21);
            this.HomePan.Controls.Add(this.label20);
            this.HomePan.Controls.Add(this.sizeCB);
            this.HomePan.Controls.Add(this.textBox1);
            this.HomePan.Controls.Add(this.label10);
            this.HomePan.Controls.Add(this.label19);
            this.HomePan.Controls.Add(this.OrderBut);
            this.HomePan.Controls.Add(this.textBox10);
            this.HomePan.Controls.Add(this.GoodPB);
            this.HomePan.Controls.Add(this.label11);
            this.HomePan.Controls.Add(this.textBox9);
            this.HomePan.Controls.Add(this.GoodsDGV);
            this.HomePan.Controls.Add(this.textBox2);
            this.HomePan.Controls.Add(this.textBox6);
            this.HomePan.Controls.Add(this.label18);
            this.HomePan.Controls.Add(this.label14);
            this.HomePan.Controls.Add(this.label12);
            this.HomePan.Controls.Add(this.label15);
            this.HomePan.Controls.Add(this.textBox5);
            this.HomePan.Controls.Add(this.textBox3);
            this.HomePan.Controls.Add(this.textBox7);
            this.HomePan.Controls.Add(this.label13);
            this.HomePan.Controls.Add(this.textBox4);
            this.HomePan.Controls.Add(this.label16);
            this.HomePan.Location = new System.Drawing.Point(160, 12);
            this.HomePan.Name = "HomePan";
            this.HomePan.Size = new System.Drawing.Size(1092, 629);
            this.HomePan.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(14, 321);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(81, 24);
            this.label22.TabIndex = 74;
            this.label22.Text = "Детали:";
            // 
            // textBox12
            // 
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(214, 321);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(446, 29);
            this.textBox12.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(14, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(192, 24);
            this.label17.TabIndex = 72;
            this.label17.Text = "Материал подошвы:";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(214, 192);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(446, 29);
            this.textBox8.TabIndex = 71;
            // 
            // textBox11
            // 
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(214, 285);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(446, 29);
            this.textBox11.TabIndex = 70;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 260);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(181, 24);
            this.label21.TabIndex = 69;
            this.label21.Text = "Материал стельки:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(666, 311);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 20);
            this.label20.TabIndex = 68;
            this.label20.Text = "Размер:";
            // 
            // sizeCB
            // 
            this.sizeCB.FormattingEnabled = true;
            this.sizeCB.Items.AddRange(new object[] {
            "35 UKR 36 EUR",
            "36 UKR 37 EUR",
            "37 UKR 38 EUR",
            "38 UKR 39 EUR",
            "39 UKR 40 EUR",
            "40 UKR 31 EUR"});
            this.sizeCB.Location = new System.Drawing.Point(736, 306);
            this.sizeCB.Name = "sizeCB";
            this.sizeCB.Size = new System.Drawing.Size(338, 32);
            this.sizeCB.TabIndex = 67;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(736, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(338, 29);
            this.textBox1.TabIndex = 66;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(671, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 24);
            this.label10.TabIndex = 65;
            this.label10.Text = "Цена:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(14, 226);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(151, 24);
            this.label19.TabIndex = 64;
            this.label19.Text = "Материал низа:";
            // 
            // OrderBut
            // 
            this.OrderBut.Location = new System.Drawing.Point(736, 361);
            this.OrderBut.Name = "OrderBut";
            this.OrderBut.Size = new System.Drawing.Size(338, 40);
            this.OrderBut.TabIndex = 6;
            this.OrderBut.Text = "Оформить заказ";
            this.OrderBut.UseVisualStyleBackColor = true;
            this.OrderBut.Click += new System.EventHandler(this.OrderBut_Click);
            // 
            // textBox10
            // 
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(214, 252);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(446, 29);
            this.textBox10.TabIndex = 63;
            // 
            // GoodPB
            // 
            this.GoodPB.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GoodPB.Location = new System.Drawing.Point(736, 17);
            this.GoodPB.Name = "GoodPB";
            this.GoodPB.Size = new System.Drawing.Size(338, 236);
            this.GoodPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GoodPB.TabIndex = 5;
            this.GoodPB.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 24);
            this.label11.TabIndex = 47;
            this.label11.Text = "Бренд:";
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(214, 221);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(446, 29);
            this.textBox9.TabIndex = 62;
            // 
            // GoodsDGV
            // 
            this.GoodsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GoodsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GoodsDGV.Location = new System.Drawing.Point(18, 440);
            this.GoodsDGV.Name = "GoodsDGV";
            this.GoodsDGV.ReadOnly = true;
            this.GoodsDGV.Size = new System.Drawing.Size(1056, 171);
            this.GoodsDGV.TabIndex = 0;
            this.GoodsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GoodsDGV_CellContentClick);
            this.GoodsDGV.DoubleClick += new System.EventHandler(this.GoodsDGV_DoubleClick);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(214, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(446, 29);
            this.textBox2.TabIndex = 48;
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(214, 133);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(446, 29);
            this.textBox6.TabIndex = 55;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(14, 196);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(162, 24);
            this.label18.TabIndex = 61;
            this.label18.Text = "Материал верха:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 104);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 24);
            this.label14.TabIndex = 54;
            this.label14.Text = "Тип:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 24);
            this.label12.TabIndex = 49;
            this.label12.Text = "Страна:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 133);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 24);
            this.label15.TabIndex = 56;
            this.label15.Text = "Сезон:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(214, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(446, 29);
            this.textBox5.TabIndex = 53;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(214, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(446, 29);
            this.textBox3.TabIndex = 50;
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(214, 163);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(446, 29);
            this.textBox7.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 24);
            this.label13.TabIndex = 52;
            this.label13.Text = "Пол:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(214, 75);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(446, 29);
            this.textBox4.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 24);
            this.label16.TabIndex = 58;
            this.label16.Text = "Цвет-Декор:";
            // 
            // userPhotoOFD
            // 
            this.userPhotoOFD.FileName = "UserPhoto";
            this.userPhotoOFD.Filter = "\"images| *.JPG; *.PNG; *.GIF\"";
            // 
            // storegoodsTableAdapter1
            // 
            this.storegoodsTableAdapter1.ClearBeforeFill = true;
            // 
            // fwDataset1
            // 
            this.fwDataset1.DataSetName = "FWDataset";
            this.fwDataset1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MyOrdersBut);
            this.Controls.Add(this.ProfileBut);
            this.Controls.Add(this.HomeBut);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.MyOrdersPan);
            this.Controls.Add(this.HomePan);
            this.Controls.Add(this.ProfilePan);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "GeneralForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GeneralForm_FormClosed);
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ProfilePan.ResumeLayout(false);
            this.ProfilePan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvaPB)).EndInit();
            this.MyOrdersPan.ResumeLayout(false);
            this.MyOrdersPan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderHistoryDGV)).EndInit();
            this.HomePan.ResumeLayout(false);
            this.HomePan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoodPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GoodsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fwDataset1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button HomeBut;
        private System.Windows.Forms.Button ProfileBut;
        private System.Windows.Forms.Button MyOrdersBut;
        private System.Windows.Forms.Panel ProfilePan;
        private System.Windows.Forms.Panel MyOrdersPan;
        private System.Windows.Forms.Panel HomePan;
        private System.Windows.Forms.TextBox adressTB;
        private System.Windows.Forms.PictureBox AvaPB;
        private System.Windows.Forms.TextBox phoneTB;
        private System.Windows.Forms.Button changeAvaBut;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Button editProfileBut;
        private System.Windows.Forms.Button genderBut;
        private System.Windows.Forms.Button saveChangedBut;
        private System.Windows.Forms.TextBox genderTB;
        private System.Windows.Forms.Button changePassBut;
        private System.Windows.Forms.TextBox lnameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mnameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker birthDP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderHistoryDGV;
        private System.Windows.Forms.DataGridView GoodsDGV;
        private System.Windows.Forms.Button OrderBut;
        private System.Windows.Forms.PictureBox GoodPB;
        private System.Windows.Forms.OpenFileDialog userPhotoOFD;
        private FWDatasetTableAdapters.STOREGOODSTableAdapter storegoodsTableAdapter1;
        private FWDataset fwDataset1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox sizeCB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label21;
    }
}