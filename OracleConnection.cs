using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProgram
{
    public class OracleConenction : DbConnection
    {
        public OracleConenction(string connectionString) : base(connectionString)
        {
        }

        public override void Close()
        {
            Console.WriteLine("Closing OracleConnection");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("Opening OracleConnection");
            Console.WriteLine($"Oracle has no timeout");
        }


    }
}
