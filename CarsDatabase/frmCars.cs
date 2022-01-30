using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmCars : Form
    {

      // DataSet to store DB Data in program memory
      //https://docs.microsoft.com/en-us/dotnet/api/system.data.dataset?view=net-5.0
      DataSet carsDataset = new DataSet();

      /*The SqlDataAdapter in C# works as a bridge between a DataSet and a data source (SQL Server Database) to retrieve data. 
      The SqlDataAdapter is a class that represents a set of SQL commands and a database connection. 
      It can be used to fill the DataSet and update the data source.*/
      // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldataadapter?view=dotnet-plat-ext-5.0
      SqlDataAdapter carsDataAdapter; 

      //forms data source - links controls to data
      //https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.bindingsource?view=net-5.0
      BindingSource carsBindingSource; 

      // Create SQL Commands
      // https://docs.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqlcommandbuilder?view=dotnet-plat-ext-5.0
      SqlCommandBuilder dbSQLCommands;

      //4  - Connection String
      string DBConnectionString = @"Data Source=DESKTOP-380K30A\SQLEXPRESS2019;Initial Catalog=Hire;Integrated Security=True;";
      

      public frmCars()
        {
            InitializeComponent();
            //3
            this.Text = "Vehicle Details - Date: " + DateTime.Today.ToLongDateString();
            
        }

      private void frmCars_Load(object sender, EventArgs e)
      {
         //4
         //10 - add error handling
         try
         {
            // 4 connect to database 
            carsDataAdapter = new SqlDataAdapter("SELECT * FROM tblCar"  , DBConnectionString);
            carsDataAdapter.Fill(carsDataset, "tblCar");
             MessageBox.Show("Connected to DB");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.GetType().ToString() + ":" + ex.Message);
            Application.Exit();
         }

         BindControls(); //5 and //6 See method  BindControls()
         // First call to recordCountDisplay() just initially 
         // causes the recordCount textbox to get populated
         // to show the current record number
         recordCountDisplay();

         // Wire up an event handler to the binding source
         // PositionChanged event            
        carsBindingSource.PositionChanged += rowPositionChanged;
      }

      // Event handler wired up the 
      // carsBindingSource.PositionChanged event
      private void rowPositionChanged(object sender, EventArgs e)
      {
         recordCountDisplay();
      }

      private void BindControls()
      {
         carsBindingSource = new BindingSource(carsDataset, "tblCar");

         textBoxVehicleReg.DataBindings.Add("Text", carsBindingSource, "VehicleRegNo");
         textBoxMake.DataBindings.Add("Text", carsBindingSource, "Make");
         textBoxEngineSize.DataBindings.Add("Text", carsBindingSource, "EngineSize");

         Binding dateRegBinding =
         textBoxDateRegistered.DataBindings.Add("Text", carsBindingSource, "DateRegistered", true);
         dateRegBinding.FormatInfo = new CultureInfo("en-IE");

         Binding rentalCostBinding =
         textBoxRentalCost.DataBindings.Add("Text", carsBindingSource, "RentalPerDay", true);
         rentalCostBinding.FormatInfo = new CultureInfo("en-IE");

         rentalCostBinding.FormatString = "c"; // Format specifier for currency

         checkBoxAvailable.DataBindings.Add("Checked", carsBindingSource, "Available", true);

      }

      //7
      private void buttonAdd_Click(object sender, EventArgs e)
      {
         // Adds a new row (object) to the dataset
         // which the Binding Source is linked to
         carsBindingSource.AddNew();
      }

      //7
      private void buttonDelete_Click(object sender, EventArgs e)
      {
         // Removethe currently viewed row
         carsBindingSource.RemoveCurrent();
      }

      //7
      private void buttonCancel_Click(object sender, EventArgs e)
      {
         // Cancel editing of the curently viewed row
        carsBindingSource.CancelEdit();

         // Roll back changes that were made to the dataset
        carsDataset.RejectChanges();
      }

      //9
      private void recordCountDisplay()
      {
         textBoxRecordCount.Text = String.Format(" {0} of {1}", carsBindingSource.Position + 1, carsBindingSource.Count);
      }

      //8
      private void buttonFirst_Click(object sender, EventArgs e)
      {
        carsBindingSource.MoveFirst();
      }
      //8
      private void buttonPrevious_Click(object sender, EventArgs e)
      {
         carsBindingSource.MovePrevious();
      }
      //8
      private void buttonNext_Click(object sender, EventArgs e)
      {
         carsBindingSource.MoveNext();
      }
      //8
      private void buttonLast_Click(object sender, EventArgs e)
      {
         carsBindingSource.MoveLast();
      }

      //11
      private void buttonExit_Click(object sender, EventArgs e)
      {
         Application.Exit(); // exit windows program
      }

      //7
      private void buttonUpdate_Click(object sender, EventArgs e)
      {
         //10
         try
         {
            // 7 Apply any pending changes to the DataSet
            carsBindingSource.EndEdit();

            dbSQLCommands = new SqlCommandBuilder(carsDataAdapter);
            carsDataAdapter.Update(carsDataset, "tblCar");

            MessageBox.Show("Database successfully updated");
         }
         catch (Exception ex)
         {
            MessageBox.Show(ex.Message);
         }

      }

      private void buttonSearch_Click(object sender, EventArgs e)
      {
         frmSearch searchFrom = new frmSearch();
         searchFrom.Show();
      }

      private void label7_Click(object sender, EventArgs e)
      {

      }
   }
}
