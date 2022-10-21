using System.Globalization;
//1.Class Convert.

string a = "b";

//Целочисленные значения
Convert.ToByte(a); // Конвертация в тип данных - byte.
Convert.ToSByte(a); // Конвертация в тип данных - sbyte.

Convert.ToInt16(a); // Конвертация в тип данных - short.
Convert.ToUInt16(a); // Конвертация в тип данных - ushort.

Convert.ToInt32(a); // Конвертация в тип данных - int.
Convert.ToUInt32(a); // Конвертация в тип данных - uint.

Convert.ToInt64(a); // Конвертация в тип данных - long.
Convert.ToUInt64(a); // Конвертация в тип данных - ulong.

//С плавающей запятой
Convert.ToSingle(a); // Конвертация в тип данных - float.
Convert.ToDouble(a); // Конвертация в тип данных - double.
Convert.ToDecimal(a); // Конвертация в тип данных - decimal.

//Символьные тип

Convert.ToChar(a); // Конвертация в тип данных - char.
Convert.ToString(a); // Конвертация в тип данных - string.

//Логический тип

Convert.ToBoolean(a); // Конвертация в тип данных - bool.

//4.Исправление проблемы при работе с "." и ",".

NumberFormatInfo numberFormatInfo = new NumberFormatInfo() // Создание экземпляра класса NumberFormatInfo.
{
    NumberDecimalSeparator = ".", //Установка разделителя. Вместо точки можно поставить запятую.
};

string str = "1.9";

double b = Convert.ToDouble(str, numberFormatInfo);//При конвертации мы передаем экземпляр класса в качестве параметра.

/*
При работе с разными операционными системами и языками возникают
проблемы с разделителем у чисел с плавающей запятой при конвертации.
Для того, чтобы решить проблему мы можем воспользоваться
пространством имен using System.Globalization;
*/