namespace Challengelab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 2, 1 };
            int a = 0;
            foreach (int i in nums)
            {
                a ^= i;
            }
            Console.WriteLine(a);
        }
    }
}
