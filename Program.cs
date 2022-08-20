
while(true)
{
    Console.WriteLine("Enter string or <0> to exit");

    string str = Console.ReadLine().ToLower();
    if(str.Equals("0"))
        break;
    string newstr = "";

    int[] flag = new int[str.Length];

    for(int i = 0; i < flag.Length; i++)
    {
        flag[i] = 0;
    }

    for(int i = 0; i < str.Length; i++)
    {
        for(int j = i + 1; j < str.Length; j++)
            if(str[i]==str[j] && flag[j] == 0)
            {
                flag[i] = 1;
                flag[j] = 1;
            }
    }   

    for(int i = 0; i < str.Length; i++)
    {
        if(flag[i]==1)
            newstr+=")";
        else
            newstr+="(";
    }

    Console.WriteLine("New string:");
    Console.WriteLine(newstr);
}