Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] array = new int[n];
while (i < n) {
    Console.WriteLine("Enter number");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}
Console.WriteLine("[{0}]", string.Join(", ", array));
