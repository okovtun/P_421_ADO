namespace Academy
{
	partial class TeacherForm
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
			this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
			this.labelWorkSince = new System.Windows.Forms.Label();
			this.labelRate = new System.Windows.Forms.Label();
			this.mtbRate = new System.Windows.Forms.MaskedTextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpWorkSince
			// 
			this.dtpWorkSince.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.CustomFormat = "yyyy.MMMM.dd";
			this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpWorkSince.Location = new System.Drawing.Point(170, 297);
			this.dtpWorkSince.Name = "dtpWorkSince";
			this.dtpWorkSince.Size = new System.Drawing.Size(249, 29);
			this.dtpWorkSince.TabIndex = 16;
			// 
			// labelWorkSince
			// 
			this.labelWorkSince.AutoSize = true;
			this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSince.Location = new System.Drawing.Point(49, 299);
			this.labelWorkSince.Name = "labelWorkSince";
			this.labelWorkSince.Size = new System.Drawing.Size(115, 24);
			this.labelWorkSince.TabIndex = 17;
			this.labelWorkSince.Text = "Работает с:";
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRate.Location = new System.Drawing.Point(15, 342);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(149, 24);
			this.labelRate.TabIndex = 18;
			this.labelRate.Text = "Ставка за пару:";
			// 
			// mtbRate
			// 
			this.mtbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.mtbRate.Location = new System.Drawing.Point(170, 340);
			this.mtbRate.Mask = "00000";
			this.mtbRate.Name = "mtbRate";
			this.mtbRate.Size = new System.Drawing.Size(75, 29);
			this.mtbRate.TabIndex = 20;
			this.mtbRate.ValidatingType = typeof(int);
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(646, 433);
			this.Controls.Add(this.mtbRate);
			this.Controls.Add(this.labelRate);
			this.Controls.Add(this.labelWorkSince);
			this.Controls.Add(this.dtpWorkSince);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.dtpWorkSince, 0);
			this.Controls.SetChildIndex(this.pictureBoxPhoto, 0);
			this.Controls.SetChildIndex(this.labelWorkSince, 0);
			this.Controls.SetChildIndex(this.labelRate, 0);
			this.Controls.SetChildIndex(this.mtbRate, 0);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpWorkSince;
		private System.Windows.Forms.Label labelWorkSince;
		private System.Windows.Forms.Label labelRate;
		private System.Windows.Forms.MaskedTextBox mtbRate;
	}
}