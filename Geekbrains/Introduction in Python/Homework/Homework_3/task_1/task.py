list = [2, 3, 5, 9, 3]
print(list)

sum = 0
for i in range(len(list)):
    if i %  2 != 0:
        sum = sum + list[i]
print(f'Sum of elements in odd position {list} is', sum)
