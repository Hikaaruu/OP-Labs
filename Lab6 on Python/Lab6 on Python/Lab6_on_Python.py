import math
def Xi (a,i,h):
    return (a+(i*h)-(h/2))

a = float(input("Ener a "))  
b = float(input("Ener b ")) 
n = int(input("Ener n ")) 
h1 = math.pi/n
h2 = (b - a) / n
sum1 = 0
sum2 = 0
i = 1
while i<=n :
    sum1 += math.log(2 + math.sin(Xi(0,i,h1)))
    sum2 += math.pow(math.atan(Xi(a,i,h2)),2)
    i +=1
res = sum1*h1 + sum2*h2
print(res)


