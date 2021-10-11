using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fedha.Models;
using LiteDB;

namespace Fedha.Forms
{
    public partial class frmAddWishlist : Form
    {
        private readonly WishlistTransaction transaction = null;
        public frmAddWishlist(DateTime date, WishlistTransaction transaction = null)
        {
            InitializeComponent();
            this.transaction = transaction;
            //Load the categories 
           

            //load accounts
            txtAccount.Clear();
            foreach (var item in DbContext.GetInstace().GetCollection<Account>("accounts").FindAll())
            {
                txtAccount.AddItem(item.Name);
                txtAccount.selectedIndex = 0;
            }

            txtDate.Value = date;


        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Validation
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
            WishlistTransaction transaction = this.transaction;
            this.Opacity = 0;
            if (this.transaction == null)
            {
                transaction = new WishlistTransaction()
                {
                    Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex],
                   
                    Amount = amount,
                    Date = txtDate.Value,
                    Description = txtDesc.Text.Trim(),
                    ItemName = txtFrom.Text.Trim(),
                    TransactionCode = txtCode.Text.Trim()
                };
                DbContext.GetInstace().GetCollection<WishlistTransaction>("wishlist_transactions").Insert(transaction);
               
            }
            else
            {
                transaction.Account = DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[txtAccount.selectedIndex];
                
                transaction.Amount = amount;
                transaction.Date = txtDate.Value;
                transaction.Description = txtDesc.Text.Trim();
                transaction.ItemName = txtFrom.Text.Trim();
                transaction.TransactionCode = txtCode.Text.Trim();
                DbContext.GetInstace().GetCollection<WishlistTransaction>("wishlist_transactions").Update(transaction);
                Bunifu.Snackbar.Show(this, "Successfully Updated", 2000, Snackbar.Views.SnackbarDesigner.MessageTypes.Success);
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

