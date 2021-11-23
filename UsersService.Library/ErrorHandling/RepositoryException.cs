using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.ErrorHandling
{
    public class RepositoryException : Exception
    {
        public RepositoryException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
}
