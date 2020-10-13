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
    public partial class ViewBikesUserControl : UserControl
    {
        private MainWindow mainWindow;

        public ViewBikesUserControl()
        {
            InitializeComponent();
        }

        public ViewBikesUserControl(MainWindow mainWindow)
        {
            InitializeComponent();

            this.mainWindow = mainWindow;

            this.dataGridViewBikes.DataSource = BycicleHandler.GetBycicles();
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            this.mainWindow.Navigate(MenuOption.MAIN_WINDOW);
        }
    }
}
