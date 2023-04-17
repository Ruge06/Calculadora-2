using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Operations
    {
        public int operation { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }

        double solution;

        public Operations(double num1, double num2, int operation) {
        
            this.operation = operation;  
            this.num1 = num1;
            this.num1 = num2;

            switch(operation) {

                case 1:
                    solution= num1 + num2;
                    break;

                case 2:
                    solution = num1 - num2;
                    break;

                case 3:
                    solution = num1 * num2;
                    break;

                case 4:
                    solution = num1 / num2;
                    break;

                case 5:
                    solution = num1 * num1;
                    break;

                case 6:
                    solution = Math.Sqrt(num1);  
                    break;
            }

            PrintResults result = new PrintResults(solution);   

        } 


    }
}
