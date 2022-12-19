import os

os.system('cls')
n = int(input('n = '))
dictionary = []
for i in range(1, n+1):
    dictionary.append([i, 3 * i + 1])
print(*dict(dictionary))

# * выводит только ключи