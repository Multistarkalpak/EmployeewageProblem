using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//UC-2
//DailyEmployeeWage

namespace program
{
     public class DailyEmployeewage
     {
        int IS_Empolyee_Present = 1;
        int Wage_Per_hour = 20;
        int Full_Day_Hour = 8;
        int DailyWage = 0;

        public void CheckDailyEmpWage()
        {
            Random CheckEmp = new Random();
            int value = CheckEmp.Next(0, 2);
            if (value == IS_Empolyee_Present)
            {
                DailyWage = Full_Day_Hour * Wage_Per_hour;

                Console.WriteLine("Employee Present and Dailywage = {0}", DailyWage);
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
