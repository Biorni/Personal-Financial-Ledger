using Fedha.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fedha.Forms
{
    public partial class frmAddExpenses : Form
    {
        private readonly ExpenseTransacton transaction = null;

        public frmAddExpenses(DateTime date, ExpenseTransacton transaction = null)
        {
            InitializeComponent();
            this.transaction = transaction;
            //Load the categories 
            txtCategory.Clear();

            foreach (var item in DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindAll())
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
                txtTo.Text = transaction.PaymentTo;
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

                btnAdd.ButtonText = " Update Transaction";
            }

            this.transaction = transaction;
        }

        private void FrmAddExpenses_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //validate here
            if (txtTo.Text.Trim().Length == 0)
            {
                Bunifu.Snackbar.Show(this, "Validation Error", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                txtTo.Focus();
                return;
            }
            double amount = 0;
            double tCost = 0;

            try
            {
                if (txtTcost.Text.Trim().Length>0)
                {
                    tCost = double.Parse(txtTcost.Text.Trim());
                    if (tCost < 0)
                    {
                        Bunifu.Snackbar.Show(this, "Invalid Trasaction Cost Amount", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                        txtTcost.Focus();
                        return;
                    } 
                }

            }
            catch (Exception)
            {
                Bunifu.Snackbar.Show(this, "Invalid Trasaction Cost Amount", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Error);
                txtTcost.Focus();
                return;
            }


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
            if (MessageBox.Show("Confirm pay amount " + amount + " to " + txtTo.Text, "Fedha", MessageBoxButtons.YesNoCancel) != DialogResult.Yes)
            {
                Bunifu.Snackbar.Show(this, "Transaction cancelled", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Warning);
                return;
            }

            //complete transaction
            ExpenseTransacton transaction = this.transaction;
            this.Opacity = 0 ;
            if (this.transaction == null)
            {
                transaction = new ExpenseTransacton()
                {
                    Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex],
                    Category = DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindAll().ToList()[txtCategory.selectedIndex],
                    Amount = amount,
                    Date = txtDate.Value,
                    Description = txtDesc.Text.Trim(),
                    PaymentTo = txtTo.Text.Trim(),
                    TransactonCost = tCost,
                    TransactionCode = txtCode.Text.Trim()
                };

                //if it has expenses cost


                DbContext.GetInstace().GetCollection<ExpenseTransacton>("expense_transactions").Insert(transaction);
                
            }
            else
            {
                transaction.Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex];
                transaction.Category = DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindAll().ToList()[txtCategory.selectedIndex];
                transaction.Amount = amount;
                transaction.Date = txtDate.Value;
                transaction.Description = txtDesc.Text.Trim();
                transaction.PaymentTo = txtTo.Text.Trim();
                transaction.TransactionCode = txtCode.Text.Trim();
                DbContext.GetInstace().GetCollection<ExpenseTransacton>("expense_transactions").Update(transaction);
                Bunifu.Snackbar.Show(this, "Successfully Updated", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
            }


            closeForm.Start();

        }

        private void CloseForm_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
