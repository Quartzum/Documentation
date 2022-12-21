a = {1, 2, 3, 5, 8}
b = {'2', '5', 8, 13, 21}

print(type(a)) # set
print(type(b)) # set

a = {1, 2, 3, 5, 8}
b = set([1, 2, 3, 5, 8])
c = set((1, 2, 3, 5, 8))
print(type(a)) # set
print(type(b)) # set
print(type(c)) # set

a = {1, 1, 1, 1, 1}
print(a) #{1}

colors = {'red', 'green', 'blue'}
print(colors) # {'red', 'green', 'blue'}

colors.add('red')
print(colors) # {'red', 'green', 'blue'}

colors.add('gray')
print(colors) # {'red', 'green', 'blue', 'gray'}

colors.remove('red')
print(colors) # {'green', 'blue', 'gray'}

# colors.remove('red') # KeyError

colors.discard('red') # ok
print(colors) # {'green', 'blue', 'gray'}

colors.clear() # { }
print(colors) # set()

a = {1, 2, 3, 5, 8}
b = {2, 5, 8, 13, 21}

c = a.copy() # c = {1, 2, 3, 5, 8}
u = a.union(b) # u = {1, 2, 3, 5, 8, 13, 21}
i = a.intersection(b) # i = {8, 2, 5}
dl = a.difference(b) # dl = {1, 3}
dr = b.difference(a) # dr = {13, 21}

q = a \
    .union(b) \
    .difference(a.intersection(b))

# {1, 21, 3, 13}

# Неизменяемое множество

a = {1, 2, 3, 5, 8}
b = frozenset(a)
print(b) # frozenset({1, 2, 3, 5, 8})