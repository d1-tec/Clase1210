using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuUserControl : UserControl
    {
        private MainWindow mainWindow;

        public MenuUserControl()
        {
            InitializeComponent();
        }

        public MenuUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.mainWindow.Exit();
        }

        private void buttonAddBike_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.ADD_BIKE);
        }

        private void buttonRegisterTime_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.REGISTER_TIME);
        }

        private void buttonViewBikes_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.VIEW_BIKES);
        }

        private void buttonDistanceChart_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.DISTANCE_CHART);
        }
    }
}
