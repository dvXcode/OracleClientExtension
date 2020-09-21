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
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType, OracleTransaction transaction)
        where T : new()
        {
            
            using var command = DbConnectionExtensions.CreateCommand(conn, cmdText, commandType, transaction, parameters);
            using IDataReader reader = command.ExecuteReader();
            reader.Read();
            return reader.ToEntity<T>();
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, Action<OracleCommand> commandFactory) where T : new()
        {
            
            using var command = conn.CreateCommand(commandFactory);
            using IDataReader reader = ((DbCommand) command).ExecuteReader();
            reader.Read();
            return reader.ToEntity<T>();
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, CommandType commandType) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ExecuteEntity<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType) where T : new()
        {
            
            return conn.ExecuteEntity<T>(cmdText, parameters, commandType, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction)
        where T : new()
        {
            
            using var command = DbConnectionExtensions.CreateCommand(conn, cmdText, commandType, transaction, parameters);
            using IDataReader reader = await command.ExecuteReaderAsync();
            reader.Read();
            return reader.ToEntity<T>();
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, Action<OracleCommand> commandFactory) where T : new()
        {
            
            using var command = conn.CreateCommand(commandFactory);
            using IDataReader reader = await command.ExecuteReaderAsync();
            reader.Read();
            return reader.ToEntity<T>();
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, OracleTransaction transaction) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, CommandType commandType) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<T> ExecuteEntityAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType) where T : new()
        {
            
            return await conn.ExecuteEntityAsync<T>(cmdText, parameters, commandType, null);
        }
    }
}