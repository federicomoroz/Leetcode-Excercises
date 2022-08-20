using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*LEETCODE -- 977 -- Squares of a Sorted Array by Federico Moroz
Contact = fedegfs@gmail.com
Given an integer array nums sorted in non-decreasing order, return an array of the squares 
of each number sorted in non-decreasing order.

Input: nums = [-4,-1,0,3,10]
Output: [0,1,9,16,100]
Explanation: After squaring, the array becomes [16,1,0,9,100].
After sorting, it becomes [0,1,9,16,100].

///////// EXPLANATION //////////
I will work with 2 int arrays. The original one "nums", and another one which will be used to return squared and sorted.
Binary Search:
    There will be 2 markers, Left and Right, that will be "pointing" positions on nums[].
    A third marker, "i", that points to the new array. 


                            Nums[]
    Position:||  0  ||  1  ||  2  ||  3  ||  4  ||                                
    Value:   || -4  || -1  ||  0  ||  3  ||  10 ||
        Left --> l                           r  <-- Right Marker

                            Result[]
    Position:||  0  ||  1  ||  2  ||  3  ||  4  ||  
    Value:   ||  -  ||  -  ||  -  ||  -  ||  -  ||
                                             i <-- Target Marker
*/

public class LC_977 : MonoBehaviour
{
  
        public int[] SortedSquares(int[] nums)
        {
            //Markers
            int l = 0;                                          //Left marker, marks the beggining
            int r = nums.Length - 1;                            //Light marker, marks the end
            int i = r;                                          //Target marker, starts at the end.
            
            //New array to return
            int[] result = new int[nums.Length];                //Create a new array, same length as nums[]. It will be used as sorted array.

            while (l <= r)                                      //While left marker position is less or equal than right marker position:
            {
                int left  = Mathf.Abs(nums[l]);                 //These integrer takes the absolute value of the item of nums[] which position is the same as the left marker.
                int right = Mathf.Abs(nums[r]);                 //These integrer takes the absolute value of the item of nums[] which position is the same as the right marker.

                if (left < right)                               //If the left value integrer is shorter than the right one:
                    {
                        result[i] = (right *= right);           //The item of result[] which position is the same as the target marker takes the value of the square of the right integrer.
                        r--;                                    //Right marker reduces its value by 1 (moves to the left).
                    }
                else                                            //If the left value integrer is equal or greater than the right one:
                    {
                        result[i] = (left *= left);             //The item of result[] which position is the same as the target marker takes the value of the square of the right integrer.
                        l++;                                    //Left marker increases its value by 1 (moves to the right).
                    }
                i--;                                            //Last step of iteration: After checking the values of left and right integrers, target marker reduces its value by 1 (moves to the left).
            }
            return result;
        }

  
}
