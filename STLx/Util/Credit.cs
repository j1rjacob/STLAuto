using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class Credit
    {
        public Credit()
        {
        }

        public decimal CreditPerCompany(DataTable dtSummary, string Company)
        {
            decimal credit = 0m;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company").Contains(Company))
                    .GroupBy(r => new { Company = DataRowExtensions.Field<string>(r, "Company") })
                    .Select(np => new
                    {
                        Credit = np.Sum(c => c.Field<decimal>("Credit"))
                    })
                    .FirstOrDefault();
                credit = result.Credit;
            }
            catch (Exception)
            {
                return 0m;
            }
            return credit;
        }
    }
}