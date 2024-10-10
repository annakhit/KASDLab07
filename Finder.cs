using System;
using System.Linq;

internal class Finder
{
    readonly MyVector<string> result = new MyVector<string>();
    public MyVector<string> Find(string[] input)
    {
        foreach (string item in input)
        {
            foreach (string element in item.Split(' '))
            {
                string[] initial = element.Split('.');
                if (initial.Length != 4) continue;
                string[] numbers = initial.Where((value) => Int32.Parse(value) >= 1 && Int32.Parse(value) <= 256).ToArray();
                if (numbers.Length == 4) result.AddElement(String.Join(".", numbers));

            }
        }
        return result;
    }
}