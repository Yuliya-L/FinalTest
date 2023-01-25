// написать программу которая из имеющегося массива строк формирует массив из строк длина которых меньше либо равно 3 символа. 
// первоначальный массив можно ввести с клавиатуры либо задать на старте выполнения алгоритма.

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]

// ["1234", "1567", "-2", "computer science"] -> ["-2"]

// ["Russia", "Denmark", "Kazan"] -> []

void PrintArray(string[] array) // Функция вывода массива в консоль
{

    for (int i = 0; i < array.Length; i++)
    {
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}.");
    }
    Console.WriteLine();
}

int CountStringLessThreeChar(string[] array) // Функция считает строки, длинною 3 символа и меньше.
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] FillResultArray(string[] array, int count)
{
    string[] result = new string[count];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[result.Length - count] = array[i];
            count--;
        }
    }
    return result;
}

string[] arrayFirst =  {"hello", "2", "world", ":-)"};
int countFirst = CountStringLessThreeChar(arrayFirst);
string[] resultFirst =  FillResultArray(arrayFirst,countFirst);
PrintArray(resultFirst);

string[] arraySecond = {"1234", "1567", "-2", "computer science"};
int countSecond  = CountStringLessThreeChar(arraySecond);
string[] resultSecond = FillResultArray(arraySecond,countSecond);
PrintArray(resultSecond);

string[] arrayThird = {"Russia", "Denmark", "Kazan"};
int countThird = CountStringLessThreeChar(arrayThird);
string[] resultThird = FillResultArray(arrayThird, countThird);
PrintArray(resultThird);


