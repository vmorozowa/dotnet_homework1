Console.WriteLine("Enter a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter b");
int b = Convert.ToInt32(Console.ReadLine());
int max;
if (a > b) {
    max = a;
} else {
    max = b;
}
Console.WriteLine($"Max = {max}");

