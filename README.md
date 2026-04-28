# Simulador FIRE

Um simulador interativo para calcular quanto tempo você precisa para atingir a Independência Financeira e Aposentadoria Antecipada (FIRE).

## O que é FIRE?

FIRE (Financial Independence, Retire Early) é um movimento financeiro que busca alcançar a independência financeira através de economias, investimentos inteligentes e aumento de patrimônio, permitindo se aposentar mais cedo.

---

## Características

Múltiplos Estilos de FIRE
- FIRE Tradicional (4,0% TSR) - Regra clássica do Trinity Study (1998)
- FIRE Conservador (3,5% TSR) - Margem extra para horizontes longos
- Barista FIRE (4,0% TSR) - Trabalho parcial + meta menor

Validação Robusta de Entrada
- Verifica todos os inputs do usuário
- Previne dados inválidos

Cálculo de Juros Compostos
- Simulação realista de retorno de investimentos
- Cálculo mensal com taxa anual configurável

Resultado Detalhado
- Meta de patrimônio necessário
- Patrimônio final projetado
- Tempo até atingir FIRE (anos e meses)

---

## Como Usar

### Pré-requisitos

- .NET Framework ou .NET Core instalado
- C# compatível com o projeto

### Instalação

1. Clone o repositório
```bash
git clone https://github.com/isaqueschwinn123-stack/Simulador-Fire.git
cd Simulador-Fire
```

2. Compile o projeto
```bash
dotnet build
```

3. Execute o programa
```bash
dotnet run
```

---

## Guia de Uso

Após executar o programa, você será solicitado a inserir os seguintes dados:

### 1. Idade Atual
```
Idade atual: 
30
```
- Aceita números inteiros de 1 a 100

### 2. Patrimônio Atual
```
Patrimonio: 
50000
```
- Seu patrimônio/investimentos atuais
- Aceita números decimais (use ponto como separador)

### 3. Aportes Mensais
```
Aportes Mensais: 
2000
```
- Quanto você consegue economizar por mês
- Valores maiores = FIRE mais rápido

### 4. Retorno Anual Esperado
```
Retorno Anual EX 4 para 4%: 
7
```
- Digite apenas o número (7 para 7% ao ano)
- Baseado em histórico de retorno de investimentos

### 5. Salário Desejado
```
Salario desejado: 
3000
```
- Renda mensal que você deseja na aposentadoria

### 6. Escolha o Estilo FIRE
```
=== Estilo FIRE ===

[1] FIRE Tradicional  → 4,0% | Regra clássica — Trinity Study (1998)
[2] FIRE Conservador  → 3,5% | Margem extra para horizontes longos
[3] Barista FIRE      → 4,0% | Trabalho parcial + meta menor

Escolha seu estilo (1-3): 
1
```

### Resultado

```
===== RESULTADO FIRE =====
Meta: R$ 900.000,00
Patrimônio final: R$ 950.000,00
Tempo: 15 anos e 3 meses
```

---

## Estrutura do Projeto

```
Simulador-Fire/
├── Program.cs              # Ponto de entrada da aplicação
├── CalculoFIRE.cs         # Lógica principal de cálculo
├── ColetorDeDados.cs      # Interface de coleta de dados do usuário
├── DadosFIRE.cs           # Modelo de dados
├── Projeto.csproj         # Configuração do projeto
└── README.md              # Este arquivo
```

### Descrição dos Arquivos

#### Program.cs
Ponto de entrada do programa. Chama o cálculo FIRE e exibe os resultados formatados.

#### CalculoFIRE.cs
Contém a lógica principal:
- Cálculo da meta de patrimônio baseada na TSR
- Simulação de crescimento com juros compostos
- Retorna meta, patrimônio final e meses

#### ColetorDeDados.cs
Interface para coleta de dados:
- Validação de cada entrada do usuário
- Mensagens de erro intuitivas
- Conversão de tipos (string → int/decimal)

#### DadosFIRE.cs
Modelo de dados que armazena:
- Idade, Patrimônio, Aportes mensais
- Retorno anual, Salário desejado
- Estilo FIRE escolhido

---

## Fórmulas Utilizadas

### Taxa de Retirada Segura (TSR)
```
Meta = (Salário Desejado × 12) / TSR
```
- Garante que o patrimônio renda o salário desejado indefinidamente

### Retorno Mensal
```
Retorno Mensal = (1 + Retorno Anual)^(1/12) - 1
```

### Crescimento do Patrimônio
```
Patrimônio(n+1) = Patrimônio(n) × (1 + Retorno Mensal) + Aporte Mensal
```

---

## Exemplos de Cenários

### Cenário 1: Conservador
```
Idade: 25
Patrimônio: R$ 10.000
Aportes: R$ 1.500/mês
Retorno: 6% a.a.
Salário desejado: R$ 2.000/mês
Estilo: FIRE Conservador (3,5%)

Resultado: ~30 anos e 6 meses
```

### Cenário 2: Agressivo
```
Idade: 30
Patrimônio: R$ 50.000
Aportes: R$ 5.000/mês
Retorno: 8% a.a.
Salário desejado: R$ 3.000/mês
Estilo: FIRE Tradicional (4,0%)

Resultado: ~10 anos
```

---

## Limitações e Considerações

- Limite máximo de 100 anos de simulação (1.200 meses)
- Não considera inflação
- Assume retorno consistente (sem volatilidade)
- Não inclui impostos ou taxas
- Salário desejado é constante (não ajustado por inflação)

---

## Funcionalidades Futuras

- Considerar inflação na projeção
- Adicionar volatilidade de mercado
- Exportar resultado em CSV/PDF
- Interface gráfica (Windows Forms / WPF)
- Salvar múltiplos cenários
- Comparação entre estilos FIRE
- Integração com APIs de cotações

---

## Autor

isaqueschwinn123-stack

---

## Licença

Este projeto está disponível sem restrições de licença específica.

---

## Contribuições

Sugestões e melhorias são bem-vindas! Sinta-se à vontade para:
- Reportar bugs
- Sugerir novas funcionalidades
- Enviar pull requests

---

## Referências

- Trinity Study (1998) - Base para a regra dos 4%
- FIRE Movement
- Documentação C#

---

Comece sua jornada para a independência financeira!
