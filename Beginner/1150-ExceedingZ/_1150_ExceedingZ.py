#Entrada de valores
X = int(input())
Z = int(input())

while(Z <= X): #Testando Z
    Z = int(input())
    
X2 = X #Criando variavel adicional para nao alterar o valor original de X
soma = X2 #Soma ja considera o primeiro numero inteiro na soma
i = 1 #Contagem dos numeros inteiros ja considerando o numero X

while(soma <= Z):
    soma += (X2 + i) #Soma vai adicionar os numeros em sequencia apos o X
    i += 1

print(i) #Printando a contagem 