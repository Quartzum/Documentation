import math

pi = math.pi
print('Pi = ', pi)
d = 0.001
print(f'Accuracy = {d}')
count = 0
while d < 1:
    count += 1
    d = d*10
print(round(pi, count))