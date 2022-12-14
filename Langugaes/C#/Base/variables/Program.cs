// - однострочный комментарий
/* многострочный комментарий */

// 1.Объявление(инициализация)переменной.

int a;

/*
int a; - инструкция.

Инструкция - это какое-то завершенное выражение в языке программирования C#
(абстрактно - это можно назвать законченной мыслью), после которого начинается новая инструкция.

int - тип данных.
a - имя переменной.
; - окончание инструкции.

Мы создали в оперативной памяти переменную, к которой мы можем обратиться по ярлыку "a".

ВАЖНО!!!!!!!!!!! Переменная с названием "a" может быть только одна.
*/

//2.Групповое объявление переменных.

int q,w; // можно объявить их.

int b = 9, c = 10; // можно объявить и одновременно присвоить значение.

int i = 9, o = 57, // также можно объявлять их столбиками для читаемости кода.
    h = 0, j = 89; 

//3.Присвоение значения переменной

a = 46;

/*
Мы обратились к оперативной памяти по ярлыку "a" и присвоили ей новое значение - 46, при помощи оператора
оператора присваиванья "=".
*/

//4.Несоответствие типов данных.

int l = "Some text";// error CS0029: Не удается неявно преобразовать тип "string" в "int".

// Во время передачи значения переменной с конкретным типом данных, мы должны передавать в него только этот тип данных.

// 5.Вывод переменной в консоль

Console.WriteLine(a);

/*
Console - класс.
WriteLine - метод.
() - аргумент передаваемый методу.
*/

//НО, ЕСЛИ НЕ ПРИСВОИТЬ ЗНАЧЕНИЕ ПЕРЕМЕННОЙ, ТО БУДЕТ ОШИБКА.

int m;
Console.WriteLine(b); // error CS0165: Использование локальной переменной "b", которой не присвоено значение.

//6.Особенности типов данных.

char symbol = 'b'; //Значение указывается в одинарных кавычках.
string text = "Some text"; //Значение указывается в двойных кавычках.