using System;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleClientExtensions
{
    public static partial class OracleClientExtensions
    {
        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction)
        {
            using var command = DbConnectionExtensions.CreateCommand(conn, cmdText, commandType, transaction, parameters);
            using IDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader.ToExpandoObject();
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            using var command = DbConnectionExtensions.CreateCommand(conn, (Action<DbCommand>)commandFactory);
            using IDataReader reader = ((DbCommand)command).ExecuteReader();
            reader.Read();
            return reader.ToExpandoObject();
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText)
        {
            return conn.ExecuteExpandoObject(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            return conn.ExecuteExpandoObject(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            return conn.ExecuteExpandoObject(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            return conn.ExecuteExpandoObject(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            return conn.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            return conn.ExecuteExpandoObject(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static dynamic ExecuteExpandoObject(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            return conn.ExecuteExpandoObject(cmdText, parameters, commandType, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction)
        {
            using var command = DbConnectionExtensions.CreateCommand(conn, cmdText, commandType, transaction, parameters);
            using IDataReader reader = await command.ExecuteReaderAsync();
            reader.Read();
            return reader.ToExpandoObject();
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <returns></returns>
        public static async Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            using var command = conn.CreateCommand(commandFactory);
            using IDataReader reader = await command.ExecuteReaderAsync();
            reader.Read();
            return reader.ToExpandoObject();
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText)
        {
            return conn.ExecuteExpandoObjectAsync(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute expando object
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static Task<dynamic> ExecuteExpandoObjectAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            
            return conn.ExecuteExpandoObjectAsync(cmdText, parameters, commandType, null);
        }
    }
}
