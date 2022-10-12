int a = 1;
int b = 2;
int c = 3;
int d = 4;
int z = 10;
int n = 1324;
int m = -90;
int y = 432342;
int i = 3422;

int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    if(result < arg2) result = arg2;
    if(result < arg3) result = arg3;
    return(result);
}

int max = Max(
    Max(a,b,c),
    Max(d,z,n),
    Max(m,y,i));

Console.WriteLine(max);