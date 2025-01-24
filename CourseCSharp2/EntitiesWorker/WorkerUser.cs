using CourseCSharp2.EntitiesWorker.Enums;


namespace CourseCSharp2.EntitiesWorker
{
    internal class WorkerUser
    {
        public void WorkerShow()
        {
            Console.Write("Enter departament's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data");
            Console.WriteLine("");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");

            //Para tranformar o que o usuário digita em um enum
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());

            Departament dept = new Departament(deptName);

            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Enter #{i} contract data");

                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract);
            }


            Console.Write("Enter month an year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();

            //Usando substring para separar o mes e o ano
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Departament: " + worker.Departament.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));




        }
    }
}
