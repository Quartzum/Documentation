list = [2,3,4,5,6]
print(list,'==>')

def mult(list):
    mult = []
    for i in range((len(list)+1)//2):
        mult.append(list[i]*list[len(list)-1-i])
    return mult
print(mult(list))