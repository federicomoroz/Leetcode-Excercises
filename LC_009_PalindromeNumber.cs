using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* LEETCODE -- 009 -- Palindrome Number by Federico Moroz
Contact = fedegfs@gmail.com
 
 Given an integer x, return true if x is palindrome integer.
 An integer is a palindrome when it reads the same backward as forward.
 For example, 121 is a palindrome while 123 is not.

Example 1:

Input: x = 121
Output: true
Explanation: 121 reads as 121 from left to right and from right to left.

///////// EXPLANATION //////////

The first step is convertir the number from integrer to string. A string can be understood as an array of single characters.

I will use 2 pointers/markers: Left and Right. Left marker starts at the first character of the "stringed" number, and Right starts at the last one.
Every iteration, while the left marker is shorter or equal than the right one, it will be checked if the values of the items pointed by the markers are not equals.
If they're not equals, the answer will be false and break the loop.
If they're equals, the left marker will move 1 step to the right (increases its value by 1) and the right one will move 1 step to the left (decreases its
value by 1)

Example: 345

int    number       = 345;
string stringNumber = "345";

    Position:||  0  ||  1  ||  2  ||
    Value:   || "3" || "4" || "5" || 
        Left --> l             r  <-- Right Marker

 */

public class LC_009 : MonoBehaviour
{
    private bool IsPalindrome(ref int number)
    {
        bool answer = true;
        string stringNumber = number.ToString();        //The number gets converted to a String, which can be seen as an array of single characters

        //Markers
        int l = 0;                                      //Left marker points the first position (1st number character) 
        int r = stringNumber.Length - 1;                //Right marker points the last position (last number character)

        while (l <= r)                                  //While the left marker is shorter or equal to the right one:
        {
            if(stringNumber[l] != stringNumber[r])          //It will be checked if the values of the list pointed by the markers are not equals
            {
                answer = false;                                 //If they're not, the answer will be false
                return answer;                                  //And break the loop
            }
            else                                            //If they're equals:
            {
                l++;                                        //Left marker moves 1 step to the right (increases its value by one)
                r--;                                        //Right marker moves 1 step to the left (decreases its value by one)
            }
        }

        return answer;                                 //After ending the loop, it will return the answer
    }
}
