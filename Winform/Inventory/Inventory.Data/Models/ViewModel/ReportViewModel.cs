using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Models.ViewModel
{
    public class ReportViewModel
    {
        public Nullable<long> item_id { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public string features { get; set; }
        public string specifications { get; set; }
        public Nullable<long> category_item_id { get; set; }
        public string category_item_code { get; set; }
        public string category_item_name { get; set; }
        public Nullable<long> warehouse_id { get; set; }
        public string warehouse_code { get; set; }
        public string warehouse_name { get; set; }
        public Nullable<long> unit_id { get; set; }
        public string unit_code { get; set; }
        public string unit_name { get; set; }
        public Nullable<decimal> baseline { get; set; }
        public Nullable<decimal> grow { get; set; }
        public Nullable<decimal> decrease { get; set; }
        public Nullable<decimal> remain { get; set; }
        public Nullable<decimal> stock { get; set; }
        public Nullable<decimal> balance { get; set; }

    }
}
