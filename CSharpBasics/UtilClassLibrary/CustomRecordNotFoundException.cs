using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilClassLibrary
{
    public class CustomRecordNotFoundException : Exception
    {
        public CustomRecordNotFoundException(string message) : base(message)
        {
        }
    }
}
