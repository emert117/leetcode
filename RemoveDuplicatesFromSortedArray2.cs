public int RemoveDuplicates(int[] nums) {
        int len = nums.Length;
        int twiceCount = 0;
        int count = 0;
        int prevVal = 0;

        for (int inc = 0; inc < len; inc++) {            
            if (inc == 0 || (prevVal == nums[inc] && twiceCount < 2)) {
                prevVal = nums[inc];
                nums[count++] = prevVal;
                twiceCount++;
            } else if (prevVal != nums[inc]) {
                prevVal = nums[inc];
                nums[count++] = prevVal;
                twiceCount = 1;
            }
        }

        return count;
    }