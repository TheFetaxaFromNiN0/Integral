using System;
using WindowsFormsApplication2;

namespace Zirpl.CalcEngine
{
    class F_function
    {
        private string expression;      //строка с примером
        private string botLim;          //строка с нижней границей интеграла
        private string upperLim;       //строка с верхней границей интеграла


        //конструктор, который убирает пробелы в строках для дальнейших операция над ними
         public F_function(string expression,string botLim, string upperLim)       
        {
            this.expression = expression.Replace(" ", "").ToLower();
            this.botLim = botLim.Replace(" ", "").ToLower();
            this.upperLim = upperLim.Replace(" ", "").ToLower();
        }

        public string ExampleCalculation()
        {
            double h = 0.002, sum = 0, I;
            
            CalculationEngine calculation = new CalculationEngine();

            if (!ExpressionChanges.Check_string(expression))
                return "error";
            if (ExpressionChanges.IsEmpty(botLim) || ExpressionChanges.IsEmpty(upperLim))
                return "error_Lim";

            if (Double.Parse(botLim) > Double.Parse(upperLim))
                return "error_Lim";

            try
            {
                for (double Xi = Convert.ToDouble(botLim) + h; Xi < Convert.ToDouble(upperLim); Xi = Xi + h)
                {
                    I = 0;

                    calculation.Variables["x"] = Xi;
                    I += (double)calculation.Evaluate(expression);
                    calculation.Variables["x"] = Xi - h;
                    I += (double)calculation.Evaluate(expression);
                    calculation.Variables["x"] = Xi - h / 2;
                    I += 4 * (double)calculation.Evaluate(expression);
                    sum += I;
                }
            }
            catch(Exception e)
            {
                return "error";
            }
            
            double res = h / 6 * sum;

            if (Double.IsNaN(res))
            {
                return "error_ODZ";
            }

            return res.ToString();
        }
    }
}
