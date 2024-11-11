using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class CalPointsCode : ICalPoints
    {
        //682. Baseball Game(棒球比賽)
        public int CalPoints(string[] operations)
        {
            List<string> operationsList = operations.ToList();
            for (int i = 0; i < operationsList.Count; i++)
            {
                if (operationsList[i] == "C")
                {
                    operationsList.RemoveAt(i);
                    operationsList.RemoveAt(i - 1);
                    i = i - 2;
                }
                else if (operationsList[i] == "D")
                {
                    operationsList[i] = (Convert.ToInt32(operationsList[i - 1]) * 2).ToString();
                }
                else if (operationsList[i] == "+")
                {
                    operationsList[i] = (Convert.ToInt32(operationsList[i - 1]) + Convert.ToInt32(operationsList[i - 2])).ToString();
                }
            }
            int sum = 0;
            foreach (string item in operationsList)
            {
                sum += Convert.ToInt32(item);
            }
            return sum;
        }
    }
}
