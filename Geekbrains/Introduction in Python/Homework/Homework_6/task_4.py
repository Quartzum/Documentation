#Урок 2, задача 2. Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

from random import randint

listnum = []
for i in range(randint(3, 7)): 
    listnum.append(randint(0, 20))

print(f'Сгенерированный список: {listnum}')
print(f'Сумма элементов списка, стоящих на нечетных позициях: {sum(listnum[1::2])}')


#Старое решение
# import RandomNum as r

# list = r.newlist()
# print(f'Сгенерированный список: {list}')

# sum = 0
# for i in range(0, len(list), 2):
#     sum += list[i]
# print(f'Сумма элементов списка, стоящих на нечетных позициях: {sum}')