
import math
a = int(input("Enter a "))
b = int(input("Enter b "))
print()
i = a
while i<=b:
    print("divisors of ",i)
    j = 1
    while j<=i:
        if i % j == 0 : print(j," ")
        j=j+1
    i = i+1
    print()
    print()





           