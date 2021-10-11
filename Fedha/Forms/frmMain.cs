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

namespace Fedha
{
    public partial class frmMain : Form
    {
        double incomesav;
        double expensesav;
        public frmMain()
        {
            InitializeComponent();
            //customize theme
            ApllyGridTheme(gridIncome);
            ApllyGridTheme(gridExpense);
            ApllyGridTheme(gridMincome);
            ApllyGridTheme(gridMexpense);
            ApllyGridTheme(gridMaccounts);
           

            //set the char themeing
            bunifuDataViz1.colorSet.Add(col1.BackColor);
            bunifuDataViz1.colorSet.Add(col2.BackColor);
            bunifuDataViz1.colorSet.Add(col3.BackColor);


            //Load the categories 
            inputCategory.Clear();
            inputCategory.AddItem("All Categories");
            foreach (var item in DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll())
            {
                inputCategory.AddItem(item.Name);
            }
            inputCategory.selectedIndex = 0;

            //Load expense categories 
            inputCategoryE.Clear();
            inputCategoryE.AddItem("All Categories");
            foreach (var item in DbContext.GetInstace().GetCollection<IncomeCategory>("expense_categories").FindAll())
            {
                inputCategoryE.AddItem(item.Name);
            }
            inputCategoryE.selectedIndex = 0;

            //Load the categories 
            inputCategory.Clear();
            inputCategory.AddItem("All Categories");
            foreach (var item in DbContext.GetInstace().GetCollection<IncomeCategory>("wishlist_categories").FindAll())
            {
                inputCategory.AddItem(item.Name);
            }
            inputCategory.selectedIndex = 0;



            //load accounts
            inputAccount.Clear();
            inputAccount.AddItem("All Accounts");
            inputAccountE.Clear();
            inputAccountE.AddItem("All Accounts");
            foreach (var item in DbContext.GetInstace().GetCollection<Account>("accounts").FindAll())
            {
                inputAccount.AddItem(item.Name);
                inputAccountE.AddItem(item.Name);
            }
            inputAccount.selectedIndex = 0;
            inputAccountE.selectedIndex = 0;



            //Load incom categories 
            foreach (var item in DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll())
                gridMincome.Rows[gridMincome.Rows.Add(item.Name)].Tag = item;

            //Load expense categories 
            foreach (var item in DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindAll())
                gridMexpense.Rows[gridMexpense.Rows.Add(item.Name)].Tag = item;

            //Load wishlist categories 
            foreach (var item in DbContext.GetInstace().GetCollection<WishlistCategory>("wishlist_categories").FindAll())
                gridMincome.Rows[gridMincome.Rows.Add(item.Name)].Tag = item;

            //Load the categories 
            foreach (var item in DbContext.GetInstace().GetCollection<Account>("accounts").FindAll())
                gridMaccounts.Rows[gridMaccounts.Rows.Add(item.Name)].Tag = item;


            ReloadIncome();
            ReloadExpenses();
            ReloadWishlist();

            
        }
        void ReloadIncome()
        {
            gridIncome.Rows.Clear();

            var incomeTransactions = DbContext.GetInstace().GetCollection<IncomeTransaction>("income_transactions")
                                    .Include(x => x.Account)
                                  .Include(x => x.Category)
                                    .FindAll();
            //filter the search
            incomeTransactions = incomeTransactions
                .Where(r => r.PaymentFrom.ToLower().Contains(inputSearch.Text.ToLower()));


            //filetr durations
            incomeTransactions = incomeTransactions.Where(r => r.Date.Year == inputDate.Value.Year && r.Date.Month == inputDate.Value.Month);
            if (inputDuration.selectedIndex == 0)
                incomeTransactions = incomeTransactions.Where(r => r.Date.Day == inputDate.Value.Day);

            //filter categories
            if (inputCategory.selectedIndex > 0)
                incomeTransactions = incomeTransactions.Where(r => r.Category.Id == DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindAll().ToList()[inputCategory.selectedIndex - 1].Id);

            //filter account
            if (inputAccount.selectedIndex > 0)
                incomeTransactions = incomeTransactions.Where(r => r.Account.Id == DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[inputAccount.selectedIndex - 1].Id);

            incomesav = incomeTransactions.Sum(r => r.Amount);
            lblTotoIncome.Text = "TOTAL:    " + incomeTransactions.Sum(r => r.Amount).ToString("N0");
            incomeTransactions = incomeTransactions.OrderByDescending(r => r.Id);

            foreach (var item in incomeTransactions)
            {
                gridIncome.Rows[ gridIncome.Rows.Add(new object[]{
                    "  "+ item.Date.ToShortDateString(),
                    item.PaymentFrom,
                    item.Description,
                    item.Category.Name,
                    item.Account.Name,
                    item.Amount.ToString("N0")+"    "
                })].Tag = item;
            }

            

        }

