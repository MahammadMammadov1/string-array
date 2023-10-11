using System.Text;

namespace String_Array_Char_methods__Access_modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.Name = "Mehemmed";
            worker.SurName = "Memmedov";
            worker.Experience = 1;


            Worker worker1 = new Worker();
            worker1.Name = "Ali";
            worker1.SurName = "Memmezade";
            worker1.Experience = 4 ;

            Worker worker2 = new Worker();
            worker1.Name = "Esed";
            worker1.SurName = "Memmedeliyev";
            worker1.Experience = 2;

            Department department = new Department();
            department.AddWorker(worker1);
            department.AddWorker(worker);
            department.AddWorker(worker2);

            Console.WriteLine(department.SearchWorker("Mehemmed").Name);

            department.ShowAllWorkers();






            //Task 1

             static int CustomLastIndexOf(string input, char searchChar)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (input[i] == searchChar)
                    {
                        return i;
                    }
                }
                return -1;
            }

            Console.WriteLine(CustomLastIndexOf("salam",'a'));


             



                





                






        }
    }
}
