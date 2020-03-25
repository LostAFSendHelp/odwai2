using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ODWai2.Controllers;

namespace ODWai2.Presentation
{
    public partial class DataSetView : Form
    {
        private DataSetController data_set_controller;
        private MainController main_controller;

        public DataSetView(MainController main_controller)
        {
            InitializeComponent();
            data_set_controller = new DataSetController(this);
            this.main_controller = main_controller;
        }
    }
}
