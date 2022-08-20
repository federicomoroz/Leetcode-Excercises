using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*    LEETCODE -- 2235 -- Add Two Integers by Federico Moroz
      Contact = fedegfs@gmail.com
     * 26. Remove Duplicates from Sorted Array 
    Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. 
    The relative order of the elements should be kept the same.
    Since it is impossible to change the length of the array in some languages, you must instead have the result be placed in the first part of the array nums. 
    More formally, if there are k elements after removing the duplicates, then the first k elements of nums should hold the final result. It does not matter what you leave beyond the first k elements.
    Return k after placing the final result in the first k slots of nums.
    Do not allocate extra space for another array. You must do this by modifying the input array in-place with O(1) extra memory.    
 
 
 */
public class LC_2235_AddTwoIntegrer : MonoBehaviour
{
    public int Sum(int num1, int num2)                          //The method receives 2 integrers and returns another integrer
    {
        int result = num1 += num2;                              //A new integrer is created, and its value is the sum of both ints received
        return result;

    }
}
