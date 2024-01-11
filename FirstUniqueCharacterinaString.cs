public int FirstUniqChar(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
		foreach(char c in s)
		{
			if (dict.ContainsKey(c))
				dict[c]++;
			else
				dict.Add(c, 1);			
		}
		
		int min = dict.Min(x => x.Value);
		
		if (min != 1)
			return -1;
		
		return s.IndexOf(dict.FirstOrDefault(x => x.Value == min).Key);
    }