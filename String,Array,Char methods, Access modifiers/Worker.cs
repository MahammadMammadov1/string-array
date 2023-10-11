using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Array_Char_methods__Access_modifiers
{
    public class Worker
    {
        public  string Name { get; set; }
        public string SurName { get; set; }
        private string _workerCode;
        private byte _experience;

        public string WorkerCode
        {
            get
            {
                if (!string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(SurName))
                {
                    return $"{char.ToUpper(Name[0])}{char.ToUpper(SurName[0])}";
                }
                else
                {
                    
                    return string.Empty;
                }
            



            }
        }

        

        public byte Experience
        {
            get 
            {
                return _experience; 
            }

            set 
            { 
                if (value>0)
                { 
                    _experience = value;
                }
            }
        }

    }
}
