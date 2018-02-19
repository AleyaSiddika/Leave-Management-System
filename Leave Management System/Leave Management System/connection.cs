using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OracleClient;

namespace Leave_Management_System
{
    class connection
    {
        public OracleConnection thisConnection = new OracleConnection("Data Source=DESKTOP-CAPDTNP:1521;User ID=csharpdb;Password=csharpdb;");
    }
}
