using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingApp.Domain.Exceptions
{
    public class DomainException: Exception
    {
        public DomainException(string message) : base(message)
        {}
        
        public DomainException(string message, Exception innerException) : base(message, innerException) { }

        public class UserAlreadyExistsException : DomainException
        {
            public UserAlreadyExistsException(string email) : base($"A user with the email '{email}' already exists.") { }
        }
    }
}
