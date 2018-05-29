using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class NetPay
    {
        public decimal NetPayPerCompany(DataTable dtSummary, string Company)
        {
            var netpay = 0m;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company").Contains(Company))
                    .GroupBy(r => new { Company = DataRowExtensions.Field<string>(r, "Company") })
                    .Select(np => new
                    {
                        NetPay = np.Sum(c => c.Field<decimal>("Bank"))
                    })
                    .FirstOrDefault();
                netpay = result.NetPay;
            }
            catch (Exception)
            {
                return 0m;
            }
            return netpay;
        }
    }
}