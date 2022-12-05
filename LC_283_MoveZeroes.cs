/* LEETCODE -- 283 -- Move Zeroes by Federico Moroz
 Contact = fedegfs@gmail.com
 Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
 Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

////////// EXPLANATION ///////////
I will use a pointer, which is named "l" and initializes on 0.

With a for thru the array vigen, every iteration it will check if the current value of the array is not equal to 0.
If it that's true, it will swap its value with the value of the item of the array which index is equal to the pointer. And the pointer moves one step to the right (increases its value by one)

              default nums[]
Position: ||  0  ||  1  ||  2  ||  3  || 4  ||
Value:    ||  0  ||  1  ||  0  ||  3  || 12 ||
Pointer:->    l

              sorted nums[]
Position: ||  0  ||  1  ||  2   ||  3   ||  4  ||
Value:    ||  1  ||  3  ||  12  ||  0   ||  0  ||
Pointer:->                                  l
            
             

 */
public class LC_283 : MonoBehaviour
{
    private int[] MoveZeroes (int[] nums)
    {
        int l = 0;                                              //The Pointer begins pointing the first position of the array.

        for (int i = 0; i < nums.Length; i++)                   //This for will run through the entire array
        {
            if(nums[i] != 0)                                        //Every iteration it will ask if the current value of the array is not-equal to 0
            {
                SwapValues(ref nums, l, i);                            //If it's true, the values of index i and index l (marker) of nums[] are swapped
                l++;                                                   //The marker moves 1 step to the right (increases its value by 1) 
            }
        }

        return nums;                                            //Finally, the method returns the modifed array
    }

    private void SwapValues(ref int[] array, int i, int j)      //The SwapValues method receives a reference to an integrer array, and 2 integrers: "i" and "j".
    {
        int aux = array[i];                                     //It creates an integrer auxiliar variable, that stores the value of the item of index "i" o the array received
        array[i] = array[j];                                    //The value of item "i" of array is changed to the item "j" of the array
        array[j] = aux;                                         //The value of item "j" of the array is changed to the auxiliar value stored (original array[i] value)
    }
}
