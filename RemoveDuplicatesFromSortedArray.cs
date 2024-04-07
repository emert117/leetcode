    public int RemoveDuplicates(int[] nums) {
        int current = nums[0];
		int unique = 1;
		
		for(int i=1; i<nums.Length; i++)
		{
			if (nums[i] != current)
			{
				current = nums[i];
				nums[unique] = current;
				unique++;
			}
		}
		
		return unique;
    }