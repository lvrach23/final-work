Console.Write("Введите колчиство элементов в массиве: ");
int amountArray = int.Parse(Console.ReadLine()!);
string [] mainArray = new string[amountArray];
string [] secondArray = new string[mainArray.Length];
for (int i =0; i<mainArray.Length; i++)
{
    Console.Write($"Введите элемент массива № {i+1}: ");
    mainArray[i]=Console.ReadLine()!; 
}
void NewSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
NewSecondArray(mainArray, secondArray);
PrintArray(secondArray);