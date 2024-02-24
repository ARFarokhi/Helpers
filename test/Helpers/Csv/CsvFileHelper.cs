using System.Reflection;
using System.Text;

namespace Helpers.Csv
{
    public static class CsvFileHelper
    {
        public static byte[] ToCsvByteArray<T>(this List<T> items) where T : class
        {
            const string delimiter = ",";
            var properties = GetTProperties<T>();

            using var stream = new MemoryStream();
            using (var sw = new StreamWriter(stream, Encoding.UTF8))
            {
                //for persian encoding
                stream.Write(new byte[] { 0xEF, 0xBB, 0xBF });

                var header = properties
                    .Select(n => n.Name)
                    .Aggregate((a, b) => a + delimiter + b);
                sw.WriteLine(header);

                foreach (var item in items)
                {
                    var row = properties
                        .Select(n => n.GetValue(item, null))
                        .Select(n => n == null ? "null" : n.ToString())
                        .Aggregate((a, b) => a + delimiter + b);
                    sw.WriteLine(row);
                }
            }

            return stream.ToArray();
        }

        private static List<PropertyInfo> GetTProperties<T>() where T : class =>
            typeof(T)
                .GetProperties()
                .Where(n =>
                    n.PropertyType == typeof(string)
                    || n.PropertyType == typeof(bool)
                    || n.PropertyType == typeof(char)
                    || n.PropertyType == typeof(byte)
                    || n.PropertyType == typeof(decimal)
                    || n.PropertyType == typeof(int)
                    || n.PropertyType == typeof(DateTime)
                    || n.PropertyType == typeof(DateTime?))
                .ToList();
    }
}
