using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class CompanyCount
    {
        public decimal CountPerCompany(DataTable dtSummary, string Company)
        {
            var compCount = 0m;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company")
                        .Contains(Company));
                compCount = Convert.ToDecimal(result.Count());
            }
            catch (Exception)
            {
                return 0m;
            }
            return compCount;
        }
    }
}