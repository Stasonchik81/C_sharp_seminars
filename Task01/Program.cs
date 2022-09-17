// Is square of number?
int [][] numbers = {new int []{25, 5}, new int []{2, 10}, new int []{9, -3}, new int []{-3, 9}};
for (int i = 0; i < numbers.Length; i++)
{
    if(numbers[i][0] == numbers[i][1]*numbers[i][1])
    {
        Console.Write("Yes");
    }
    else
    {
        Console.Write("No");
    }
    Console.WriteLine("");
    
}
