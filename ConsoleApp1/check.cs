using System;

public class Check
{
    public static bool IsPalindrome(string str)
    {
        // Убираем пробелы и приводим строку к одному регистру
        string cleanedStr = str.Replace(" ", "").ToLower();

        int left = 0;
        int right = cleanedStr.Length - 1;

        while (left < right)
        {
            if (cleanedStr[left] != cleanedStr[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}
