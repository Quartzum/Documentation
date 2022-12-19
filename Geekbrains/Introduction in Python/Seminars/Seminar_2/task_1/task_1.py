'''
1. Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
    
    *Пример:*
    
    - Для N = 5: 1, -3, 9, -27, 81

'''
import os
import random

os.system('cls')
n = int(input('Введите число: '))

for _ in range(n):
    print(random.randrange(-100, 100), end=" ")