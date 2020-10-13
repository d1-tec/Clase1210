namespace UI
{
    partial class ViewBikesUserControl
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
            this.dataGridViewBikes = new System.Windows.Forms.DataGridView();
            this.buttonReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewBikes
            // 
            this.dataGridViewBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBikes.Location = new System.Drawing.Point(87, 74);
            this.dataGridViewBikes.Name = "dataGridViewBikes";
            this.dataGridViewBikes.RowTemplate.Height = 33;
            this.dataGridViewBikes.Size = new System.Drawing.Size(998, 502);
            this.dataGridViewBikes.TabIndex = 0;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(463, 682);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(245, 83);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.Text = "Volver";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // ViewBikesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.dataGridViewBikes);
            this.Name = "ViewBikesUserControl";
            this.Size = new System.Drawing.Size(1184, 862);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBikes;
        private System.Windows.Forms.Button buttonReturn;
    }
}
