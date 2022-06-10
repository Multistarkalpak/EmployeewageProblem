using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class employeewage
    {
        public const float Empwageperhour = 20;
        public const int Fulltime_Workinghrs_perday = 8;
        public const int parttime_Working_perday = 4;
        public const int max_working_hrs = 100;
        public const int max_working_days = 20;
        public const int Fulltime = 1;
        public const int partime = 2;
        public const int absent = 0;
        float Empdailywage = 0;
        public float Totalwage = 0;
        public const int Is_absent = 0;
        public const int Is_parttime = 1;
        public const int Is_fulltime = 2;


        public int IsEmployeePresent()
        {
            return new Random().Next() % 3;

        }
         
        public void Calculatewage()
        {
            int DayNumber = 1;
            int Empworkinghrs = 0;
            int TotalWorkinghours = 0;
            while (DayNumber <= max_working_days && TotalWorkinghours <= max_working_hrs)
            {
                switch (IsEmployeePresent())
                {
                    case Is_absent:
                        Empworkinghrs = 0;
                        break;

                    case Is_parttime:
                        Empworkinghrs = parttime_Working_perday;
                        break;

                    case Is_fulltime:
                        Empworkinghrs = Fulltime_Workinghrs_perday;
                        break;
                }
                Empdailywage = Empworkinghrs * Empwageperhour;
                Totalwage += Empdailywage;
                DayNumber++;
                TotalWorkinghours += Empworkinghrs;
            }
            Console.WriteLine("Total Working days:" + DayNumber + "\nTotal working hrs : " + TotalWorkinghours + "\nTotalwage");
        }


    }
}
