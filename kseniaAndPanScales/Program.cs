using static System.Console;
using static System.Convert;
using static System.Math;


string str1, str2, str3, external;


str1 = ReadLine();
external = ReadLine();

var arr = str1.Split("|");

str2 = arr[0];
str3 = arr[1];



if (str2.Length == str3.Length)
{
    if (external.Length % 2 == 0)
    {
        for (int i = 0; i < external.Length; i++)
        {
            if (i % 2 == 0)
            {
                str3 += external[i];
            }
            else
            {
                str2 += external[i];

            }
        }
        WriteLine($"{str2}|{str3}");

    }
    else
    {
        WriteLine("Impossible");
    }
}
else
{
    int mn = Min(str2.Length, str3.Length);
    int mx = Max(str2.Length, str3.Length);
    int el = external.Length;
    if (mn + el >= mx)
    {
        if (Abs(mn + el - mx) % 2 == 0)
        {
            for (int i = 0; i < el; i++)
            {
                if (str2.Length >= str3.Length)
                {
                    str3 += external[i];
                }
                else
                {
                    str2 += external[i];
                }


            }
            WriteLine($"{str2}|{str3}");
        }
        else
        {
            WriteLine("Impossible");
        }
    }
    else
    {
        WriteLine("Impossible");
    }

}



