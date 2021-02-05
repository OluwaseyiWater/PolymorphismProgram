using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProgram
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;
        public TimeSpan _timeout { get; set; }

        protected DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("The connection string cannot be null, whitespace or empty");

            this._connectionString = connectionString;
        }

        public virtual void Open()
        {
            var startTime = DateTime.Now;
            var endTime = DateTime.Now;
            CheckTimeout(startTime, endTime);
        }

        public virtual void Close()
        {

        }
        private void CheckTimeout(DateTime startTime, DateTime endTime)
        {
            if (endTime - startTime >= this._timeout)
                throw new TimeoutException("this connection timed out");
        }
    }
}
