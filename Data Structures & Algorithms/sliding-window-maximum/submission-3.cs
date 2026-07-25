public class Solution {

    /*
    arr of nums and int k

    sliding window 

    fixed sliding window

    need to return an array of int with maxium values 

    initialize the pointer

    we will use a monotonic queue where we store the highest element 
    
    in the queue and dequeu only after the window as ended

    window size -> right = k - 1;

    keep iterating through the window and enqueue items

    store index of the number so that we remember what number was the largest

    in the window 

    so we can remove an item from the queue after it has left the window frame
    if it was the largest and we continue to keep moving each iteration
    only increment when we reach k - 1

    sol: Attempt #1 example nums 1,2,1,0,4,2,6 k = 3 
        Queue<int> queue = new Queue<int>();
        int left = 0;
        int right = k - 1;
        int[] out = new int[nums.Length];

        while(right < nums.Length){

            //iteratin to loop through a window
            for(int j = left; j <=right;j++){

                if(queue.Count == 0){
                    queue.Enqueue(j);    
                } 
                //[2,3,2]
                while(nums[j] > nums[queue.Peek()]){
                    queue.Dequeue();
                }
                queue.Enqueue(j);
            }
            out[left] = nums[queue.Dequeue()]; // out = [2,2]
            right++;
            left++; } return out;
    */
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> deque = new LinkedList<int>();
          int left = 0;
          int right = 0;//since we know the size of the window we dont need to have right start at k
          int[] res = new int[nums.Length - k + 1];
          while(right < nums.Length){
            
            if(deque.Count > 0 && deque.First.Value < left) deque.RemoveFirst();           
            while(deque.Count > 0 && nums[right] > nums[deque.Last.Value]) deque.RemoveLast();
            deque.AddLast(right);
            if(right >= k - 1){
                res[left] = nums[deque.First.Value];
                left++;
            }

            right++;
          }
          return res; 
    }
}
