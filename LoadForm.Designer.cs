namespace Project3
{
    partial class LoadForm
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
            this.loadButton = new System.Windows.Forms.Button();
            this.end_date = new System.Windows.Forms.Label();
            this.start_date = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog_stockUpload = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(234, 192);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(152, 53);
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // end_date
            // 
            this.end_date.AutoSize = true;
            this.end_date.Location = new System.Drawing.Point(142, 138);
            this.end_date.Name = "end_date";
            this.end_date.Size = new System.Drawing.Size(63, 16);
            this.end_date.TabIndex = 10;
            this.end_date.Text = "End Date";
            // 
            // start_date
            // 
            this.start_date.AutoSize = true;
            this.start_date.Location = new System.Drawing.Point(142, 92);
            this.start_date.Name = "start_date";
            this.start_date.Size = new System.Drawing.Size(66, 16);
            this.start_date.TabIndex = 9;
            this.start_date.Text = "Start Date";
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(234, 133);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(243, 22);
            this.endDate.TabIndex = 8;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(234, 87);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(243, 22);
            this.startDate.TabIndex = 7;
            this.startDate.Value = new System.DateTime(2022, 9, 11, 0, 0, 0, 0);
            // 
            // openFileDialog_stockUpload
            // 
            this.openFileDialog_stockUpload.FileName = "openFileDialog";
            this.openFileDialog_stockUpload.Filter = "All Stock files|*.csv|Daily Stocks|*-Day.csv|Weekly Stocks|*-Week.csv|Monthly Sto" +
    "cks|*-Month.csv";
            this.openFileDialog_stockUpload.InitialDirectory = "C:...\\Project_2\\Stock Data";
            this.openFileDialog_stockUpload.Multiselect = true;
            this.openFileDialog_stockUpload.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_stockUpload_FileOk);
            // 
            // LoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 330);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.end_date);
            this.Controls.Add(this.start_date);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Name = "LoadForm";
            this.Text = "LoadForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label end_date;
        private System.Windows.Forms.Label start_date;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.OpenFileDialog openFileDialog_stockUpload;
    }
}

