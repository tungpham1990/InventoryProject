using Inventory.Data.Models;
using Inventory.Data.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Utilities.Data;

namespace Inventory.Data.Views
{
    public class ReportView
    {
        public static DataTable reportFinal(Int64 warehouseId, string itemCode, DateTime fromDate, DateTime toDate)
        {
            InventoryEntities invEntities = new InventoryEntities();

            var result = default(IEnumerable<ReportViewModel>);

            var qrf = default(IEnumerable<ReportViewModel>);
            qrf = reportProcess(warehouseId, itemCode, DateTime.MinValue, fromDate != DateTime.MinValue ? fromDate.Date.AddDays(-1) : fromDate);

            var qrc = default(IEnumerable<ReportViewModel>);
            qrc = reportProcess(warehouseId, itemCode, fromDate, toDate);

            var qrl = default(IEnumerable<ReportViewModel>);
            qrl = reportProcess(warehouseId, itemCode, toDate != DateTime.MaxValue ? toDate.Date.AddDays(1) : fromDate, DateTime.MaxValue);

            var union = default(IEnumerable<ReportViewModel>);

            union = qrf.Union(qrc);
            union = union.Union(qrl).Distinct();

            result = from ui in union
                     join qft in qrf on new { ui.item_id, ui.warehouse_id } equals new { qft.item_id, qft.warehouse_id } into qrft
                     from qf in qrft.DefaultIfEmpty()
                     join qct in qrc on new { ui.item_id, ui.warehouse_id } equals new { qct.item_id, qct.warehouse_id } into qrct
                     from qc in qrct.DefaultIfEmpty()
                     join qlt in qrl on new { ui.item_id, ui.warehouse_id } equals new { qlt.item_id, qlt.warehouse_id } into qrlt
                     from ql in qrlt.DefaultIfEmpty()
                     join wh in invEntities.warehouses on ui.warehouse_id equals wh.warehouse_id
                     join it in invEntities.items on ui.item_id equals it.item_id
                     join cte in invEntities.category_item on it.category_item_id equals cte.category_item_id into ctet
                     from ct in ctet.DefaultIfEmpty()
                     join uts in invEntities.units on it.unit_id equals uts.unit_id into utst
                     from ut in utst.DefaultIfEmpty()
                     where ui.warehouse_id != null
                     select new ReportViewModel
                     {
                         warehouse_id = ui.warehouse_id,
                         warehouse_code = wh.warehouse_code,
                         warehouse_name = wh.warehouse_name,
                         item_id = ui.item_id,
                         item_code = it.item_code,
                         item_name = it.item_name,
                         features = it.features,
                         specifications = it.specifications,
                         category_item_id = it.category_item_id,
                         category_item_code = ct.category_item_code,
                         category_item_name = ct.category_item_name,
                         unit_id = it.unit_id,
                         unit_code = ut.unit_code,
                         unit_name = ut.unit_name,
                         baseline = (qf == null || qf.remain == null ? 0 : qf.remain),
                         grow = (qc == null || qc.grow == null ? 0 : qc.grow),
                         decrease = (qc == null || qc.decrease == null ? 0 : qc.decrease),
                         remain = (qc == null || qc.remain == null ? 0 : qc.remain),
                         stock = (ql == null || ql.remain == null ? 0 : ql.remain),
                         balance = (qf == null || qf.remain == null ? 0 : qf.remain) + (qc == null || qc.remain == null ? 0 : qc.remain) + (ql == null || ql.remain == null ? 0 : ql.remain)
                     };

            result = from rst in result
                     group rst by new
                     {
                         rst.warehouse_id,
                         rst.warehouse_code,
                         rst.warehouse_name,
                         rst.item_id,
                         rst.item_code,
                         rst.item_name,
                         rst.features,
                         rst.specifications,                       
                         rst.category_item_id,
                         rst.category_item_code,
                         rst.category_item_name,
                         rst.unit_id,
                         rst.unit_code,
                         rst.unit_name,
                         rst.baseline,
                         rst.grow,
                         rst.decrease,
                         rst.remain,
                         rst.stock,
                         rst.balance
                     } into rs
                     select new ReportViewModel
                     {
                         warehouse_id = rs.Key.warehouse_id,
                         warehouse_code = rs.Key.warehouse_code,
                         warehouse_name = rs.Key.warehouse_name,
                         item_id = rs.Key.item_id,
                         item_code = rs.Key.item_code,
                         item_name = rs.Key.item_name,
                         features = rs.Key.features,
                         specifications = rs.Key.specifications,                          
                         category_item_id = rs.Key.category_item_id,
                         category_item_code = rs.Key.category_item_code,
                         category_item_name = rs.Key.category_item_name,
                         unit_id = rs.Key.unit_id,
                         unit_code = rs.Key.unit_code,
                         unit_name = rs.Key.unit_name,
                         baseline = rs.Key.baseline,
                         grow = rs.Key.grow,
                         decrease = rs.Key.decrease,
                         remain = rs.Key.remain,
                         stock = rs.Key.stock,
                         balance = rs.Key.balance
                     };

            DataTable dt = Utils.ToDataTable(result.Distinct());

            return dt;

        }

