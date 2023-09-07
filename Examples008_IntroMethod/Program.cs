int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 122;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 24;
int c3 = 40;

//Разобьем условие на три части.Определим переменную max, в кот. положим значение первого аргумента
int max = a1;
//На след. этапе проверяем:  если значение новой переменной, то есть b1,
//больше max, то в max положим b1, и так перебираем все переменные
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if(a3 > max) max = a3;
if(b3 > max) max = b3;
if(c3 > max) max = c3;

Console.WriteLine(max);