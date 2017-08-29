using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Oracle.ManagedDataAccess.Client;


namespace PCStore
{
    public partial class GeneralForm : Form
    {
        //переменная, в которую пишется id клиента после входа в аккаунт
        decimal userID;
        
        public GeneralForm(decimal ClientIdentificationNumber)
        {
            userID = ClientIdentificationNumber;
            
            InitializeComponent();
        }

        private void GeneralForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginWindow.Show();
        }

        private void GeneralForm_Load(object sender, EventArgs e)
        {
            sizeCB.SelectedItem = sizeCB.Items[0];

            try
            {
                storegoodsTableAdapter1.Fill(fwDataset1.STOREGOODS);
                GoodsDGV.DataSource = fwDataset1.STOREGOODS;
            }
            catch
            {
                MessageBox.Show("Не удалось получить доступ к данных, проверьте соединение с сервером:(", "@Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void HomeBut_Click(object sender, EventArgs e)
        {
            ProfilePan.Visible = false;
            MyOrdersPan.Visible = false;
            HomePan.Visible = true;
        }

        private void ProfileBut_Click(object sender, EventArgs e)
        {          
            MyOrdersPan.Visible = false;
            HomePan.Visible = false;
            ProfilePan.Visible = true;

            // отображение данных профайла при нажатии на кнопку
            OracleConnection Connection = new OracleConnection(Program.DBConStr);
            Connection.Open();
            string ClientDataQuery = "SELECT * FROM CLIENT WHERE CLIENTID = " + userID.ToString();
            OracleCommand Comand = new OracleCommand(ClientDataQuery, Connection);
            OracleDataReader DataReader = Comand.ExecuteReader();
            DataReader.Read();

            try { fnameTB.Text = DataReader.GetString(1); } catch { }
            try { mnameTB.Text = DataReader.GetString(2); } catch { }
            try { lnameTB.Text = DataReader.GetString(3); } catch { }
            try { genderTB.Text = DataReader.GetString(5); } catch { }
            try { birthDP.Value = DataReader.GetDateTime(4); } catch { }
            try { emailTB.Text = DataReader.GetString(6); } catch { }
            try { phoneTB.Text = DataReader.GetString(7); } catch { }
            try { adressTB.Text = DataReader.GetString(8); } catch { }

            try
            {
                byte[] avaBinary = new byte[((byte[])DataReader[9]).Length];
                DataReader.GetBytes(9, 0, avaBinary, 0, ((byte[])DataReader[9]).Length);
                AvaPB.Image = byteArrayToImage(avaBinary);
            }
            catch
            {

            }
            DataReader.Close();
            DataReader.Dispose();
            Comand.Dispose();
            Connection.Close();
            Connection.Dispose();
        }

        private void MyOrdersBut_Click(object sender, EventArgs e)
        {         
            HomePan.Visible = false;
            ProfilePan.Visible = false;
            MyOrdersPan.Visible = true;

            OracleConnection connection = new OracleConnection(Program.DBConStr);
            OracleDataAdapter adapter = new OracleDataAdapter("SELECT ORDERID \"Номер заказа\", ORDERSTART \"Дата заказа\", STATUS \"Статус\", PAYTYPE \"Тип оплаты\", DELIVERYADRESS \"Адресс доставки\", DELIVERYTYPE \"Способ доставки\", ORDERCOST \"Цена\", ORDERFINISH \"Дата окончания\", FOOTWEARID \"Код товара\" FROM CLIENTORDER WHERE CLIENTID = " + userID, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            connection.Dispose();
            orderHistoryDGV.DataSource = table;
        }

        private void changePassBut_Click(object sender, EventArgs e)
        {
            //блокировка повторного открытия(базовая)
            if (Program.IsOpenChangePass == false)
            {
                Program.IsOpenChangePass = true;
                ChangePassForm ChangePassWindow = new ChangePassForm(userID);
                ChangePassWindow.Show();
            }
          
        }

        private void editProfileBut_Click(object sender, EventArgs e)
        {
            //разблокировка всех элементов для редактирования
            fnameTB.Enabled = true;
            mnameTB.Enabled = true;
            lnameTB.Enabled = true;
            genderBut.Enabled = true;
            adressTB.Enabled = true;
            birthDP.Enabled = true;
            phoneTB.Enabled = true;
            emailTB.Enabled = true;
            //активация кнопки сохранить при редактировании
            saveChangedBut.Enabled = true;
        }

        private void saveChangedBut_Click(object sender, EventArgs e)
        {
            //Диалоговое окно подтверждения редактирования
            DialogResult EditAccountDia = MessageBox.Show("Cохранить изменения", "???", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (EditAccountDia == DialogResult.Yes)
            {
                //редактирование
                FWDatasetTableAdapters.QueriesTableAdapter editprofile = new FWDatasetTableAdapters.QueriesTableAdapter();
                editprofile.EDITACCOUNT(userID, fnameTB.Text, lnameTB.Text, mnameTB.Text, birthDP.Value, genderTB.Text, emailTB.Text, phoneTB.Text, adressTB.Text);
                editprofile.Dispose();

                //деактивация кнопки сохранить при сохранении
                saveChangedBut.Enabled = false;
                //блокировка всех элементов для редактирования
                fnameTB.Enabled = false;
                mnameTB.Enabled = false;
                lnameTB.Enabled = false;
                genderBut.Enabled = false;
                adressTB.Enabled = false;
                birthDP.Enabled = false;
                phoneTB.Enabled = false;
                emailTB.Enabled = false;
            }
            if (EditAccountDia == DialogResult.No)
            {
                // отображение данных профайла при нажатии на кнопку
                OracleConnection Connection = new OracleConnection(Program.DBConStr);
                Connection.Open();
                string ClientDataQuery = "SELECT * FROM CLIENT WHERE CLIENTID = " + userID.ToString();
                OracleCommand Comand = new OracleCommand(ClientDataQuery, Connection);
                OracleDataReader DataReader = Comand.ExecuteReader();
                DataReader.Read();

                try { fnameTB.Text = DataReader.GetString(1); } catch { }
                try { mnameTB.Text = DataReader.GetString(2); } catch { }
                try { lnameTB.Text = DataReader.GetString(3); } catch { }
                try { genderTB.Text = DataReader.GetString(5); } catch { }
                try { birthDP.Value = DataReader.GetDateTime(4); } catch { }
                try { emailTB.Text = DataReader.GetString(6); } catch { }
                try { phoneTB.Text = DataReader.GetString(7); } catch { }
                try { adressTB.Text = DataReader.GetString(8); } catch { }

                try
                {
                    byte[] avaBinary = new byte[((byte[])DataReader[9]).Length];
                    DataReader.GetBytes(9, 0, avaBinary, 0, ((byte[])DataReader[9]).Length);
                    AvaPB.Image = byteArrayToImage(avaBinary);
                }
                catch
                {

                }
                DataReader.Close();
                DataReader.Dispose();
                Comand.Dispose();
                Connection.Close();
                Connection.Dispose();

                //деактивация кнопки сохранить при сохранении
                saveChangedBut.Enabled = false;
                //блокировка всех элементов для редактирования
                fnameTB.Enabled = false;
                mnameTB.Enabled = false;
                lnameTB.Enabled = false;
                genderBut.Enabled = false;
                adressTB.Enabled = false;
                birthDP.Enabled = false;
                phoneTB.Enabled = false;
                emailTB.Enabled = false;
            }
            if (EditAccountDia == DialogResult.Cancel)
            {

            }
        }

        private void changeAvaBut_Click(object sender, EventArgs e)
        {
            try
            {
                userPhotoOFD.ShowDialog();
                System.IO.FileStream fs = new System.IO.FileStream(userPhotoOFD.FileName, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                var newAvatarPicture = new byte[fs.Length];
                fs.Read(newAvatarPicture, 0, Convert.ToInt32(fs.Length));
                //настройка буфера для Blob через DataSet
                FWDatasetTableAdapters.QueriesTableAdapter userPhoto = new FWDatasetTableAdapters.QueriesTableAdapter();
                userPhoto.UPDATEUSERPHOTO(userID, newAvatarPicture);
                userPhoto.Dispose();
                fs.Close();
                fs.Dispose();
                AvaPB.Image = byteArrayToImage(newAvatarPicture);
            }
            catch
            {
                MessageBox.Show("Не удалось загрузить изображение", "Error:0", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void GoodsDGV_DoubleClick(object sender, EventArgs e)
        {
            //расширение и сворачивание DataGridView панели СatalogPanel
            if (GoodsDGV.Height < 537)
            {
                GoodsDGV.BringToFront();
                GoodsDGV.Height = 537;
                GoodsDGV.Location = new Point(18, 74);
            }
            else
            {
                GoodsDGV.Location = new Point(18, 440);
                GoodsDGV.Height = 171;
            }
        }

        private void filterOne_Click(object sender, EventArgs e)
        {

        }

        private void filterTwo_Click(object sender, EventArgs e)
        {

        }

        private void filterThird_Click(object sender, EventArgs e)
        {

        }

        private void filterFour_Click(object sender, EventArgs e)
        {

        }

        private void OrderBut_Click(object sender, EventArgs e)
        {
            OrderForm OrderWindow = new OrderForm(GoodPB.Image, fwearID, goodprice, userID, sizeCB.SelectedItem.ToString());
            OrderWindow.Show();
        }
        //бинарный код в граф объект Image
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new System.IO.MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms, true, false);
            return returnImage;
        }

        private void genderBut_Click(object sender, EventArgs e)
        {
            //изменения пола в профайле
            if (genderTB.Text == "Женский")
                genderTB.Text = "Мужской";
            else
                genderTB.Text = "Женский";
        }
        decimal fwearID = 0;
        decimal goodprice = 0;
        string fwearsize = null;
        private void GoodsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            fwearID = 0;
            goodprice = 0;
            fwearsize = null;
            int goodDGVSelected = GoodsDGV.CurrentRow.Index;

            try { fwearID = Convert.ToDecimal(GoodsDGV.Rows[goodDGVSelected].Cells[0].Value); } catch { }


            if (fwearID != 0)
            {
                //предварительная очистка полей
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox10.Clear();
                textBox11.Clear();
                textBox12.Clear();


                OracleConnection Connection = new OracleConnection(Program.DBConStr);
                Connection.Open();
                string HeadphonesAsortiQuery = "SELECT * FROM FOOTWEAR WHERE FOOTWEARID = " + fwearID;
                OracleCommand Comand = new OracleCommand(HeadphonesAsortiQuery, Connection);
                OracleDataReader DataReader = Comand.ExecuteReader();
                DataReader.Read();
                //try catch if null
                try
                {
                    byte[] goodphoto = new byte[((byte[])DataReader[3]).Length];
                    DataReader.GetBytes(3, 0, goodphoto, 0, ((byte[])DataReader[3]).Length);
                    GoodPB.Image = byteArrayToImage(goodphoto);
                }
                catch
                {

                }

                try { textBox1.Text = DataReader.GetDecimal(1).ToString(); goodprice = DataReader.GetDecimal(1); } catch { }
                try { textBox2.Text = DataReader.GetString(10); } catch { }
                try { textBox3.Text = DataReader.GetString(11); } catch { }
                try { textBox4.Text = DataReader.GetString(15); } catch { }
                try { textBox5.Text = DataReader.GetString(16).ToString(); } catch { }
                try { textBox6.Text = DataReader.GetString(12); } catch { }
                try { textBox7.Text = DataReader.GetString(13).ToString(); } catch { }
                try { textBox8.Text = DataReader.GetString(6); } catch { }

                try { textBox9.Text = DataReader.GetString(7); } catch { }
                try { textBox10.Text = DataReader.GetString(8); } catch { }
                try { textBox11.Text = DataReader.GetString(9); } catch { }
                try { textBox12.Text = DataReader.GetString(14); } catch { }
                DataReader.Close();
                DataReader.Dispose();
                Comand.Dispose();
                Connection.Close();
                Connection.Dispose();
            }
            else
            {

            }
        }
    }
}
