using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

class MainClass
{

    static void Main()
    {
        //string str = "therE iS aN erroR";
        //string output = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        //Console.WriteLine(output);
        //int[] numbers = new int[] { 1, 2, 3, 4, 5 };

        //int maxNumber = numbers[0]; 

        //for (int i = 1; i < numbers.Length; i++)
        //{
        //    if (numbers[i] > maxNumber)
        //    {
        //        maxNumber = numbers[i];
        //    }
        //}

        //Console.WriteLine("The largest number is: " + maxNumber);
        //Console.WriteLine("Enter the number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //if (IsPrime(num) == true)
        //{
        //    Console.WriteLine("The Number is Prime");
        //}
        //else
        //{
        //    Console.WriteLine("The Number is Not a Prime");
        //}

        //Console.WriteLine("Enter the number");
        //int num = Convert.ToInt32(Console.ReadLine());
        //FibSeries(num);
        //MainClass main = new MainClass();
        //main.DemoMethodA();
        //main.DemoMethod();


        //int[] arr = { 64, 34, 25, 12, 22, 11, 90 };

        //var data = arr.ToList().OrderByDescending(x => x);
        //data.ToList().ForEach(o =>
        //{
        //    Console.WriteLine(o);
        //});

        //MaxFrequency();
        //GetDuplicates();
        //DictionaryEx();
        //ReverseStringFor();
        //ReverseWordOrder();
        // CorrectTextFormat();
        // SquareasdaRoot();
        //Testasda();
        //StringLength();
        //ReverseWords();
        // DuplicateCount();
        //MostFreqelement();

        PartialClass partial = new PartialClass();
        //partial.ReverseWords();
        //partial.MaxFreqNumber();
        //partial.UsingDictionary();
        //partial.FindLargestAndSmallestNum();
        //partial.ReverseElement();
        //partial.FindSecLargestNum();
        //partial.FindDuplicates();
        partial.FindNonDuplicates();
    }

    static void MostFreqelement()
    {
        int[] numbers = new int[] { 1, 2, 2, 4, 4, 4, 4, 5, 6, 7, 8, 8 };

        int maxFreqNumber = 0;
        int maxFreq = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentNumber = numbers[i];
            int currentFreq = 1;

            if (currentFreq == -1)
            {
                continue;
            }

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == currentNumber)
                {
                    currentFreq++;
                    numbers[j] = -1;
                }

                if (currentFreq > maxFreq)
                {
                    maxFreq = currentFreq;
                    maxFreqNumber = currentNumber;
                }
            }
        }
        Console.WriteLine(maxFreqNumber);
    }

    static void DuplicateCount()
    {
        int[] numbers = new int[] { 1, 2, 2, 4, 4, 4, 4, 5, 6, 7, 8, 8 };
        Dictionary<int, int> dic = new Dictionary<int, int>();

        foreach (var item in numbers)
        {
            if (dic.ContainsKey(item))
            {
                dic[item]++;
            }
            else
            {
                dic[item] = 1;
            }
        }

        dic.ToList().ForEach(x =>
        {
            Console.WriteLine($"Value: {x.Key} Count: {x.Value}");
        });
    }

    //static void SquareasdaRoot()
    //{
    //    //List<int> numbers = new List<int>();

    //    //for (int i = 1; i <= 7; i++)
    //    //{
    //    //    int num = i * i;
    //    //    numbers.Add(num);
    //    //    Console.WriteLine(numbers[i - 1]);
    //    //}

    //}

    static void ReverseWords()
    {
        string str = "My name is Nandhakumar";
        string[] arr = str.Split(" ");
        string[] arr2 = new string[arr.Length];
        //Array.Reverse(arr);
        for (int i = arr.Length - 1, j = 0; i >= 0; i--, j++)
        {
            arr2[j] = arr[i];
        }

        Console.WriteLine(string.Join(" ", arr2));
    }

    static void StringLength()
    {
        string str = "Nandhakumar S";
        int length = str.Length;

        Console.WriteLine(length);
    }


    static void Testasda()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                if (i > 2)
                {
                    continue;
                }
                Console.WriteLine("asda");
            }
        }
    }
    static void CorrectTextFormat()
    {
        string str = "nandhakumar S";
        string properStr = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);
        Console.WriteLine(properStr);
    }

    static void ReverseWordOrder()
    {
        string str = "Reverse String";

        for (int i = 0; i < str.Split(' ').Length - 1; i++)
        {
            string word = str.Split(" ")[str.Split(' ').Length - 1];
            string word1 = str.Split(" ")[i];
            Console.WriteLine($"{word} {word1}");
        }
    }

    static void ReverseStringFor()
    {
        string str = "Reverse String";

        char[] chars = str.ToCharArray();

        for (int i = 0, j = chars.Length - 1; i < j; i++, j--)
        {
            chars[i] = str[j];
            chars[j] = str[i];
        }
        Console.WriteLine(new string(chars));
    }

    static void DictionaryEx()
    {
        int[] numbers = new int[] { 1, 2, 3, 2, 4, 2, 3, 1, 4, 4, 5, 4 };

        Dictionary<int, int> keyValues = new Dictionary<int, int>();

        foreach (var item in numbers)
        {
            if (keyValues.ContainsKey(item))
            {
                keyValues[item]++;
            }
            else
            {
                keyValues[item] = 1;
            }
        }

        foreach (var kvp in keyValues)
        {
            Console.WriteLine($"Number: {kvp.Key}, Count: {kvp.Value}");
        }
    }

    static void GetDuplicates()
    {
        int[] numbers = new int[] { 1, 2, 3, 2, 4, 2, 3, 1, 4, 4, 5, 4 };


        var data = numbers
            .GroupBy(x => x)
            //.Where(o => o.Count() > 1)
            .Select(g => new
            {
                Number = g.Key,
                Count = g.Count()
            });
        data.ToList().ForEach(x => Console.WriteLine(x));


    }

    public static void MaxFrequency()
    {
        int[] numbers = new int[] { 1, 2, 3, 2, 4, 2, 3, 1, 4, 4, 5, 4 };

        int mostFrequentElement = 0;
        int maxFrequency = 0;

        int n = numbers.Length;

        for (int i = 0; i < n; i++)
        {
            int currentElement = numbers[i];
            int currentFrequency = 1;


            if (currentElement == -1)
                continue;

            for (int j = i + 1; j < n; j++)
            {
                if (numbers[j] == currentElement)
                {
                    currentFrequency++;
                    // Mark the element as checked by setting it to -1
                    numbers[j] = -1;
                }
            }

            if (currentFrequency > maxFrequency)
            {
                maxFrequency = currentFrequency;
                mostFrequentElement = currentElement;
            }
        }

        Console.WriteLine(mostFrequentElement);
    }

    public static bool IsPrime(int number)
    {
        if (number <= 0)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }


    static void FibSeries(int number)
    {
        int[] fibonacciSequence = new int[number];

        int first = 0;
        int second = 1;

        for (int i = 0; i < number; i++)
        {
            Console.Write($"{fibonacciSequence[i] = first} ");
            int next = first + second;
            first = second;
            second = next;
        }
    }

    public void DemoMethod()
    {
        Console.WriteLine("DemoMethod");
    }

    public void DemoMethodA()
    {
        Console.WriteLine("DemoMethodA");
    }
}

