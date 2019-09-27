N = [] # Declarando a variável N como uma lista

for i in range(20): # Leitura dos números
    N.append(int(input()))

# Troca dos números
for i in range(10): # O range é 10 pois o N[i] vai de [0,10) e o outro N vai de [20,9)
    N[i] , N[-1*(i+1)] = N[-1*(i+1)] , N[i]             

for i in range(len(N)): # Print para mostrar os números
    print("N[{}] = {}".format(i, N[i]))