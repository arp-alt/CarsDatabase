namespace CarsDatabase
{
    partial class frmCars
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
         this.components = new System.ComponentModel.Container();
         this.label1 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.textBoxVehicleReg = new System.Windows.Forms.TextBox();
         this.textBoxMake = new System.Windows.Forms.TextBox();
         this.textBoxEngineSize = new System.Windows.Forms.TextBox();
         this.textBoxDateRegistered = new System.Windows.Forms.TextBox();
         this.textBoxRentalCost = new System.Windows.Forms.TextBox();
         this.checkBoxAvailable = new System.Windows.Forms.CheckBox();
         this.label7 = new System.Windows.Forms.Label();
         this.buttonUpdate = new System.Windows.Forms.Button();
         this.buttonAdd = new System.Windows.Forms.Button();
         this.buttonDelete = new System.Windows.Forms.Button();
         this.buttonSearch = new System.Windows.Forms.Button();
         this.buttonCancel = new System.Windows.Forms.Button();
         this.buttonExit = new System.Windows.Forms.Button();
         this.buttonFirst = new System.Windows.Forms.Button();
         this.buttonPrevious = new System.Windows.Forms.Button();
         this.buttonNext = new System.Windows.Forms.Button();
         this.buttonLast = new System.Windows.Forms.Button();
         this.textBoxRecordCount = new System.Windows.Forms.TextBox();
         this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
         this.SuspendLayout();
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(33, 72);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(139, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Vehicle Registration number";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(33, 113);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(34, 13);
         this.label2.TabIndex = 1;
         this.label2.Text = "Make";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(33, 154);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(63, 13);
         this.label3.TabIndex = 2;
         this.label3.Text = "Engine Size";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(33, 195);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(84, 13);
         this.label4.TabIndex = 3;
         this.label4.Text = "Date Registered";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(33, 236);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(79, 13);
         this.label5.TabIndex = 4;
         this.label5.Text = "Rental Per Day";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(33, 277);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(50, 13);
         this.label6.TabIndex = 5;
         this.label6.Text = "Available";
         // 
         // textBoxVehicleReg
         // 
         this.textBoxVehicleReg.Location = new System.Drawing.Point(216, 72);
         this.textBoxVehicleReg.Name = "textBoxVehicleReg";
         this.textBoxVehicleReg.Size = new System.Drawing.Size(180, 20);
         this.textBoxVehicleReg.TabIndex = 6;
         this.toolTip1.SetToolTip(this.textBoxVehicleReg, "Enter Reg number");
         // 
         // textBoxMake
         // 
         this.textBoxMake.Location = new System.Drawing.Point(216, 113);
         this.textBoxMake.Name = "textBoxMake";
         this.textBoxMake.Size = new System.Drawing.Size(180, 20);
         this.textBoxMake.TabIndex = 7;
         this.toolTip1.SetToolTip(this.textBoxMake, "Make and Model");
         // 
         // textBoxEngineSize
         // 
         this.textBoxEngineSize.Location = new System.Drawing.Point(216, 154);
         this.textBoxEngineSize.Name = "textBoxEngineSize";
         this.textBoxEngineSize.Size = new System.Drawing.Size(100, 20);
         this.textBoxEngineSize.TabIndex = 8;
         this.toolTip1.SetToolTip(this.textBoxEngineSize, "Please enter Engine Size in Litres (L)");
         // 
         // textBoxDateRegistered
         // 
         this.textBoxDateRegistered.Location = new System.Drawing.Point(216, 195);
         this.textBoxDateRegistered.Name = "textBoxDateRegistered";
         this.textBoxDateRegistered.Size = new System.Drawing.Size(77, 20);
         this.textBoxDateRegistered.TabIndex = 9;
         this.toolTip1.SetToolTip(this.textBoxDateRegistered, "Please enter date as dd/mm/yyy");
         // 
         // textBoxRentalCost
         // 
         this.textBoxRentalCost.Location = new System.Drawing.Point(216, 233);
         this.textBoxRentalCost.Name = "textBoxRentalCost";
         this.textBoxRentalCost.Size = new System.Drawing.Size(77, 20);
         this.textBoxRentalCost.TabIndex = 10;
         this.textBoxRentalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
         this.toolTip1.SetToolTip(this.textBoxRentalCost, "Please enter cost in decimal");
         // 
         // checkBoxAvailable
         // 
         this.checkBoxAvailable.AutoSize = true;
         this.checkBoxAvailable.Location = new System.Drawing.Point(216, 272);
         this.checkBoxAvailable.Name = "checkBoxAvailable";
         this.checkBoxAvailable.Size = new System.Drawing.Size(15, 14);
         this.checkBoxAvailable.TabIndex = 11;
         this.checkBoxAvailable.UseVisualStyleBackColor = true;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.label7.Location = new System.Drawing.Point(147, 19);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(203, 39);
         this.label7.TabIndex = 12;
         this.label7.Text = "Rusty Car Hire";
         this.label7.Click += new System.EventHandler(this.label7_Click);
         // 
         // buttonUpdate
         // 
         this.buttonUpdate.Location = new System.Drawing.Point(413, 71);
         this.buttonUpdate.Name = "buttonUpdate";
         this.buttonUpdate.Size = new System.Drawing.Size(127, 23);
         this.buttonUpdate.TabIndex = 13;
         this.buttonUpdate.Text = "&Update";
         this.buttonUpdate.UseVisualStyleBackColor = true;
         this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
         // 
         // buttonAdd
         // 
         this.buttonAdd.Location = new System.Drawing.Point(413, 102);
         this.buttonAdd.Name = "buttonAdd";
         this.buttonAdd.Size = new System.Drawing.Size(127, 23);
         this.buttonAdd.TabIndex = 14;
         this.buttonAdd.Text = "&Add";
         this.buttonAdd.UseVisualStyleBackColor = true;
         this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
         // 
         // buttonDelete
         // 
         this.buttonDelete.Location = new System.Drawing.Point(413, 131);
         this.buttonDelete.Name = "buttonDelete";
         this.buttonDelete.Size = new System.Drawing.Size(127, 23);
         this.buttonDelete.TabIndex = 15;
         this.buttonDelete.Text = "&Delete";
         this.buttonDelete.UseVisualStyleBackColor = true;
         this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
         // 
         // buttonSearch
         // 
         this.buttonSearch.Location = new System.Drawing.Point(413, 161);
         this.buttonSearch.Name = "buttonSearch";
         this.buttonSearch.Size = new System.Drawing.Size(127, 23);
         this.buttonSearch.TabIndex = 16;
         this.buttonSearch.Text = "&Search";
         this.buttonSearch.UseVisualStyleBackColor = true;
         this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
         // 
         // buttonCancel
         // 
         this.buttonCancel.Location = new System.Drawing.Point(413, 190);
         this.buttonCancel.Name = "buttonCancel";
         this.buttonCancel.Size = new System.Drawing.Size(127, 23);
         this.buttonCancel.TabIndex = 17;
         this.buttonCancel.Text = "&Cancel";
         this.buttonCancel.UseVisualStyleBackColor = true;
         this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
         // 
         // buttonExit
         // 
         this.buttonExit.Location = new System.Drawing.Point(413, 219);
         this.buttonExit.Name = "buttonExit";
         this.buttonExit.Size = new System.Drawing.Size(127, 23);
         this.buttonExit.TabIndex = 18;
         this.buttonExit.Text = "E&xit";
         this.buttonExit.UseVisualStyleBackColor = true;
         this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
         // 
         // buttonFirst
         // 
         this.buttonFirst.Location = new System.Drawing.Point(36, 348);
         this.buttonFirst.Name = "buttonFirst";
         this.buttonFirst.Size = new System.Drawing.Size(75, 23);
         this.buttonFirst.TabIndex = 19;
         this.buttonFirst.Text = "First";
         this.buttonFirst.UseVisualStyleBackColor = true;
         this.buttonFirst.Click += new System.EventHandler(this.buttonFirst_Click);
         // 
         // buttonPrevious
         // 
         this.buttonPrevious.Location = new System.Drawing.Point(119, 348);
         this.buttonPrevious.Name = "buttonPrevious";
         this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
         this.buttonPrevious.TabIndex = 20;
         this.buttonPrevious.Text = "Previous";
         this.buttonPrevious.UseVisualStyleBackColor = true;
         this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
         // 
         // buttonNext
         // 
         this.buttonNext.Location = new System.Drawing.Point(310, 348);
         this.buttonNext.Name = "buttonNext";
         this.buttonNext.Size = new System.Drawing.Size(75, 23);
         this.buttonNext.TabIndex = 21;
         this.buttonNext.Text = "Next";
         this.buttonNext.UseVisualStyleBackColor = true;
         this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
         // 
         // buttonLast
         // 
         this.buttonLast.Location = new System.Drawing.Point(393, 348);
         this.buttonLast.Name = "buttonLast";
         this.buttonLast.Size = new System.Drawing.Size(75, 23);
         this.buttonLast.TabIndex = 22;
         this.buttonLast.Text = "Last";
         this.buttonLast.UseVisualStyleBackColor = true;
         this.buttonLast.Click += new System.EventHandler(this.buttonLast_Click);
         // 
         // textBoxRecordCount
         // 
         this.textBoxRecordCount.Location = new System.Drawing.Point(202, 351);
         this.textBoxRecordCount.Name = "textBoxRecordCount";
         this.textBoxRecordCount.Size = new System.Drawing.Size(100, 20);
         this.textBoxRecordCount.TabIndex = 24;
         this.textBoxRecordCount.Text = "0 of 0";
         this.textBoxRecordCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // toolTip1
         // 
         this.toolTip1.IsBalloon = true;
         // 
         // frmCars
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.Color.LightCyan;
         this.ClientSize = new System.Drawing.Size(565, 408);
         this.Controls.Add(this.textBoxRecordCount);
         this.Controls.Add(this.buttonLast);
         this.Controls.Add(this.buttonNext);
         this.Controls.Add(this.buttonPrevious);
         this.Controls.Add(this.buttonFirst);
         this.Controls.Add(this.buttonExit);
         this.Controls.Add(this.buttonCancel);
         this.Controls.Add(this.buttonSearch);
         this.Controls.Add(this.buttonDelete);
         this.Controls.Add(this.buttonAdd);
         this.Controls.Add(this.buttonUpdate);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.checkBoxAvailable);
         this.Controls.Add(this.textBoxRentalCost);
         this.Controls.Add(this.textBoxDateRegistered);
         this.Controls.Add(this.textBoxEngineSize);
         this.Controls.Add(this.textBoxMake);
         this.Controls.Add(this.textBoxVehicleReg);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.label2);
         this.Controls.Add(this.label1);
         this.Name = "frmCars";
         this.Text = "Vehicle Details";
         this.toolTip1.SetToolTip(this, "Welcome to Bowman Car Hire");
         this.Load += new System.EventHandler(this.frmCars_Load);
         this.ResumeLayout(false);
         this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVehicleReg;
        private System.Windows.Forms.TextBox textBoxMake;
        private System.Windows.Forms.TextBox textBoxEngineSize;
        private System.Windows.Forms.TextBox textBoxDateRegistered;
        private System.Windows.Forms.TextBox textBoxRentalCost;
        private System.Windows.Forms.CheckBox checkBoxAvailable;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonFirst;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonLast;
        private System.Windows.Forms.TextBox textBoxRecordCount;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

