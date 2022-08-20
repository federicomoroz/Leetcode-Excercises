using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* LEETCODE -- 852 -- Peak Index in a Mountain Array by Federico Moroz
An array arr[] is a mountain if the following properties hold:
arr.length >= 3
There exists some i with 0 < i < arr.length - 1 such that:
arr[0] < arr[1] < ... < arr[i - 1] < arr[i]
arr[i] > arr[i + 1] > ... > arr[arr.length - 1]
Given a mountain array arr, return the index i such that arr[0] < arr[1] < ... < arr[i - 1] < arr[i] > arr[i + 1] > ... > arr[arr.length - 1].

You must solve it in O(log(arr.length)) time complexity.

Example 1:

Input: arr = [0,1,0]
Output: 1
Example 2:

Input: arr = [0,2,1,0]
Output: 1

///////// EXPLANATION //////////

The method needs to find where the greatest number of the list (its index), which is sorted in mountain shape.
In order to find it, it will use 3 pointers/markers:
    - Left:   which starts at the first position of the array (0)
    - Right:  which starts at the last position of the array (length - 1)
    - Middle: every iteration sits at the number exactly in the middle of Left and Right markers

Every iteration while the right marker is at least 1 whole number after the left one, it will ask if the number pointed by the middle marker is greater than the ones before and after it. That's the mountain peak.
If the number pointed by the middle marker is:
    -shorter than the one before it -> the right marker goes to the middle.
    -shorter than the one next to i -> the left marker goes to the middle.

After the loop, the left and right pointers should be next other.
It will return the value of the greater number pointed by the 2 markers.

 */

public class LC_852_PeakIndexInMountainArray : MonoBehaviour
{
 public int PeakIndexInMountainArray(int[] array)
    {
        //Check for array availabily
        if (array == null || array.Length < 3)                                      //A mountain shaped list needs to have at least 3 items
        { 
            return -1;                                                              
        }

        // Markers
        int left  = 0;                                                              //Left marker pointing at the beggining of the array
        int right = array.Length-1;                                                 //Left marker pointing at the last item of the array

        //Check for the element
        while(right - left > 1)                                                     //While the right marker is at least 1 position after the left one:
        {
            int middle = left + Mathf.Abs((right - left)/2);                            //The middle marker points at the number exactly on the middle between the left and right markers.
            
            if (array[middle - 1] > array[middle])                                      //If the number of array[] pointed by the middle marker is shorter than the one before it:
            {
                right = middle;                                                             //The right marker goes to the middle
            }
            else                                                                        //If it's shorter
            {
                left = middle;                                                              //The left marker goes to the middle
            }
            
        }

        //After the loop, if the number of array[] pointed by the left marker is greater than the right one:
        if (array[left] > array[right]) 
        {
            return left;                                                                //The method returns the left marker value
        }
        else                                                                        //If not
        {
            return right;                                                               //It returns the right one
        }
    }


}
