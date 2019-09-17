# Questão: https://www.urionlinejudge.com.br/judge/en/problems/view/1165

N = int(input())
for i in range(N): # Loop para cada teste
    chavePrimo = True # Chave que determina se é ou não primo
    X = int(input())
    for j in range(2,X): # Usamos o intervalo [2,X) pois já sabemos o resultado do X dividido por 1 e X
        if X % j == 0:
            print(X,"nao eh primo")
            chavePrimo = False
            break # Um caso fora da regra do Número Primo já é o suficiente para dizer que não é Primo
    if chavePrimo == True:
        print(X,"eh primo")