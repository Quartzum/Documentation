def history(data):
    with open('hisrory.txt', 'a', encoding='utf-8') as h:
        if data.split() == 1:
            h.write(f'экспорт - {data}' + '\n')
        else:
            h.write(f'импорт - {data}' + '\n')