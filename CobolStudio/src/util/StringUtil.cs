using System.Collections.Generic;
using System.IO;

namespace CobolStudio.src.util
{
    internal class StringUtil
    {
        public static string AsString(object value)
        {
            if (value == null)
                return "null";
            else if (value is int || value is float || value is double || value is decimal || value is bool || value is string)
                return value.ToString();
            else if (value is List<object>)
                return ListAsString((List<object>)value);
            else if (value is Dictionary<string, object>)
                return DictionaryAsString((Dictionary<string, object>)value);
            else
                return value.GetType().Name;
        }

        static string ListAsString(List<object> list)
        {
            StringWriter writer = new StringWriter();
            writer.Write("[");
            for (int i = 0; i < list.Count; i++)
            {
                if (i > 0)
                    writer.Write(", ");
                writer.Write(AsString(list[i]));
            }
            writer.Write("]");
            return writer.ToString();
        }

        static string DictionaryAsString(Dictionary<string, object> dict)
        {
            StringWriter writer = new StringWriter();
            writer.Write("{");
            var keys = dict.Keys;
            foreach (var key in keys)
            {
                writer.Write($"'{key}':");
                writer.Write(AsString(dict[key]));
            }
            writer.Write("}");
            return writer.ToString();
        }
    }
}
