namespace SalaryDemoApp1
{
    internal class Program
    {

        //program execution bgins here
       
        static void Main(string[] args)
        {
            //declare variables
            decimal hoursWorked;                         //input
            decimal rate;                                //input
            decimal salary;                              //output

            Console.WriteLine("Enter hours worked");
            hoursWorked = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter rate of pay");
            rate = Convert.ToDecimal(Console.ReadLine());

            if (hoursWorked > 0 && hoursWorked <= 40)//1-40
            {
                salary = hoursWorked * rate;

                Console.WriteLine("Salary is \tR" + salary.ToString("F2"));
            }//end if

            else if(hoursWorked > 40)
            {
                salary = (hoursWorked - 40) * rate * 1.5M + (40 * rate);
                Console.WriteLine("Salary is \tR" + salary.ToString("F2"));
            }

            else
            {
                Console.WriteLine("Invalid entry");
            }

        }//end main
    
    }//end class
}//end namespace