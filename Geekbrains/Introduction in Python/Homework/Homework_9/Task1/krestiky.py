# Создайте программу для игры в ""Крестики-нолики"" при помощи виртуального окружения и PIP

from itertools import count


field = list(range(1,10)) #Для создания игрового поля из 9 ячеек

def drawField(field):     # Рисование игрового поля в терминале
   print('-' * 13)
   for i in range(3):
      print('|', field[0+i*3], '|', field[1+i*3], '|', field[2+i*3], '|')
      print('-' * 13)

def positionEntry(pos):   #Запрос позиции у пользователя
   valid = False
   while not valid:
      position = int(input('Куда поставим ' + pos + '?'))

      if position >= 1 and position <= 9:
         if(str(field[position-1]) not in 'XO'):
            field[position-1] = pos
            valid = True
         else:
            print('Упс, занято!')
      else:
        print('Что-то не то, введите числа от 1 до 9!')

def Win(field):               #Проверка игрового поля на наличие выигрышных комбинаций
   combinations = ((0,1,2), (3,4,5), (6,7,8), (0,3,6), (1,4,7), (2,5,8), (0,4,8), (2,4,6))
   for i in combinations:
       if field[i[0]] == field[i[1]] == field[i[2]]:
          return field[i[0]]
   return False

def game(field):
    count = 0
    win = False
    while not win:
        drawField(field)
        if count % 2 == 0:
           positionEntry('X')
        else:
           positionEntry('O')
        count += 1
        if count > 4:
           tmp = Win(field)
           if tmp:
              print(tmp, 'выиграл!')
              win = True
              break
        if count == 9:
            print('Ничья!')
            break
    drawField(field)
game(field)

input('Нажмите Enter для выхода!')