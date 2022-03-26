namespace ObjectsClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pets do you have?")
                // array would go here
                int arrayPetCount = new int(Console.ReadLine));
                
                for (int i = 0 ; i < arrayPetCount ; i++)
                // this is where id seperate the array so the user can imput data for each pet. while creating a loop depending on how many pets the user has
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
