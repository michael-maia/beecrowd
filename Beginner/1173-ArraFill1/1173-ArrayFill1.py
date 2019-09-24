n = [] # Declaramos que n é uma lista
num = int(input()) # Entrada do primeiro número da lista
n.append(num) # Adicionando o "num" para o final da lista
print("N[{}] = {}".format(0, n[0]))
for i in range(1,10):  
    n.append(2 * n[i-1]) # Adicionando o dobro do penúltimo número da lista para o último índice
    print("N[{}] = {}".format(i, n[i]))