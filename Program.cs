namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Declares an array of integers named "numbers". Allocates memory on the heap for 5 elements in the array.
            int[] numbers = new int[5];

            //Initializes each index of the array to an integer value.
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //This is a method of indexing the array and then displaying the element at our specified index to the console application.
            Console.WriteLine(numbers[1]);
            //This is a method used to determine how many elements are contained within an array.
            Console.WriteLine(numbers.Length);
            */

            /*This is a more efficient way of declaring and initializing an array. By implicitly initializing the array, we let the 
             compiler decide how many elements are contained in int[] numbers at any given moment. */
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };



            Console.ReadKey();
        }
    }
}