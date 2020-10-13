using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.Navigate(MenuOption.MAIN_WINDOW);
        }

        public void Navigate(MenuOption menuOption)
        {
            UserControl userControl = this.GetUserControl(menuOption);

            this.panel.Controls.Clear();
            this.panel.Controls.Add(userControl);
        }

        public void Exit()
        {
            this.Close();
        }

        private UserControl GetUserControl(MenuOption menuOption)
        {
            switch (menuOption)
            {
                case MenuOption.MAIN_WINDOW:
                    return new MenuUserControl(this);
                case MenuOption.ADD_BIKE:
                    return new AddBikeUserControl(this);
                case MenuOption.REGISTER_TIME:
                    return new RegisterTimeUserControl(this);
                case MenuOption.VIEW_BIKES:
                    return new ViewBikesUserControl(this);
                case MenuOption.DISTANCE_CHART:
                    return new DistanceChartUserControl(this);
                default:
                    return null;
            }
        }
    }
}
