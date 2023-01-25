def imp_d(data_person):
    with open('directory.txt', 'a', encoding='utf-8') as d:
        d.write(data_person + '\n')