public interface IInterfaceA
{
    void DemoMethod();
}

public interface IInterfaceB
{
    void DemoMethodA();
}


public partial class PartialClass
{

}


public partial class PartialClass
{
    public void ReverseWords()
    {
        string str = "My name is Nandhakumar";
        string[] str1 = str.Split(" ");
        string[] str2 = new string[str1.Length];
        for (int i = str1.Length - 1, j = 0; i >= 0; i--, j++)
        {
            str2[j] = str1[i];
        }
        Console.WriteLine(string.Join(" ", str2));
    }



    public void MaxFreqNumber()
    {
        int[] numbers = { 1, 2, 3, 3, 3, 4 };

        int maxFreqNum = 0;
        int maxFreq = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            int currentFreqNum = numbers[i];
            int currentFreq = 1;

            if (currentFreq == -1)
            {
                continue;
            }

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[j] == currentFreqNum)
                {
                    currentFreq++;
                    numbers[j] = -1;
                }
            }
            if (currentFreq > maxFreq)
            {
                maxFreq = currentFreq;
                maxFreqNum = currentFreqNum;
            }
        }
        Console.WriteLine(maxFreqNum);
    }

    public void UsingDictionary()
    {
        int[] numbers = { 1, 2, 3, 3, 3, 4 };

        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        foreach (var item in numbers)
        {
            if (dictionary.ContainsKey(item))
            {
                dictionary[item]++;
            }
            else
            {
                dictionary[item] = 1;
            }
        }

        dictionary.ToList().ForEach(x => Console.WriteLine($"Numbers: {x.Key} Count: {x.Value}"));
    }


    public void FindLargestAndSmallestNum()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5 };

        int min = numbers.Min();
        int max = numbers.Max();

        //for (int i = 1; i < numbers.Length; i++)
        //{
        //    if (numbers[i] < min)
        //    {
        //        min = numbers[i];
        //    }
        //    else if (numbers[i] > max)
        //    {
        //        max = numbers[i];
        //    }
        //}
        Console.WriteLine($"Min-Value: {min}, Max-Value: {max}");
    }


    public void ReverseElement()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5 };
        int[] newNumbers = new int[numbers.Length];
        for (int i = numbers.Length - 1, j = 0; i >= 0; i--, j++)
        {
            newNumbers[j] = numbers[i];
        }

        Console.WriteLine(string.Join(",", newNumbers));
    }

    public void FindSecLargestNum()
    {
        int[] numbers = { 0, 1, 2, 3, 4, 5 };


        numbers.OrderByDescending(x => x).Skip(1).Take(1)
            .Select(i => i).ToList()
            .ForEach(o =>
            Console.WriteLine($"Sec-largest-value: {o}")
            );
    }


    public void FindDuplicates()
    {
        int[] numbers = new int[] { 1, 2, 3, 2, 4, 2, 3, 1, 4, 4, 5, 4 };

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] != numbers[j])
                {
                    Console.WriteLine(numbers[i] + " is not a duplicate");
                }
            }
        }

    }

    public void FindNonDuplicates()
    {
        int[] numbers = new int[] { 1, 2, 3, 2, 4, 2, 3, 1, 4, 4, 5, 4 };

        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int i in numbers)
        {
            if (counts.ContainsKey(i))
            {
                counts[i]++;
            }
            else
            {
                counts[i] = 1;
            }
        }

        counts.ToList().ForEach(x =>
        {
            if (x.Value == 1)
            {
                Console.WriteLine(x.Key);
            }
        });
    }

}