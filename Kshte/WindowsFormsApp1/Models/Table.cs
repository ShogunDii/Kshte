﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class Table
    {
        #region DB Properties
        public int ID { get; set; }
        public Transaction CurrentTransaction { get; set; }
        #endregion
    }
}
