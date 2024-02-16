using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QASauceDemoTest
{
    public class Person
    {
        string Name;
        string Age;
        string Gender;

        public string Move(string distance) 
        {
            return $"{Name} moved {distance}";
        }

    }
}
