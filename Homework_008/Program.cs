Console.WriteLine("Enter number");
int x = Convert.ToInt32(Console.ReadLine());
string s = x.ToString();
if (s[0] == s[4] && s[1] == s[3]) {
    Console.WriteLine("да");
} else {
    Console.WriteLine("нет");
}
