﻿int a = 5;
int b = 3;
int c = 2;
int d = 6;
int e = 8;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);