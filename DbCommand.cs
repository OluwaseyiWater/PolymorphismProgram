using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProgram
{
    public class DbCommand
    {
        private readonly DbConnection _dbConnection;
        private readonly string _sql;
        public DbCommand(DbConnection dbConnection, string sql)
        {
            _dbConnection = dbConnection ?? throw new InvalidOperationException("DbConnection required.");
            this._sql = sql ?? throw new InvalidOperationException("sql required.");
        }

        public void Execute()
        {
            _dbConnection.Open();
            Console.WriteLine($"Executing: {_sql}");
            _dbConnection.Close();
        }
    }
}
