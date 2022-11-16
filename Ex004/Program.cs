int a = 4;
int b = 7;
int c = 3;
int d = 2;
int e = -9;

int max = a;

if (max < b) max = b;
if (max < c) max = c;
if (max < d) max = d;
if (max < e) max = e;

Console.WriteLine(max);
