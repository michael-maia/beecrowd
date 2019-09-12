N = int(input())

soma = [0,0]

for i in range(N):
    X, Y = int(input()).split(" ")
    cont = 0
    j = X    
    while cont < Y:
        if j % 2 == 1:
            soma[i] += j
            j += 1
            cont += 1
        else:
            j += 1

print(soma[0], soma[1])
