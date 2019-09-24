x = [] # Neste caso foi necessário declarar que x é uma lista para o python interpretar
for i in range(10):
    num = int(input()) # Lê e adiciona a uma variável temporária
    x.append(num) # A função append() adicionar o valor "num" para o último indice da lista
    if x[i] <= 0:
        x[i] = 1
    print("X[{}] = {}".format(i, x[i]))