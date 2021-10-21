using System;

namespace Proyecto1.Modelos.DAO
{
    internal class SqlCommand
    {
        internal object CommandText;

        public object Connection { get; internal set; }
        public object CommandType { get; internal set; }
        public object Parameters { get; internal set; }

        internal bool ExecuteScalar()
        {
            throw new NotImplementedException();
        }
    }
}