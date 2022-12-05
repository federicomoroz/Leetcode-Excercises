/*  LEETCODE -- 035 -- Search Insert Position by Federico Moroz
    Contact = fedegfs@gmail.com
    https://leetcode.com/problems/search-insert-position/

    Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
    You must write an algorithm with O(log n) runtime complexity.
 
    Example 1:
        Input: nums = [1,3,5,6], target = 5
        Output: 2
        
    Example 2:
        Input: nums = [1,3,5,6], target = 2
        Output: 1

    /////// EXPLANATION /////////
    
The method needs to find the position of the target number on the array, or the position it would be if it's not in the array.
    It receives an ascending order sorted int Array, called nums[], and an integer called target. 
    Every number of the array is unique.

Using the binary search principles, there will be two pointers which limit the search range:
    -Left:  Starts at the beginning of the array (0).
    -Right: Starts at the last position of the array (Length-1).

The checking loop, While, will have as condition that Left marker should not surpass Right marker (left <= right).
    Every iteration, it will create and position the Middle marker at the center index of the range limited by the Left and Right pointers.
    
    If the number of the array pointed by the Middle marker is equal to the target, it means that the target position has been found and Middle marker value is returned.
    
    If the number of the array pointed by the Middle marker is shorter than the target number, it means that the target is on the range limited by the Middle and Right markers.
        The numbers between Left and Middle markers are irrelevant and cut off by moving the Left marker to position next to the Middle one.

    If the number of the array pointed by the Middle marker is greater than the target number, it means that the target is on the range limited by the Left and Middle markers.
        The numbers between Middle and Right markers are irrelevant and cut off by moving the Right marker to position before the Middle one.

The loop breaks when the Left Marker surpass the Right one position. That means that target number is greater than the largest number of the array.
So, in that case, its position would 1 step next to the last number of the array. That's where the Left marker is so its value is returned.
    

 */
public class LC_035_SearchInsertPosition : MonoBehaviour
{
    public int SearchInsert(int[] nums, int target)
    {
        //Markers
        int left = 0;
        int right = nums.Length - 1;

        //Loop
        while (left <= right)
        {
            //Middle marker sits on the center betweeen Left and Right 
            int middle = left + Mathf.Abs((right - left) / 2);

            //If number pointed by Middle is = Target, it returns Middle marker
            if (nums[middle] == target) { return middle; }

            //If number pointed by Middle is shorter than Target, Left Marker moves to position next to Middle. If not, Right Marker moves to the position before Middle.
            if (nums[middle] < target) { left  = middle + 1; }
            else                       { right = middle - 1; }
        }
        //If target is larger than the last number of the array, Left marker will be positioned 1 step after Right Marker, breaking the Loop and returning the Left Value
        //That means that the target would be on an extra position.
        return left;
    }
}
