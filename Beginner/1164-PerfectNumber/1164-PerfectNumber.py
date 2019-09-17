N = int(input()) # Quantidade de testes

for i in range(N): # Loop para os testes
    X = int(input()) # Número a ser verificado
    soma = 0
    for j in range(1, X): # Loop para verificar os divisores
        if X % j == 0:
            soma += j
    if soma == X:
        print(X,"eh perfeito")
    else:
        print(X,"nao eh perfeito")       