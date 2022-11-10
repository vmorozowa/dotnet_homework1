Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 0;
int[] array = new int[n];
Random rnd = new Random();
while (i < n) {
    array[i] = rnd.Next(0, 1000);
    i++;
}
int j = 0;
int max = array[0];
int min = array[0];
while (j < n) {
    if (array[j] > max) {
        max = array[j];
    }
    if (array[j] < min) {
        min = array[j];
    }
    j++;

}
Console.WriteLine("[{0}]", string.Join(", ", array));
Console.WriteLine(max - min);