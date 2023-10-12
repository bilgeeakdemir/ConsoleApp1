namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("name please:\t\t  ");
            name = Console.ReadLine();
            string age;
            Console.Write("age please: \t\t ");
            age = Console.ReadLine();

            string job;
            Console.Write("job please:\t\t  ");
            job = Console.ReadLine();

            string cat;
            Console.Write("cat please:\t\t ");
            cat = Console.ReadLine();

            Console.WriteLine(name  + age + job + cat);



            float e = 25.4f;
            Console.WriteLine(e);

            Console.ReadKey();
        }
    }
}