def search_by_name(name):
    with open('directory.csv', 'r', encoding='utf-8') as d:
        direct_list = d.read().splitlines()
        for teacher in direct_list:
            if name in teacher:
                print(teacher)