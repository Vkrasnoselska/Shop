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
    public partial class ChangePassForm : Form
    {
        decimal userID = 0;
        public ChangePassForm(decimal ClienIdentificator)
        {
            InitializeComponent();
            userID = ClienIdentificator;
        }

        private void ChangePassForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.IsOpenChangePass = false;
        }

        private void savePassTB_Click(object sender, EventArgs e)
        {
            notifyLabel.Visible = false;
            notifyLabel.Text = "Notify Label";

            OracleConnection Connection = new OracleConnection(Program.DBConStr);
            Connection.Open();
            string ClientDataQuery = "SELECT PASS FROM CLIENT WHERE CLIENTID = " + userID;
            OracleCommand Comand = new OracleCommand(ClientDataQuery, Connection);
            OracleDataReader DataReader = Comand.ExecuteReader();
            DataReader.Read();

            if (oldPassTB.Text == DataReader.GetString(0))
            {
                DataReader.Close();
                DataReader.Dispose();
                Comand.Dispose();
                Connection.Close();
                Connection.Dispose();
                if (newPassTB.Text == confirmNewTB.Text)
                {
                    FWDatasetTableAdapters.QueriesTableAdapter updatepassword = new FWDatasetTableAdapters.QueriesTableAdapter();
                    updatepassword.CHANGEPASS(Convert.ToDecimal(userID), newPassTB.Text);
                    updatepassword.Dispose();
                    notifyLabel.Visible = true;
                    notifyLabel.Text = "Пароль успешно изменен:)";
                    oldPassTB.Clear();
                    newPassTB.Clear();
                    confirmNewTB.Clear();

                }
                else
                {
                    notifyLabel.Visible = true;
                    notifyLabel.Text = "Некорректное подтверждение пароля:(";
                    oldPassTB.Clear();
                    newPassTB.Clear();
                    confirmNewTB.Clear();
                }
            }
            else
            {
                notifyLabel.Visible = true;
                notifyLabel.Text = "Некорректный старый пароль:(";
                oldPassTB.Clear();
                newPassTB.Clear();
                confirmNewTB.Clear();
            }
        }
    }
}
