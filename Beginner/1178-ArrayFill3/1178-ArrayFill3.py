# Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1178

X = float(input())
Y = X
for i in range(100):    
    print("N[{}] = {:.4f}".format(i, Y))
    Y /= 2