i = 0
for j in range(6):
    r = input('')
    i += 1 if r == 'V' else 0
i = 1 if(i >= 5) else 2 if (i >= 3) else 3 if (i > 0) else -1
print(i)