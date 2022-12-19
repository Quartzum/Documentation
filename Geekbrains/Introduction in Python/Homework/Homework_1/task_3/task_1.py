import sys
import os

os.system('CLS')

def get_coordinate():
    x = int(input('Введите координату x: '))
    if x == 0: sys.exit('Координата "x" не может быть равна 0!')
    y = int(input('Введите координату y: '))
    if y == 0: sys.exit('Координата "y" не может быть равна 0!')
    return x, y

def show_plane(x,y):
    if x > 0 and y > 0: sys.exit("Первая четверть!")
    if x > 0 and y < 0: sys.exit("Четвёртая четверть!")
    if x < 0 and y < 0: sys.exit("Третья четверть!")
    if x > 0 and y > 0: sys.exit("Вторая четверть!")

x, y = get_coordinate()
show_plane(x,y)