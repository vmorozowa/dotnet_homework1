Console.WriteLine("Enter M");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(m, n);
Console.WriteLine(result);

int Ackermann(int n, int m) {
    if (n == 0) return m + 1;
    if (n != 0 && m == 0) return Ackermann(n - 1, 1);
    if (n > 0 && m > 0) return Ackermann(n - 1, Ackermann(n, m - 1));
    return Ackermann(n, m);
}
