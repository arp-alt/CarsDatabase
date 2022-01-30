using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsDatabase
{
    public partial class frmSearch : Form
    {
        frmCars callingForm;
        DataView carsTableView;

        public frmSearch()
        {
            InitializeComponent();
         //callingForm = carForm;
         //callingForm.Hide();
         // carsTableView = new DataView(ds.Tables["tblCar"]);
         this.dataGridView1.Rows.Add("1", "XX");
      } 

        private void frmSearch_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = carsTableView;

            dataGridView1.Columns["DateRegistered"].
                DefaultCellStyle.Format = "dd/MM/yyy";

            dataGridView1.Columns["RentalPerDay"].
                DefaultCellStyle.FormatProvider = new CultureInfo("en-IE");
            dataGridView1.Columns["RentalPerDay"].
                DefaultCellStyle.Format = "c";

            this.Text = "Task A Search - Thomas McCann - Date: " +
                DateTime.Now.ToShortDateString();

            //18
            cboField.Items.Add("Make");
            cboField.Items.Add("EngineSize");
            cboField.Items.Add("RentalPerDay");
            cboField.Items.Add("Available");


            cboOperator.Items.Add("=");
            cboOperator.Items.Add("<");
            cboOperator.Items.Add(">");
            cboOperator.Items.Add("<=");
            cboOperator.Items.Add(">=");
           

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            callingForm.Show();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(cboField.Text) ||
                String.IsNullOrEmpty(cboOperator.Text) ||
                String.IsNullOrEmpty(textBoxFilterValue.Text))
            {
                MessageBox.Show("Missing search criteria!");
            }
            else
            {
                string filter = String.Format("{0} {1} '{2}'",
                    cboField.Text, cboOperator.Text,
                    textBoxFilterValue.Text);

                carsTableView.RowFilter = filter;
                MessageBox.Show(carsTableView.Count.ToString() +  " matching rows found.");
            }
        }

        
    }
}
