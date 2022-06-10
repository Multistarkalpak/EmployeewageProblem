using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-3
//Part time Employee Wage

namespace Program
{
    internal class PartTime_Employee_Wage
    {
        public int IS_Empolyee_Present = 1;
        public int Full_time = 1;
        public int Wage_Per_hour = 20;
        public int Full_Day_Hour = 16;
        public int Part_Day_Hour = 8;
        public int DailyWage = 0;

        public void CheckDailyEmpWage()
        {
            Random CheckEmp = new Random();
            int value = CheckEmp.Next(0, 2);
            if (value == IS_Empolyee_Present)
            {
                Random Timecheck = new Random();
                int Workinghour = Timecheck.Next(0, 2);
                if (Workinghour == Full_time)
                {
                    DailyWage = Workinghour * Full_Day_Hour;
                    Console.WriteLine("Employee is present, in full time and Dailywage = {0}", DailyWage);
                }

                else
                {
                    DailyWage = Workinghour * Part_Day_Hour;
                    Console.WriteLine("Employee is present, in part time and Dailywage = {0}", DailyWage);

                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }

    }
}