        void ReloadExpenses()
        {
            gridExpense.Rows.Clear();

            var transactions = DbContext.GetInstace().GetCollection<ExpenseTransacton>("expense_transactions")
                                    .Include(x => x.Account)
                                  .Include(x => x.Category)
                                    .FindAll();
            //filter the search
            transactions = transactions
                .Where(r => r.PaymentTo.ToLower().Contains(inputSearchE.Text.ToLower()));


            //filetr durations
            transactions = transactions.Where(r => r.Date.Year == inputDate.Value.Year && r.Date.Month == inputDate.Value.Month);
            if (inputDurationE.selectedIndex == 0)
                transactions = transactions.Where(r => r.Date.Day == inputDate.Value.Day);

            //filter categories
            if (inputCategoryE.selectedIndex > 0)
                transactions = transactions.Where(r => r.Category.Id == DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindAll().ToList()[inputCategoryE.selectedIndex - 1].Id);

            //filter account
            if (inputAccountE.selectedIndex > 0)
                transactions = transactions.Where(r => r.Account.Id == DbContext.GetInstace().GetCollection<Account>("accounts").FindAll().ToList()[inputAccountE.selectedIndex - 1].Id);

            expensesav = transactions.Sum(r => r.GetAmount());
            lblTotoIncomeE.Text = "TOTAL:    " + transactions.Sum(r => r.GetAmount()).ToString("N0");
            transactions = transactions.OrderByDescending(r => r.Id);

            foreach (var item in transactions)
            {
                gridExpense.Rows[gridExpense.Rows.Add(new object[]{
                    "  "+ item.Date.ToShortDateString(),
                    item.PaymentTo,
                    item.Description,
                    item.Category.Name,
                    item.Account.Name,
                    item.Amount.ToString("N0")+"    ",
                    item.TransactonCost.ToString("N0")+"    ",
                    (item.Amount+item.TransactonCost).ToString("N0")+"    ",
                })].Tag = item;
            }

           

        }

        void ReloadWishlist()
        {
            gridWishlist.Rows.Clear();

            var wishlistTransactions = DbContext.GetInstace().GetCollection<WishlistTransaction>("wishlist_transactions")
                                    .Include(x => x.Account)
                                 
                                    .FindAll();
            //filter the search
            wishlistTransactions = wishlistTransactions
                .Where(r => r.ItemName.ToLower().Contains(bunifuTextBox1.Text.ToLower()));


            //filetr durations
            wishlistTransactions = wishlistTransactions.Where(r => r.Date.Year == inputDate.Value.Year && r.Date.Month == inputDate.Value.Month);
            if (bunifuDropdown3.selectedIndex == 0)
                wishlistTransactions = wishlistTransactions.Where(r => r.Date.Day == inputDate.Value.Day);



            var savings = incomesav - expensesav;
            lblTotoWishlist.Text = "TOTAL:    " + wishlistTransactions.Sum(r => r.Amount - savings);
            wishlistTransactions = wishlistTransactions.OrderByDescending(r => r.Id);

            foreach (var item in wishlistTransactions)
            {
                gridWishlist.Rows[gridWishlist.Rows.Add(new object[]{
                    "  "+ item.Date.ToShortDateString(),
                    item.ItemName,
                    item.Description,
                    
                    item.Account.Name,
                    item.Amount.ToString("N0")+"    "
                })].Tag = item;
            }

        }


