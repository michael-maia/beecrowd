T = int(input()) # Quantidade de testes

for i in range(T):
    #N = Quantos numeros da sequencia queremos ver
    N = int(input())
    #A sequencia precisa dos 2 primeiros numeros para iniciar
    x1, x2 = 0, 1
    #Caso queremos ver o primeiro numero da sequencia
    if N == 0:
        print("Fib({}) = {}".format(N,x1))
    #Caso queremos ver o segundo numero da sequencia
    elif N == 1: 
        print("Fib({}) = {}".format(N,x2)) 
    #Caso queremos ver mais de 3 numeros da sequencia
    else:         
        X = 0
        for i in range(N - 1): # N - 1 -> Pois desconsideramos os 2 primeiros números da sequência e também pq o intervalo do range é assim [0,N-1)
            X = x1 + x2
            #O X determina o proximo numero da sequencia                  
            x1 = x2
            x2 = X
        print("Fib({}) = {}".format(N,X))