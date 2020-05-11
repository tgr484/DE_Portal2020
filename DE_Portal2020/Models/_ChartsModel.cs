using Dapper;
using DE_Portal.DAL.RawSqlHelpers;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace DE_Portal2020.Models
{
    public class ChartsViewModel
    {
        public ClosedTickets ClosedTickets { get; set;}
    }

    public class ClosedTickets
    {
        //public int ClientID { get; set; }
        public int TotalTickets { get; set; }
        public int CritProdTicktes { get; set; }
        public int CritNonProdTicktes { get; set; }
        public int NonCritTicktes { get; set; }
        public int GeneralTicktes { get; set; }
        public int Hours { get; set; }

        public ClosedTickets()
        {
            
        }
    }
}
