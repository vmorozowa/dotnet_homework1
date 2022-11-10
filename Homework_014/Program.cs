Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] array = new int[n];
Random rnd = new Random();
while (i < n) {
    array[i] = rnd.Next(100, 999);
    i++;
}
int j = 0;
int count = 0;
while (j < n) {
    if (array[j] % 2 == 0) {
        count++;
    }
    j++;
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(count);
