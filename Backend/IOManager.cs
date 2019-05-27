using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Backend
{
    public class IOManager
    {
        private readonly string Location;

        public IOManager(string location)
        {
            Location = location;
        }

        public List<Entry> Unpack(string name)
        {
            string Path = GetPath(name);
            try
            {
                if (!File.Exists(Path))
                {
                    throw new FileNotFoundException();
                }
                File.Decrypt(Path);
                string Data = File.ReadAllText(Path);
                File.Encrypt(Path);
                if (Data == "")
                {
                    throw new FileNotFoundException("No data found!");
                }
                return JsonConvert.DeserializeObject<List<Entry>>(Data);
            }
            catch (FileNotFoundException)
            {
                File.WriteAllText(Path, JsonConvert.SerializeObject(new List<Entry>()));
                File.Encrypt(Path);
                return new List<Entry>();
            }
            catch (ArgumentException)
            {
                return new List<Entry>();
            }
        }

        public void Pack(string name, List<Entry> entries)
        {
            string Path = GetPath(name);
            string Data = JsonConvert.SerializeObject(entries);
            File.Decrypt(Path);
            File.WriteAllText(Path, Data);
            File.Encrypt(Path);
        }

        private string GetPath(string name)
        {
            return Path.Combine(Location, string.Concat(name.Split(' ')) + ".json");
        }
    }
}