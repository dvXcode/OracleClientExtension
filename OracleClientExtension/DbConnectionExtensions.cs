using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Data.Common;

namespace OracleClientExtensions
{
    public static partial class DbConnectionExtensions
    {
        /// <summary>
        /// Create Command
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static DbCommand CreateCommand(this DbConnection conn, string cmdText, CommandType commandType, DbTransaction transaction,
            params DbParameter[] parameters)
        {

            var command = conn.CreateCommand();
            command.CommandText = cmdText;
            command.CommandType = commandType;
            command.Transaction = transaction;

            if (parameters != null)
                command.Parameters.AddRange(parameters);

            return command;
        }

        /// <summary>
        /// Create Command
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <returns></returns>
        public static DbCommand CreateCommand(this DbConnection conn, Action<DbCommand> commandFactory)
        {
            using var command = conn.CreateCommand();
            commandFactory?.Invoke(command);
            return command;
        }

    }
}
