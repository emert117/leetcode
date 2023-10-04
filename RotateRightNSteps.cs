 public void Rotate(int[] nums, int k) {
        Queue<int> numbers = new Queue<int>();
		int n = nums.Length;
        k = k%n;
        int start = n - k;
        for (var i = 0; i < nums.Length; i++)
        {
            numbers.Enqueue(nums[(start+i)%n]);
        }
		
		for (var i = 0; i < nums.Length; i++)
        {
            nums[i] = numbers.Dequeue();
        }
    }    