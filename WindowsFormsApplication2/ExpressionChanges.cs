

namespace WindowsFormsApplication2
{
    public class ExpressionChanges
    {
        //выводит false, если строка не соотвествует нужному формату
        static public bool Check_string(string line)
        {
            if (line == "exp" || line == "Exp")
            {
                return false;
            }
            if (IsEmpty(line) | ChechNotX(line))
                return false;
            else
                return true;
            
        }

        static public bool IsEmpty(string line) // проверка на пустоту строки
        {
            if ((line == ""))
                return true;
            else
                return false;
        }

        static private bool ChechNotX(string line) // проверка на содержание в строке символ "x"
        {
            if (!line.Contains("x"))
                return true;
            else
                return false;
        }
    }
}
