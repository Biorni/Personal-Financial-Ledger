using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using Fedha.Models;
namespace Fedha.Forms
{
    public partial class frmAddIncome : Form
    {
        private readonly IncomeTransaction transaction = null;

        public frmAddIncome(DateTime date, IncomeTransaction transaction = null)
        {


            InitializeComponent();
            this.transaction = transaction;
            //Load the categories 
            txtCategory.Clear();

            foreach (var item in DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll())
            {
                txtCategory.AddItem(item.Name);
                txtCategory.selectedIndex = 0;
            }

            //load accounts
            txtAccount.Clear();
            foreach (var item in DbContext.GetInstace().GetCollection<Account>("accounts").FindAll())
            {
                txtAccount.AddItem(item.Name);
                txtAccount.selectedIndex = 0;
            }

            txtDate.Value = date;


            //detect if its edit
            if (this.transaction != null)
            {
                txtFrom.Text = transaction.PaymentFrom;
                txtDesc.Text = transaction.Description;

                //setAccount
                for (int i = 0; i < txtAccount.items.Length; i++)
                {
                    if (txtAccount.items[i].Trim() == transaction.Account.Name)
                    {
                        txtAccount.selectedIndex = i;
                    }
                }
                //setCategory
                for (int i = 0; i < txtCategory.items.Length; i++)
                {
                    if (txtCategory.items[i].Trim() == transaction.Category.Name)
                    {
                        txtCategory.selectedIndex = i;
                    }
                }

                txtDate.Value = transaction.Date;
                txtCode.Text = transaction.TransactionCode;
                txtAmount.Text = transaction.Amount.ToString();

                btnAddIncome.ButtonText = " Update Transaction";
            }


        }



        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAddIncome_Click(object sender, EventArgs e)
        {
            //validate here
            if (txtFrom.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Validation Error", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                txtFrom.Focus();
                return;
            }
            double amount = 0;
            try
            {

                amount = double.Parse(txtAmount.Text.Trim());
                if (amount <= 0)
                {
                    Bunifu.Snackbar.Show(this, "Invalid Amount", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                    txtAmount.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                Bunifu.Snackbar.Show(this, "Invalid Amount", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                txtAmount.Focus();
                return;
            }

            //save the transacton
            if (MessageBox.Show("Confirm receve amount " + amount + " from " + txtFrom.Text, "Fedha", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                Bunifu.Snackbar.Show(this, "Transaction cancelled", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                return;
            }

            //complete transaction
            IncomeTransaction transaction = this.transaction;
            this.Opacity = 0;
            if (this.transaction == null)
            {
                transaction = new IncomeTransaction()
                {
                    Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex],
                    Category = DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll().ToList()[txtCategory.selectedIndex],
                    Amount = amount,
                    Date = txtDate.Value,
                    Description = txtDesc.Text.Trim(),
                    PaymentFrom = txtFrom.Text.Trim(),
                    TransactionCode = txtCode.Text.Trim()
                };
               DbContext.GetInstace().GetCollection<IncomeTransaction>("income_transactions").Insert(transaction);
               
            }
            else
            {
                transaction.Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex];
                transaction.Category = DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll().ToList()[txtCategory.selectedIndex];
                transaction.Amount = amount;
                transaction.Date = txtDate.Value;
                transaction.Description = txtDesc.Text.Trim();
                transaction.PaymentFrom = txtFrom.Text.Trim();
                transaction.TransactionCode = txtCode.Text.Trim();
                DbContext.GetInstace().GetCollection<IncomeTransaction>("income_transactions").Update(transaction);
                
            }

         
            closeForm.Start();

        }

        private void CloseForm_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
