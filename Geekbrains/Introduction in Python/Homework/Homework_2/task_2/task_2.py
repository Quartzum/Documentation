def errors(inputText):
    is_OK = False
    while not is_OK:
        try:
            number = int(input(f"{inputText}"))
            is_OK = True
        except ValueError:
            print('Введите число!')
        return number

def factorial(number):
    if number == 0:
        return 1
    return factorial(number - 1) * number

number = errors("Введите число: ")

print(f'Произведенье чисел от 1 до {number} - {factorial(number)}.')