Console.WriteLine("Enter N");
int n = Convert.ToInt32(Console.ReadLine());
string result = getNumbers(n, "");
Console.WriteLine(result);


string getNumbers(int x, string acc) {
    if (x == 1) {
        return acc + x.ToString();
    }
    acc = acc + x.ToString() + ", ";
    return getNumbers(x - 1, acc);
}
