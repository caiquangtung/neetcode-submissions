public class Solution {

    // Encode: từ List<string> thành một string duy nhất
    public string Encode(List<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var s in strs)
        {
            sb.Append(s.Length).Append('#').Append(s);
        }
        return sb.ToString();
    }

    // Decode: từ string duy nhất thành lại List<string>
    public List<string> Decode(string s)
    {
        var res = new List<string>();
        int i = 0;
        while (i < s.Length)
        {
            // tìm dấu #
            int j = i;
            while (s[j] != '#')
            {
                j++;
            }
            int length = int.Parse(s.Substring(i, j - i));
            string str = s.Substring(j + 1, length);
            res.Add(str);
            i = j + 1 + length;
        }
        return res;
    }
}
