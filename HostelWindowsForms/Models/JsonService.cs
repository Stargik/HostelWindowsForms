﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace HostelWindowsForms.Models
{
    public class JsonService<T>
    {
        private readonly string path;
        public JsonService(string path)
        {
            this.path = path;
        }
        public List<T> GetContent()
        {
            using (FileStream readStream = new FileStream(path, FileMode.OpenOrCreate))
            {
                var records = JsonSerializer.Deserialize<List<T>>(readStream);
                return records;
            }
        }
        public void UpdateContent(List<T> records)
        {
            using (FileStream writeStream = new FileStream(path, FileMode.Create))
            {
                JsonSerializer.Serialize<List<T>>(writeStream, records);
            }
        }
    }
}
