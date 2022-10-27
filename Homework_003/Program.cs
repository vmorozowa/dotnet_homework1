Console.WriteLine("Enter number");
int x = Convert.ToInt32(Console.ReadLine());
bool isEven = x % 2 == 0;
if (isEven) {
    Console.WriteLine("Even Number");
} else {
    Console.WriteLine("Odd Number");
}