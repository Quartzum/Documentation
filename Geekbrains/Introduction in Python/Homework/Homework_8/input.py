def welcome():
    print('\n' + '=' * 20)
    print('Добро пожаловать в Хогвартс - Школу Чародейства и Волшебства!')
    print('Выберите необходимое действие: 1. Поиск учителя по фамилии или имени')
    print('                               2. Фильтрация учителей по предмету')
    print('                               3. Фильтрация учителей по зарплате')
    print('                               4. Добавить учителя')
    print('                               5. Удалить учителя')
    print('                               6. Закончить работу')

    return int(input('Введите номер необходимого действия: '))

def last_name():
    lname = input('Введите имя или фамилию учителя: ')
    return lname

def employee_position():
    empl = input('Введите предмет, преподаваемый учителем: ')
    return empl.lower()

def salary():
    salary_inp = input('Введите сумму заработной платы: ')
    return salary_inp

def employee_details():
    human = input('Введите данные учителя в формате: id, имя, фамилия, должность, з/п руб. : ')
    return human

def data_deletion():
    with open('directory.csv', 'r', encoding='utf-8') as d:
        print(d.read())
        number = int(input('Введите номер учителя для удаления: '))
        return number