using System;

namespace ejercicio94
{
    class Neumtico

    {
        public enum Neumaticos { Para_Coche, Para_Furgoneta, Para_4X4 };
        public void tneum()
        {
            Console.Clear();
            Console.WriteLine("Tipos de Neumaticos: \n\n");
            Console.WriteLine(Neumaticos.Para_4X4.ToString());
            Console.WriteLine(Neumaticos.Para_Coche.ToString());
            Console.WriteLine(Neumaticos.Para_Furgoneta.ToString());

            Console.ReadKey();
        }
    }
}
