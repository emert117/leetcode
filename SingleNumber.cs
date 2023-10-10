public int SingleNumber(int[] nums) {
        Dictionary<int, bool> count = new Dictionary<int, bool>();
		int single = 0;
		foreach(int num in nums)
		{
			if (!count.ContainsKey(num))
			{
				count.Add(num, false);				
			}
            else
            {
                count[num] = true;
            }
		}
		return count.FirstOrDefault(x => x.Value == false).Key;;
    }