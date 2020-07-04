using System.Data;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OracleClientExtensions
{
    /// <summary>
    /// Extensions for OracleClient
    /// </summary>
    public static partial class OracleClientExtensions
    {
        #region Execute DataSet

        /// <summary>
        /// Execute DataSet
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(this OracleCommand command)
        {
            var ds = new DataSet();
            using var dataAdapter = new OracleDataAdapter(command);
            dataAdapter.Fill(ds);

            return ds;
        }

        /// <summary>
        /// Execute DataSet
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static async Task<DataSet> ExecuteDataSetAsync(this OracleCommand command)
        {
            var ds = new DataSet();
            using var dataAdapter = new OracleDataAdapter(command);
            await Task.Run(() => dataAdapter.Fill(ds));

            return ds;
        }

        #endregion

        #region Execute DataTable

        /// <summary>
        /// Execute DataTable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTable(this OracleCommand command)
        {
            var dt = new DataTable();
            using var dataAdapter = new OracleDataAdapter(command);
            dataAdapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Execute DataTable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static async Task<DataTable> ExecuteDataTableAsync(this OracleCommand command)
        {
            var dt = new DataTable();
            using var dataAdapter = new OracleDataAdapter(command);
            await Task.Run(() => dataAdapter.Fill(dt));

            return dt;
        }

        #endregion

        #region Internal Execute DataTable

        /// <summary>
        /// Execute DataTable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static DataTable ExecuteFirstDataTable(this OracleCommand command)
        {
            var ds = new DataSet();
            using var dataAdapter = new OracleDataAdapter(command);
            dataAdapter.Fill(ds);

            return ds.Tables[0];
        }

        /// <summary>
        /// Execute DataTable async
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        internal static async Task<DataTable> ExecuteFirstDataTableAsync(this OracleCommand command)
        {
            var ds = new DataSet();
            using var dataAdapter = new OracleDataAdapter(command);
            await Task.Run(() => dataAdapter.Fill(ds));

            return ds.Tables[0];
        }

        #endregion

        #region Execute DataReader

        /// <summary>
        /// Execute DataTable
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static Task<OracleDataReader> ExecuteReaderAsync(this OracleCommand command)
        {
            return Task.Run(command.ExecuteReader);
        }

        #endregion
    }
}
