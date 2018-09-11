namespace WindowsFormsApplication2
{
    partial class Form2
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.fuctionsDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fuctionsDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fuctionsDataSet1 = new WindowsFormsApplication2.FuctionsDataSet1();
            this.таблица1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.таблица1TableAdapter = new WindowsFormsApplication2.FuctionsDataSet1TableAdapters.Таблица1TableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.DataSource = this.таблица1BindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(384, 262);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // fuctionsDataSet1
            // 
            this.fuctionsDataSet1.DataSetName = "FuctionsDataSet1";
            this.fuctionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // таблица1BindingSource
            // 
            this.таблица1BindingSource.DataMember = "Таблица1";
            this.таблица1BindingSource.DataSource = this.fuctionsDataSet1;
            // 
            // таблица1TableAdapter
            // 
            this.таблица1TableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Описание";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(384, 262);
            this.Controls.Add(this.dataGridView2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fuctionsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.таблица1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource fuctionsDataSetBindingSource;
        private System.Windows.Forms.BindingSource fuctionsDataSetBindingSource1;
        private FuctionsDataSet1 fuctionsDataSet1;
        private System.Windows.Forms.BindingSource таблица1BindingSource;
        private FuctionsDataSet1TableAdapters.Таблица1TableAdapter таблица1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}