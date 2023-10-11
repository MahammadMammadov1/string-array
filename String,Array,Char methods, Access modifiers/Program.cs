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


             static string CustomTrim(string input) //INTERNETDEN KOMEK ALDIM
            {
                int startIndex = 0;
                int endIndex = input.Length - 1;

                while (startIndex <= endIndex && char.IsWhiteSpace(input[startIndex]))
                {
                    startIndex++;
                }

                while (endIndex >= startIndex && char.IsWhiteSpace(input[endIndex]))
                {
                    endIndex--;
                }

                if (startIndex <= endIndex)
                {
                    return input.Substring(startIndex, endIndex - startIndex + 1);
                }
                else
                {
                    return string.Empty;
                }




                static string CustomSubstring(string input, int startIndex, int length) //INTERNETDEN KOMEK ALDIM
                {
                    StringBuilder result = new StringBuilder();
                    for (int i = startIndex; i < startIndex + length && i < input.Length; i++)
                    {
                        result.Append(input[i]);
                    }
                    return result.ToString();
                }






                 static bool CustomContains(string input, string searchSubstring) //INTERNETDEN KOMEK ALDIM
                {
                    for (int i = 0; i <= input.Length - searchSubstring.Length; i++)
                    {
                        bool found = true;
                        for (int j = 0; j < searchSubstring.Length; j++)
                        {
                            if (input[i + j] != searchSubstring[j])
                            {
                                found = false;
                                break;
                            }
                        }
                        if (found)
                        {
                            return true;
                        }
                    }
                    return false;
                }


                static string CustomReplace(string input, string target, string replacement) //INTERNETDEN KOMEK ALDIM
                {
                    StringBuilder result = new StringBuilder();
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i <= input.Length - target.Length && input.Substring(i, target.Length) == target)
                        {
                            result.Append(replacement);
                            i += target.Length - 1;
                        }
                        else
                        {
                            result.Append(input[i]);
                        }
                    }
                    return result.ToString();
                }



            }






        }
    }
}