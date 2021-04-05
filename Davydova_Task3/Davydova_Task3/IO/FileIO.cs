using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace Davydova_Task3.IO
{
    public class FileIO
    {
        public string ReadingFile(string fileName)
        {
            string inputString = "";
            try
            {
                StreamReader sr = new StreamReader(fileName);
                inputString = sr.ReadToEnd();
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }

            return inputString;
        }

        public Map GetMap(string fileName)
        {
            Map newMap = null;
            using (StreamReader stream = new StreamReader(fileName))
            {
                string inputString = stream.ReadToEnd();
                newMap = JsonConvert.DeserializeObject<Map>(inputString);
            }
            return newMap;
        }


    }
}
