dictionary = {}
dictionary = \
    {
        'plus': '+',
        'minus': '-',
        'multiply': '*',
        'divide': '/',
    }

print(dictionary) # {'plus': '+', 'minus': '-', 'multiply': '*', divide': '/',}
print(dictionary['minus']) # -

dictionary['plus'] = '-'
print(dictionary['plus']) # -
# print(dictionary['type']) # KeyError
del dictionary['minus'] # Удаление элемента

for item in dictionary: # for(k,v) in dictionary.items():
    print('{}: {}'.format(item, dictionary[item]))

# plus: +
# minus: -
# multiply: *
# divide: /