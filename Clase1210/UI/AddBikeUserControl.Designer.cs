namespace UI
{
    partial class AddBikeUserControl
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxBikes = new System.Windows.Forms.ListBox();
            this.textBoxBikeDetail = new System.Windows.Forms.TextBox();
            this.checkBoxIsNew = new System.Windows.Forms.CheckBox();
            this.radioButtonSize26 = new System.Windows.Forms.RadioButton();
            this.radioButton32 = new System.Windows.Forms.RadioButton();
            this.groupBoxBikeSize = new System.Windows.Forms.GroupBox();
            this.groupBoxBikeSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(766, 710);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(247, 77);
            this.buttonReturn.TabIndex = 0;
            this.buttonReturn.Text = "Volver";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(689, 126);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(324, 31);
            this.textBoxName.TabIndex = 1;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(689, 218);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(324, 33);
            this.comboBoxType.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(689, 556);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(324, 52);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxBikes
            // 
            this.listBoxBikes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxBikes.FormattingEnabled = true;
            this.listBoxBikes.ItemHeight = 37;
            this.listBoxBikes.Location = new System.Drawing.Point(71, 126);
            this.listBoxBikes.Name = "listBoxBikes";
            this.listBoxBikes.Size = new System.Drawing.Size(300, 300);
            this.listBoxBikes.TabIndex = 4;
            this.listBoxBikes.SelectedValueChanged += new System.EventHandler(this.listBoxBikes_SelectedValueChanged);
            // 
            // textBoxBikeDetail
            // 
            this.textBoxBikeDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBikeDetail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBoxBikeDetail.Location = new System.Drawing.Point(71, 572);
            this.textBoxBikeDetail.Multiline = true;
            this.textBoxBikeDetail.Name = "textBoxBikeDetail";
            this.textBoxBikeDetail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBikeDetail.Size = new System.Drawing.Size(410, 205);
            this.textBoxBikeDetail.TabIndex = 5;
            // 
            // checkBoxIsNew
            // 
            this.checkBoxIsNew.AutoSize = true;
            this.checkBoxIsNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxIsNew.Location = new System.Drawing.Point(689, 286);
            this.checkBoxIsNew.Name = "checkBoxIsNew";
            this.checkBoxIsNew.Size = new System.Drawing.Size(189, 41);
            this.checkBoxIsNew.TabIndex = 6;
            this.checkBoxIsNew.Text = "Es nueva";
            this.checkBoxIsNew.UseVisualStyleBackColor = true;
            // 
            // radioButtonSize26
            // 
            this.radioButtonSize26.AutoSize = true;
            this.radioButtonSize26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonSize26.Location = new System.Drawing.Point(20, 30);
            this.radioButtonSize26.Name = "radioButtonSize26";
            this.radioButtonSize26.Size = new System.Drawing.Size(214, 41);
            this.radioButtonSize26.TabIndex = 7;
            this.radioButtonSize26.TabStop = true;
            this.radioButtonSize26.Text = "Rodado 26";
            this.radioButtonSize26.UseVisualStyleBackColor = true;
            // 
            // radioButton32
            // 
            this.radioButton32.AutoSize = true;
            this.radioButton32.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton32.Location = new System.Drawing.Point(20, 86);
            this.radioButton32.Name = "radioButton32";
            this.radioButton32.Size = new System.Drawing.Size(214, 41);
            this.radioButton32.TabIndex = 8;
            this.radioButton32.TabStop = true;
            this.radioButton32.Text = "Rodado 32";
            this.radioButton32.UseVisualStyleBackColor = true;
            // 
            // groupBoxBikeSize
            // 
            this.groupBoxBikeSize.Controls.Add(this.radioButtonSize26);
            this.groupBoxBikeSize.Controls.Add(this.radioButton32);
            this.groupBoxBikeSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxBikeSize.Location = new System.Drawing.Point(685, 347);
            this.groupBoxBikeSize.Name = "groupBoxBikeSize";
            this.groupBoxBikeSize.Size = new System.Drawing.Size(328, 148);
            this.groupBoxBikeSize.TabIndex = 9;
            this.groupBoxBikeSize.TabStop = false;
            this.groupBoxBikeSize.Text = "Rodado";
            // 
            // AddBikeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxBikeSize);
            this.Controls.Add(this.checkBoxIsNew);
            this.Controls.Add(this.textBoxBikeDetail);
            this.Controls.Add(this.listBoxBikes);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonReturn);
            this.Name = "AddBikeUserControl";
            this.Size = new System.Drawing.Size(1184, 862);
            this.groupBoxBikeSize.ResumeLayout(false);
            this.groupBoxBikeSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxBikes;
        private System.Windows.Forms.TextBox textBoxBikeDetail;
        private System.Windows.Forms.CheckBox checkBoxIsNew;
        private System.Windows.Forms.RadioButton radioButtonSize26;
        private System.Windows.Forms.RadioButton radioButton32;
        private System.Windows.Forms.GroupBox groupBoxBikeSize;
    }
}
