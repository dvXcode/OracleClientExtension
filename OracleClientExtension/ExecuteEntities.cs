using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleClientExtensions
{
    public static partial class OracleClientExtensions
    {
        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction) where T : new()
        {
            
            using var command = conn.CreateCommand(cmdText, commandType, transaction, parameters);
            using IDataReader reader = command.ExecuteReader();
            return reader.ToEntities<T>();
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, Action<OracleCommand> commandFactory) where T : new()
        {
            
            using var command = conn.CreateCommand(commandFactory);
            using IDataReader reader = ((DbCommand) command).ExecuteReader();
            return reader.ToEntities<T>();
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, CommandType commandType) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ExecuteEntities<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType) where T : new()
        {
            
            return conn.ExecuteEntities<T>(cmdText, parameters, commandType, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType,
            OracleTransaction transaction) where T : new()
        {
            
            using var command = DbConnectionExtensions.CreateCommand(conn, cmdText, commandType, transaction, parameters);
            using IDataReader reader = await command.ExecuteReaderAsync();
            return reader.ToEntities<T>();
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="commandFactory"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, Action<OracleCommand> commandFactory) where T : new()
        {
            
            using var command = conn.CreateCommand(commandFactory);
            using IDataReader reader = await command.ExecuteReaderAsync();
            return reader.ToEntities<T>();
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText) where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, null, CommandType.Text, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, OracleTransaction transaction) where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, null, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, CommandType commandType) where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, null, commandType, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandType"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, CommandType commandType, OracleTransaction transaction)
        where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, null, commandType, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters) where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, parameters, CommandType.Text, null);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="transaction"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, OracleTransaction transaction)
        where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, parameters, CommandType.Text, transaction);
        }

        /// <summary>
        /// Execute a set of entity
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="parameters"></param>
        /// <param name="commandType"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static async Task<IEnumerable<T>> ExecuteEntitiesAsync<T>(this OracleConnection conn, string cmdText, OracleParameter[] parameters, CommandType commandType)
        where T : new()
        {
            
            return await conn.ExecuteEntitiesAsync<T>(cmdText, parameters, commandType, null);
        }
    }
}