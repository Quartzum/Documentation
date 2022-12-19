import sys
import os

os.system('CLS')

def check_day():
    day = int(input("Введите день недели(цифрой): "))
    if day < 1 or day > 7:
        sys.exit('Такого дня недели не существует! Введите корректный день недели!')
        
    print("Выходной!") if day == 6 or day == 7 else print("Не выходной!")
    
check_day()