Console.WriteLine("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter operator: ");
string operators = Console.ReadLine()!;
Console.WriteLine("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine()!);

var result = operators.ToLower() switch
{
    "+" => firstNum + secondNum,
    "plus" => firstNum + secondNum,
    "-" => firstNum - secondNum,
    "minus" => firstNum - secondNum,
    "*" => firstNum * secondNum,
    "times" => firstNum * secondNum,
    "%" => firstNum % secondNum,
};

Console.WriteLine($"{firstNum} { operators} { secondNum} = { result}");