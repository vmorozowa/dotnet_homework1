Console.WriteLine("Enter M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (m <= n) {
    sum = sum + m;
    m++;
}
Console.WriteLine(sum);
