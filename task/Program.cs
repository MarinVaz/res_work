string[] array = WriteArray();

string[] WriteArray()
{
   Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}