        public static IEnumerable<ReportViewModel> reportProcess(Int64 warehouseId, string itemCode, DateTime fromDate, DateTime toDate)
        {
            InventoryEntities invEntities = new InventoryEntities();

            fromDate = new DateTime(fromDate.Year, fromDate.Month, fromDate.Day, 0, 0, 1);
            toDate = new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59);

            ///get data remain quantity 
            var qrr = default(IEnumerable<ReportViewModel>);

            var qrg = default(IEnumerable<ReportViewModel>);
            ///get data grow quantity
            qrg = from m in invEntities.transaction_master
                  join d in invEntities.transaction_detail on m.transaction_master_id equals d.transaction_master_id
                  join i in invEntities.items on d.item_id equals i.item_id
                  where m.transaction_date >= fromDate
                       && m.transaction_date <= toDate
                       && (warehouseId == Int64.MinValue || m.received_warehouse_id == warehouseId)
                       && i.item_code.Contains(itemCode)
                  group d by new { m.received_warehouse_id, d.item_id } into rs
                  select new ReportViewModel
                  {
                      warehouse_id = rs.Key.received_warehouse_id,
                      item_id = rs.Key.item_id,
                      grow = rs.Sum(d => d.quantity)
                  };

            DataTable dtg = Utils.ToDataTable(qrg);
            var qrd = default(IEnumerable<ReportViewModel>);

            ///get data decrease quantity
            qrd = from m in invEntities.transaction_master
                  join d in invEntities.transaction_detail on m.transaction_master_id equals d.transaction_master_id
                  join i in invEntities.items on d.item_id equals i.item_id
                  where m.transaction_date >= fromDate
                        && m.transaction_date <= toDate
                        && (warehouseId == Int64.MinValue || m.delivered_warehouse_id == warehouseId)
                        && i.item_code.Contains(itemCode)
                  group d by new { m.delivered_warehouse_id, d.item_id } into rs
                  select new ReportViewModel
                  {
                      warehouse_id = rs.Key.delivered_warehouse_id,
                      item_id = rs.Key.item_id,
                      decrease = rs.Sum(d => d.quantity)
                  };
            DataTable dtd = Utils.ToDataTable(qrd);

            var union = default(IEnumerable<ReportViewModel>);
            union = qrg.Union(qrd).Distinct();

            ///get data remain quantity 
            ///
            qrr = from ui in union
                  join qgt in qrg on new { ui.item_id, ui.warehouse_id } equals new { qgt.item_id, qgt.warehouse_id } into qgtt
                  from qg in qgtt.DefaultIfEmpty()
                  join qdt in qrd on new { ui.item_id, ui.warehouse_id } equals new { qdt.item_id, qdt.warehouse_id } into qdtt
                  from qd in qdtt.DefaultIfEmpty()
                  where ui.warehouse_id != null
                  select new ReportViewModel
                  {
                      warehouse_id = ui.warehouse_id,
                      item_id = ui.item_id,
                      grow = (qg == null || qg.grow == null ? 0 : qg.grow),
                      decrease = (qd == null || qd.decrease == null ? 0 : qd.decrease),
                      remain = (qg == null || qg.grow == null ? 0 : qg.grow) - (qd == null || qd.decrease == null ? 0 : qd.decrease)
                  };

            DataTable dtr = Utils.ToDataTable(qrr);
            return qrr;
        }
    }
}
