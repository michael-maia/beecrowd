#N = Quantos numeros da sequencia queremos ver
N = int(input())

#A sequencia precisa dos 2 primeiros numeros para iniciar
x1, x2 = 0, 1
#Caso queremos ver o primeiro numero da sequencia
if N == 1:
    print(x1)
#Caso queremos ver o segundo numero da sequencia
elif N == 2: 
    print("{} {}".format(x1, x2))    
#Caso queremos ver mais de 3 numeros da sequencia
else: 
    print("{} {}".format(x1, x2), end = " ")
    soma = 0
    for i in range(N - 2): # N - 2 -> Pois desconsideramos os 2 primeiros números da sequência
        soma = x1 + x2
        #A soma determina o proximo numero da sequencia
        if i == N - 3:
            print(soma)
        else:
            print(soma, end = " ")       
        x1 = x2
        x2 = soma
        
        

