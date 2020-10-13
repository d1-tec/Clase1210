namespace UI
{
    partial class MenuUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAddBike = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonRegisterTime = new System.Windows.Forms.Button();
            this.buttonViewBikes = new System.Windows.Forms.Button();
            this.buttonDistanceChart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddBike
            // 
            this.buttonAddBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBike.Location = new System.Drawing.Point(427, 116);
            this.buttonAddBike.Name = "buttonAddBike";
            this.buttonAddBike.Size = new System.Drawing.Size(351, 85);
            this.buttonAddBike.TabIndex = 0;
            this.buttonAddBike.Text = "Agregar Bicicleta";
            this.buttonAddBike.UseVisualStyleBackColor = true;
            this.buttonAddBike.Click += new System.EventHandler(this.buttonAddBike_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(427, 738);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(351, 81);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Salir";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonRegisterTime
            // 
            this.buttonRegisterTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisterTime.Location = new System.Drawing.Point(427, 292);
            this.buttonRegisterTime.Name = "buttonRegisterTime";
            this.buttonRegisterTime.Size = new System.Drawing.Size(351, 92);
            this.buttonRegisterTime.TabIndex = 2;
            this.buttonRegisterTime.Text = "Registrar tiempo";
            this.buttonRegisterTime.UseVisualStyleBackColor = true;
            this.buttonRegisterTime.Click += new System.EventHandler(this.buttonRegisterTime_Click);
            // 
            // buttonViewBikes
            // 
            this.buttonViewBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewBikes.Location = new System.Drawing.Point(427, 460);
            this.buttonViewBikes.Name = "buttonViewBikes";
            this.buttonViewBikes.Size = new System.Drawing.Size(351, 92);
            this.buttonViewBikes.TabIndex = 3;
            this.buttonViewBikes.Text = "Ver bicis";
            this.buttonViewBikes.UseVisualStyleBackColor = true;
            this.buttonViewBikes.Click += new System.EventHandler(this.buttonViewBikes_Click);
            // 
            // buttonDistanceChart
            // 
            this.buttonDistanceChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDistanceChart.Location = new System.Drawing.Point(427, 612);
            this.buttonDistanceChart.Name = "buttonDistanceChart";
            this.buttonDistanceChart.Size = new System.Drawing.Size(351, 70);
            this.buttonDistanceChart.TabIndex = 4;
            this.buttonDistanceChart.Text = "Grafico distancias";
            this.buttonDistanceChart.UseVisualStyleBackColor = true;
            this.buttonDistanceChart.Click += new System.EventHandler(this.buttonDistanceChart_Click);
            // 
            // MenuUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDistanceChart);
            this.Controls.Add(this.buttonViewBikes);
            this.Controls.Add(this.buttonRegisterTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAddBike);
            this.Name = "MenuUserControl";
            this.Size = new System.Drawing.Size(1184, 862);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAddBike;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonRegisterTime;
        private System.Windows.Forms.Button buttonViewBikes;
        private System.Windows.Forms.Button buttonDistanceChart;
    }
}
