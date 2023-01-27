Console.Clear();
Console.WriteLine("vvedsite chisla cherez probel ");
int [] numbs = UserArray(Console.ReadLine());
int [] UserArray(string stringArray)
{
    string[] numbers = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int [] result = new int[numbers.Length];
    for (int i = 0; i< result.Length; i++)
    {
        result[i] = int.Parse(numbers[i]);
    }
    return result;
}
int [] CountPositiv(int[] array)
{
int count = 0;

        for(int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    
    }
    return count; //не понимаю что не так с count????
}
Console.WriteLine($"polojitelnih chisel -> {CountPositiv(numbs)}");