data = open("numeroDir/numerot.txt", "r")

summa = 0
for numero in data:
    summa += int(numero)

print(summa)