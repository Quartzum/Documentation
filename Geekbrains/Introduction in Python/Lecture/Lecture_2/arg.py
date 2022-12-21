def new_string(symbol, count):
    return symbol * count

print(new_string('!', 5)) # !!!!!
print(new_string('!')) # TypeError missing 1 requierd...

def new2_string(symbol, count = 3):
    return symbol * count

print(new2_string('!', 5)) # !!!!!
print(new2_string('!')) # !!
print(new2_string(4)) # 12

