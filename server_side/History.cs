using calculator.server_side;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;  // read/write the file
using System.Windows.Forms;

namespace calculator.server_side
{
    public class History
    {
        
        string st1, op, st2, res;
        public History() { }
        public static List<string> historyList = new List<string>(0);
        public History(string st1,string op,string st2, string res) {
            this.st1 = st1;
            this.st2 = st2;
            this.op = op;
            this.res = res;
            historyList.Add(st1 + " " + op + " " + st2 + " = " + res);


        }


        public List<string> getHistory()
        {
            return historyList;            
        }
    }
}
