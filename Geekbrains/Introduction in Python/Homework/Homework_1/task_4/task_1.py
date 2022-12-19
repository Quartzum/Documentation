import os

os.system('CLS')

def get_plane():
    plane = int(input('Введите номер четверти: '))
    return plane

def show_range(plane):
    if plane == 1:
        print("Диапазон возможных точек: x - от 0 до бесконечности, y - от 0 до бесконечности.")
    if plane == 2:
        print("Диапазон возможных точек: x - от 0 до минус бесконечности, y - от 0 до бесконечности.")
    if plane == 3:
        print("Диапазон возможных точек: x - от 0 до минус бесконечности, y - от 0 до минус бесконечности.")
    if plane == 4:
        print("Диапазон возможных точек: x - от 0 до бесконечности, y - от 0 до минус бесконечности.")

plane = get_plane()
show_range(plane)