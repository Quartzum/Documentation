def export(data_person):
    with open('directory.txt', 'r', encoding ='utf-8') as d:
        directory_read = d.read().splitlines()
        for person in directory_read:
            if data_person in person:
                print(person)