using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleReponsbility.Violation
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

        // class is loadin stuffs, this is the violation
        // persistent part shall be done in separate class.
        public void Load(string fileName)
        {
            entries = File.ReadAllLines(fileName).ToList();
        }

        public void Save(string fileName, bool overWrite = false)
        {
            if (overWrite)
                File.WriteAllLines(fileName, entries);
            else
                File.AppendAllLines(fileName, entries);

        }

    }
}
