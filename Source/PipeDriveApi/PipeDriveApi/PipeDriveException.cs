using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipeDriveApi
{
    public class PipeDriveException : Exception
    {
        public PipeDriveException(string errorMessage) : base(errorMessage)
        {
        }
    }
}
