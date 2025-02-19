// See https://aka.ms/new-console-template for more information 
// Soma dos números pares de 1 a 100
soma = 0
for i in range(1, 101):
    if i % 2 == 0:
        soma += i
print("A soma dos números pares de 1 a 100 é:", soma)

//Contagem regressiva de 10 a 1
for i in range(10, 0, -1):
    print(i)
print("Decolagem!")

//Contagem de vogais em uma palavra
palavra = input("Digite uma palavra: ")
vogais = "aeiouAEIOU"
contador = 0
for letra in palavra:
    if letra in vogais:
        contador += 1
print("O número de vogais na palavra é:", contador)

//Verificação de palíndromo
texto = input("Digite uma palavra ou frase: ")
texto_limpo = texto.replace(" ", "").lower()
if texto_limpo == texto_limpo[::-1]:
    print("É um palíndromo!")
else:
    print("Não é um palíndromo.")

//Jogo de adivinhação
import random

numero_secreto = random.randint(1, 100)
tentativas = 0

while True:
    tentativa = int(input("Adivinhe o número entre 1 e 100: "))
    tentativas += 1
    if tentativa < numero_secreto:
        print("O número é maior.")
    elif tentativa > numero_secreto:
        print("O número é menor.")
    else:
        print(f"Parabéns! Você acertou o número em {tentativas} tentativas.")
        break