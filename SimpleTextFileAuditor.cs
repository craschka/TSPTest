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
            System.IO.File.AppendAllText(filename, System.Environment.NewLine+entry.ToString());
        }
    }
}
