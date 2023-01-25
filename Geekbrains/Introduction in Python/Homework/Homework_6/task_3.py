# Урок 2, задача 5. Реализуйте алгоритм перемешивания списка

list1 = [i for i in range(1,7)]
print(f'Сгенерированный список: {(list1)}')

import random

newlist = list(map(lambda i: list1.pop(random.randint(0, (len(list1) - 1))), [i for i in list1]))

print(f'Перемешанный список: {(newlist)}')


#Старое решение
# import random

# newlist = [i for i in range(1,15)]
# print(f'Сгенерированный список: {(newlist)}')

# random.shuffle(newlist)                    # random.shuffel() - метод перемешиванния списка
# print(f'Перемешанный список: {(newlist)}')