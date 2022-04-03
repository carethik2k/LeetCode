public class ReverseStringSolution {
    public void ReverseString(char[] s) {
        // for(int i=0; i<=(s.Length-1)/2; i++)
        // {            
        //     char temp = s[i];
        //     s[i] = s[s.Length-1-i];
        //     s[s.Length-1-i] = temp;
        // }
        Stack<char> stkString = new Stack<char>(s);
        for(int i=0;i <= s.Length-1; i++)
            s[i] = stkString.Pop();

        System.Console.WriteLine(s);
    }
}