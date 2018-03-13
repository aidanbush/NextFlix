using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class PostalCodeException : Exception
    {
        public PostalCodeException() : base()
        {
        }

        public PostalCodeException(String message)
          : base(message)
        {
        }

        public PostalCodeException(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected PostalCodeException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
