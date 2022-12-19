import os

os.system('CLS')

def get_value():
    x = int(input("Введите первое значение: "))
    y = int(input("Введите второе значение: "))
    z = int(input("Введите третье значение: "))
    return x, y, z

def check_predicate(list_value):
    print('True') if not(list_value[0] or list_value[1] or list_value[2]) == (not list_value[0] and not list_value[1] and not list_value[2]) else print('False')

list_value = get_value()
check_predicate(list_value)