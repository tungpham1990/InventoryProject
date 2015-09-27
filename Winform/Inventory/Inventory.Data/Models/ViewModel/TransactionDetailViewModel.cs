using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Models.ViewModel
{
    public class TransactionDetailViewModel
    {
        public long transaction_detail_id { get; set; }
        public long transaction_master_id { get; set; }
        public long category_item_id { get; set; }
        public string category_item_code { get; set; }
        public string category_item_name { get; set; }
        public string features { get; set; }
        public string specifications { get; set; }
        public long item_id { get; set; }
        public string item_code { get; set; }
        public string item_name { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<long> unit_id { get; set; }
        public string unit_code { get; set; }
        public string unit_name { get; set; }
        public Nullable<decimal> quantity { get; set; }
        public Nullable<decimal> total_price { get; set; }
        public Nullable<decimal> percent_charges { get; set; }
        public Nullable<decimal> total_charges { get; set; }
        public Nullable<decimal> total_amount { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string create_user { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_user { get; set; }
    }
}
