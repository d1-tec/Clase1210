namespace UI
{
    partial class RegisterTimeUserControl
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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.comboBoxBikes = new System.Windows.Forms.ComboBox();
            this.numericUpDownDistance = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAddDistanceEntry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(455, 702);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(263, 71);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Volver";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // comboBoxBikes
            // 
            this.comboBoxBikes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBikes.FormattingEnabled = true;
            this.comboBoxBikes.Location = new System.Drawing.Point(121, 96);
            this.comboBoxBikes.Name = "comboBoxBikes";
            this.comboBoxBikes.Size = new System.Drawing.Size(281, 50);
            this.comboBoxBikes.TabIndex = 1;
            // 
            // numericUpDownDistance
            // 
            this.numericUpDownDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDistance.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDistance.Location = new System.Drawing.Point(569, 96);
            this.numericUpDownDistance.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownDistance.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownDistance.Name = "numericUpDownDistance";
            this.numericUpDownDistance.Size = new System.Drawing.Size(288, 44);
            this.numericUpDownDistance.TabIndex = 2;
            this.numericUpDownDistance.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(553, 188);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(598, 44);
            this.dateTimePicker.TabIndex = 3;
            // 
            // buttonAddDistanceEntry
            // 
            this.buttonAddDistanceEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddDistanceEntry.Location = new System.Drawing.Point(553, 324);
            this.buttonAddDistanceEntry.Name = "buttonAddDistanceEntry";
            this.buttonAddDistanceEntry.Size = new System.Drawing.Size(449, 101);
            this.buttonAddDistanceEntry.TabIndex = 4;
            this.buttonAddDistanceEntry.Text = "Agregar distancia recorrida";
            this.buttonAddDistanceEntry.UseVisualStyleBackColor = true;
            this.buttonAddDistanceEntry.Click += new System.EventHandler(this.buttonAddDistanceEntry_Click);
            // 
            // RegisterTimeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAddDistanceEntry);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.numericUpDownDistance);
            this.Controls.Add(this.comboBoxBikes);
            this.Controls.Add(this.buttonReturn);
            this.Name = "RegisterTimeUserControl";
            this.Size = new System.Drawing.Size(1184, 862);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDistance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox comboBoxBikes;
        private System.Windows.Forms.NumericUpDown numericUpDownDistance;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAddDistanceEntry;
    }
}
