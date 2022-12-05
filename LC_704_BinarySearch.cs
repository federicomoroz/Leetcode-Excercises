/*  LEETCODE -- 704 -- Binary Search by Federico Moroz
    Contact = fedegfs@gmail.com
    https://leetcode.com/problems/binary-search/

Given an array of integers nums which is sorted in ascending order, and an integer target, write a function to search target in nums. 
If target exists, then return its index. Otherwise, return -1.
You must write an algorithm with O(log n) runtime complexity.

Example 1:
Input: nums = [-1,0,3,5,9,12], target = 9
Output: 4
Explanation: 9 exists in nums and its index is 4

Constraints:

1 <= nums.length <= 104
-104 < nums[i], target < 104
All the integers in nums are unique.
nums is sorted in ascending order.

//////// EXPLANATION //////////

In order to find the target number position in a sorted list of unique integrers using the least amount if iterations, I'll be using binary search principles.
There will be 3 pointers/markers that point at different positions/indexes of the given array:
    - Left: Begins at the first array position (0)
    - Right: Begins at the last array position (Length - 1)
    - Marker: It will always point to the position in the middle of left and right ones.

The point is shortening the search range by moving the left and right markers.

While the left marker doesn't surpass the right one (less or equal value), every iteration it will move the middle marker to the center of the array between left and right pointers.

If the number pointer by the middle marker is equal to the target number, we found the target and return the middle marker
If it's shorter than the target, the left marker moves to the position next to the middle one (middle + 1). It means that the numbers before the current middle marker location are irrelevant and cut off.
If it's greater than the target, the right marker moves to the position before the middle one (middle - -1). It means that the numbers after the current middle marker location are irrelevant and cut off.
After that, it goes to the next iteration.

                       target = 9
                  nums[] - iteration 0
Position: ||  0  ||  1  ||  2  ||  3  ||  4  ||  5  ||
Value:    || -1  ||  0  ||  3  ||  5  ||  9  ||  12 ||
Markers:    left          middle                right

                  nums[] - iteration 1
Position: ||  0  ||  1  ||  2  ||  3  ||  4  ||  5  ||
Value:    || -1  ||  0  ||  3  ||  5  ||  9  ||  12 ||
Markers:                  left   middle         right

                  nums[] - iteration 2
Position: ||  0  ||  1  ||  2  ||  3  ||  4  ||  5  ||
Value:    || -1  ||  0  ||  3  ||  5  ||  9  ||  12 ||
Markers:                          left   middle right              <--- nums[middle] == target : Target has been found, is on position 4


*/
public class LC_704_BinarySearch : MonoBehaviour
{
    public int Search(int[] nums, int target)                                   //The method receives an int array called nums[], and an integer called target
    {
        //Markers/Pointers
        int left = 0;                                                           //Left marker begins at the first array position (0)
        int right = nums.Length - 1;                                            //Right marker begins at the last array position (Length - 1)

        while (left <= right)                                                   //While the left marker doesn't surpass the right one (less or equal)
        {
            int middle = left + Mathf.Abs((right - left) / 2);                            //The middle marker sits on the number on the middle of the array ranged by the left and right markers.
            if (nums[middle] == target)                                             //If the number of array pointed by the middle marker is equal to the target
            {
                return middle;                                                            //Target position has been found and is returned
            }
            else if (nums[middle] < target)                                         //If the number of the array pointed by the middle marker is shorter than the target
            {
                left = middle + 1;                                                        //The left marker moves to the position next to the middle one
            }
            else                                                                    //If the number of the array pointed by the middle marker is greater than the target
            {
                right = middle - 1;                                                       //The right mover moves to the position before the middle one
            }
        }
        return -1;                                                              // If the loop ends before returning the middle marker, it means that target has not been found and returns -1
    }

}
