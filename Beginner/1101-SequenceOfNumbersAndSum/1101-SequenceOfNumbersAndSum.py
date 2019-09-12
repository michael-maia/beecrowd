while True: # Para emular o do-while loop
    valores = input().split(" ")
    M, N = map(int, valores) # Para "converter" os valores para int
    if M <= 0 or N <= 0: 
        break # Quebrar o loop infinito
    else:
        if M > N:
            M, N = N, M # Troca um valor pelo outro (só em Python)
        soma = 0
        for i in range(M, N + 1): # N + 1 pois queremos o valor de N no range
            soma += i
            print(i, end = " ") # Para que ao invés de ser \n no final seja " "
        print("Sum={}".format(soma))
        