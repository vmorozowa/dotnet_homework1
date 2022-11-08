Console.WriteLine("Enter A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter B");
int b = Convert.ToInt32(Console.ReadLine());
int i = 1;
int res = a;
while (i < b) {
    res = res * a;
    i++;
}
Console.WriteLine(res);