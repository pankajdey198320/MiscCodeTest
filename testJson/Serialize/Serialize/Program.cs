using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            var txt = File.ReadAllText(@"C:\Projects\me\testJson\Serialize\Serialize\Data.txt");
            var obj = JsonConvert.DeserializeObject<Rootobject>(txt);

            var d = (from v in obj.albums.data.AsEnumerable()
                     from c in v.photos.data

                     //  from k in c.
                     select new object[]{ 
                        v.created_time,
                         
                        c.likes != null? c.likes.data.Count():0,
                        c.name.ToFormatString()
                    }).ToList();
            var csv = new StringBuilder();
            csv.AppendLine("created date,likes,comments");
            d.ForEach(line =>
            {
                csv.AppendLine(string.Join(",", line));
            });

            File.WriteAllText("c:\\test.csv", csv.ToString());

        }
    }
    public static class StringExtension
    {
        public static string ToFormatString(this string obj)
        {
            if (string.IsNullOrWhiteSpace(obj))
            {
                return "NA";
            }
            else
            {
                var o = obj.Replace("\n", "");
                return o.Replace(",", " ").Trim();
            }
        }
    }
}
