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
    public partial class DistanceChartUserControl : UserControl
    {
        private MainWindow mainWindow;

        public DistanceChartUserControl()
        {
            InitializeComponent();
        }

        public DistanceChartUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            this.comboBox1.DataSource = BycicleHandler.GetBycicles();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.MAIN_WINDOW);
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            this.distanceChart.Series["Distancia"].Points.Clear();

            Bycicle bycicle = (Bycicle)this.comboBox1.SelectedValue;

            foreach (DistanceEntry distanceEntry in bycicle.DistanceEntries)
            {
                this.distanceChart.Series["Distancia"].Points.AddXY(distanceEntry.Distance, 40);
            }
        }
    }
}
