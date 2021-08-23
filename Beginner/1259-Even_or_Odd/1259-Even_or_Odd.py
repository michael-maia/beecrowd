# Declarando listas para incluir os números pares e ímpares
list_odd = []
list_even = []

# Variável que indica quantos números vão ser avaliados
N = int(input())

# Caso o número N não esteja dentro do range específicado na questão
# OBS: Questionário está errado e deve ser considerado o range abaixo
if(N > 1 and N <= 100000):
    # Loop para digitar os N números e verificar se é par/ímpar para colocar em sua respectiva lista
    for i in range(N):
        number = int(input())
        if(number % 2 == 0):
            list_even.append(number)
        else:
            list_odd.append(number)
    # Ordenando as listas
    # Ascendente
    list_even.sort()
    # Descendente
    list_odd.sort(reverse = True)

    # Printando as listas
    def PrintList(numberList):
        for value in numberList:
            # LEMBRETE: print() já inclui nova linha
            print(value)

    PrintList(list_even)
    PrintList(list_odd)
