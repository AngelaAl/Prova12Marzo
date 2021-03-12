using System;
using System.Runtime.Serialization;

namespace ExceptionHandling
{
    [Serializable]
    public class ExceptionUtente : Exception
    {
        //Costruttori
        public ExceptionUtente() : base() { }
        public ExceptionUtente(string message) : base(message) { }
        public ExceptionUtente(string message, Exception inner) : base(message, inner) { }

        //Costruttore Serializzazione
        protected ExceptionUtente(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
