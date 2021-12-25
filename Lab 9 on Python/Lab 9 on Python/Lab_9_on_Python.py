import math
def Delete_Even_Words_and_Find_Biggest_of_them(a) :
    count = 0
    result = ""
    word = ""
    biggest_word = ""
    i = 0
    while i < len(a):
        if a[i] != ' ':
            count +=1
            if (count % 2) != 0 :
                while (i < len(a)) and ((a[i]) != ' '):
                    word+=a[i]
                    i+=1
                result+=word
                result+=" "
                if len(word) > len(biggest_word):
                    biggest_word = word
                word = ""
            else:
                while (i < len(a)) and (a[i] != ' '):
                    i+=1
        i+=1
    print()
    print("результат :  " + result)
    print()
    print("найдовше непарне слово :  " + biggest_word)

a = (input("введіть ваш рядок\n"))
Delete_Even_Words_and_Find_Biggest_of_them(a)







        