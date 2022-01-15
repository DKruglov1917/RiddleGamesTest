using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Palindrom : MonoBehaviour
{
    static bool IsPalindrom(string word, bool ignoreCase = true)
    {
        word.Replace(" ", "");

        if (ignoreCase)
        {
            word = word.ToLowerInvariant();
        }

        for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
        {
            if (word[first] != word[last])
            {
                return false;
            }
        }

        return true;
    }
}
