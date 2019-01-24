using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.ComponentModel;


namespace MyApp.ServiceInterface.utils
{
   public static class DataSetExt
    {

        public static DataTable ToDataTable<T>(this IEnumerable<T> varlist)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (T item in varlist)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            
            return table;

        }


        public static DataTable LinqQueryToDataTable(IEnumerable<dynamic> v)
    {
        //We really want to know if there is any data at all
        var firstRecord = v.FirstOrDefault();
        if (firstRecord == null)
        return null;

        /*Okay, we have some data. Time to work.*/

        //So dear record, what do you have?
        PropertyInfo[] infos = firstRecord.GetType().GetProperties();

        //Our table should have the columns to support the properties
        DataTable table = new DataTable();

        //Add, add, add the columns
        foreach (var info in infos)
        {

        Type propType = info.PropertyType;

        if (propType.IsGenericType
           && propType.GetGenericTypeDefinition() == typeof(Nullable<>)) //Nullable types should be handled too
        {
           table.Columns.Add(info.Name, Nullable.GetUnderlyingType(propType));
        }
        else
        {
           table.Columns.Add(info.Name, info.PropertyType);
        }
        }

        //Hmm... we are done with the columns. Let's begin with rows now.
        DataRow row;

        foreach (var record in v)
        {
        row = table.NewRow();
        for (int i = 0; i < table.Columns.Count; i++)
        {
           row[i] = infos[i].GetValue(record) != null ? infos[i].GetValue(record) : DBNull.Value;
        }

        table.Rows.Add(row);
        }

        //Table is ready to serve.
        table.AcceptChanges();

        return table;
    }

}
}
