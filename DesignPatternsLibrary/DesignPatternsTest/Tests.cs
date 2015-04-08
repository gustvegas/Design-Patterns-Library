using AdapteePattern;
using System;

namespace DesignPatternsTest
{
    public class Program
    {
        public void Main(string[] args)
        {
            AdapteeTest();
        }

        public void AdapteeTest()
        {
            var employess = new Employees();
            var adapter = new PhoneListAdapter(employess);
            var intranet = new Intranet(adapter);

            Console.WriteLine("adaptador de telefonos 1 " + intranet.GetIntranetList());
            Console.ReadLine();
        }
    }
}
