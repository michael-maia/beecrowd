N = int(input()) # Entrada do número de repetições

for i in range(N): # O primeiro loop é for pois sabemos o numero de vezes pra verificar
    valores = input().split(" ")
    X, Y = map(int,valores)
    cont = 0 # Contador do numero de impares encontrados
    j = X # A variavel j foi usada para nao alterar X diretamente
    soma = 0
    while cont < Y: # Enquanto j é menor que a quantidade de ímpares que queremos
        if (j % 2) == 1 or (j % 2) == -1: # Para caso o número seja negativo o módulo será -1
            soma += j
            j += 1
            cont += 1
        else:
            j += 1
    print(soma)