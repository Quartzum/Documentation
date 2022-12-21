t = ()
print(type(t)) # tuple

t = (1,)
print(type(t)) # tuple

t = (1)
print(type(t)) # int

t = (28, 9, 1990)
print(type(t)) # tuple

colors = ['red', 'green', 'blue'] # list
print(colors) # ['red', 'green', 'blue']

t = tuple(colors) # Преобразование в кортеж
print(t) # ('red', 'green', 'blue')

t = tuple(['red', 'green', 'blue'])
print(t[0]) # red
print(t[2]) # blue
# print(t[10]) # IndexError
print(t[-2]) # green
# print(t[-200]) # IndexError

for e in t:
    print(e) # red green blue

t[0] = 'black' # TypeError. Нельзя присвоить новое значение кортежу, т.к. он неизменяем.

t = tuple(['red', 'green', 'blue'])
red, green, blue = t

print('r: {} g: {} b: {}'.format(red, green, blue))
# r:red g:green b:blue