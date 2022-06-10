using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//UC-1
// check Employee is present or absent
//use ((Random)) for attendence check

namespace Program

{
    public class EmpPresentAbsent
    {
        public int EmpPresent = 1;

        public void CheckEmpPresentAbesent()
        {
            Random EmpCheck = new Random();
            int value = EmpCheck.Next(0, 2);
            if (value == EmpPresent)
            {
                Console.WriteLine("Employee is Present");

            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }

    }
}

