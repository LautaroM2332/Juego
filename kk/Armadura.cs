using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    public class Armadura
    {
        public string[] armadura = new string[4];
        
        public Armadura()
        {
            armadura[0] = "Casco";
            armadura[1] = "Pechera";
            armadura[2] = "Pantalones";
            armadura[3] = "Botas";
        }

    }
}
