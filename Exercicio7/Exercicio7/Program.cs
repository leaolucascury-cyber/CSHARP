int a = 15;
int b = 8;
int c = 32;
int temp;

if (a < b) { temp = a; a = b; b = temp; }
if (a < c) { temp = a; a = c; c = temp; }
if (b < c) { temp = b; b = c; c = temp; }

Console.WriteLine($"Ordem decrescente: {a}, {b}, {c}");