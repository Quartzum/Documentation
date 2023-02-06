
import logging
from config import TOKEN
from telegram.ext import (Updater, CommandHandler, MessageHandler, Filters, ConversationHandler)

# Логирование
logging.basicConfig(format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=logging.INFO)
logger = logging.getLogger(__name__)

# Определяем константы выполняемых этапов
CHOICE, RATIONAL_ONE, RATIONAL_TWO, OPERATIONS_RATIONAL, OPERATIONS_COMPLEX, COMPLEX_ONE, COMPLEX_TWO = range(7)

def start(update, _):
    update.message.reply_text(f'Привет, {update.effective_user.first_name}, это - калькулятор. Для начала, даавайте определимся, с какими числами будем работать!\n' 'Команда /cancel, чтобы прекратить разговор.\n\n')
    update.message.reply_text('1 - рациональные числа; \n2 - комплесные числа; \n3 - Нитего не хотю :( \n')
    return CHOICE

def choice(update, context):
    user = update.message.from_user
    logger.info("Выбор операции: %s: %s", user.first_name, update.message.text)
    user_choice = update.message.text
    if user_choice in '123':
        if user_choice == '1':
            update.message.reply_text('Ну ладно-ладно :)\n Ваше первое рациональное число - эт-о-о: ')
            return RATIONAL_ONE
        if user_choice == '2':
            context.bot.send_message(update.effective_chat.id, 'Введите Re и Im первого числа через ПРОБЕЛ: ')
            return COMPLEX_ONE
        if user_choice == '3':
            update.message.reply_text('Ну и л-л-л-адно, ну и пожа-а-а-луйста :(')
            return ConversationHandler.END     
    else:
        update.message.reply_text('Так, что за дела, давайте поясню еще раз.\n 1 - для операций с рациональными числами; \n2 - для операций с комплесными числами; \n3 - для выхода \n')

def rational_one(update, context):
    user = update.message.from_user
    logger.info("Пользователь ввел число: %s: %s", user.first_name, update.message.text)
    get_rational = update.message.text
    if get_rational.isdigit():
        get_rational = float(get_rational)
        context.user_data['rational_one'] = get_rational
        update.message.reply_text('А второе?')
        return RATIONAL_TWO

    else:
        update.message.reply_text('Нужно ввести число')


def rational_two(update, context):
    user = update.message.from_user
    logger.info("Пользователь ввел число: %s: %s", user.first_name, update.message.text)
    get_rational = update.message.text
    if get_rational.isdigit():
        get_rational = float(get_rational)
        context.user_data['rational_two'] = get_rational
        update.message.reply_text('А что мы будем с ними делать?: \n\n+ - для сложения; \n- - для вычетания; \n* - для умножения; \n/ - для деления. \n')
        return OPERATIONS_RATIONAL


def operatons_rational(update, context):
    user = update.message.from_user
    logger.info(
        "Пользователь выбрал операцию %s: %s", user.first_name, update.message.text)
    rational_one = context.user_data.get('rational_one')
    rational_two = context.user_data.get('rational_two')
    user_choice = update.message.text
    if user_choice in '+-/*':
        if user_choice == '+':
            result = rational_one + rational_two
        if user_choice == '-':
            result = rational_one - rational_two
        if user_choice == '*':
            result = rational_one * rational_two
        if user_choice == '/':
            try:
                result = rational_one / rational_two
            except:
                update.message.reply_text('Деление на ноль запрещено')
        update.message.reply_text(f'Результат: {rational_one} + {rational_two} = {result}')
        return ConversationHandler.END
    else:
        update.message.reply_text('Ничего не понимаю -__- \n+ - для сложения; \n- - для вычетания; \n* - для умножения; \n/ - для деления. \n' )

def complex_one(update, context):
    user = update.message.from_user
    logger.info(
        "Пользователь ввел число %s: %s", user.first_name, update.message.text)
    user_choice = update.message.text
    test = user_choice.replace('-', '')
    if ' ' in test and (test.replace(' ', '')).isdigit():
        user_choice = user_choice.split(' ')
        complex_one = complex(int(user_choice[0]), int(user_choice[1]))
        context.user_data['complex_one'] = complex_one
        update.message.reply_text(f'Первое число {complex_one},  Введите Re и Im второго числа через ПРОБЕЛ: ')
        return COMPLEX_TWO
    else:
        update.message.reply_text('А? Что? Что здесь написано? Введите Re и Im первого числа через ПРОБЕЛ')


