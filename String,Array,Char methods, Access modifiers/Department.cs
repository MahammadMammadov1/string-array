using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Array_Char_methods__Access_modifiers
{
    public class Department
    {
        public string Name { get; set; }
        Worker[] Workers =Array.Empty<Worker>();

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref Workers,Workers.Length+1);
            Workers[^1] = worker;
        }

        public Worker SearchWorker(string name)
        {
            for (int i = 0; i < Workers.Length; i++)
            {
                if (Workers[i].Name == name)
                {
                    return Workers[i];
                }
            }
            return null;
        }

        public void ShowAllWorkers()
        {
            for(int i = 0;i < Workers.Length;i++)
            {
                Console.WriteLine($"{Workers[i].Name}-{Workers[i].SurName}-{Workers[i].WorkerCode}-{Workers[i].Experience}");
            }
        }
    }
}
