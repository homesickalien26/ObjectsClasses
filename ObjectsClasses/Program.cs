namespace ObjectsClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pets do you have?")
                

            Pet petInfo = new Pet();
            Console.WriteLine("What is your pets name?");
            petInfo.Name = Console.ReadLine();
            Console.WriteLine("What is your pets breed");
            petInfo.Breed = Console.ReadLine();
            Console.WriteLine("What is your dogs age?");
            petInfo.Age = int.Parse(Console.ReadLine());
           

        }

    }
}
