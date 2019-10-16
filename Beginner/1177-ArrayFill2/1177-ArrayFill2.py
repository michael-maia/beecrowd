'''
Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1177
Write a program that reads a number T and fill a vector N[1000] with the numbers from 0 to T-1 repeated times, like as the example below.

Input
The input contains an integer number T (2 ≤ T ≤ 50).

Output
For each position of the array N, print "N[i] = x", where i is the array position and x is the number stored in that position.
'''

T = int(input())
x = 0 # Numero que vai de [0,T)
for i in range(1000):
    if x == T: 
        x = 0
    print("N[{}] = {}".format(i, x))
    x += 1