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
  void recursion(int A, int B, int exponentiation = 1, int i = 0)
  {
    if (i == B) CW($"{exponentiation}");
    if (i != B)
    {
      exponentiation = exponentiation * A;
      recursion(A, B, exponentiation, i + 1);
    }
  }

  CWL("Задание 3. Программа, которая на вход принимает два числа A и B, и возводит число А в целую степень B.");
  CWL("Введите число: ");
  int numberA = Int32.Parse(CR());
  int numberB = Int32.Parse(CR());
  CW($"Число {numberA} в степени {numberB} равна: ");
  recursion(numberA, numberB);
}
catch (InvalidCastException e) { }
