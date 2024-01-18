    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;
        
        foreach(var c in s.Distinct().ToList())
		{
			if (t.Count(i => i==c) != s.Count(i => i==c))
				return false;				
		}
		return true;
    }