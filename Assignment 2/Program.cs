namespace Sortn
{
    internal class Sorting 
    {
        static void Main(string[] args)
        {
            int[] Vin = { 22, 33, 55, 56, 77, 78, 11, 34, 44, 28 };
            int tem;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (Vin[i] < Vin[j])
                    {
                        tem = Vin[i];
                        Vin[i] = Vin[j];
                        Vin[j] = tem;


                    }
                }
               
            

            }
            Console.WriteLine("Array in descending order: ");
            foreach(int i in Vin) 
            { 
                Console.WriteLine(i); 
            }

        }
        
    }
}