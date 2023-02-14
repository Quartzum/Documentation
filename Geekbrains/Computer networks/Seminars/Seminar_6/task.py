# Импорт библиотеки socket
import socket
import threading
from time import sleep
## Создание сокета
ya_sock = socket.socket()
# Создаём массив с IP сайта, к которому хотим приконнектиться и порт(т.к. соединение HTTPS, то порт 443)
addr = ("87.250.250.242", 443)
# Вызов функции connect, которая устанавливает соединение с сайтом. 
# Параметром передаём массив с IP и портом.
ya_sock.connect(addr)
# Создаём HTTP запрос
data_out = b"GET / HTTP/1.1\r\nHOST:ya.ru\r\n\r\n"
# Отправка HTTP запроса
ya_sock.send(data_out)
# Получение данных
data_in = b"" # Контейнер для входящих данных
# Создаём функцию, в которую помещаем бесконечный цикл получения данных
def recieving():
    global data_in # Делаем переменную глобальной, чтобы её было видно за функцией
    while True:
        data_chunk = ya_sock.recv(1024) # В переменную помещаем входящие данные
        data_in = data_in + data_chunk # Собираем части данных
# Создаём отдельный поток для приёма данных и помещаем туда вызов функции приёма данных
rec_thread = threading.Thread(target=recieving) # Создаём поток и помещаем в переменную
rec_thread.start() # Вызываем поток

sleep(4) # Задержка ввода в консоль
print(data_in) # Печать ответа от сервера
ya_sock.close()# Закрытие сокета