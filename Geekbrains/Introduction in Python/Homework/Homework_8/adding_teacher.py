def add(infa):
    with open('directory.csv', 'a', encoding='utf-8') as d:
        d.write(infa + '\n')