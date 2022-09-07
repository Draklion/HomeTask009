void CWL(string msg)
{
  Console.WriteLine(msg);
}
void CW(string msg)
{
  Console.Write(msg);
}
string CR()
{
  return Console.ReadLine();
}
try
{
  void recursion(int N)
  {
    CW($"{N} ");
    if (N != 1) recursion(N - 1);
  }

  CWL("Задание 4. Программа, которая выведет все натуральные числа в промежутке от N до 1.");
  CWL("Введите число: ");
  int number = Int32.Parse(CR());
  CW($"Натуральные числа в промежутке от {number} до 1: ");
  recursion(number);
}
catch (InvalidCastException e) { }
