    public int HammingWeight(uint n) {
        int res = 0;
        
        while (n != 0)
        {
            uint cur = n;
            
            if ((cur & 1) == 1)
                res++;
            
            n = n >> 1;
        }
        
        return res;
    }