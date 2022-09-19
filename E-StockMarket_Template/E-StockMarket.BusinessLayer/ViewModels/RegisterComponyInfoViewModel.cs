using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_StockMarket.BusinessLayer.ViewModels
{
    public class RegisterComponyInfoViewModel
    {

        public long ComponyCode { get; set; }

        public string Name { get; set; }

        public string CEO { get; set; }

        public double Turnover { get; set; }

        public string BoardOfDirectors { get; set; }

        public string Profile { get; set; }
        public string StockExchange { get; set; }

        public bool IsDeleted { get; set; }
    }
}
