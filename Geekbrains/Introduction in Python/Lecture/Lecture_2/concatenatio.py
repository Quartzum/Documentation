def concatenatio(*params):
    res: str = ""
    for item in params:
        res += item
    return res

print(concatenatio('a', 's', 'd', 'w')) #asdw
print(concatenatio('a', '1', 'd', '2')) #a1d2
# TypeError...
# Т.к. мы в функции определили, что работаем со строками, то программа выдаст ошибку.
