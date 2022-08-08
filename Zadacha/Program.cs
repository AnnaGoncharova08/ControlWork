//Задача: Написать программу, которая из имеющегося массива строк 
//формирует массив из строк, длина которых меньше либо равна 3 символа. 

void Zadacha()
{
string[] arrayA = new string [5] {"Привет", "Hi", ":)", "555", "Hello!"};
Console.WriteLine("Вывод стартового массива");
PrintArray(arrayA);
string[] arrayB = new string [arrayA.Length];
FindArrayElements(arrayA, arrayB);
Console.WriteLine("Вывод итогового массива");
PrintArray(arrayB);

void PrintArray(string[] arrayA)
{
    for (int i = 0; i < arrayA.Length; i++)
   {
        Console.Write(arrayA[i] + "\t");
   }
Console.WriteLine();
}

void FindArrayElements(string[] arrayA, string[] arrayB)
{
    int count = 0;
    for (int i = 0; i < arrayA.Length; i++)
    {
        if (arrayA[i].Length <= 3)
        {
            arrayB[count] = arrayA[i];
            count++;
        }
    }
}
}
Zadacha();