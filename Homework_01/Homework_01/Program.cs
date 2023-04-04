namespace Homework_01
{
    //Q.A
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the is array number Array = ");
            int arraynumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the is firstnumber A = ");
            int firstnumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the is secondnumber D = ");
            int secondnumber = int.Parse(Console.ReadLine());
            int[] array = new int[arraynumber];
            int thirnumber;
            for (int i = 0; i < arraynumber; i++)
            {
                array[i] = firstnumber + secondnumber;
                Console.WriteLine($"arr[{i}] = {firstnumber + secondnumber}");
                firstnumber = array[i];
            }

        }
    }
}