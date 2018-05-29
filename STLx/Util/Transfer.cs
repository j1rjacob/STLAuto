using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class Transfer
    {
        public Transfer()
        {
        }

        public decimal TransferPerCompany(DataTable dtSummary, string Company)
        {
            var transfer = 0m;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company").Contains(Company))
                    .GroupBy(r => new { Company = DataRowExtensions.Field<string>(r, "Company") })
                    .Select(np => new
                    {
                        Transfer = np.Sum(c => c.Field<decimal>("Transfer"))
                    })
                    .FirstOrDefault();
                transfer = result.Transfer;
            }
            catch (Exception)
            {
                return 0m;
            }

            return transfer;
        }
    }
}