        void ApllyGridTheme(Bunifu.UI.WinForms.BunifuDataGridView grid)
        {

            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.DimGray;

            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.DimGray;
        }

        //move indicator
        void MoveIndicator(Control btn)
        {
            indicator.Left = btn.Left;
            indicator.Width = btn.Width;
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            bunifuPages.SetPage("Dashboard");
        }

        private void BtnIncomebtnExpenses_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            bunifuPages.SetPage("Income");
        }

        private void BtnExpenses_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            bunifuPages.SetPage("Expenses");
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            bunifuPages.SetPage("Wishlist");
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //update indicator
            MoveIndicator((Control)sender);
            bunifuPages.SetPage("Settings");
        }

        //PLOT CHARTS
        void RenderMonthChart()
        {
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            //series
            Bunifu.DataViz.WinForms.DataPoint income = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);
            Bunifu.DataViz.WinForms.DataPoint expenses = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_column);
            Bunifu.DataViz.WinForms.DataPoint balance = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_spline);

            //add random data
            Random ran = new Random();
            for (int i = 0; i <= 30; i++)
            {
                income.addLabely(i.ToString(), ran.Next(20, 500));
                expenses.addLabely(i.ToString(), ran.Next(0, 100));
                balance.addLabely(i.ToString(), ran.Next(100, 1000));

            }


            canvas.addData(income);
            canvas.addData(expenses);
            canvas.addData(balance);

            //render the chart
            bunifuDataViz1.Render(canvas);
        }
        void RenderIncomeChart()
        {
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            //series
            Bunifu.DataViz.WinForms.DataPoint outlook = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);

            //add random data

            outlook.addLabely("Salary", 100000);
            outlook.addLabely("Commission", 50000);
            outlook.addLabely("Freelance", 2000);
            outlook.addLabely("Youtube", 20000);


            canvas.addData(outlook);

            //render the chart
            bunifuDataViz2.Render(canvas);
        }
        void RenderExpenseChart()
        {
            Bunifu.DataViz.WinForms.Canvas canvas = new Bunifu.DataViz.WinForms.Canvas();

            //series
            Bunifu.DataViz.WinForms.DataPoint outlook = new Bunifu.DataViz.WinForms.DataPoint(Bunifu.DataViz.WinForms.BunifuDataViz._type.Bunifu_pie);

            //add random data

            outlook.addLabely("Rent", 20000);
            outlook.addLabely("Food", 50000);
            outlook.addLabely("Bills", 2000);
            outlook.addLabely("Internet", 20000);
            outlook.addLabely("Airtime", 2000);


            canvas.addData(outlook);

            //render the chart
            bunifuDataViz3.Render(canvas);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            RenderMonthChart();
            RenderIncomeChart();
            RenderExpenseChart();
        }

        private void BtnAddIncome_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this, new Forms.frmAddIncome(inputDate.Value));
            ReloadIncome();
        }

        private void GridMincome_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (gridMincome.Rows[e.RowIndex].Tag != null)
            {
                //edit 
                var incomeCategory = (IncomeCategory)gridMincome.Rows[e.RowIndex].Tag;
                incomeCategory.Name = gridMincome.Rows[e.RowIndex].Cells[0].Value.ToString();
                DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").Update(incomeCategory);

            }
            else
            {
                //new record
                int id = DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").Insert(
                      new IncomeCategory()
                      {
                          Name = gridMincome.Rows[e.RowIndex].Cells[0].Value.ToString()
                      }
                      );
                //update tag
                gridMincome.Rows[e.RowIndex].Tag = DbContext.GetInstace().GetCollection<IncomeCategory>("income_categories").FindById(id);
            }
        }

        private void GridMexpense_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMexpense.Rows[e.RowIndex].Tag != null)
            {
                //edit 
                var expenseCategory = (ExpenseCategory)gridMexpense.Rows[e.RowIndex].Tag;
                expenseCategory.Name = gridMexpense.Rows[e.RowIndex].Cells[0].Value.ToString();
                DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").Update(expenseCategory);

            }
            else
            {
                //new record
                int id = DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").Insert(
                      new ExpenseCategory()
                      {
                          Name = gridMexpense.Rows[e.RowIndex].Cells[0].Value.ToString()
                      }
                      );
                //update tag
                gridMexpense.Rows[e.RowIndex].Tag = DbContext.GetInstace().GetCollection<ExpenseCategory>("expense_categories").FindById(id);
            }
        }

        private void GridMaccounts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridMaccounts.Rows[e.RowIndex].Tag != null)
            {
                //edit 
                var account = (Account)gridMaccounts.Rows[e.RowIndex].Tag;
                account.Name = gridMaccounts.Rows[e.RowIndex].Cells[0].Value.ToString();
                DbContext.GetInstace().GetCollection<Account>("accounts").Update(account);

            }
            else
            {
                //new record
                int id = DbContext.GetInstace().GetCollection<Account>("accounts").Insert(
                      new Account()
                      {
                          Name = gridMaccounts.Rows[e.RowIndex].Cells[0].Value.ToString()
                      }
                      );
                //update tag
                gridMaccounts.Rows[e.RowIndex].Tag = DbContext.GetInstace().GetCollection<Account>("accounts").FindById(id);
            }
        }

        

        private void InputDate_ValueChanged(object sender, EventArgs e)
        {
            ReloadIncome();
        }

        private void InputDuration_onItemSelected(object sender, EventArgs e)
        {
            ReloadIncome();
        }

        private void InputAccount_onItemSelected(object sender, EventArgs e)
        {
            ReloadIncome();
        }

        private void InputCategory_onItemSelected(object sender, EventArgs e)
        {
            ReloadIncome();
        }

        private void InputSearch_TextChanged(object sender, EventArgs e)
        {
            ReloadIncome();
        }

        private void GridIncome_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                new Helper.Popup.transparentBg(this, new Forms.frmAddIncome(inputDate.Value,(IncomeTransaction)gridIncome.Rows[e.RowIndex].Tag));
                ReloadIncome();

            }
        }

       

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridIncome.CurrentRow.Index >= 0)
            {
                new Helper.Popup.transparentBg(this, new Forms.frmAddIncome(inputDate.Value, (IncomeTransaction)gridIncome.Rows[gridIncome.CurrentRow.Index].Tag));
                ReloadIncome();

            }
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridIncome.CurrentRow.Index >= 0 && MessageBox.Show("Delete transaction?","Confirm!!",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
            {
                var transaction = (IncomeTransaction)gridIncome.Rows[gridIncome.CurrentRow.Index].Tag;
                DbContext.GetInstace().GetCollection<IncomeTransaction>("income_transactions").Delete(transaction.Id);
               ReloadIncome();

            }
        }



        private void IncomeContext_Opening(object sender, CancelEventArgs e)
        {
            if (!(gridIncome.CurrentRow.Index >= 0))
            {
                e.Cancel = true;
            }
        }

        private void BtnAddExpenditure_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this, new Forms.frmAddExpenses(inputDate.Value));
            ReloadExpenses();
        }

        private void InputSearchE_TextChanged(object sender, EventArgs e)
        {
            ReloadExpenses();
        }

        private void InputAccountE_onItemSelected(object sender, EventArgs e)
        {
            ReloadExpenses();
        }

        private void InputDurationE_onItemSelected(object sender, EventArgs e)
        {
            ReloadExpenses();
        }

        private void InputCategoryE_onItemSelected(object sender, EventArgs e)
        {
            ReloadExpenses();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            new Helper.Popup.transparentBg(this, new Forms.frmAddWishlist(inputDate.Value));
            ReloadWishlist();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            ReloadWishlist();
        }

        private void bunifuDropdown3_onItemSelected(object sender, EventArgs e)
        {
            ReloadWishlist();
        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            ReloadWishlist();
        }
    }
}
