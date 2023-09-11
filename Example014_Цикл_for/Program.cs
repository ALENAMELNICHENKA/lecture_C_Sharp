// Цикл for
//Итак, это цикл со счётчиком или ещё называется цикл for. Синтаксически он
// просто в себе собирает все в кучу. Не нужно будет отдельно инициализировать счетчик, где-то
// в теле цикла что-то нужно будет увеличивать, где-то проверять условия. Цикл for как раз
// собирает всё в одном месте.
//Поправим наш 4 метод, который был завязан на цикле while. Я его просто за комментирую и
//продублирую для того, чтобы у вас остались всевозможные вариации. 
// string Metod4(int count, string text)
// {
// int i = 0;
// string result = String.Empty;
// while (i<count)
// {
// result = result + text;
// i++;
// }
// return result;
// }
// string res = Metod4(10, “asdf”);
// Console.WriteLine(res);

// Итак, синтаксис цикла for примерно следующий:

string Method4(int count, string text)
{
string result = String.Empty;
for (int i = 0; i < count; i++) //- вначале ключевое слово, затем инициализация
                             //счётчика, после проверка условия 
                            //и инкремент (увеличение счётчика).
{
result = result + text;
}
return result;
}
string res = Method4(10, "asdf");
Console.WriteLine(res);



