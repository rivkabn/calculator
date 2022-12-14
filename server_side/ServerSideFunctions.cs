using calculator.server_side;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace calculator
{
    internal class ServerSideFunctions
    {
        String num1, op, num2, res, operationText;
        public ServerSideFunctions() { }
        public ServerSideFunctions(string num1, string op, string num2,string operationText)
        {
            this.num1 = num1;
            this.op = op;
            this.num2 = num2;
            this.operationText = "choose or type an operation";

        }//end constructor



        


        string  calcResult(decimal num1,decimal num2,String op)
        {
            
            
            decimal ans=0;
            string status="VALID";
            switch (op)
            {
                case "+":
                    ans = (num1) + (num2);
                    break;
                case "-":
                    ans = (num1) - (num2);
                    break;
                case "/":
                    try
                    {

                        ans =Math.Round( (num1) / (num2),2);
                    }
                    catch (DivideByZeroException err) {
                        status = err.Message;
                    
                    }
                    break;
                case "*":
                    ans = (num1) * (num2);
                    break;
                default:
                    
                    status = "ERROR_NO_VALID_OPERATION";
                    break;
                    
            }
            if (status == "VALID")
                return System.Convert.ToString(ans);
            else
                return status;

        }



        //for 2 strings
        string calcResult(String num1, String num2, String op)
        {
            string ans="" ;
            string status = "VALID";
            switch (op)
            {
                case "+":
                    ans = num1 + num2;
                    break;
                case "is in":
                    ans = System.Convert.ToString(num2.Contains(num1));
                    break;
                case "contains":

                    ans = System.Convert.ToString(num1.Contains(num2));

                    break;

                default:
                 
                        status = "ERROR_NO_VALID_OPERATION";

                 

                    break;
            
            }
            if (status == "VALID")
                return System.Convert.ToString(ans);
            else
                return status;

        }


       

        public String calcResult()
        {
            decimal dec1,dec2;
            string res;
            if (isNumeric(num1) && isNumeric(num2))
            {
                dec1 = System.Convert.ToDecimal(num1);
                dec2 = System.Convert.ToDecimal(num2);
                res= "" +calcResult(dec1, dec2, op);
                // return num1+" "+op+" "+num2+ " " + " = "+res;               
            }
            else
            {
                // else
                res = "" + calcResult(num1, num2, op);
                //return num1 + " " + op + " " + num2 + " " + " = " + res;
            }
            History history = new History(num1,op,num2,res);
            //history.save();
                    
            return num1 + " " + op + " " + num2 + " " + " = " + res;

        }//end calcResult



        int num;
        public bool isNumeric(String st)
        {
            Regex decimalRegex = new Regex("[0 - 9]");
            String regex = "^-?[0-9]([.,][0-9]{1,3})?$";
            Match m = Regex.Match(st, regex);
             if (m.Success)
                return true;
             else
                return false;
        }
        public String validation()
        {
            if (num1 == "" || num2 == "")
            {
                return "please fill all the fields";
            }
            else
            {
                    if (op == operationText)
                    return "please, choose an operation";

            }
            return "valid";//valid

            


                 }


    }
}



 
