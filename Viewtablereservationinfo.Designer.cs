namespace WindowsFormsApp6
{
    partial class Viewtablereservationinfo
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ilkinDataSet2 = new WindowsFormsApp6.ilkinDataSet2();
            this.tpBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tpTableAdapter = new WindowsFormsApp6.ilkinDataSet2TableAdapters.tpTableAdapter();
            this.secParticipantnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secParticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secRoomsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secPrirorityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secEventTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secHostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secCoHostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secNoofparticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secstartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secendtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectime1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectime2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkinDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.secParticipantnDataGridViewTextBoxColumn,
            this.secParticipantsDataGridViewTextBoxColumn,
            this.secRoomsDataGridViewTextBoxColumn,
            this.secPrirorityDataGridViewTextBoxColumn,
            this.secEventTypeDataGridViewTextBoxColumn,
            this.secHostDataGridViewTextBoxColumn,
            this.secCoHostDataGridViewTextBoxColumn,
            this.secNoofparticipantsDataGridViewTextBoxColumn,
            this.secstartdateDataGridViewTextBoxColumn,
            this.secendtimeDataGridViewTextBoxColumn,
            this.sectime1DataGridViewTextBoxColumn,
            this.sectime2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tpBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1243, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // ilkinDataSet2
            // 
            this.ilkinDataSet2.DataSetName = "ilkinDataSet2";
            this.ilkinDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tpBindingSource
            // 
            this.tpBindingSource.DataMember = "tp";
            this.tpBindingSource.DataSource = this.ilkinDataSet2;
            // 
            // tpTableAdapter
            // 
            this.tpTableAdapter.ClearBeforeFill = true;
            // 
            // secParticipantnDataGridViewTextBoxColumn
            // 
            this.secParticipantnDataGridViewTextBoxColumn.DataPropertyName = "secParticipantn";
            this.secParticipantnDataGridViewTextBoxColumn.HeaderText = "secParticipantn";
            this.secParticipantnDataGridViewTextBoxColumn.Name = "secParticipantnDataGridViewTextBoxColumn";
            // 
            // secParticipantsDataGridViewTextBoxColumn
            // 
            this.secParticipantsDataGridViewTextBoxColumn.DataPropertyName = "secParticipants";
            this.secParticipantsDataGridViewTextBoxColumn.HeaderText = "secParticipants";
            this.secParticipantsDataGridViewTextBoxColumn.Name = "secParticipantsDataGridViewTextBoxColumn";
            // 
            // secRoomsDataGridViewTextBoxColumn
            // 
            this.secRoomsDataGridViewTextBoxColumn.DataPropertyName = "secRooms";
            this.secRoomsDataGridViewTextBoxColumn.HeaderText = "secRooms";
            this.secRoomsDataGridViewTextBoxColumn.Name = "secRoomsDataGridViewTextBoxColumn";
            // 
            // secPrirorityDataGridViewTextBoxColumn
            // 
            this.secPrirorityDataGridViewTextBoxColumn.DataPropertyName = "secPrirority";
            this.secPrirorityDataGridViewTextBoxColumn.HeaderText = "secPrirority";
            this.secPrirorityDataGridViewTextBoxColumn.Name = "secPrirorityDataGridViewTextBoxColumn";
            // 
            // secEventTypeDataGridViewTextBoxColumn
            // 
            this.secEventTypeDataGridViewTextBoxColumn.DataPropertyName = "secEventType";
            this.secEventTypeDataGridViewTextBoxColumn.HeaderText = "secEventType";
            this.secEventTypeDataGridViewTextBoxColumn.Name = "secEventTypeDataGridViewTextBoxColumn";
            // 
            // secHostDataGridViewTextBoxColumn
            // 
            this.secHostDataGridViewTextBoxColumn.DataPropertyName = "secHost";
            this.secHostDataGridViewTextBoxColumn.HeaderText = "secHost";
            this.secHostDataGridViewTextBoxColumn.Name = "secHostDataGridViewTextBoxColumn";
            // 
            // secCoHostDataGridViewTextBoxColumn
            // 
            this.secCoHostDataGridViewTextBoxColumn.DataPropertyName = "secCoHost";
            this.secCoHostDataGridViewTextBoxColumn.HeaderText = "secCoHost";
            this.secCoHostDataGridViewTextBoxColumn.Name = "secCoHostDataGridViewTextBoxColumn";
            // 
            // secNoofparticipantsDataGridViewTextBoxColumn
            // 
            this.secNoofparticipantsDataGridViewTextBoxColumn.DataPropertyName = "secNoofparticipants";
            this.secNoofparticipantsDataGridViewTextBoxColumn.HeaderText = "secNoofparticipants";
            this.secNoofparticipantsDataGridViewTextBoxColumn.Name = "secNoofparticipantsDataGridViewTextBoxColumn";
            // 
            // secstartdateDataGridViewTextBoxColumn
            // 
            this.secstartdateDataGridViewTextBoxColumn.DataPropertyName = "secstartdate";
            this.secstartdateDataGridViewTextBoxColumn.HeaderText = "secstartdate";
            this.secstartdateDataGridViewTextBoxColumn.Name = "secstartdateDataGridViewTextBoxColumn";
            // 
            // secendtimeDataGridViewTextBoxColumn
            // 
            this.secendtimeDataGridViewTextBoxColumn.DataPropertyName = "secendtime";
            this.secendtimeDataGridViewTextBoxColumn.HeaderText = "secendtime";
            this.secendtimeDataGridViewTextBoxColumn.Name = "secendtimeDataGridViewTextBoxColumn";
            // 
            // sectime1DataGridViewTextBoxColumn
            // 
            this.sectime1DataGridViewTextBoxColumn.DataPropertyName = "sectime1";
            this.sectime1DataGridViewTextBoxColumn.HeaderText = "sectime1";
            this.sectime1DataGridViewTextBoxColumn.Name = "sectime1DataGridViewTextBoxColumn";
            // 
            // sectime2DataGridViewTextBoxColumn
            // 
            this.sectime2DataGridViewTextBoxColumn.DataPropertyName = "sectime2";
            this.sectime2DataGridViewTextBoxColumn.HeaderText = "sectime2";
            this.sectime2DataGridViewTextBoxColumn.Name = "sectime2DataGridViewTextBoxColumn";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ilkinDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tpBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ilkinDataSet2 ilkinDataSet2;
        private System.Windows.Forms.BindingSource tpBindingSource;
        private ilkinDataSet2TableAdapters.tpTableAdapter tpTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn secParticipantnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secParticipantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secRoomsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secPrirorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secEventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secHostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secCoHostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secNoofparticipantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secstartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secendtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectime1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectime2DataGridViewTextBoxColumn;
    }
}