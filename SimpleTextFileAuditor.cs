using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSPTest
{
    class SimpleTextFileAuditor : EntryAuditor
    {
        private readonly string filename;

        public SimpleTextFileAuditor(string filename)
        {
            this.filename = filename;
        }

        public void WriteEntry(TankstellenEntry entry)
        {
            var s = new StringBuilder();
            s.Append(entry.Date()).Append(";")
                .Append(entry.Name()).Append(";")
                .Append(entry.Price()).AppendLine();
            System.IO.File.AppendAllText(filename, s.ToString());
        }
    }
}
