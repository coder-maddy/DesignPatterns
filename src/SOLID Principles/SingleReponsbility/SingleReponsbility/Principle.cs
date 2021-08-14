using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsbility
{
    internal class Journal
    {
        int count = 0;
        List<string> entries = new List<string>();

        public void Add(string entry)
        {
            entries.Add($"{++count}. {entry}");
        }

        public void Remove(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    internal class Persistance
    {
        public void Save(Journal journal, string fileName, bool overWrite = false)
        {
            if (overWrite || !File.Exists(fileName))
                File.WriteAllText(fileName, journal.ToString());

        }

    }
}
