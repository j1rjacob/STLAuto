using System.Text.RegularExpressions;

namespace STL_Auto.Util
{
    public class EmployeeIdNo
    {
        public bool CheckMatch(string val)
        {
            Regex rgx = new Regex(@"^[0-9]{10}$");
            return rgx.IsMatch(val) ? true : false;
        }
    }
}
