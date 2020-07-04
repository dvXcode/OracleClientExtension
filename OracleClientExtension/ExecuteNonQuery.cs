using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleClientExtensions
{
    public static partial class OracleClientExtensions
    {
        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        public static int ExecuteNonQuery(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType, OracleTransaction transaction)
        {
            using var command = conn.CreateCommand(cmdText, commandType, transaction, parameters);
            return command.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            using var command = conn.CreateCommand(commandFactory);
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        public static int ExecuteNonQuery(this OracleConnection conn, string cmdText)
        {
            return conn.ExecuteNonQuery(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            conn.ExecuteNonQuery(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            conn.ExecuteNonQuery(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            conn.ExecuteNonQuery(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        public static int ExecuteNonQuery(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            return conn.ExecuteNonQuery(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            conn.ExecuteNonQuery(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        public static void ExecuteNonQuery(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            conn.ExecuteNonQuery(cmdText, parameters, commandType, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType, OracleTransaction transaction)
        {
            using var command = conn.CreateCommand(cmdText, commandType, transaction, parameters);
            return command.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            using var command = conn.CreateCommand(commandFactory);
            return command.ExecuteNonQueryAsync();
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText)
        {
            return conn.ExecuteNonQueryAsync(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            return conn.ExecuteNonQueryAsync(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            return conn.ExecuteNonQueryAsync(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            return conn.ExecuteNonQueryAsync(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            return conn.ExecuteNonQueryAsync(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            return conn.ExecuteNonQueryAsync(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute NonQuery
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        public static Task ExecuteNonQueryAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            return conn.ExecuteNonQueryAsync(cmdText, parameters, commandType, null);
        }
    }
}