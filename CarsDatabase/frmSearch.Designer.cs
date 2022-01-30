namespace CarsDatabase
{
    partial class frmSearch
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
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.textBoxFilterValue = new System.Windows.Forms.TextBox();
         this.cboOperator = new System.Windows.Forms.ComboBox();
         this.cboField = new System.Windows.Forms.ComboBox();
         this.dataGridView1 = new System.Windows.Forms.DataGridView();
         this.Reg = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Make = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.EngineSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.RegistrationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.Available = new System.Windows.Forms.DataGridViewCheckBoxColumn();
         this.btnRun = new System.Windows.Forms.Button();
         this.btnClose = new System.Windows.Forms.Button();
         this.comboBox1 = new System.Windows.Forms.ComboBox();
         this.groupBox1.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
         this.SuspendLayout();
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.label3);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.textBoxFilterValue);
         this.groupBox1.Controls.Add(this.cboOperator);
         this.groupBox1.Controls.Add(this.cboField);
         this.groupBox1.Location = new System.Drawing.Point(23, 31);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(388, 90);
         this.groupBox1.TabIndex = 0;
         this.groupBox1.TabStop = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(260, 20);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(34, 13);
         this.label3.TabIndex = 5;
         this.label3.Text = "Value";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(175, 20);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(48, 13);
         this.label2.TabIndex = 4;
         this.label2.Text = "Operator";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(25, 20);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(29, 13);
         this.label1.TabIndex = 3;
         this.label1.Text = "Field";
         // 
         // textBoxFilterValue
         // 
         this.textBoxFilterValue.Location = new System.Drawing.Point(263, 53);
         this.textBoxFilterValue.Name = "textBoxFilterValue";
         this.textBoxFilterValue.Size = new System.Drawing.Size(100, 20);
         this.textBoxFilterValue.TabIndex = 2;
         // 
         // cboOperator
         // 
         this.cboOperator.FormattingEnabled = true;
         this.cboOperator.Location = new System.Drawing.Point(178, 53);
         this.cboOperator.Name = "cboOperator";
         this.cboOperator.Size = new System.Drawing.Size(62, 21);
         this.cboOperator.TabIndex = 1;
         // 
         // cboField
         // 
         this.cboField.FormattingEnabled = true;
         this.cboField.Location = new System.Drawing.Point(25, 53);
         this.cboField.Name = "cboField";
         this.cboField.Size = new System.Drawing.Size(121, 21);
         this.cboField.TabIndex = 0;
         // 
         // dataGridView1
         // 
         this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Reg,
            this.Make,
            this.EngineSize,
            this.RegistrationDate,
            this.Rate,
            this.Available});
         this.dataGridView1.Location = new System.Drawing.Point(48, 140);
         this.dataGridView1.Name = "dataGridView1";
         this.dataGridView1.Size = new System.Drawing.Size(636, 221);
         this.dataGridView1.TabIndex = 1;
         // 
         // Reg
         // 
         this.Reg.HeaderText = "Reg";
         this.Reg.Name = "Reg";
         // 
         // Make
         // 
         this.Make.HeaderText = "Make";
         this.Make.Name = "Make";
         // 
         // EngineSize
         // 
         this.EngineSize.HeaderText = "Engine Size";
         this.EngineSize.Name = "EngineSize";
         // 
         // RegistrationDate
         // 
         this.RegistrationDate.HeaderText = "Registration Date";
         this.RegistrationDate.Name = "RegistrationDate";
         // 
         // Rate
         // 
         this.Rate.HeaderText = "Rate";
         this.Rate.Name = "Rate";
         // 
         // Available
         // 
         this.Available.HeaderText = "Available";
         this.Available.Name = "Available";
         // 
         // btnRun
         // 
         this.btnRun.Location = new System.Drawing.Point(458, 41);
         this.btnRun.Name = "btnRun";
         this.btnRun.Size = new System.Drawing.Size(75, 23);
         this.btnRun.TabIndex = 2;
         this.btnRun.Text = "Run";
         this.btnRun.UseVisualStyleBackColor = true;
         this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
         // 
         // btnClose
         // 
         this.btnClose.Location = new System.Drawing.Point(458, 82);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(75, 23);
         this.btnClose.TabIndex = 3;
         this.btnClose.Text = "Close";
         this.btnClose.UseVisualStyleBackColor = true;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // comboBox1
         // 
         this.comboBox1.FormattingEnabled = true;
         this.comboBox1.Location = new System.Drawing.Point(265, 176);
         this.comboBox1.Name = "comboBox1";
         this.comboBox1.Size = new System.Drawing.Size(121, 21);
         this.comboBox1.TabIndex = 4;
         // 
         // frmSearch
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(651, 373);
         this.Controls.Add(this.comboBox1);
         this.Controls.Add(this.btnClose);
         this.Controls.Add(this.btnRun);
         this.Controls.Add(this.dataGridView1);
         this.Controls.Add(this.groupBox1);
         this.Name = "frmSearch";
         this.Text = "frmSearch";
         this.Load += new System.EventHandler(this.frmSearch_Load);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
         this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFilterValue;
        private System.Windows.Forms.ComboBox cboOperator;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClose;
      private System.Windows.Forms.DataGridViewTextBoxColumn Reg;
      private System.Windows.Forms.DataGridViewTextBoxColumn Make;
      private System.Windows.Forms.DataGridViewTextBoxColumn EngineSize;
      private System.Windows.Forms.DataGridViewTextBoxColumn RegistrationDate;
      private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
      private System.Windows.Forms.DataGridViewCheckBoxColumn Available;
      private System.Windows.Forms.ComboBox comboBox1;
   }
}