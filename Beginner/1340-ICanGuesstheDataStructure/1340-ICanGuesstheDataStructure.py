# VERIFICAR SE O INPUT DEVE VIR A PARTIR DE UM ARQUIVO
# EXEMPLO DE INPUT PARA TESTES

# CASOS DE ESTRUTURA DE DADOS
# Na Fila o primeiro a entrar é o primeiro a sair, logo as listas serão iguais
def Queue(list1, list2):
    if(list1 == list2):
        return True
    else:
        return False

# Na Empilha o primeiro a entrar é o último a sair, logo as listas vão ser inversas uma da outra
def Stack(list1, list2):
    # Invertendo a lista
    list2.reverse()
    if(list1 == list2):
        return True
    else:
        return False

# Neste caso qualquer valor entra porém o maior valor sai primeiro
def PriorityQueue(list1, list2):
    # Ordenando de forma decrescente
    list1.sort(reverse = True)
    if(list1[0] == list2[0]):
        return True
    else:
        return False


# PARTE PRINCIPAL
# ->> TODO: CRIAR UMA FORMA DE VERIFICAR OS CASOS impossible e not sure
def CheckDataStructure(list1, list2):
    pass


while(True):
    n = int(input())

    if(n == 0):
        break

    addList = []
    removeList = []

    if(1 <= n <= 1000):
        for i in range(n):
            # Lê 2 inputs ao mesmo tempo e os converte para INT (List Comprehension: https://www.w3schools.com/python/python_lists_comprehension.asp)
            command, x = [int(x) for x in input().split(' ')]
            if(command == 1):
                addList.append(x)
            else:
                removeList.append(x)


