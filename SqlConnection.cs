using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProgram
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            base._timeout = TimeSpan.FromSeconds(120);
        }
        public override void Close()
        {
            Console.WriteLine("Closing SqlConnection ");
        }

        public override void Open()
        {
            base.Open();
            Console.WriteLine("Opening SqlConnection ");
            Console.WriteLine($"Timeout is set to { base._timeout}");

        }



    }
}
