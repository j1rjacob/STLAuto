using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class Cash
    {
        public Cash()
        {
        }

        public decimal CashPerCompany(DataTable dtSummary, string Company)
        {
            var cash = 0m;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company").Contains(Company))
                    .GroupBy(r => new { Company = DataRowExtensions.Field<string>(r, "Company") })
                    .Select(np => new
                    {
                        Cash = np.Sum(c => c.Field<decimal>("Cash"))
                    })
                    .FirstOrDefault();
                cash = result.Cash;
            }
            catch (Exception)
            {
                return 0m;
            }

            return cash;
        }
    }
}