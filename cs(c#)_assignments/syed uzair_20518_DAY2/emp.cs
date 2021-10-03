using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_concepts
{
    public class EmpSalary
    {
        string name;
        int eid;
        int Bsalary;
        int hr;
        int trvlall;

        public EmpSalary(string name, int eid, int Bsalry, int hr, int trvlall)
        {
            this.name = name;
            this.eid = eid;
            this.Bsalary = Bsalry;
            this.hr = hr;
            this.trvlall = trvlall;
        }
        public string getName()
        {
            return name;
        }
        public int geteid()
        {
            return eid;
        }
        public int getBasic()
        {
            return Bsalary;
        }
        public int getHr()
        {
            return Bsalary;
        }
        public int getTrvl()
        {
            return Bsalary;
        }
        public double tax()
        {
            if (Bsalary * 12 < 50000 && Bsalary * 12 > 0)
                return Bsalary * 0;
            else if (Bsalary * 12 > 50000 && Bsalary * 12 < 70000)
                return Bsalary * .15;
            else
                return Bsalary * .2;
        }
        public int gross()
        {
            return Bsalary + hr + trvlall;
        }
        }
        class emp
    {
        static void Main(string[] args)
        {
            EmpSalary emp1 = new EmpSalary("syed", 30785, 4000, 1230, 1000);

            Console.WriteLine("Hello" + emp1.getName() + ".\n Emp ID:" + emp1.geteid() + ".\n Basic salary:" + emp1.getBasic() + ".\n HR Allowance:" + emp1.getHr() + ".\n Travel Allowance:" + emp1.getTrvl()+".\n Tax:" + emp1.tax() + ".\n Gross" + emp1.gross());
        }
    }
}
