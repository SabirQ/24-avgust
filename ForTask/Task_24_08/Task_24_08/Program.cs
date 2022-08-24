using System.Text;



#region Task 1
Console.WriteLine("Task 1:");
for (int i = 0; i <= 100; i++)
{
    Console.WriteLine($"positive={i} and negative={i * (-1)}");
}
#endregion

#region Task 2
Console.WriteLine($"\nTask 2:");
Console.WriteLine("Please enter word you want to reverse:");
string str = Console.ReadLine();
//1st Way
//StringBuilder reverse = new StringBuilder();
//for (int i = str.Length - 1; i >= 0; i--)
//{
//    reverse.Append(str[i]);
//}
//Console.WriteLine(reverse.ToString());

//2nd Way
for (int i = str.Length - 1; i >= 0; i--)
{
    Console.Write(str[i]);
}
Console.WriteLine();

//3rd Way
//char[] charArray = Console.ReadLine().Trim().ToCharArray();
//Array.Reverse(charArray);
//Console.WriteLine(charArray);

#endregion

#region Task 3
Console.WriteLine($"\nTask 3:");
for (int i = 10; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"# {i} eşittir 2 * {i / 2}");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"# {i} eşittir 3 * {i / 3}");
    }
    else
    {
        Console.WriteLine($"# {i} asal sayıdır");
    }
}
#endregion

#region Task 4
Console.WriteLine($"\nTask 4:");
int num;
string numStr;
string answer;
bool result;
int[] numbers = new int[0];
do
{
    Console.Write("Please enter number: ");
    numStr = Console.ReadLine();
    result = int.TryParse(numStr, out num);

} while (!result);
Array.Resize(ref numbers, numbers.Length + 1);
numbers[numbers.Length - 1] = num;
do
{
    Console.Write("Would you like to add more numbers?(y/any)");
    answer = Console.ReadLine().Trim().ToLower();
    if (answer == "y")
    {
        do
        {
            Console.Clear();
            Console.Write("Please enter number: ");
            numStr = Console.ReadLine();
            result = int.TryParse(numStr, out num);

        } while (!result);
        Array.Resize(ref numbers, numbers.Length + 1);
        numbers[numbers.Length - 1] = num;
    }
} while (answer == "y");

int[] odds=Array.FindAll(numbers,x=>x%2!=0);
if (odds.Length>1)
{
    Array.Sort(odds);
    Console.WriteLine($"Max from odds={odds[odds.Length - 1]} and Min from odds={odds[0]}");
    Console.WriteLine($"result: {odds[odds.Length - 1]}-{odds[0]}={odds[odds.Length - 1] - odds[0]}");
}
else if (odds.Length==1)
{
    Console.WriteLine("There is only one odd number so result will be: 0  --> because Max and Min values are equal");
}
else
{
    Console.WriteLine("There is no odd number in array");
}

//or another way:

//int max = 0;
//int min = 0;
//int count = 0;
//for (int i = 0; i < numbers.Length; i++)
//{
//    if (numbers[i] % 2 != 0)
//    {
//        count++;
//        if (numbers[i] > max)
//        {
//            max = numbers[i];
//        }
//        if (count == 1)
//        {
//            min = numbers[i];
//        }
//        if (numbers[i] < min)
//        {
//            min = numbers[i];
//        }
//    }
//}
//if (max == 0 && min == 0)
//{
//    Console.WriteLine("There is no odd number in array");
//}
//else
//{
//    Console.WriteLine($"Max from odds={max} and Min from odds={min}");
//    Console.WriteLine($"result: {max}-{min}={max - min}");
//} 
#endregion




