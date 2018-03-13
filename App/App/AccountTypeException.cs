using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class AccountTypeException : Exception
    {
        public AccountTypeException() : base()
        {
        }

        public AccountTypeException(String message)
          : base(message)
        {
        }

        public AccountTypeException(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected AccountTypeException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
