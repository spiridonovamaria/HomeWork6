//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

double[] arrayNumbers = Prompt("Введите через пробел значения переменных b1, k1, b2, k2");
double[] result = FindCommonPoint(arrayNumbers);
ConsolePrint();


double[] Prompt(string message)
{   
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    string[] numStrs = value.Trim().Split(" ");
    double[] array = new double[4];
    for (int i = 0; i < array.Length; i++)
    {
        bool isNum = double.TryParse(numStrs[i], out double nullNum);
        if (isNum)
        {
            array[i] = double.Parse(numStrs[i]);
        }
        else
        {
            throw new Exception("Не все введенные элементы являются числами");
        }
    }
    return array;
}

double[] FindCommonPoint(double[] array)
{ 
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    double y1 = array[1] * x + array[0];
    double y2 = array[3] * x + array[2];
    double[] result = new double[2];
    if (y1 == y2)
    {
        result[0] = x;
        result[1] = y1;
    }
    return result;
}

void ConsolePrint()
{
    System.Console.WriteLine($@"Точка пересечения двух прямых, заданных уравнениями:
                            y = {arrayNumbers[1]}x + {arrayNumbers[0]};
                            y = {arrayNumbers[3]}x + {arrayNumbers[2]};
({result[0]}; {result[1]})");
}