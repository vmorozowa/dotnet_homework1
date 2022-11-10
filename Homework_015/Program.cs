Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] array = new int[n];
Random rnd = new Random();
while (i < n) {
    array[i] = rnd.Next(0, 1000);
    i++;
}
int j = 1;
int s = 0;
while (j < n) {
    s = s + array[j];
    j = j + 2;
}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(s);
