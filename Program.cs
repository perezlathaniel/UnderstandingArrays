namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declares an array of integers named "numbers". Initializes the array to have 5 elements.
            int[] numbers = new int[5];

            //Assigns each index of the array to an integer value.
            numbers[0] = 4;
            numbers[1] = 8;
            numbers[2] = 15;
            numbers[3] = 16;
            numbers[4] = 23;

            //This is a method of indexing the array and then displaying the element at our specified index to the console application.
            Console.WriteLine(numbers[1]);
            //This is a method used to determine how many elements are contained within an array.
            Console.WriteLine(numbers.Length);
        }
    }
}