using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*  LEETCODE -- 374 -- Guess Number Higher or Lower by Federico Moroz
    Contact = fedegfs@gmail.com
    https://leetcode.com/problems/guess-number-higher-or-lower/

// NOTE //
As this is built using Unity Engine, I added the TargetNumber choosing and Guess methods built-in the excercise in LeetCode

We are playing the Guess Game. The game is as follows:

I pick a number from 1 to n. You have to guess which number I picked.

Every time you guess wrong, I will tell you whether the number I picked is higher or lower than your guess.

You call a pre-defined API int guess(int num), which returns three possible results:

-1: Your guess is higher than the number I picked (i.e. num > pick).
1: Your guess is lower than the number I picked (i.e. num < pick).
0: your guess is equal to the number I picked (i.e. num == pick).
Return the number that I picked. 

Example 1:

Input: n = 10, pick = 6
Output: 6

//////// EXPLANATION //////////

The method GuessNumber receives the last number of the possible numbers (the first one is 1).
It will use 3 pointers: 
    -Left   = that starts at the beggining (0) and will be moving to its right (increasing its value)
    -Right  = that starts at the last possible number (number) and will be moving to its left (decreasing its value)s
    -Middle = Every iteration, it will sit at the integer on the center between the left and right pointers

While the Left marker doesn't surpass the Right one (less or equal value):
    The Middle marker will sit at the position on the center between Left and Right pointers.
    And will use the Guess() method, passing its value as a parameter.
        The Guess method checks if the number received (current middle marker) is equal, greater or shorter than the target number.
            If Middle marker is shorter than the target, it returns 1. That means that the target number is at the right of the current middle marker position.
            If Middle marker is greater than the target, it returns -1. That means that the target number is at the left of the current middle marker position.
            If Middle marker is equal to the target, it returns 0.

    If Guess returns 0:  Means the target has been found and the middle marker value is returned.
    If Guess returns 1,  Means the target number is at the Right of the current Middle marker position. 
                         Every number between the Left and Middle markers are irrelevant and cut off by moving the Left marker to the position on the Right of the current middle pointer. (Middle + 1)
    If Guess returns -1, Means the target number is at the Left of the current middle marker position. 
                         Every number between the Middle and Right markers are irrelevant and cut off by moving the left marker to the position on the Light of the current middle pointer. (Middle - 1)
        It goes to next iteration

After the loop, if the target has not been found method returns -1.
 
 
*/
public class LC_374_GuessNumberHigherOrLower : MonoBehaviour
{
    //Parameters
    private int choosedNumber;                                                 //Will store the target number to find
    private int maxNum;                                                        //Will store the range to choose

    private void Start()
    {
        maxNum = Random.Range(5, 30);                                         //Set the range
        Choose(maxNum);                                                       //Choose the target number
        GuessNumber(maxNum);                                                  //Guess the target
        
    }
    private void Choose(int num)
    {
        choosedNumber = Random.Range(1, num + 1);                               
        print($"Choosed number is: {choosedNumber}");
    }
    private int Guess(int num)                                              //The method receives the target number and the one picked
    {
        if(num > choosedNumber)                                                             //If the number picked is greater than the target
        {
            return -1;                                                                             //It returns -1
        }
        else if (num < choosedNumber)                                                       //If the number picked is shorter than the target
        {
            return 1;                                                                              //It returns 1
        }
        else                                                                                //If the number picked is equal to the target
        {
            return 0;                                                                              //It returns 0
        }
    }

    public int GuessNumber(int n)                                              //The method receives the range to guess
    {
        //Pointers
        int left = 0;                                                               //Left pointer sits at the beggining of the numbers list
        int right = n;                                                              //Right pointer sits at the end of the numbers list

        //Loop
        while (left <= right)                                                       //While the left pointer doesn't surpass the right one
        {
            int middle = left + (right - left) / 2;                                 //Middle pointer gets positioned at the number on the center between the range limited by the Left and Right pointers
            if (Guess(middle) == 0)                                                 //0: Picked Number == Target Number. Target has been found
            {
                print($"Number was: {middle}");
                return middle;                                                          //Middle marker value is returned
            }
            if (Guess(middle) == -1)                                                //1:  Picked Number is greater than the target. 
            {                                                                       //    Means Target is on the Left of the Middle. Every number between Middle and Right are irrelevant and cutoff 
                print($"Your pick was: {middle}");
                right = middle - 1;                                                     //By moving the Right Marker to the position before the Middle one (Middle - 1)     
            }
            else                                                                    //-1: Picked Number is shorter than the target. 
            {                                                                       //    Means Target is on the Right of the Middle. Every number between Left and Middle are irrelevant and cutoff 
                print($"Your pick was: {middle}");
                left = middle + 1;                                                      //By moving the Left Marker to the position next to the Middle one (Middle + 1)
            }

        }
        //After not finding the target
        return -1;                                                                  //If Target has not been found, method returns -1
    }

}
