

Console.Clear();
Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()!);

string PrintNumbers(int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.WriteLine(PrintNumbers(numberM, numberN));