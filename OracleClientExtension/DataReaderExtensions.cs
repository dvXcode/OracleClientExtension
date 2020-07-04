using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace OracleClientExtensions
{
    /// <summary>
    /// Extensions for <see cref="IDataReader"/>
    /// </summary>
    public static class DataReaderExtensions
    {
        /// <summary>
        /// Is DbNull
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        // ReSharper disable once InconsistentNaming
        public static bool IsDBNull(this IDataReader reader, string name)
        {
            
            return reader.IsDBNull(reader.GetOrdinal(name));
        }

        /// <summary>
        /// To DataTable
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static DataTable ToDataTable(this IDataReader reader)
        {
            
            var dt = new DataTable();
            dt.Load(reader);
            return dt;
        }

        /// <summary>
        /// To Entity
        /// </summary>
        /// <param name="reader"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ToEntity<T>(this IDataReader reader) where T : new()
        {
            

            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var entity = new T();

            var hash = new HashSet<string>(Enumerable.Range(0, reader.FieldCount).Select(reader.GetName));

            foreach (var property in properties)
            {
                if (hash.Contains(property.Name))
                {
                    var valueType = property.PropertyType;
                    property.SetValue(entity, reader[property.Name].CastTo(valueType), null);
                }
            }

            foreach (var field in fields)
            {
                if (hash.Contains(field.Name))
                {
                    var valueType = field.FieldType;
                    field.SetValue(entity, reader[field.Name].CastTo(valueType));
                }
            }

            return entity;
        }

        /// <summary>
        /// To a set of entity
        /// </summary>
        /// <param name="reader"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IEnumerable<T> ToEntities<T>(this IDataReader reader) where T : new()
        {
            

            var type = typeof(T);
            var properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

            var list = new List<T>();

            var hash = new HashSet<string>(Enumerable.Range(0, reader.FieldCount).Select(reader.GetName));

            while (reader.Read())
            {
                var entity = new T();

                foreach (var property in properties)
                {
                    if (hash.Contains(property.Name))
                    {
                        var valueType = property.PropertyType;
                        property.SetValue(entity, reader[property.Name].CastTo(valueType), null);

                    }
                }

                foreach (var field in fields)
                {
                    if (hash.Contains(field.Name))
                    {
                        var valueType = field.FieldType;
                        field.SetValue(entity, reader[field.Name].CastTo(valueType));
                    }
                }

                list.Add(entity);
            }

            return list;
        }

        public static object CastTo(this object value, Type conversionType)
        {
            if (value == DBNull.Value) return null;
            return Convert.ChangeType(value, conversionType);

        }

        /// <summary>
        /// To expando object
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static dynamic ToExpandoObject(this IDataReader reader)
        {
            
            var columnNames = Enumerable.Range(0, reader.FieldCount)
               .Select(x => new KeyValuePair<int, string>(x, reader.GetName(x)))
               .ToDictionary(pair => pair.Key);

            dynamic entity = new ExpandoObject();
            var expandoDict = (IDictionary<string, object>)entity;

            Enumerable.Range(0, reader.FieldCount)
               .ToList()
               .ForEach(x => expandoDict.Add(columnNames[x].Value, reader[x]));

            return entity;
        }

        /// <summary>
        /// To a set of expando object
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static IEnumerable<dynamic> ToExpandoObjects(this IDataReader reader)
        {
            
            var columnNames = Enumerable.Range(0, reader.FieldCount)
               .Select(x => new KeyValuePair<int, string>(x, reader.GetName(x)))
               .ToDictionary(pair => pair.Key);

            var list = new List<dynamic>();

            while (reader.Read())
            {
                dynamic entity = new ExpandoObject();
                var expandoDict = (IDictionary<string, object>)entity;

                Enumerable.Range(0, reader.FieldCount)
                   .ToList()
                   .ForEach(x => expandoDict.Add(columnNames[x].Value.ToLower(), reader[x]));

                list.Add(entity);
            }

            return list;
        }

        /// <summary>
        /// Gets column name
        /// </summary>
        /// <param name="reader"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetColumnNames(this IDataRecord reader)
        {
            
            return Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToList();
        }

        /// <summary>
        /// Gets value as...
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="index"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetValueAs<T>(this IDataReader reader, int index)
        {
            
            return (T)reader.GetValue(index);
        }

        /// <summary>
        /// Gets value as...
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="columnName"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T GetValueAs<T>(this IDataReader reader, string columnName)
        {
            
            return (T)reader.GetValue(reader.GetOrdinal(columnName));
        }


        /// <summary>
        /// For each
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static IDataReader ForEach(this IDataReader reader, Action<IDataReader> action)
        {
            
            if (action is null)
                return reader;
            while (reader.Read())
                action(reader);
            return reader;
        }

    }
}
