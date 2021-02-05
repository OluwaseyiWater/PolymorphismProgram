using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProgram
{
    public class Program
    {
        static void Main(string[] args)
        {


            var sqlConnection = new SqlConnection("My.SQL.ConnectionString");
            var sqlCommand = new DbCommand(sqlConnection, "Opening XYZ SqlConnection");
            sqlCommand.Execute();
            var oracleConnection = new OracleConenction("My.Oracle.ConnectionString");
            var oracleCommand = new DbCommand(oracleConnection, "Drop table on Oracle");
            oracleCommand.Execute();





        }

    }
}
