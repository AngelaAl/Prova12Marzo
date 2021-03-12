using System;
using System.Data.SqlClient;

namespace ExceptionHandling
{
    public class Esercizio1
    {
        //Eccezione data dalla mancata connessione a un database filtrando il tipo per errore fatale

        //Creo una connection string che so che non funzionerà
        const string connectionString = @"Server = nonEsiste; Persist Security Info= False; User ID = Pippo; Password = 1234; Connection Timeout = 10";


        //Creo un metodo che dovrebbe aprire la connessione
        public static void OpenConnection()
        {
            //Creo la connessione
            SqlConnection connection = new SqlConnection(connectionString);

            //Apro la connessione
            connection.Open();
        }

        //Creo un metodo che gestisce l'eccezione
        public static void GestioneEccezione()
        {
            try
            {
                OpenConnection();
            }
            ////Errore fatale: classe > 19
            //catch (SqlException e) when (e.Class > 19)
            //{
            //    Console.WriteLine("Errore fatale");
            //}
            //Qualsiasi errore dovuto alla query
            catch(SqlException e)
            {
                Console.WriteLine("Errore query");
            }
        }
    }
}
