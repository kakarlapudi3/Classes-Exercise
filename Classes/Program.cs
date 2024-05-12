namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Car myMake = new Car();
            Car myModel = new Car();
            Car myYear = new Car();

            myMake.Make = "Toyota";
            myModel.Model = "Corolla";
            myYear.Year = 2015;

            Console.WriteLine(myMake);
            Console.WriteLine(myModel);
            Console.WriteLine(myYear);
        
        }
    }
}
