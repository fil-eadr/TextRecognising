﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSetCreater
{  
    public static class DataSetSettings
    {
        /// <summary>
        /// File system path to folder what will parsing 
        /// </summary>
        public static string PathToParseFolder { get; set; }
        /// <summary>
        /// How mach coll`s cells of xls file will be read
        /// </summary>
        public static decimal XlsRowsDepth { get; set; }
        /// <summary>
        /// Max count value of entities what will got 
        /// </summary>
        public static decimal MaxEntityCount { get; set; }
        /// <summary>
        /// Is it true if all fields of DataSetSettings initialized
        /// </summary>
        public static bool IsInitialise { get; set; }
    }
}
