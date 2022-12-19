'''
2. Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
    
    *Пример:*
    
    - Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}
'''

import os
import random

os.system('cls')
n = int(input('Введите число'))

list = []

for _ in range(n):
    list.append(random.randrange(-100, 100))

print(* list)