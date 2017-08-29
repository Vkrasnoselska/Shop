using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace PCStore
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void passVisibleBut_MouseDown(object sender, MouseEventArgs e)
        {
            passTB.PasswordChar = '\0';
        }

        private void passVisibleBut_MouseUp(object sender, MouseEventArgs e)
        {
            passTB.PasswordChar = '*';
        }

        private void ClearBut_Click(object sender, EventArgs e)
        {
            loginTB.Clear();
            passTB.Clear();
        }

        private void registerBut_Click(object sender, EventArgs e)
        {
            RegisterForm RegisterWindow = new RegisterForm();
            RegisterWindow.Show();
            this.Hide();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            bool logSuccess = false;
            OracleConnection connection = new OracleConnection(Program.DBConStr);
            OracleDataAdapter adapter = new OracleDataAdapter("SELECT PHONE, EMAIL, PASS, CLIENTID FROM CLIENT", connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            adapter.Dispose();
            connection.Dispose();

            foreach (DataRow row in table.Rows)
            {
                if (loginTB.Text == row[0].ToString() || loginTB.Text == row[1].ToString())
                {
                    if (passTB.Text == row[2].ToString())
                    {
                        logSuccess = true;
                        GeneralForm GeneralWindow = new GeneralForm(Convert.ToDecimal(row[3]));
                        GeneralWindow.Show();
                        this.Hide();
                        loginTB.Clear();
                        passTB.Clear();
                        break;
                    }
                }
            }
            if (logSuccess == false)
                MessageBox.Show("Неправильный логин или пароль", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