def complex_two(update, context):
    user = update.message.from_user
    logger.info(
        "Пользователь ввел число %s: %s", user.first_name, update.message.text)
    user_choice = update.message.text
    test = user_choice.replace('-', '')
    if ' ' in test and (test.replace(' ', '')).isdigit():
        user_choice = user_choice.split(' ')
        complex_two = complex(int(user_choice[0]), int(user_choice[1]))
        context.user_data['complex_two'] = complex_two
        update.message.reply_text(
            f'Второе число {complex_two}, что нам нужно с ними сделать?: \n\n+ - для сложения; \n- - для вычетания; \n* - для умножения; \n/ - для деления. \n')
        return OPERATIONS_COMPLEX
    else:
        update.message.reply_text('Все совсем не то! Введите Re и Im второго числа через ПРОБЕЛ')

def operatons_complex(update, context):
    user = update.message.from_user
    logger.info(
        "Пользователь выбрал операцию %s: %s", user.first_name, update.message.text)
    complex_one = context.user_data.get('complex_one')
    complex_two = context.user_data.get('complex_two')
    user_choice = update.message.text
    if user_choice in '+-/*':
        if user_choice == '+':
            result = complex_one + complex_two
        if user_choice == '-':
            result = complex_one - complex_two
        if user_choice == '*':
            result = complex_one * complex_two
        if user_choice == '/':
            try:
                result = complex_one / complex_two
            except:
                update.message.reply_text('Деление на ноль запрещено')
        update.message.reply_text(f'Результат: {complex_one} + {complex_two} = {result}')
        return ConversationHandler.END
    else:
        update.message.reply_text('Ничего не понимаю -__- \n+ - для сложения; \n- - для вычетания; \n* - для умножения; \n/ - для деления. \n')

def cancel(update, _):
    # определяем пользователя
    user = update.message.from_user
    # Пишем в журнал о том, что пользователь не разговорчивый
    logger.info("Пользователь %s отменил разговор.", user.first_name)
    # Отвечаем на отказ поговорить
    update.message.reply_text('Ну эй, ты чего, нормально же общались...')
    return ConversationHandler.END


if __name__ == '__main__':
    # Создаем Updater и передаем ему токен вашего бота.
    updater = Updater(TOKEN)
    # получаем диспетчера для регистрации обработчиков
    dispatcher = updater.dispatcher

    # Определяем обработчик разговоров `ConversationHandler`
    # с состояниями CHOICE, RATIONAL_ONE, RATIONAL_TWO, OPERATIONS_RATIONAL, OPERATIONS_COMPLEX, COMPLEX_ONE, COMPLEX_TWO
    conversation_handler = ConversationHandler(  # здесь строится логика разговора
        # точка входа в разговор
        entry_points=[CommandHandler('start', start)],
        # этапы разговора, каждый со своим списком обработчиков сообщений
        states={
            CHOICE: [MessageHandler(Filters.text, choice)],
            RATIONAL_ONE: [MessageHandler(Filters.text, rational_one)],
            RATIONAL_TWO: [MessageHandler(Filters.text, rational_two)],
            OPERATIONS_RATIONAL: [MessageHandler(Filters.text, operatons_rational)],
            OPERATIONS_COMPLEX: [MessageHandler(Filters.text, operatons_complex)],
            COMPLEX_ONE: [MessageHandler(Filters.text, complex_one)],
            COMPLEX_TWO: [MessageHandler(Filters.text, complex_two)],
        },
        # точка выхода из разговора
        fallbacks=[CommandHandler('cancel', cancel)],
    )

    # Добавляем обработчик разговоров `conv_handler`
    dispatcher.add_handler(conversation_handler)

    # Запуск бота
    updater.start_polling()
    updater.idle()