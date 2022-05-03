using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class IntegrityEnception : ApplicationException
    {
        public IntegrityEnception(string message) : base(message)
        {

        }
    }
}