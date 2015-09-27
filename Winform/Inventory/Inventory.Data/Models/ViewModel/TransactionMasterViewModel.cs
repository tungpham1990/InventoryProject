using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Models.ViewModel
{
    public class TransactionMasterViewModel
    {
        public long transaction_master_id { get; set; }
        public string transaction_code { get; set; }
        public long transaction_type_id { get; set; }
        public string transaction_type_code { get; set; }
        public System.DateTime transaction_date { get; set; }
        public Nullable<long> received_warehouse_id { get; set; }
        public string received_warehouse_code { get; set; }
        public string received_warehouse_name { get; set; }
        public Nullable<long> delivered_warehouse_id { get; set; }
        public string delivered_warehouse_code { get; set; }
        public string delivered_warehouse_name { get; set; }
        public string receiver { get; set; }
        public string deliver { get; set; }
        public Nullable<long> customer_id { get; set; }
        public string customer_code { get; set; }
        public string customer_name { get; set; }
        public Nullable<long> supplier_id { get; set; }
        public string supplier_code { get; set; }
        public string supplier_name { get; set; }
        public Nullable<decimal> total_price { get; set; }
        public Nullable<decimal> percent_charges { get; set; }
        public Nullable<decimal> total_charges { get; set; }
        public Nullable<decimal> total_amount { get; set; }
        public Nullable<bool> enabled { get; set; }
        public string description { get; set; }
        public Nullable<System.DateTime> created_date { get; set; }
        public string create_user { get; set; }
        public Nullable<System.DateTime> update_date { get; set; }
        public string update_user { get; set; }
    }
}
