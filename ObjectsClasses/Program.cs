namespace ObjectsClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pets do you have?")
                // array would go here
                int arrayPetCount = new int(Console.ReadLine));
                
              
                // this is where id seperate the array so the user can imput data for each pet. while creating a loop depending on how many pets the user 
                    // Im stuck on the idea that a user may have 2 dogs...lets next get the first dogs name..then for that dog lets get its age and its breed.
                    // lets then loop that so the user can get the 2nd dogs name. etc 
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
