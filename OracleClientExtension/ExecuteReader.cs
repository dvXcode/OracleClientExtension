using System;
using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleClientExtensions
{
    public static partial class OracleClientExtensions
    {
        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction)
        {
            using var command = conn.CreateCommand(cmdText, commandType, transaction, parameters);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            using var command = conn.CreateCommand(commandFactory);
            return command.ExecuteReader();
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText)
        {
            return conn.ExecuteReader(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            return conn.ExecuteReader(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            return conn.ExecuteReader(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            return conn.ExecuteReader(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            return conn.ExecuteReader(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            return conn.ExecuteReader(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static OracleDataReader ExecuteReader(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            return conn.ExecuteReader(cmdText, parameters, commandType, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction)
        {
            await using var command =  conn.CreateCommand(cmdText, commandType, transaction, parameters);
            return await ExecuteReaderAsync(command);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, Action<OracleCommand> commandFactory)
        {
            await using var command = conn.CreateCommand(commandFactory);
            return await ExecuteReaderAsync(command);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText)
        {
            return await conn.ExecuteReaderAsync(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, OracleTransaction transaction)
        {
            return await conn.ExecuteReaderAsync(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, CommandType commandType)
        {
            return await conn.ExecuteReaderAsync(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        {
            return await conn.ExecuteReaderAsync(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters)
        {
            return await conn.ExecuteReaderAsync(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        {
            return await conn.ExecuteReaderAsync(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute reader
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <returns></returns>
        public static async Task<OracleDataReader> ExecuteReaderAsync(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        {
            return await conn.ExecuteReaderAsync(cmdText, parameters, commandType, null);
        }
    }
}