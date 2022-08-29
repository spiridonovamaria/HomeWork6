// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.



string stringNumbers = Prompt("Введите числа через пробел ");
int result = CountNumbers(stringNumbers);
System.Console.WriteLine($"{result} раз(а) было введено чисел больше 0 ");

string Prompt(string message)
{  
    System.Console.WriteLine(message);
    return Console.ReadLine();
}

int CountNumbers(string str)
{
    int count = 0;
    string[] numStrs = str.Trim().Split(" ");
    for (int i = 0; i < numStrs.Length; i++)
    {
        bool isNum = int.TryParse(numStrs[i], out int nullNum);
        if (isNum)
        {
            int number = int.Parse(numStrs[i]);
            if (number > 0) count++;
        }
    }
    return count;
} 