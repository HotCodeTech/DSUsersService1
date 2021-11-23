using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersService.Library.ErrorHandling
{
    public class ControllerException : Exception
    {
        public ControllerException(string message, Exception ex)
            : base(message, ex)
        {

        }
    }
}
