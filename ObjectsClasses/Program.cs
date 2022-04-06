namespace ObjectsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many pets do you have?");
            int size = int.Parse(Console.ReadLine());

            Pet[] petsArray = new Pet[size];



            for (int i = 0; i < petsArray.Length; i++)
            {
                Console.Write("Enter Pet #" + (i + 1) + "'s Name:");
                string petName = Console.ReadLine();
                Console.WriteLine("What breed type is your pet ?");
                string petBreed = Console.ReadLine();

                Console.WriteLine("What is your Pets age");
                int petAge = int.Parse(Console.ReadLine());

                petsArray[i] = new Pet() { Age = petAge, Breed = petBreed, Name = petName };

            }

            foreach (Pet pet in petsArray)
            {
                Console.WriteLine("Your pets name is " + pet.Name + " Your pets age is " + pet.Age + " Your pets breed is " + pet.Breed);
            }

        }
    }
}
