    public int[] Intersect(int[] nums1, int[] nums2) {
        List<int> result = new List<int>();
        int[] smallArr;  // Other array to work on
        int[] bigArr;

        // Assign the bigArr & arr based on size of arrays
        if (nums1.Length >= nums2.Length) {
            bigArr = nums1;
            smallArr = nums2;
        } else {
            bigArr = nums2;
            smallArr = nums1;
        }

        // Add elements of bigArr array in the dictionary &
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach(int num in bigArr) {
            if (dict.ContainsKey(num)) {
                dict[num] = dict[num] + 1;
            } else
                dict.Add(num, 1);
        }

        // Iterate smallArr
        int val = 0;
        foreach (int num in smallArr) {
            if (dict.TryGetValue(num, out val) && val > 0) {
                dict[num] = --val;
                result.Add(num);
            }
        }

        return result.ToArray();
    }