namespace Binary_Search_Actual
{
    internal class Program
    {
        public List<int> randomNumbers = new List<int>();

        public int listlength;

        public string length;

        public bool isNumber = false;

        public bool isNumberAgain = false;

        static void Main(string[] args)
        {
            Program program = new Program();
            program.GetRandomList();
            Console.WriteLine(program.BinarySearch());
        }

        public void GetRandomList()
        {
            Console.WriteLine("How many numbers would you like in the random list?");
            while (isNumber == false)
            {
                try
                {
                                        
                    length = Console.ReadLine();
                    
                    listlength = int.Parse(length);
                    
                    if(listlength.ToString() == length)
                    {
                        isNumber = true;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{length} is not a number!");
                }
            }
            for (int i = 0; i < listlength; i++)
            {
                Random rannum = new Random();
                randomNumbers.Add(rannum.Next(0, 100));
            }

        }

        public string BinarySearch()
        {
            int chosenNumber = 0;
            Console.WriteLine("What number would you like to search for?");
            while (isNumberAgain == false) 
            {
                string chosenNumberInput = Console.ReadLine();

                try
                {
                    chosenNumber = int.Parse(chosenNumberInput);
                    
                    if(chosenNumber.ToString() == chosenNumberInput)
                    {
                        isNumberAgain = true;
                    }
                }
                catch (Exception ex) 
                {
                    Console.WriteLine($"{chosenNumberInput} is not a valid number!");
                }
            }
            randomNumbers.Sort();

            if (randomNumbers.Count % 2 != 0) 
            {
                randomNumbers.Remove(randomNumbers.Count - 1);
                Console.WriteLine("Change to even amount of numbers");
            }
            int min = 0;
            int max = randomNumbers.Count - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (chosenNumber == randomNumbers[mid])
                {
                    for (int i = 0; i < randomNumbers.Count; i++)
                    {
                        Console.Write($"{randomNumbers[i]} ");
                    }
                    return $"\n Your number {chosenNumber} is in the list";
                }
                else if (chosenNumber < randomNumbers[mid])
                {
                    max = mid - 1;
                }
                else 
                { 
                    min = mid + 1;
                }
            }
            for (int i = 0; i < randomNumbers.Count; i++)
            {
                Console.Write($"{randomNumbers[i]} ");
            }
            return "\nYour number is not in the list";


        }
    }
}
