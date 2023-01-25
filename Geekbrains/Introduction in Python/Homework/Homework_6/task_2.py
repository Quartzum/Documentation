#Урок 2, задача 2. Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.

def Factorial(N):
    if N == 1:
        return 1
    else: return N * Factorial(N-1)

number = int(input('Введите число: '))
newlist = list(map(Factorial, [i for i in range(1,number + 1 )]))

print(f'Набор произведений чисел от 1 до {number}: {newlist}')


#Старое решение
# def MultiplicationOfNumbers(N):
#     a = 1
#     n = 1
#     newlist = []

#     while a <= N:
#         n = a * n
#         newlist.append(n)
#         a += 1

#     return(newlist)

# number = int(input('Введите число: '))          #не работет с отрицательными числами (пока что)

# print(f'Набор произведений чисел от 1 до {number}: {MultiplicationOfNumbers(number)}')