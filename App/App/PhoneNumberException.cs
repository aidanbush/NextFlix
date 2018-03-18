using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class PhoneNumberException : Exception
    {
        public PhoneNumberException() : base()
        {
        }

        public PhoneNumberException(String message)
          : base(message)
        {
        }

        public PhoneNumberException(String message, Exception innerException)
          : base(message, innerException)
        {
        }

        protected PhoneNumberException(SerializationInfo info, StreamingContext context)
          : base(info, context)
        {
        }
    }
}
