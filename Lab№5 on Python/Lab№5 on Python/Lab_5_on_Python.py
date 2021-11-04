import math

a = float(input("Enter a "))
b = float(input("Enter b "))
print()
if a < 1:
    a1 = 1
elif a % 1 != 0:
    a1 = a - (a % 1) + 1
else:
    a1 = a

b1 = b - (b % 1)
i = a1

while i <= b1:
    sum = 0
    n = 0
    print("divisors of ", i)
    j = 1
    while j <= i:
        if (i % j) == 0:
            print(str(j) + " ")
            n = n + 1
            sum += j
        j = j + 1
    i = i + 1
    print("number of divisors = " + str(n))
    print("their sum = " + str(sum))
    print()
    print()