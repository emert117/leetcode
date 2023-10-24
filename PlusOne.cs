public int[] PlusOne(int[] digits) {
        int carrier = 1;
        
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int temp = digits[i] + carrier;
            
            digits[i] = temp % 10;
            carrier = temp / 10;
        }
        
        if (carrier == 1)
        {
            List<int> tempList = new List<int>();
            
            tempList.Add(carrier);
            
            foreach (var n in digits)
                tempList.Add(n);
            
            return tempList.ToArray();
        }
        
        return digits;
    }