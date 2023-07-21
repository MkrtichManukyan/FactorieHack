using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorieHack
{
    public class GinuKonyakiFactorie
    {
        Gini gini = new Gini();
        Konyak konyak = new Konyak();

        public void Factorie(int qanak)
        {
            Console.WriteLine("duq gnel eq {0} xmichq", qanak);
        }
    }
}
