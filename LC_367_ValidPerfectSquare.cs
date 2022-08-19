using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* LEETCODE -- 367 -- Valid Perfect Square
Given a positive integer num, write a function which returns True if num is a perfect square else False.

Follow up: Do not use any built-in library function such as sqrt.
Example 1:

Input: num = 16
Output: true
Example 2:

Input: num = 14
Output: false

//////// EXPLANATION /////////

The method receives an integrer (numb) and returns a boolean. 

First, it checks if the integrer is positive. If it's not, boolean returns false.
Second, it checks if the integrer is 0 or 1. If it is, booleans returns true without further checking.

For last, after checking that number is greater than 1, method will check if it's a perfect square.
The method uses binary search principles. We'll use the numbers between 1 and integrer value as a list. 
Method has 3 pointers:
    - Left: begins at 1 (first relevant number)
    - Right: begins at number value (last relevant number)
    - Middle: It will be positioned at the center of the range between left and right. 

Every iteration, the middle marker moves to the number exactly on the center of the range of numbers limited by left and right markers. 
After setting the middle marker, it gets the square of the middle marker value.
If squared the middle marker value is equal to received number value, number has been found as a perfect square and no further checking is required.

If middleValue is shorter than number value, left marker moves to the number next to the middle marker.
If middleValue is greater than number value, right marker moves to the number before the middle marker.

And goes to next iteration. 

(Ex: Checking if 256 is perfect square) 
Iteration 1: 
    if Left marker is 1 and Right marker is 256, middle marker will sit at 128
    middle marker value gets squared = 128 * 128 = 16384.

    It needs to check the middleValue to the received number:

    16384 is greater than 256, so right marker moves to the number before the middle one: 128 - 1 = 127

    Left marker it's still 1, and Right marker is now 127. So It goes to next iteration.

Iteration 2:
    Left Marker is 1, Right Marker is 127, so Middle marker goes to 64
    middle marker value gets squared = 64 * 64 = 4096

    4096 is greater than 256 so
    Left marker lies still at 1, right marker moves to 63. It goes to next iteration.

Iteration 3:
    Left Marker is 1, Right Marker is 63, so Middle marker goes to 32
    middle marker value gets squared = 32 * 32 = 1024

    1024 is greater than 256.
    Left marker is 1, and the Right marker moves to 31. Next iteration.

Iteration 4:
    Left marker is 1, Right Marker is 31, so middle marker goes to 16
    middle marker value gets squared = 256

    256 is equal to number, so number has been found as a perfect square.    
    
 
*/

public class LC_367 : MonoBehaviour
{
    public bool IsPerfectSquare(int num)
    {
        if (num < 0)                                                                    // If number is negative, it's clearly not perfect square and further checking is not required.
        {
            return false;
        }
        else if (num == 0 || num == 1)                                                  //If number is 0 or 1, it's clearly a perfect square and further checking is not required.
        {
            return true;
        }
        else                                                                            //If number is greater than 1:
        {
            int left  = 1;                                                              //Left marker starts at 1 (first relevant number) 
            int right = num;                                                            //Right marker starts at value of number (last relevant number)

            while (left <= right)                                                       //While left marker doesn't surpass the right one:
            {
                int middle      = left + Mathf.Abs((right - left) / 2);                 //The middle marker sits exactly on the middle number between the left and right marker
                int middleValue = middle * middle;                                      //middleValue gets the square of the middle marker

                if (middleValue == num)                                                 //If middleValue is equal to the num given, num is a perfect square number.
                {
                    return true;
                }
                else if (middleValue < num)                                             //If middleValue is shorter than num value, the left marker moves to the number next to the middle marker
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle - 1;                                                 //If middleValue is greater than num, the right marker moves to the number before the middle marker
                }
            }
            return false;                                                               //If the loop did not find a perfect square number, boolean returns false.
        }

    }
}
