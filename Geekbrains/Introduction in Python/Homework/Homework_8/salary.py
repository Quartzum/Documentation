def teacher_salary(num):
    with open('directory.csv', 'r', encoding='utf-8') as d:
        direct_list = d.read().splitlines()
        for salary in direct_list:
            if num in salary:
                salary = salary.split(' ')
                if num in salary:
                    print(*salary)