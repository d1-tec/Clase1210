using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace UI
{
    public partial class AddBikeUserControl : UserControl
    {
        private MainWindow mainWindow;

        public AddBikeUserControl()
        {
            InitializeComponent();
        }

        public AddBikeUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.comboBoxType.DataSource = BycicleHandler.GetBikeTypes();

            this.mainWindow = mainWindow;

            this.radioButtonSize26.Checked = true;

            this.LoadBycicles();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.MAIN_WINDOW);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string bikeName = this.textBoxName.Text;
            BikeType type = (BikeType)this.comboBoxType.SelectedItem;
            bool isBikeNew = this.checkBoxIsNew.Checked;

            Bycicle bike = new Bycicle()
            {
                Name = bikeName,
                BikeType = type,
                IsNew = isBikeNew,
                BikeSize = this.radioButtonSize26.Checked ? BikeSize.SIZE_26 : BikeSize.SIZE_32
            };

            BycicleHandler.AddBycicle(bike);

            this.textBoxName.Text = "";
            this.LoadBycicles();
        }

        private void LoadBycicles()
        {
            this.listBoxBikes.Items.Clear();
            this.listBoxBikes.Items.AddRange(BycicleHandler.GetBycicles().ToArray());
        }

        private void listBoxBikes_SelectedValueChanged(object sender, EventArgs e)
        {
            Bycicle bycicle = (Bycicle) this.listBoxBikes.SelectedItem;

            if (bycicle == null) return;

            string bikeNewOrOld = bycicle.IsNew ? "y es nueva" : "y es usada";

            string bikeSize = bycicle.BikeSize == BikeSize.SIZE_26 ? "Rodado 26" : "Rodado 32";

            this.textBoxBikeDetail.Text = $"Nombre: {bycicle.Name} Tipo: {bycicle.BikeType} {bikeNewOrOld} Rodado: {bikeSize}";
            this.textBoxBikeDetail.ForeColor = bycicle.BikeSize == BikeSize.SIZE_26 ? Color.Red : Color.Green;
        }
    }
}
