using System;
using System.Data;
using System.Linq;

namespace STLx.Util
{
    public class CompanyCount
    {
        public int CountPerCompany(DataTable dtSummary, string Company)
        {
            var compCount = 0;
            try
            {
                var result = dtSummary.AsEnumerable()
                    .Where(r => r.Field<string>("Company")
                        .Contains(Company));
                compCount = result.Count();
            }
            catch (Exception)
            {
                return 0;
            }
            return compCount;
        }
    }
}