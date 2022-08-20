int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return result;
}

int a1 = 7;
int b1 = 2;
int c1 = 15;
int a2 = 4;
int b2 = 9;
int c2 = 0;
int a3 = 7;
int b3 = 22;
int c3 = 5;

int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

Console.WriteLine(Max(max1, max2, max3));

