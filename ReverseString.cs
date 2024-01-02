public class Solution {
    public void ReverseString(char[] s) {
        var n = s.Length;

        for (var i = 0; i < n / 2; i++) {
            var temp = s[i];
            s[i] = s[n - i - 1];
            s[n - i - 1] = temp;
        }
    }
}