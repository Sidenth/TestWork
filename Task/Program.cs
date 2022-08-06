int Prompt (string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine());
}
string [] FillArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i+1}-й элемент");
        array[i]=Console.ReadLine();
    }
    return array;
}
void PrintArray (string [] array)
{
    for (int i = 0; i <array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void CreateNewArray (string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            Console.Write($"{array[i]} ");
        }
    }
    Console.WriteLine();
}
int length = Prompt("Введите длину массива");
string [] array = new string [length];
FillArray(array);
Console.WriteLine("Первоначальный массив");
PrintArray(array);
Console.WriteLine("Новый массив");
CreateNewArray(array);
