    public int MajorityElement(int[] nums) {
        Dictionary<int, int> count = new Dictionary<int, int>();
		foreach(int i in nums)
		{
			if (count.ContainsKey(i))
				count[i] = count[i] +1;
			else
				count.Add(i, 1);
		}
		int max = count.Values.Max();
		return count.First(c => c.Value == max).Key; 
    }