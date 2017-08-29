using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PCStore
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.LoginWindow.Show();
        }

        private void clearAllBut_Click(object sender, EventArgs e)
        {
            fnameTB.Clear();
            mnameTB.Clear();
            lnameTB.Clear();
            birthDP.Value = DateTime.Today;
            womanRB.Checked = false;
            manRB.Checked = false;
            womanRB.Checked = true;
            adressTB.Clear();
            emailTB.Clear();
            phoneTB.Clear();
            passTB.Clear();
            confirmPassTB.Clear();

        }

        private void createProfileBut_Click(object sender, EventArgs e)
        {
            if (fnameTB.Text == "" || mnameTB.Text == "" || lnameTB.Text == "" || adressTB.Text == "" || emailTB.Text == "" || phoneTB.Text == "" || passTB.Text == "" || confirmPassTB.Text == "")
            {
                MessageBox.Show("Обязательные поля не были заполнены должным образом. Заполните их пожалуйста:)", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (passTB.Text == confirmPassTB.Text)
                {
                    string gendertype = " ";
                    if (womanRB.Checked == true)
                        gendertype = "Женский";
                    if (manRB.Checked == true)
                        gendertype = "Мужской";

                    FWDatasetTableAdapters.QueriesTableAdapter registeruser = new FWDatasetTableAdapters.QueriesTableAdapter();
                    registeruser.USERREGISTER(fnameTB.Text, lnameTB.Text, mnameTB.Text, birthDP.Value, gendertype, emailTB.Text, phoneTB.Text, adressTB.Text, passTB.Text);
                    registeruser.Dispose();
                    MessageBox.Show("Добро пожаловать, " + fnameTB.Text + ", теперь вы можете войти в созданый аккаунт.", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    fnameTB.Clear();
                    mnameTB.Clear();
                    lnameTB.Clear();
                    birthDP.Value = DateTime.Today;
                    womanRB.Checked = false;
                    manRB.Checked = false;
                    womanRB.Checked = true;
                    adressTB.Clear();
                    emailTB.Clear();
                    phoneTB.Clear();
                    passTB.Clear();
                    confirmPassTB.Clear();
                }
                else
                {
                    MessageBox.Show("Пароль введенный в поле \"Подтверждение пароля\" не совпадает с указаным выше паролем.", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
