using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class NumberManipulator
    {
        public static int MakeNumberBigger(int number)
        {
            if (number < 9)
                throw new ArgumentOutOfRangeException();

            char[] nextNumber = FindNextNumber(number.ToString().ToCharArray());
            int biggerNumber = Convert.ToInt32(new string(nextNumber));
            if (number < biggerNumber)
                return biggerNumber;
            else
                return -1;
        }

        #region Private methods
        private static char[] FindNextNumber(char[] nextNumber)
        {
            bool notBreakFlag = true;
            for (int i = nextNumber.Length - 2; i > -1 && notBreakFlag; i--)
            {
                for (int j = nextNumber.Length - 1; j > i; j--)
                {
                    if (nextNumber[j] > nextNumber[i])
                    {
                        char temp = nextNumber[j];
                        nextNumber[j] = nextNumber[i];
                        nextNumber[i] = temp;
                        Array.Sort(nextNumber, i + 1, nextNumber.Length - i - 1);
                        return nextNumber;
                    }
                }
            }
            return nextNumber;
        }
        #endregion
    }
}
