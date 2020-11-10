using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_11
{
    public class Class1
    {
        /// <summary>
        /// Проверяет строки массива на условие 
        /// </summary>
        public int JobArrey(int[,] array)
        {
            int n = 1;
            int coll = 0;
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            for (int i = 0; i <rows; i++)
            {
                for (int j = 0; j < columns-1; j++)
                {
                    if(array[i,j]>array[i,j+1])
                    {
                         n = 0;
                        break;
                    }
                   

                }
                    coll += n;
            }

            return coll;
        }



    }
}
