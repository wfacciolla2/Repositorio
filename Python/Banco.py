from datetime import datetime

status = 0
while status == 0:
    nome, senha = input("nome: "), input("senha: ")

    if (nome == "well" and senha == "123"):
        print("logado")
        status = 1
        continue
    else:
        print("Usuário ou senha inválidos")
        print(status)
    
limite = 500
extrato_final = ""
num_saques = 0
LIM_SAQUE = 3

saldo = 200

transacoes = []

def deposito():
    global saldo
    valor = float(input("Digite o valor do depósito: "))
    if(valor > 0):
        saldo += valor
        data_hora_atual = datetime.now()
        transacoes.append(f"Deposito: {data_hora_atual} Valor: +{valor}")
        print(f"Deposito realizado. Saldo atual: {saldo}\n")
    else:
        print("Erro no processamento\n")

def saque():
    global saldo
    valor = float(input("Digite o valor do saque: "))
    if valor > saldo:
        print("Saldo insuficiente\n")
    else:
        saldo -= valor
        data_hora_atual = datetime.now()
        transacoes.append(f"Saque: {data_hora_atual} Valor: -{valor}")
        print(f"Saque realizado. Saldo atual: {saldo}\n")

def extrato():
    global saldo
    print("Transações:")
    for t in transacoes:
        print(t)
    print(f"Saldo atual: {saldo}")

def sair():
    print("Obrigado, volte sempre!\n")
    global status
    status = 0

if __name__ == "__main__":
    switch = {
        "D": deposito,
        "S": saque,
        "E": extrato,
        "X": sair
    }
    while(status == 1):
        print("MENU:")
        print("[D] - Deposito")
        print("[S] - Saque")
        print("[E] - Ver Extrato")
        print("[X] - Sair")
        opcao = input("Escolha uma opção: \n")
        case = switch.get(opcao.upper(), sair)
        case()