//Program.cs
//1 Arquivo por projeto

//COMO INSTANCIO UM OBJETO?

//1. Criar classe
//**1 Classe - 1 Arquivo

//2. Defino Atributos

//public TIPO NOME

//3. Defino Metodos
//public RETORNO NOME() { }

//Variavel
//TIPO NOME 
using POOFundamentos;
using static System.Runtime.InteropServices.JavaScript.JSType;

//Instanciar
//Carros carroZe = new Carros();

//carroZe.Modelo = "Onix";
//carroZe.Marca = "Chevrolet";
//carroZe.Ano = 2018;
//carroZe.ExibirInformacoes();

//Console.WriteLine();

//Carros carroBB = new();

//carroBB.Modelo = "Uno";
//carroBB.Marca = "Fiat";
//carroBB.Ano = 2006;
//carroBB.ExibirInformacoes();

//Console.WriteLine();

////Objetos
//Pedido ordem1 = new Pedido();

//ordem1.Item = "Hamburguer";
//ordem1.Quantidade = 3;
//ordem1.Preco = 31.32;
//ordem1.NomeDoCliente = "João";

//Console.WriteLine(ordem1.Item);
//Console.WriteLine(ordem1.Quantidade);
//Console.WriteLine(ordem1.Preco);
//Console.WriteLine(ordem1.NomeDoCliente);



//// Classe Pedido
//// NomeDoCliente, Item, Quantidade, Preco
//// Objetos
//Pedido pedido1 = new Pedido();

////string item = "X-Burguer";
////pedido1.Item = "X-Burguer";

//Console.WriteLine("Digite o nome do item: ");
//pedido1.Item = Console.ReadLine();

//Console.WriteLine("Digite o nome do cliente: ");
//pedido1.NomeDoCliente = Console.ReadLine();

//Console.WriteLine("Digite a quantidade: ");
//pedido1.Quantidade = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o preco: ");
//pedido1.Preco = double.Parse(Console.ReadLine());

//Console.WriteLine(pedido1.Quantidade);
//Console.WriteLine(pedido1.Preco);
//Console.WriteLine(pedido1.NomeDoCliente);
//Console.WriteLine(pedido1.Item);





//LISTA 1
//EXERCICIOS POO



//NIVEL 1 FACIL


//### 🙋 Exercício 1: Pessoa

//Crie a classe `Pessoa` com:

//-Atributos: `Nome` e `Idade`.
//- Método `Apresentar()`, que mostra uma frase de apresentação.

//Crie **dois objetos** diferentes e chame `Apresentar()` em cada um.

//**Saída esperada:**

//```
//Olá, meu nome é Ana e tenho 25 anos.
//Olá, meu nome é Bruno e tenho 31 anos.
//```

//Pessoa ser1 = new Pessoa();

//ser1.Nome = "José";
//ser1.Idade = 18;
//ser1.Apresentar();

//Pessoa ser2 = new Pessoa();

//ser2.Nome = "Maria";
//ser2.Idade = 19;
//ser2.Apresentar();





//### 📐 Exercício 2: Retângulo

//Crie a classe `Retangulo` com:

//- Atributos: `Largura` e `Altura` (números com casas decimais).
//- Método `CalcularArea()`, que **retorna * *a área (largura × altura).
//- Método `CalcularPerimetro()`, que **retorna * *o perímetro (2 × (largura + altura)).

//Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.

//**Saída esperada** (largura 5, altura 3):

//```
//Área: 15
//Perímetro: 16
//```

//< aside >
//💡

//**Dica:**método com retorno usa o tipo no lugar de `void`: `public double CalcularArea() { return ...; }`

//Retangulo retangulo = new Retangulo();

//retangulo.Altura = 3;
//retangulo.Largura = 5;

//Console.WriteLine($"Largura: {retangulo.Largura}, Altura: {retangulo.Altura}");
//Console.WriteLine();
//Console.WriteLine($"Area: {retangulo.CalcularArea()}");
//Console.WriteLine($"Perimetro: {retangulo.CalcularPerimetro()}");





//### 💡 Exercício 3: Lâmpada

//Crie a classe `Lampada` com:

//-Atributo: `Ligada` (`bool`).
//- Métodos: `Ligar()`, `Desligar()`, `Alternar()` (se está ligada, desliga; se está desligada, liga) e `ExibirEstado()`.

//Crie uma lâmpada e chame, nesta ordem: `ExibirEstado()`, `Ligar()`, `ExibirEstado()`, `Alternar()`, `ExibirEstado()`.

//**Saída esperada: **

//```
//A lâmpada está desligada.
//A lâmpada está ligada.
//A lâmpada está desligada.
//```

//Lampada lampada = new Lampada();

//lampada.ExibirEstado();

//lampada.Ligar();
//lampada.ExibirEstado();

//lampada.Alternar();
//lampada.ExibirEstado();






//NIVEL 2 INTERMEDIARIO






//### 🏦 Exercício 4: Conta Bancária

//Crie a classe `ContaBancaria` com:

//-Atributos: `Titular` (texto) e `Saldo` (número com centavos).
//- Método `Depositar(double valor)`: soma o valor ao saldo.
//- Método `Sacar(double valor)`: só tira o dinheiro se 
//    houver saldo suficiente. Se não houver, mostra uma mensagem e
//    o saldo não muda.
//- Método `ExibirSaldo()`.

//Teste: depositar 500, sacar 200, tentar sacar 1000 e exibir o saldo.

//**Saída esperada:**

//```
//Depósito de R$ 500,00 realizado.
//Saque de R$ 200,00 realizado.
//Saldo insuficiente para sacar R$ 1000,00.
//Saldo de Ana: R$ 300,00
//```

//ContaBancaria conta = new ContaBancaria();

//conta.Titular = "José";

//conta.Saldo = 300;

//double deposito = conta.Depositar(500);
//Console.WriteLine($"Depósito de R$ {deposito:F2} realizado");

//double saque = conta.Sacar(200);
//Console.WriteLine($"Saque de R$ {saque:F2} realizado");

//conta.Sacar(1000);

//conta.ExibirSaldo();







//LISTA 2
//NIVEL 1 FACIL







//### 👋 Exercício 1: Saudação

//Crie a classe `Pessoa` com o atributo `Nome` e os métodos abaixo.

//| Método | Retorno | O que faz |
//| --- | --- | --- |
//| `Cumprimentar()` | `void` | Mostra: Olá, eu sou {Nome}! |
//| `CumprimentarAlguem(string outraPessoa)` | `void` | Mostra: Olá, {outraPessoa}!Eu sou {Nome}. |
//| `ObterApresentacao()` | `string` | **Retorna** o texto: Meu nome é {Nome}. (não mostra na tela) |

//**Use assim no Program.cs:**

//```csharp
//Pessoa ana = new Pessoa();
//ana.Nome = "Ana";

//ana.Cumprimentar();
//ana.CumprimentarAlguem("Bruno");

//string frase = ana.ObterApresentacao();
//Console.WriteLine(frase);
//```
Pessoa2 ana = new Pessoa2();

ana.Nome = "Ana";

ana.Cumprimentar();
ana.CumprimentarAlguem("Bruno");

string frase = ana.ObterApresentacao();
Console.WriteLine(frase);