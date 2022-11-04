Console.WriteLine("Enter number");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 100) {
    Console.WriteLine("третьей цифры нет");
} else {
    Console.WriteLine(x.ToString()[2]);
}
