import sys
import time
import math

def writePrime(max_numb):
    before = time.time()
    f = open('prime_pyt.csv', 'w')
    for i in range(3, max_numb + 1):
        if isPrime(i) == True:
            f.write(str(i) + "\n")
    f.close()
    after = time.time()
    res_time = after - before
    return res_time

def isPrime(numb):
    if numb % 2 == 0:
        return False
    i = 3
    while i * i <= numb: 
        if numb % i == 0:
            return False
        i += 2
    return True

#if __name__ == "__main__":
print(writePrime(1000000))
