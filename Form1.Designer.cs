namespace OtelTakip_Me
{
    partial class Form1
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
            this.btnPer = new System.Windows.Forms.Button();
            this.btnRoomRecord = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnCus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPer
            // 
            this.btnPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPer.Location = new System.Drawing.Point(27, 52);
            this.btnPer.Name = "btnPer";
            this.btnPer.Size = new System.Drawing.Size(105, 39);
            this.btnPer.TabIndex = 0;
            this.btnPer.Text = "PERSONEL";
            this.btnPer.UseVisualStyleBackColor = true;
            this.btnPer.Click += new System.EventHandler(this.BtnPer_Click);
            // 
            // btnRoomRecord
            // 
            this.btnRoomRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoomRecord.Location = new System.Drawing.Point(184, 116);
            this.btnRoomRecord.Name = "btnRoomRecord";
            this.btnRoomRecord.Size = new System.Drawing.Size(105, 39);
            this.btnRoomRecord.TabIndex = 1;
            this.btnRoomRecord.Text = "ROOM RECORDS";
            this.btnRoomRecord.UseVisualStyleBackColor = true;
            this.btnRoomRecord.Click += new System.EventHandler(this.BtnRoomRecord_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoom.Location = new System.Drawing.Point(27, 116);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(105, 39);
            this.btnRoom.TabIndex = 2;
            this.btnRoom.Text = "ROOM";
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // btnCus
            // 
            this.btnCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCus.Location = new System.Drawing.Point(184, 52);
            this.btnCus.Name = "btnCus";
            this.btnCus.Size = new System.Drawing.Size(105, 39);
            this.btnCus.TabIndex = 3;
            this.btnCus.Text = "CUSTOMER";
            this.btnCus.UseVisualStyleBackColor = true;
            this.btnCus.Click += new System.EventHandler(this.BtnCus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 7F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(354, 229);
            this.Controls.Add(this.btnCus);
            this.Controls.Add(this.btnRoom);
            this.Controls.Add(this.btnRoomRecord);
            this.Controls.Add(this.btnPer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "GİRİŞ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPer;
        private System.Windows.Forms.Button btnRoomRecord;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCus;
    }
}

