# Questão: https://www.urionlinejudge.com.br/judge/en/problems/view/1159

while True: # O loop infinito foi criado para ler inúmeras vezes a variável x
    x = int(input())
    if x == 0: # Caso o usuário coloque zero, o loop quebra e termina o programa
        break
    i = 0 # Contador de números pares
    j = x # Cópia de x criada para não alterarmos diretamente o x
    soma = 0
    while i < 5: # O loop só quebra quando conseguirmos achar os 5 pares consecutivos
        if j % 2 == 0:
            soma += j
            i += 1
            j += 1
        else:
            j += 1
    print(soma)
