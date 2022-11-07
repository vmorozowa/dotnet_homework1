Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i <= n) {
    double res = Math.Pow(i, 3);
    Console.WriteLine(res);
    i = i + 1;
}
