using System;



    public struct Mascota
    {
        public string NombreMascota;
        public int EdadMascota;
        public string TipoMascota;

        public Mascota(string nNombreMascota, int nEdadMascota, string nTipoMascota)
        {
            NombreMascota = nNombreMascota;
            EdadMascota = nEdadMascota;
            TipoMascota = nTipoMascota;
        }
    }

    public struct Dueño
    {
        public string NombreDueño;
        public int EdadDueño;
        public Mascota Perro;

        public Dueño(string nNombreDueño, int nEdadDueño, string NM, int EM, string TM)
        {
            NombreDueño = nNombreDueño;
            EdadDueño = nEdadDueño;

            Perro = new Mascota(NM, EM, TM);
        }
    }

namespace ejercicio93
{
    class Pet
    {
        public void masc()
        {
            Dueño Du;

            Console.Clear();
            Du.NombreDueño = "Elias";
            Du.EdadDueño = 25;
            Du.Perro.NombreMascota = "pirulai";
            Du.Perro.TipoMascota = "perro";
            Du.Perro.EdadMascota = 5;
            Console.WriteLine("Nombre del Dueño: " + Du.NombreDueño + "\nEdad del Dueño: " + Du.EdadDueño + "\nNombre de la Mascota: " + Du.Perro.NombreMascota + "\nTipo de Mascota: " + Du.Perro.TipoMascota + "\nEdad de La Mascota: " + Du.Perro.TipoMascota);

            Console.ReadKey();
        }
    }
}

