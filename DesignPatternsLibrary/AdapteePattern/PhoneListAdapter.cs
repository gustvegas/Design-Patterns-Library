using System;
using System.Text;

namespace AdapteePattern
{
    public class PhoneListAdapter : IIntranetPhoneList
    {
        private Employees _employees;

        public PhoneListAdapter(Employees employees)
        {
            _employees = employees;
        }

        public string GetPhoneList()
        {
            string[][] employees = _employees.GetEmployees();

            StringBuilder stb = new StringBuilder();

            foreach (var employ in employees)
            {
                stb.Append(employ[0]);
                stb.Append(employ[1]);
                stb.Append(employ[2]);
            }

            return stb.ToString();
        }
    }
}