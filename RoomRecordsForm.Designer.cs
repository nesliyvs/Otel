namespace OtelTakip_Me
{
    partial class RoomRecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomRecordsForm));
            this.btnAddRoomRecord = new System.Windows.Forms.Button();
            this.dataGridViewRoomRecords = new System.Windows.Forms.DataGridView();
            this.roomRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomRecordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRoomRecord
            // 
            this.btnAddRoomRecord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddRoomRecord.BackgroundImage")));
            this.btnAddRoomRecord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRoomRecord.Location = new System.Drawing.Point(350, 170);
            this.btnAddRoomRecord.Name = "btnAddRoomRecord";
            this.btnAddRoomRecord.Size = new System.Drawing.Size(55, 32);
            this.btnAddRoomRecord.TabIndex = 8;
            this.btnAddRoomRecord.UseVisualStyleBackColor = true;
            this.btnAddRoomRecord.Click += new System.EventHandler(this.BtnAddRoomRecord_Click);
            // 
            // dataGridViewRoomRecords
            // 
            this.dataGridViewRoomRecords.AutoGenerateColumns = false;
            this.dataGridViewRoomRecords.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewRoomRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoomRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.startDateDataGridViewTextBoxColumn,
            this.endDateDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.customerNameDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn,
            this.dayCountDataGridViewTextBoxColumn});
            this.dataGridViewRoomRecords.DataSource = this.roomRecordBindingSource;
            this.dataGridViewRoomRecords.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRoomRecords.Name = "dataGridViewRoomRecords";
            this.dataGridViewRoomRecords.Size = new System.Drawing.Size(737, 137);
            this.dataGridViewRoomRecords.TabIndex = 7;
            // 
            // roomRecordBindingSource
            // 
            this.roomRecordBindingSource.DataSource = typeof(OtelTakip_Me.RoomRecord);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            this.startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            this.startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            this.startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            this.endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            this.endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            this.endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "RoomName";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            this.roomNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dayCountDataGridViewTextBoxColumn
            // 
            this.dayCountDataGridViewTextBoxColumn.DataPropertyName = "DayCount";
            this.dayCountDataGridViewTextBoxColumn.HeaderText = "DayCount";
            this.dayCountDataGridViewTextBoxColumn.Name = "dayCountDataGridViewTextBoxColumn";
            this.dayCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // RoomRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(938, 267);
            this.Controls.Add(this.btnAddRoomRecord);
            this.Controls.Add(this.dataGridViewRoomRecords);
            this.Name = "RoomRecordsForm";
            this.Text = "RoomRecordsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoomRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomRecordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddRoomRecord;
        private System.Windows.Forms.DataGridView dataGridViewRoomRecords;
        private System.Windows.Forms.BindingSource roomRecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayCountDataGridViewTextBoxColumn;
    }
}