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
    public partial class OrderForm : Form
    {
        Image shoesreview = null;
        decimal shoesid = 0;
        decimal shoesPrice = 0;
        decimal userID = 0;
        string footwearsize = null;
        public OrderForm(Image goodreview, decimal goodID, decimal goodPrice, decimal clientIdentificator, string goodsize)
        {
            shoesreview = goodreview;
            shoesid = goodID;
            shoesPrice = goodPrice;
            userID = clientIdentificator;
            footwearsize = goodsize;
            InitializeComponent();
            
            
        }

        private void OrderForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //значение комбобоксов по дефолту
            paymentCB.SelectedItem = paymentCB.Items[0];
            deliveryCB.SelectedItem = deliveryCB.Items[0];
            orderGoodPB.Image = shoesreview;
            costTB.Text = (shoesPrice + 70).ToString();
            sizeTB.Text = footwearsize;
        }

        private void plusBut_Click(object sender, EventArgs e)
        {

        }

        private void minusBut_Click(object sender, EventArgs e)
        {
            
        }

        private void buyBut_Click(object sender, EventArgs e)
        {
            if (adressTB.Text != "")
            {
                FWDatasetTableAdapters.QueriesTableAdapter addNewOrder = new FWDatasetTableAdapters.QueriesTableAdapter();
                addNewOrder.SENDORDER(paymentCB.SelectedItem.ToString(), adressTB.Text, deliveryCB.SelectedItem.ToString(), Convert.ToDecimal(costTB.Text), userID, shoesid, footwearsize);
                addNewOrder.Dispose();
                MessageBox.Show("Заказ был отправлен", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Адрес не был введен", "message(i)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
