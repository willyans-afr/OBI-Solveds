list = []

for i in range(3):
    list.append(int(input('')))

for i in range(3):
    for j in range(i):
        if int(list[i]) > int(list[j]):
            aux = list[i]
            list[i] = list[j]
            list[j] = aux

print(list[1])