public bool ContainsDuplicate(int[] nums) {
        List<int> myList = new List<int>();
		foreach(int n in nums)
		{
			if (myList.Contains(n))
				return true;
			else
				myList.Add(n);
		}
        return false;
    }