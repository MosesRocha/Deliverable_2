namespace Deliverable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ensure user prompt is between 5 and 15
                int userInput = ReadIntegerInput(5, 15);

            // Generate random array
                int[] array = Random_Array(userInput);


            // Write array elements
                Console.WriteLine("The elements of the array are: ");
                PrintArrayElements(array);

            // Calculates sum of array
                int sum = CalculateArraySum(array);
                Console.WriteLine("The sum is: " + sum);
        }

            static int ReadIntegerInput(int minValue, int maxValue)
            {
                int value;
                while (true)
                {
                    try
                    {
                    // Question displayed for user input and validates
                        Console.Write("Enter an integer between 5 and 15: ");
                        value = Convert.ToInt32(Console.ReadLine());
                        if (value >= minValue && value <= maxValue)
                        {
                            return value;
                        }
                        else
                        {
                            Console.WriteLine("Please enter an integer value between 5 and 15.");
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter an integer value.");
                    }
                }
            }

            static int[] Random_Array(int length)
            {
                Random random = new Random();
                int[] array = new int[length];

                for (int i = 0; i < length; i++)
                {
                // generate random number between 10 and 50
                    array[i] = random.Next(10, 50);
                }

                return array;
            }

            static void PrintArrayElements(int[] array)
            {
            // Writes each element in array 
                foreach (int element in array)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }

            static int CalculateArraySum(int[] array)
            {
                int sum = 0;
                foreach (int element in array)
                {
                // Sum all elements in array
                    sum += element;
                }
                return sum;
            }
        }
    }