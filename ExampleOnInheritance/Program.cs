namespace ExampleOnInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region With Object initializer
            //Manager manager = new Manager()
            //{
            //    Id = 1000,
            //    Name = "Ahmed",
            //    LoggedHours = 180,
            //    Wage = 10
            //};

            //Maintenance maintenance = new Maintenance()
            //{
            //    Id = 1001,
            //    Name = "Ali",
            //    LoggedHours = 182,
            //    Wage = 8
            //};

            //Sales sales = new Sales()
            //{
            //    Id = 1002,
            //    Name = "Saly",
            //    LoggedHours = 176,
            //    Wage = 9,
            //    Commission = .05m,
            //    SalesVolume = 10000m
            //};

            //Developer developer = new Developer()
            //{
            //    Id = 1003,
            //    Name = "Mustafa",
            //    LoggedHours = 186,
            //    Wage = 15,
            //    TaskCompleted = true
            //};

            //Employee[] employee =  { manager, maintenance, sales, developer };

            //foreach (var emploee in employee)
            //{
            //    Console.WriteLine("\n---------------------------------------");
            //    Console.WriteLine(emploee);
            //} 
            #endregion
            Manager manager = new Manager(1000, "Ahmed", 180,10);
            Maintenance maintenance = new Maintenance (1001, "Ali", 160,8);
            Sales sales = new Sales(1002,"Saly",176,9,.05m,10000m);
            Developer developer = new Developer(1003,"Mustafa",186,15,false);
            Employee[] employees = { manager, maintenance, sales, developer };
            foreach (var employee in employees)
            {
                Console.WriteLine("\n-----------------------------");
                Console.WriteLine(employee);
            }

        }

    }
}