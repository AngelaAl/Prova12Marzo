using System;
namespace ExceptionHandling
{
    public class Esercizio2Dimostrazione
    {
        //Lancia eccezione
        public static void Utente(string utente)
        {
            _ = utente ?? throw new ExceptionUtente("Utente non trovato");
        }

        //Gestisce eccezione
        public static void GestoreEccezione()
        {
            try
            {
                Utente(null);
            }
            catch (ExceptionUtente e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
