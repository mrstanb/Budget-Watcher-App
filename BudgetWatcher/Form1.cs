using System;
using System.Windows.Forms;
using BudgetDB;
using BudgetWatcher.Factories;
using BudgetWatcher.InputReader;
using BudgetWatcher.Repository;

namespace BudgetWatcher
{
    public partial class Bw : Form
    {
        readonly BudgetFactory budgetFactory = new BudgetFactory();
        readonly OutcomeFactory outcomeFactory = new OutcomeFactory();
        readonly IRepository<Budget> repositoryBudget = new Repository<Budget>();
        readonly IRepository<Outcome> repositoryOutcome = new Repository<Outcome>();
        private string reportDetails;

        private decimal budget;

        public Bw()
        {
            InitializeComponent();
        }

        private void budgetTextBox_TextChanged(object sender, EventArgs e)
        {
           WinFormsReader.BudgetInput = WinFormsReader.ReadBudget(budgetTextBox.Text);
        }

        private void setBudgetBtn_Click(object sender, EventArgs e)
        {

// Create Budget object
          var budgetObj =  budgetFactory.CreateBudget(WinFormsReader.BudgetInput);
            repositoryBudget.AddBudget(budgetObj);

          ClearBudgetBox();
        }

        private void foodTextBox_TextChanged(object sender, EventArgs e)
        {

        WinFormsReader.SpendingsInput[0] = WinFormsReader.ReadSpending(foodTextBox.Text);
        }

        private void transportTextBox_TextChanged(object sender, EventArgs e)
         {
         WinFormsReader.SpendingsInput[1] = WinFormsReader.ReadSpending(transportTextBox.Text);
        }

        private void homeTextBox_TextChanged(object sender, EventArgs e)
        {
            WinFormsReader.SpendingsInput[2] = WinFormsReader.ReadSpending(homeTextBox.Text);
        }

        private void billsTextBox_TextChanged(object sender, EventArgs e)
        {
        WinFormsReader.SpendingsInput[3] = WinFormsReader.ReadSpending(billsTextBox.Text);
        }

        private void leasureTextBox_TextChanged(object sender, EventArgs e)
        {
        WinFormsReader.SpendingsInput[4] = WinFormsReader.ReadSpending(leasureTextBox.Text);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Create Outcome object   
            int lastId = repositoryBudget.GetBudgetId();
            var outcome = outcomeFactory.GreateOutcome(lastId, WinFormsReader.SpendingsInput[0],
                WinFormsReader.SpendingsInput[1], WinFormsReader.SpendingsInput[2],
                WinFormsReader.SpendingsInput[3], WinFormsReader.SpendingsInput[4]);
            decimal spendingsTillNow = repositoryBudget.TotalSpendings();
            if (spendingsTillNow + outcome.SpendingsSum > repositoryBudget.GetLastBudget())
            {
                throw new ArgumentException("READ ->  Spending cannot be added because exceeds budget!");
            }
            repositoryOutcome.AddSpending(outcome);
            ClearSpendingBoxes();
        }

        private void GetReportBtn_Click(object sender, EventArgs e)
        {       
            reportDetails = repositoryBudget.GetReport();
            UpdateReportLabel();
        }    
        private void RepLabel_Click(object sender, EventArgs e)
        {
   //         RepLabel.Text = reportDetails;
        }

        private void UpdateReportLabel()
        {
            RepLabel.Text = reportDetails;
        }


        private void ClearSpendingBoxes()
        {
            foodTextBox.Text = string.Empty;
            transportTextBox.Text = string.Empty;
            homeTextBox.Text = string.Empty;
            billsTextBox.Text = string.Empty;
            leasureTextBox.Text = string.Empty;
        }

        private void ClearBudgetBox()
        {
            budgetTextBox.Text = string.Empty;
        }

    }
}
