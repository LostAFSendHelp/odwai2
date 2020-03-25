using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ODWai2.Presentation;

namespace ODWai2.Controllers
{
    class DataSetController
    {
        private DataSetView data_set_view;

        public DataSetController(DataSetView data_set_view)
        {
            this.data_set_view = data_set_view;
        }
    }
}
