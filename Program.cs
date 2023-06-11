using System.Security.Cryptography;

namespace SwichCaseEmployeePartTimeFullTime
{

     class SwitchCaseEmployee
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;

        static void Main(string[] args)
        {
            



        int empHur = 0;
        int empWage = 0;
        Random random = new Random();
        int empCheck = random.Next(0, 2);

             switch (empCheck)
            {
                case IS_PART_TIME:
                    empHur = 4;
                    break;
                case IS_FULL_TIME:
                    empHur = 8;
                    break;
                default:
                    empHur = 0;
                    break;

            }
            empWage = empHur * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage :" + empWage);
        }


        

        
        

             


                 

    }
}