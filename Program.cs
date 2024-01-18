// This section is where I ask for input from the user.
Console.WriteLine("Enter first number: ");
int firstNum = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter operator: ");
string operators = Console.ReadLine()!;
Console.WriteLine("Enter second number: ");
int secondNum = int.Parse(Console.ReadLine()!);

// Here the new switch case syntax is used on the operators variable to perform arithmetical operations.
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

// Here the result is displayed
Console.WriteLine($"{firstNum} { operators} { secondNum} = { result}");
