using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektArbete
{
   public class Runtime
    {
        public void PrintOut()
        // Printing out the numbers from 1 to 1000 via Check method
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(Check(i + 1));
            }
        }

        public string Check(int v)
        // if the number is divided by 3 and 5 output CocaCola, divided by 3 output is Coca, divided by 5 output is Cola, Else Output is number.ToSTring
        {
            if (v % 3 == 0 && v % 5 == 0)
                return "CocaCola";
            if (v % 3 == 0)
                return "Coca";
            else if (v % 5 == 0)
                return "Cola";
            else return v.ToString();
        }

        
    }
}
