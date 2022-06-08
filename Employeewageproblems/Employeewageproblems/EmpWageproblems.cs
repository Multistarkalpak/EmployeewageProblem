using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// UC- 4
// Part_Time_Switch_case

namespace Program
{
    internal class Part_Time_switch_case
    {
        public const int Is_Full_Time = 1;
        public const int Is_part_Time = 2;
        public const int Is_absent = 3;
        int Empdailywage = 0;
        public int empwage = 20;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);


        }
        public void CalculateEmpWage()
        {
            int EmpWorkinghours = 0;

            switch (IsEmployeePresent())
            {
                case Is_absent:
                    EmpWorkinghours = 0;
                    break;

                case Is_part_Time:
                    EmpWorkinghours = 4;
                    break;

                case Is_Full_Time:
                    EmpWorkinghours = 8;
                    break;
            }
            Empdailywage = EmpWorkinghours + empwage;
            Console.WriteLine(" Total Employee Wage = {0}", Empdailywage);
        }
    }
}
