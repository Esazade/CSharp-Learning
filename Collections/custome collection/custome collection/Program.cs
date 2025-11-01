using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace custome_collection
{
    class Program
    {
        static void Main(string[] args)
        {
            BankQueue<string> bankQueue = new BankQueue<string>(3);

            try
            {
                bankQueue.Add("Ali");
                bankQueue.Add("Sara");
                bankQueue.Add("Reza");
            
                bankQueue.DisplayQueue();
            
                // bankQueue.Add("Nazanin");  Error:because Queue is Full
            
                bankQueue.ServeNext(); // Ali
                bankQueue.DisplayQueue();
            
                bankQueue.Add("Nazanin"); // ✅ 
                bankQueue.DisplayQueue();
            }
            catch (Exception ex)
            {
                Console.WriteLine("❌ Error: " + ex.Message);
            }

            Console.ReadLine();
        }
    }
}
