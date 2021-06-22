
namespace Dates_and_Strings_exercise
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
            this.lblArrivalDate = new System.Windows.Forms.Label();
            this.lblDepartureDate = new System.Windows.Forms.Label();
            this.lblNumberOfNights = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblAvgPricePerNight = new System.Windows.Forms.Label();
            this.txtBxNoOfNights = new System.Windows.Forms.TextBox();
            this.txtBxTotalPrice = new System.Windows.Forms.TextBox();
            this.txtBxAvgPricePerNight = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dtPikrArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.dtPkrDepartureDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblArrivalDate
            // 
            this.lblArrivalDate.AutoSize = true;
            this.lblArrivalDate.Location = new System.Drawing.Point(180, 66);
            this.lblArrivalDate.Name = "lblArrivalDate";
            this.lblArrivalDate.Size = new System.Drawing.Size(84, 17);
            this.lblArrivalDate.TabIndex = 0;
            this.lblArrivalDate.Text = "Arrival date:";
            // 
            // lblDepartureDate
            // 
            this.lblDepartureDate.AutoSize = true;
            this.lblDepartureDate.Location = new System.Drawing.Point(180, 115);
            this.lblDepartureDate.Name = "lblDepartureDate";
            this.lblDepartureDate.Size = new System.Drawing.Size(112, 17);
            this.lblDepartureDate.TabIndex = 1;
            this.lblDepartureDate.Text = "Departure  date:";
            // 
            // lblNumberOfNights
            // 
            this.lblNumberOfNights.AutoSize = true;
            this.lblNumberOfNights.Location = new System.Drawing.Point(180, 162);
            this.lblNumberOfNights.Name = "lblNumberOfNights";
            this.lblNumberOfNights.Size = new System.Drawing.Size(120, 17);
            this.lblNumberOfNights.TabIndex = 2;
            this.lblNumberOfNights.Text = "Number of nights:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(180, 211);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(75, 17);
            this.lblTotalPrice.TabIndex = 3;
            this.lblTotalPrice.Text = "Total price";
            // 
            // lblAvgPricePerNight
            // 
            this.lblAvgPricePerNight.AutoSize = true;
            this.lblAvgPricePerNight.Location = new System.Drawing.Point(180, 269);
            this.lblAvgPricePerNight.Name = "lblAvgPricePerNight";
            this.lblAvgPricePerNight.Size = new System.Drawing.Size(131, 17);
            this.lblAvgPricePerNight.TabIndex = 4;
            this.lblAvgPricePerNight.Text = "Avg. price per night";
            // 
            // txtBxNoOfNights
            // 
            this.txtBxNoOfNights.Location = new System.Drawing.Point(383, 162);
            this.txtBxNoOfNights.Name = "txtBxNoOfNights";
            this.txtBxNoOfNights.Size = new System.Drawing.Size(97, 22);
            this.txtBxNoOfNights.TabIndex = 7;
            // 
            // txtBxTotalPrice
            // 
            this.txtBxTotalPrice.Location = new System.Drawing.Point(383, 211);
            this.txtBxTotalPrice.Name = "txtBxTotalPrice";
            this.txtBxTotalPrice.Size = new System.Drawing.Size(97, 22);
            this.txtBxTotalPrice.TabIndex = 8;
            // 
            // txtBxAvgPricePerNight
            // 
            this.txtBxAvgPricePerNight.Location = new System.Drawing.Point(380, 269);
            this.txtBxAvgPricePerNight.Name = "txtBxAvgPricePerNight";
            this.txtBxAvgPricePerNight.Size = new System.Drawing.Size(100, 22);
            this.txtBxAvgPricePerNight.TabIndex = 9;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(171, 346);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(128, 41);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(439, 356);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 31);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dtPikrArrivalDate
            // 
            this.dtPikrArrivalDate.Location = new System.Drawing.Point(383, 77);
            this.dtPikrArrivalDate.Name = "dtPikrArrivalDate";
            this.dtPikrArrivalDate.Size = new System.Drawing.Size(246, 22);
            this.dtPikrArrivalDate.TabIndex = 12;
            this.dtPikrArrivalDate.ValueChanged += new System.EventHandler(this.dtPikrArrivalDate_ValueChanged);
            // 
            // dtPkrDepartureDate
            // 
            this.dtPkrDepartureDate.Location = new System.Drawing.Point(388, 115);
            this.dtPkrDepartureDate.Name = "dtPkrDepartureDate";
            this.dtPkrDepartureDate.Size = new System.Drawing.Size(241, 22);
            this.dtPkrDepartureDate.TabIndex = 13;
            this.dtPkrDepartureDate.ValueChanged += new System.EventHandler(this.dtPkrDepartureDate_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtPkrDepartureDate);
            this.Controls.Add(this.dtPikrArrivalDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxAvgPricePerNight);
            this.Controls.Add(this.txtBxTotalPrice);
            this.Controls.Add(this.txtBxNoOfNights);
            this.Controls.Add(this.lblAvgPricePerNight);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblNumberOfNights);
            this.Controls.Add(this.lblDepartureDate);
            this.Controls.Add(this.lblArrivalDate);
            this.Name = "Form1";
            this.Text = "Reservations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrivalDate;
        private System.Windows.Forms.Label lblDepartureDate;
        private System.Windows.Forms.Label lblNumberOfNights;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblAvgPricePerNight;
        private System.Windows.Forms.TextBox txtBxNoOfNights;
        private System.Windows.Forms.TextBox txtBxTotalPrice;
        private System.Windows.Forms.TextBox txtBxAvgPricePerNight;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DateTimePicker dtPikrArrivalDate;
        private System.Windows.Forms.DateTimePicker dtPkrDepartureDate;
    }
}

