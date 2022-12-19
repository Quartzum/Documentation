n = int(input("Введите число: "))
dict = {}
for i in range(1, n+1):
    dict.update({i:3*i+1}) 
    #dict[i] = 3*i+1
print(dict)
