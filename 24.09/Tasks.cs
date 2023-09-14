using System.Text;

namespace _24._09;

public class Tasks
{
    public static void Task1(int length, char simbol)
    {
        if (length <= 0)
        {
            Console.WriteLine("Length cannot be 0 or negative");
            return;
        }
        StringBuilder sb = new StringBuilder();

        sb.AppendLine(new string(simbol, length));

        for(int i=0; i<length-2; i++)
            sb.AppendLine($"{simbol}{new string(' ', length-2)}{simbol}");

        sb.AppendLine(new string(simbol, length));

        Console.WriteLine(sb.ToString());
    }
    public static bool Task2(int number) 
    {
        //string str = number.ToString();
        //return str.Reverse() == str;

        //кода больше и задействуется больше памяти, чем при .ToString() и .Reverse(), но такое решение работает быстрее при больших числах  
        if (number < 0)
            return false;

        int reversed = 0;
        int temp = number;

        while (temp != 0)
        {
            int digit = temp % 10;
            reversed = reversed * 10 + digit;
            temp /= 10;
        }

        return reversed == number; 
    }

    public static List<int> Task3(List<int> original, List<int> filter) =>
        original.Where(x => !filter.Contains(x)).ToList();
}
