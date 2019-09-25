A = [] # Inicializa A como uma lista
for i in range(100):
    A.append(float(input())) # Adiciona o valor lido para o último índice de A
    if A[i] <= 10:
        print("A[{}] = {:.1f}".format(i, A[i])) # Exemplo de formatação de float com mais de 1 valor no print 