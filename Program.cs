using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Esercizio1.GestioneEccezione();

            //Lancia eccezione
            Esercizio2Dimostrazione.Utente(null);

            //Gestisce eccezione
            Esercizio2Dimostrazione.GestoreEccezione();
        }
    }
}
