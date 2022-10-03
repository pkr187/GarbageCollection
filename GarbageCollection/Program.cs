namespace GarbageCollection
{
    public class Program
    {
        static void Main(string[] args)
        {
            long nem1 = GC.GetTotalMemory(false);
            {
                //Allocate an array and make it unreachable
                int[] values = new int[50000];
                values = null;
            }
            long nem2 = GC.GetTotalMemory(false);
            {
                //collect garbage
                GC.Collect();
            }
            long nem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(nem1);
                Console.WriteLine(nem2);
                Console.WriteLine(nem3);
            }
            Console.WriteLine("*******");
            long bytes1 = GC.GetTotalMemory(false);//Get memory in bytes
            byte[] memory = new byte[1000 * 1000 * 10];//Ten million bytes
            long bytes2 = GC.GetTotalMemory(false);//get memory
            long bytes3 = GC.GetTotalMemory(true);//get memory
            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1);//write difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);//write difference
            Console.ReadLine();
        }
    }
}