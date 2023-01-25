def delit(number):
    number = int(number - 1)
    with open("directory.csv", "r+", encoding='utf-8') as d:
        line_t = d.read().splitlines()
        line_t.pop(number)

    with open("directory.csv", "r+", encoding='utf-8') as d:
        d.write('\n'.join(line_t) +'\n')
        print('\n'.join(line_t))