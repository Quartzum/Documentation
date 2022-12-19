str_1 = 'somesomesomesome'
str_2 = 'sdf'

for i in range(len(str_1)):
    flag = False
    if str_2[0] == str_1[i]:
        flag = True
        for j in range(1, len(str2)):
            if str_1[j] != str_2[i + j]
