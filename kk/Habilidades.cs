using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace kk
{
    public class Habilidades
    {
        Random random = new Random();
        public string nombre { get; set; }
        public string tipo { get; set; }
        public int num;
        public int numHabi;
        public bool habilidad_Selecc;
        public Personaje personaje;
        public Habilidad1 habilidad1;
        public Habilidad2 habilidad2; 

        public Habilidades()
        {
            numHabi = random.Next(1,6);
        }

        public void Seleccion()
        {
            switch (numHabi)
            {
                case 1:
                    habilidad_Selecc = habilidad1.aplicar();
                break;
                case 2:
                    habilidad_Selecc = habilidad2.aplicar();
                break;
                case 3:

                break;
                case 4:

                break;
                case 5:

                break;
                case 6:

                break;
            }
        }

    }

    public class Habilidad1 : Habilidades
    {
        public Habilidad1()
        {
            nombre = "More life";
            tipo = "Curativa";
            num = 1;
        }

        public bool aplicar()
        {
            bool toco = false;
            if (numHabi == 1)
            {
                personaje.vida += 30;
                Console.WriteLine("Mi vida a aumentado....");
                toco = true;
            }

            return toco;
        }
    }

    public class  Habilidad2 : Habilidades
    {
        public Habilidad2()
        {
            nombre = "More Damage";
            tipo = "Daño";
            num = 2;
        }

        public bool aplicar()
        {
            bool toco = false;

            if (numHabi == 3)
            {
                personaje.dano += 10;
                Console.WriteLine("Siento que mi fuerza ha aumentado...");
                toco = true;
            }

            return toco; 
        }
    }
}
