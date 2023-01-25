#Урок 3, задача 4. Напишите программу, которая будет преобразовывать десятичное число в двоичное.

num = int(input('Введите число: '))

binarylist = list(range(-10, 1))
binarynum = list(map(lambda i: num//2**abs(i)%2, binarylist))
print(*binarynum)

# Старое решение
# def BinaryNumber(number):
#     a = ''
#     while number > 0:
#         a = str(number % 2) + a   #последний остаток должен быть первой цифрой двоичного числа. Тип str - для хранения остатков.
#         number = number // 2
#     return a

# num = int(input('Введите число: '))

# print(f'Введенное число в двоичной системе счисления: {BinaryNumber(num)}')