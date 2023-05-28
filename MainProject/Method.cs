using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject
{
    public class Method
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public string Greeting(string name)
        {
            if(String.IsNullOrEmpty(name))
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {name}!";
            }
        }
    }
}
