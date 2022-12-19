import os
import math

os.system('CLS')

def get_coordinates():
    x_one = int(input("Введите координату на оси x: "))
    y_one = int(input("Введите координату на оси y: "))
    x_two = int(input("Введите координату на оси x: "))
    y_two = int(input("Введите координату на оси y: "))
    return (x_one, y_one, x_two, y_two)

def calculate_distance(coordinates_list):
    result = math.sqrt(coordinates_list[0] * coordinates_list[2] + coordinates_list[1] * coordinates_list[3])
    print(f'Расстояние между точками [{coordinates_list[0]},{coordinates_list[1]}] и [{coordinates_list[2]},{coordinates_list[3]}] - {result}')

coordinates_list = get_coordinates()
calculate_distance(coordinates_list)