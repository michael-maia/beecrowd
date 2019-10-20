# Question: https://www.urionlinejudge.com.br/judge/en/problems/view/1179
# Declaração das 2 listas
par = []
impar = []
for i in range(15): # Loop para ler os números e avalia-los
    num = int(input())
    if num % 2 == 0: # Caso seja par
        par.append(num)
        if len(par) == 5:            
            for j, x in enumerate(par):
                print("par[{}] = {}".format(j, x))
            par.clear() # Limpa o conteúdo da lista           
    else: # Caso seja ímpar
        impar.append(num)
        if len(impar) == 5:            
            for j, x in enumerate(impar):
                print("impar[{}] = {}".format(j, x))
            impar.clear() # Limpa o conteúdo da lista
# Mostra os números restantes das listas
for i, x in enumerate(impar):
    print("impar[{}] = {}".format(i, x))
for i, x in enumerate(par):
    print("par[{}] = {}".format(i, x))

