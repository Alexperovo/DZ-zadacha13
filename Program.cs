// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

  Console.Write ("Введите число: ");
  int num = Convert.ToInt32(Console.ReadLine ());
   if (num <= 99)
 {
    Console.Write ("третьей цифры нет");
  }
  else if (num > 99)
  {
  int num1 = num / 100;
  int num2 = num % 10;
  Console.Write(num2);
 } 
// это решение нашел в интернете, так как не смог математически в числах более 3-значных, выбрать именно 3 цифру(((
//  Console.Write("Введите число: ");
//  int anyNumber = Convert.ToInt32(Console.ReadLine());
//  string anyNumberText = Convert.ToString(anyNumber);
//  if (anyNumberText.Length > 2){
//     Console.WriteLine("Третья цифра   " + anyNumberText[2]);
//  }
//  else {
//     Console.WriteLine("третьей цифры нет");
//  }
