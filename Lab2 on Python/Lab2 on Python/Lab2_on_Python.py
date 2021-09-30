import math
x = float(input("Enter x "))
y = float(input("Enter y "))
if (math.pow(x,2)+math.pow(y,2)>4) :
    print("point does not belong to the area")
elif x >= 0 and y >= 0 and y >= -x + 2 :
    print("point belongs to the area")
elif x <= 0 and y <= 0 and y <= -x - 2 :
    print("point belongs to the area")
elif x >= 0 and y <= 0 and y >= x - 2 :
    print("point belongs to the area")
elif x <= 0 and y >= 0 and y <= x + 2 :
    print("point belongs to the area")
elif math.pow(x,2)+math.pow(y,2) == 4 :
    print("point belongs to the area")
else: print("point does not belong to the area")


