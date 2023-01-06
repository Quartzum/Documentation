from random import randint

n = int(input('Введите размер списка: '))
list = []
for element in range(n):
    list.append(randint(-n,n))

print(list)

data = open(r'D:\main_folder\WebDev\documentation\Geekbrains\Introduction in Python\Homework\Homework_2\task_4\text.txt', 'r')
result = 1

for line in data:
    print(list[int(line)])
    print('индекс')
    result *= list[int(line)]
    print(result)
    print('результат')
data.close()

print(result)