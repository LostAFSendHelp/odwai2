﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ODWai2.DAOs
{
    class InputSetRepository
    {
        DataSetRepository repo = new DataSetRepository();
        public InputSetRepository()
        {
            repo.get_all_data_sets();
        }
    }
}
