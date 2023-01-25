import teacher_search
import input
import logger
import salary
import adding_teacher
import deletion

def hogwarts():
    a = input.welcome()

    if a == 1:
        name = input.last_name()
        teacher_search.search_by_name(name)
        logger.history(name)
    elif a == 2:
        subject_taught = input.employee_position()
        teacher_search.search_by_name(subject_taught)
        logger.history(subject_taught)
    elif a == 3:
        salary_t = input.salary()
        salary.teacher_salary(salary_t)
        logger.history(salary_t)
    elif a == 4:
        teacher = input.employee_details()
        adding_teacher.add(teacher)
        logger.history(teacher)
    elif a ==  5:
        number = input.data_deletion()
        deletion.delit(number)
        logger.history(str(number))