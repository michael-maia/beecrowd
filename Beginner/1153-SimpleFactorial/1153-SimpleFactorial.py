N = int(input())
fatorial = 1 # Nao pode ser zero pois se não todo o fatorial vai ser zero

for i in range(N):
    fatorial *= (N - i)

print(fatorial)
