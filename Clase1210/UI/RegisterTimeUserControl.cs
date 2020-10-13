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
    public partial class RegisterTimeUserControl : UserControl
    {
        private MainWindow mainWindow;

        public RegisterTimeUserControl()
        {
            InitializeComponent();
        }

        public RegisterTimeUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
            this.comboBoxBikes.DataSource = BycicleHandler.GetBycicles();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.MAIN_WINDOW);
        }

        private void buttonAddDistanceEntry_Click(object sender, EventArgs e)
        {
            Bycicle bycicle = (Bycicle)this.comboBoxBikes.SelectedItem;

            if (bycicle == null)
            {
                MessageBox.Show("Elija una", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int distance = (int)this.numericUpDownDistance.Value;
                DateTime dateTime = this.dateTimePicker.Value;

                bycicle.AddDistanceEntry(new DistanceEntry() { DateTime = dateTime, Distance = distance });
            }
        }
    }
}
