#Questão: https://www.urionlinejudge.com.br/judge/en/problems/view/1160

T = int(input()) # Número de casos testes

for i in range(T):
    valores = input().split(" ") # Cada valor da linha vai para um índice da lista "valores"
    PA, PB, G1, G2 = valores # Cada um dos 4 índices vai respectivamente para as variáveis na ordem que foi colocada
    ano = 0 # Contador da quantidade danos para popA > popB
    popA = int(PA)    
    popB = int(PB)
    chaveSeculo = False  # Booleana para caso seja mais de 100 anos  
    while popA <= popB: # Tem que ser igual também pois queremos ultrapassar a contagem de popB
        # As taxas G1 e G2 devem ser dividas por 100 pois são porcentagens
        popA += popA*(float(G1) / 100)
        popA = int(popA)  # Devemos converter o valor de volta para inteiro para somarmos no proximo loop                  
        popB += popB*(float(G2) / 100)
        popB = int(popB)                
        ano += 1
        if ano > 100:
            seculo = ano / 100
            print("Mais de {} seculo.".format(int(seculo)))
            chaveSeculo = True
            break # O problema informou que não precisamos calcular caso seja mais de 100 anos 
    if chaveSeculo == False:
        print(ano,"anos.")