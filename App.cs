using calculator.server_side;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static calculator.ServerSideFunctions;
using System.IO;

namespace calculator
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            hist.Hide();
            number1.Text = String.Empty; number2.Text = String.Empty;
            File.WriteAllText("Text.txt", "new file");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void boxHistory_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          String num1= number1.Text;
          String num2=number2.Text;
          String op = operation.Text;
            String opText = "choose or type an operation";
          ServerSideFunctions ser = new ServerSideFunctions(num1, op, num2,opText);
            String valid=ser.validation();
            if (valid != "valid")
            {
                res.Text = valid;
                res.BackColor = Color.Red;
            }
            else  
            {
                res.BackColor = Color.White;
                res.Text = ser.calcResult();
            }



        /*}

        private void btnHistory_Click(object sender, EventArgs e)
        {*/
            hist.Show();
            History history = new History();
            hist.Text = string.Empty;
            textBox1.Text = string.Empty;
            textBox2.Text= string.Empty;
            string toPrint = "";
            string toPrintPlus = "";
            string toPrintMinus = "";
            string toPrintMul = "";
            string toPrintDiv = "";
            string toPrintContains = "";
            string toPrintIsIn = "";

            List<int> count = new List<int> { 0,0,0,0,0,0};
            List<string> values = new List<string> { "addition","subtraction","multiplication","division",
            "contains","is in"};
            
            foreach (string item in history.getHistory())
            {
                if(item !="")
                toPrint += item + Environment.NewLine;

                if (item.Contains("+"))
                {
                    toPrintPlus += item + "@";
                    count[0]+=1;
                }
                else if (item.Contains("-"))
                {
                    toPrintMinus += item + "@";
                    count[1] +=1;
                }
                else if (item.Contains("*"))
                {
                    toPrintMul += item + "@";
                    count[2] +=1;
                }
                else if (item.Contains("/"))
                {
                    toPrintDiv += item + "@";
                    count[3] += 1;
                }
                else if (item.Contains("contains"))
                {
                    toPrintContains += item + "@";
                    count[4] += 1;
                }
                else if (item.Contains("is in"))
                {
                    toPrintIsIn += item + "@";
                    count[5] += 1;
                }
            }
            hist.Text = toPrint;//all
                        
            textBox1.Visible= true;
            textBox2.Visible= true;
            String[] minList = toPrintMinus.Split('@');
            String[] plusList = toPrintPlus.Split('@');
            String[] mulList = toPrintMul.Split('@');
            String[] divList = toPrintDiv.Split('@');
            String[] containsList = toPrintContains.Split('@');
            String[] isInList = toPrintIsIn.Split('@');

            int len =minList.Length;
            if (operation.Text == "-")
            {
                if (len > 1)
                    textBox1.Text = minList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += minList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += minList[len - 4] + Environment.NewLine;
            }
            len = plusList.Length;

            if (operation.Text == "+")
            {
                if (len > 1)
                    textBox1.Text = plusList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += plusList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += plusList[len - 4] + Environment.NewLine;
            }
            len = mulList.Length;
            if (operation.Text == "*")
            {
                if (len > 1)
                    textBox1.Text = mulList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += mulList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += mulList[len - 4] + Environment.NewLine;
            }
            len = divList.Length;
            if (operation.Text == "/")
            {
                if (len > 1)
                    textBox1.Text = divList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += divList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += divList[len - 4] + Environment.NewLine;
            }
            len = containsList.Length;

            if (operation.Text == "contains")
            {
                if (len > 1)
                    textBox1.Text = containsList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += containsList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += containsList[len - 4] + Environment.NewLine;
            }
            len = isInList.Length;

            if (operation.Text == "is in")
            {
                if (len > 1)
                    textBox1.Text = isInList[len - 2] + Environment.NewLine;
                if (len > 2)
                    textBox1.Text += isInList[len - 3] + Environment.NewLine;
                if (len > 3)
                    textBox1.Text += isInList[len - 4] + Environment.NewLine;
            }
            int max = count.Max();
            int min = count.Min();
            double avg = count.Average();
            int i=count.IndexOf(max);    
            int j=count.IndexOf(min);

                textBox2.Text = "the max usage is " + values[i]+Environment.NewLine;
                textBox2.Text += "the min usage is " + values[j] + Environment.NewLine;
                textBox2.Text += "the average number of operations is  " + Math.Round(avg,2) + Environment.NewLine;
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
