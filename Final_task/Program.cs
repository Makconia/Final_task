int size = sizeArray("Задайте количество элементов массива: "); 
int count;
string[] array1 = fullingArray(size, out count);
string[] array2 = new string[count];
array2 = fullingSecondArray(array1, array2);
printArray(array2);




// Задаем количество элементов массива с проверкой на корректность ввода
int sizeArray(string str)
{
    int number;
    string text;

    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }
        Console.WriteLine("Некорректное число");
    }
    return number;
}


// Вводим элементы массива с клавиатуры
string[] fullingArray(int size, out int count)
{
    string[] myArr = new string[size];
    count = 0;
    Console.WriteLine("Поочередно вводите элементы массива: ");

    for (int i = 0; i < size; i++)
    {
        myArr[i] = Console.ReadLine();
        if (myArr[i].Length <= 3)
        {
            count = count + 1;
        }
    }
    return myArr;

}

//Заполняем второй массив элементами первого, длина которых <=3
string[] fullingSecondArray(string[] firstArr, string[] secondArr)
{
    int maxLenString = 3;
    int count = 0;
    for (int i = 0; i < firstArr.Length; i++)
    {
        if (firstArr[i].Length <= maxLenString)
        {
            secondArr[count] = firstArr[i];
            count++;
        }

    }
    return secondArr;
}

// Вывод массива на консоль
void printArray(string[] array)
{
    Console.WriteLine("Итоговый массив: ");
    Console.Write("{" + String.Join(", ", array) + "}");
}
