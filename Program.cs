namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declares an array of integers named "numbers". Allocates memory on the heap for 5 elements in the array.
            int[] numbers = new int[5];

            //Initializes each element of the array to an integer value.
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //This is a method of indexing the array and then displaying the element at our specified index to the console application.
            Console.WriteLine(numbers[1]);
            
            //The Length method is used to determine how many elements are contained within an object. In this case, we're determining
            how many elements are in the "numbers" array.
            Console.WriteLine(numbers.Length);
            */

            /*This is a more efficient way of declaring and initializing an array. By implicitly initializing the array, we let the 
             compiler decide how many elements are contained in int[] numbers at any given moment. */
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //This declares an array of strings called "names" and initializes it to contain the 3 string elements specified. 
            //string[] names = new string[] { "Dalia", "Wayne", "Lathaniel" };

            //This is an example of how to display elements of an array of strings.
            //Console.WriteLine(names[0] + names[1] + names[2]);

            /*Practical example of how arrays are manipulated using iteration loops. This example uses a simple For iteration loop.
              for (int counter = 0; counter < names.Length; counter++)
              {
                 Console.WriteLine(names[counter]);
              }
            */

            /*This is a simpler method of iteratively manipulating an array using the foreach loop.
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            */

            string phrase = "Good afternoon Mr. Lathaniel.";
            char[] reverseOrder = phrase.ToCharArray();
            Array.Reverse(reverseOrder);

            foreach (char zigChar in reverseOrder)
            {
                Console.Write(zigChar);
            }


            Console.ReadKey();
        }
    }
}