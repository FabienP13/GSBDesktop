using gsbcompta.CONTROLLERS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbcompta.VIEWS
{
    public partial class DetailsOffPrice : Form
    {
        String ID;
        String Amount;
        String Date;
        String Name;
        String Month;
        String User;
        String userID, month;
        OffPriceController opController;
        ListeFiches lt;
        public DetailsOffPrice()
        {
            InitializeComponent();
        }

        public DetailsOffPrice(string id, string amount, string date, string name, string month, string user)
        {
            InitializeComponent();
            this.ID = id;
            this.Amount = amount;
            this.Date = date;
            this.Name = name;
            this.Month = month;
            this.User = user;
            this.textBoxName.Text = this.Name;
            this.textBoxAmount.Text = this.Amount;
            this.dateTimePicker1.Text = this.Date;
            this.textBoxMonth.Text = this.Month;
            this.textBoxVisiteur.Text = this.User;

            opController = new OffPriceController();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            DateTime dateValue = Convert.ToDateTime(this.dateTimePicker1.Value);
            string date = dateValue.ToString("yyyy-MM-dd");

            String user = this.textBoxVisiteur.Text;
            String month = this.textBoxMonth.Text;
            String name = this.textBoxName.Text;
            String amount = this.textBoxAmount.Text;
            opController.updateOffPrices(this.ID, name, date, amount);

            lt = new ListeFiches();
            lt.Show();
            this.Hide();

            

        }
    }
}
