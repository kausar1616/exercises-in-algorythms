using System;
using MyStack;
using System.Text;

class Program
{
    static void Main()
    {
        MyStack<int> result = new MyStack<int>();

        
        Console.WriteLine("Expression: ");
        string infixNotation = Console.ReadLine();
        string polishNotation = ConvertToPolishNotation(infixNotation);


        string[] argument = polishNotation.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var item in argument)
        {
            switch (item)
            {
                case "+":
                    result.Push(result.Pop() + result.Pop());
                    break;
                case "*":
                    result.Push(result.Pop() * result.Pop());
                    break;
                case "/":
                    int arg1 = result.Pop();
                    int arg2 = result.Pop();
                    result.Push(arg2 / arg1);
                    break;
                case "-":
                    int arg3 = result.Pop();
                    int arg4 = result.Pop();
                    result.Push(arg4 - arg3);
                    break;
                default:
                    result.Push(int.Parse(item));
                    break;
            }
        }
        Console.WriteLine(result.Pop());
    }

     static private string ConvertToPolishNotation(string infixNotation)
    {
        MyStack<char> operators = new MyStack<char>();
        StringBuilder polishNotation = new StringBuilder();
        int index = 0;
        while (index<infixNotation.Length)
        {
            if (Char.IsDigit(infixNotation[index]))
            {
                polishNotation.Append(infixNotation[index]);
            } 
            else if (infixNotation[index] == '(')
            {
            }
            else if (infixNotation[index] == '+' ||
                infixNotation[index] == '-' ||
                infixNotation[index] == '*' ||
                infixNotation[index] == '/')
            {
                polishNotation.Append(' ');
                operators.Push(infixNotation[index]);
            }
            else if (infixNotation[index] == ')')
            {
                polishNotation.Append(' ');
                polishNotation.Append(operators.Pop());
            }
            index++;
        }
        if (!operators.IsEmpty)
        {
            polishNotation.Append(' ');
            polishNotation.Append(operators.Pop());
        }
        return polishNotation.ToString();
    }
}

