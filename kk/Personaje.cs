namespace BackEndJuego
{
    public class Personaje
    {
        //Base
        public string nombre;
        public int vida = 100;
        public string clase;
        public Arma arma;
        public int dano;
        //Nivel
        public int nivel = 1;
        public float exp = 0;
        public float expRe;
        public int oro = 0;
        //Habilidad/Armadura
        public Habilidades habilidadSelecc;
        public Habilidades[]hab_inventario = new Habilidades[4];
        public List<Object> mochila = new List<object>();
        public Armadura[] armadura = new Armadura[4];

        public int contEnemigos;
        public Enemigo enemigo;

        public Personaje(string nombre, Arma arma, int dano)
        {
            this.nombre = nombre;
            this.arma = arma;
            this.dano = dano;
        }

        public void MostrarInfo()
        {
            Console.WriteLine($"{nombre}\nNivel = {nivel}\nClase = {clase}\nExperiencia = {exp}\nOro = {oro}\n" +
                $"Cantidad de enemigos eliminados = {contEnemigos}");
        }

        public void hacerdano()
        {
            Random random = new Random();

            dano = arma.danoA;


            do
            {
                int criticoPro = random.Next(15);
                int critico = 13;
                int criticoAsestado = dano + 5;

                int golpear = dano;

                if (critico == criticoPro)
                {
                    golpear += criticoAsestado;
                    Console.WriteLine("¡¡¡¡¡¡¡CRITICO!!!!!");
                }

                enemigo.vida -= golpear;
                Console.WriteLine($"Daño infligido: {dano}");

                Console.WriteLine("Presione una tecla para continuar....");
                Console.ReadKey(true);
                Console.Clear();
            } while (enemigo.vida > 0);

            Console.WriteLine($"El enemigo {enemigo.nombre} ha sido eliminado");

            if (enemigo.vida <= 0)
            {
                //Oro
                oro = random.Next(2, 10);
                int probabOro = random.Next(0,4);
                int oroF = 2;
                if (probabOro == oroF)
                {
                    Console.WriteLine($"El enemigo a soltado {oro} monedas de oro");
                }
                else
                {
                    Console.WriteLine("El enemigo no a soltado monedas de oro");
                    oro = 0;
                }

                //Contador de enemigos
                contEnemigos += 1;
            }

        }

        public bool huir()
        {
            bool huir = false;

            Random random = new Random();

            int probabHuir = random.Next(1, 11);

            int huirr = 5;

            if (probabHuir == huirr)
            {
                huir = true;
                Console.WriteLine("Has escapado correctamente");
            }
            else
            {
                Console.WriteLine("No puedes huir!!!!");
            }

            return huir;
        }

    }
}
