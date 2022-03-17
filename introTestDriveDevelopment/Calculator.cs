using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introTestDriveDevelopment
{
    public class Calculator
    {
        private List<string> listhistory;
        private string date;
        public Calculator(string date)
        {
            listhistory = new List<string>();
            this.date = date;
        }
        public int sum(int valOne, int valTwo)
        {
            int result = valOne + valTwo;
            listhistory.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }
        public int subtract(int valOne, int valTwo)
        {
            int result = valOne - valTwo;
            listhistory.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }
        public int multiply(int valOne, int valTwo)
        {
            int result = valOne * valTwo;
            listhistory.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }
        public int divide(int valOne, int valTwo)
        {
            int result = valOne / valTwo;
            listhistory.Insert(0, "Result: " + result + "Date: " + date);
            return result;
        }

        public List<string> history()
        {
            listhistory.RemoveRange(3,listhistory.Count - 3);
            //return new List<string>();
            return listhistory;
        }
    }
}
