/* LEETCODE -- 344 -- Reverse String by Federico Moroz
 Contact = fedegfs@gmail.com
 Write a function that reverses a string. The input string is given as an array of characters s.
 You must do this by modifying the input array in-place with O(1) extra memory.

     Example 1:
     Input: s = ["h","e","l","l","o"]
     Output: ["o","l","l","e","h"]
 
///////// EXPLANATION //////////
Binary Search:
    There will be 2 markers, Left and Right. They will be pointing the first and last non-reversed positions of s[].
    Using a while looping if left marker position if at the left of the right marker (left < right), left marker item of the array
    will swap its value with the right marker item. After that, left marker increases its value by 1 (moves 1 place to the right)
    and right marker value decreases its value by one (moves 1 place to the left).
    When left marker is at the same or greater position than the right one, it means the array is already sorted and the loop ends.    


                       default s[]
    Position:||  0  ||  1  ||  2  ||  3  ||  4  ||                                
    Value:   || "h" || "e" || "l" || "l" || "o" ||
        Left --> l                           r  <-- Right Marker

                       modded s[]
    Position:||  0  ||  1  ||  2  ||  3  ||  4  ||  
    Value:   || "o" || "l" || "l" || "e" || "h" ||
                                             i <-- Target Marker
 
 */

public class LC_344 : MonoBehaviour
{
    public void ReverseString(ref string[] s)
    {
        //Markers
        int l = 0;                                          //Left marker, marks the beggining
        int r = s.Length - 1;                               //Right marker, marks the end        

        while (l < r)                                       //While left marker position is less or equal than right marker position:
        {
            //Reverse values 
            string aux = s[r];                              //Original value of right marker position is stored in an auxiliar variable
            s[r]       = s[l];                              //Right position takes the value of the left marker position
            s[l]       = aux;                               //Left marker position takes the value stored in the auxiliar variable (original right marker value)
            
            //Move the markers
            l++;                                            //Left marker moves 1 place to the right
            r--;                                            //Right marker moves 1 place to the left
        }    
    }

}
