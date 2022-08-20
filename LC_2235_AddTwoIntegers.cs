using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*    LEETCODE -- 2235 -- Add Two Integers by Federico Moroz
      Contact = fedegfs@gmail.com
      https://leetcode.com/problems/add-two-integers/
      Given two integers num1 and num2, return the sum of the two integers.
 
 
 
 */
public class LC_2235_AddTwoIntegers : MonoBehaviour
{
    public int Sum(int num1, int num2)                          //The method receives 2 integrers and returns another integrer
    {
        int result = num1 += num2;                              //A new integrer is created, and its value is the sum of both ints received
        return result;

    }
}
