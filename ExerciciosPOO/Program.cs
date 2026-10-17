using ExerciciosPOO.Heranca;
using ExerciciosPOO.Heranca.Exercicio1;
using ExerciciosPOO.Heranca.Exercicio2;
using ExerciciosPOO.Heranca.Exercicio3;
using ExerciciosPOO.Lista1_ClassesObjetos.INTERMEDIARIO.Exercicio1;
using ExerciciosPOO.Polimorfismo.Exercicio1;
using ExerciciosPOO.Polimorfismo.Exercicio2;
using ExerciciosPOO.Polimorfismo.Exercicio3;
using PilaresPOO;
using POOFundamentos;
using System.Diagnostics.Metrics;




//Classes e Objetos





//#### 🙋 Exercício 1: Pessoa

//Crie a classe `Pessoa` com:

//-Atributos: `Nome` e `Idade`.
//- Método `Apresentar()`, que mostra uma frase de apresentação.

//Crie **dois objetos** diferentes e chame `Apresentar()` em cada um.

//Pessoa p1 = new Pessoa();
//p1.Nome = "Ana";
//p1.Idade = 25;
//p1.Apresentar();

//Pessoa p2 = new Pessoa();
//p2.Nome = "Bruno";
//p2.Idade = 31;
//p2.Apresentar();





//#### 📐 Exercício 2: Retângulo

//Crie a classe `Retangulo` com:

//-Atributos: `Largura` e `Altura` (números com casas decimais).
//- Método `CalcularArea()`, que **retorna * *a área (largura × altura).
//- Método `CalcularPerimetro()`, que **retorna * *o perímetro (2 × (largura + altura)).

//Os métodos não devem usar `Console.WriteLine`: quem mostra o resultado é o `Program.cs`.




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





//#### 🏦 Exercício 4: Conta Bancária

//Crie a classe `ContaBancaria` com:

//-Atributos: `Titular` (texto) e `Saldo` (número com centavos).
//- Método `Depositar(double valor)`: soma o valor ao saldo.
//- Método `Sacar(double valor)`: só tira o dinheiro se houver saldo suficiente. Se não houver, mostra uma mensagem e o saldo não muda.
//- Método `ExibirSaldo()`.

ContaBancaria conta = new ContaBancaria();

conta.Titular = "José";
conta.Saldo = 300;
double deposito = conta.Depositar(500);
Console.WriteLine($"Depósito de R$ {deposito:F2} realizado");
double saque = conta.Sacar(200);
Console.WriteLine($"Saque de R$ {saque:F2} realizado");
conta.Sacar(1000);
conta.ExibirSaldo();




//Metodo Construtor





//### 📖 Exercício 1: Livro

//Crie a classe `Livro` com:

//-Atributos: `Titulo`, `Autor` e `Paginas`.
//- Um **construtor** que recebe os três valores.
//- Método `Exibir()`, que mostra os dados do livro.



//Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 256);
//Livro livro2 = new Livro("O Hobbit", "J. R. R. Tolkien", 336);

//livro1.Exibir();
//Console.WriteLine();
//livro2.Exibir();





//### ✈️ Exercício 2: Viagem

//Crie a classe `Viagem` com:

//-Atributos: `Destino` (texto), `Dias` (inteiro) e `ValorDiaria` (número com centavos).
//- Um **construtor** que recebe os três valores.
//- Método `CalcularTotal()`, que **retorna * *Dias × ValorDiaria.
//- Método `Exibir()`, que mostra a viagem usando o `CalcularTotal()`.

//Viagem v1 = new Viagem("Paris", 5, 200);
//Viagem v2 = new Viagem("Gramado", 3, 350);

//v1.Exibir();
//Console.WriteLine("============================");
//v2.Exibir();




//### 📇 Exercício 3: Contato (dois métodos construtor)

//Crie a classe `Contato` com:

//-Atributos: `Nome`, `Telefone` e `Email`.
//- **Construtor 1:**recebe nome, telefone e e-mail.
//- **Construtor 2:**recebe só nome e telefone. Nesse caso, o `Email` fica "não informado".
//- Método `Exibir()`, que mostra os três dados.

//Contato c1 = new Contato("Ana", "(11) 99999-0000", "ana@email.com");
//Contato c2 = new Contato("Bruno", "(21) 98888-1111");

//c1.Exibir();
//c2.Exibir();











//Encapsulamento





//### 👀 Exercício 1: Contador de Visitas

//Crie a classe `ContadorDeVisitas` com:

//-Campo `private int visitas` (ninguém de fora pode mexer).
//- Método público `RegistrarVisita()`: soma 1 às visitas.
//- Método público `ObterTotal()`: **retorna * *o total de visitas.


//ContadorDeVisitas contador = new ContadorDeVisitas();

//contador.RegistrarVisita();
//contador.RegistrarVisita();
//contador.RegistrarVisita();

//Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");



//### 📝 Exercício 2: Boletim

//Crie a classe `Boletim` com:

//-Propriedade pública `Aluno`: `public string Aluno { get; set; }`
//-Campo `private double nota`.
//-Método público `DefinirNota(double valor)`: só aceita notas de 0 a 10.
//Fora disso, mostra "Nota inválida: {valor}" e não altera a nota.
//- Método público `ObterNota()`: **retorna * *a nota.

//Boletim boletim = new Boletim();
//boletim.Aluno = "Ana";

//boletim.DefinirNota(8.5);
//boletim.DefinirNota(15);

//Console.WriteLine($"{boletim.Aluno}: nota {boletim.ObterNota()}");




//### 🔑 Exercício 3: Usuário

//Crie a classe `Usuario` com:

//-Propriedade pública `Login`.
//- Campo `private string senha`.
//-Um * *construtor * *que recebe login e senha.
//- Método público `ConferirSenha(string tentativa)`: **retorna * * `true` se a tentativa for igual à senha.
//- Método público `TrocarSenha(string senhaAtual, string novaSenha)`: só troca se a senha 
//atual estiver correta. Mostra "Senha alterada!" ou "Senha atual incorreta.".

//Usuario usuario = new Usuario("ana123", "segredo");

//Console.WriteLine(usuario.ConferirSenha("1234"));
//Console.WriteLine(usuario.ConferirSenha("segredo"));

//usuario.TrocarSenha("errada", "novaSenha");
//usuario.TrocarSenha("segredo", "novaSenha");

//Console.WriteLine(usuario.ConferirSenha("novaSenha"));





//Herança





//### 🐶 Exercício 1: Animal e Cachorro

//Crie as classes:

//- `Animal` (classe pai): propriedade `Nome` e método `Comer()`, que mostra "{Nome} está comendo.".
//- `Cachorro` (classe filha de `Animal`): método `Latir()`, que mostra "{Nome}: Au au!".

//O `Cachorro` **não** deve declarar `Nome` nem `Comer()`: ele herda do `Animal`.

//Cachorro cachorro = new Cachorro();
//cachorro.Nome = "Rex";

//cachorro.Comer();
//cachorro.Latir();




//### 💼 Exercício 2: Funcionário e Gerente

//Crie as classes:

//- `Funcionario` (classe pai): propriedades `Nome` e `Salario`, e um **construtor** que recebe as duas.
//- `Gerente` (filha de `Funcionario`): propriedade `Bonus`, 
//    construtor que recebe nome, salário e bônus, e o método `SalarioComBonus()`, que **retorna** Salario + Bonus.

//Funcionario ana = new Funcionario("Ana", 3000);
//Gerente carlos = new Gerente("Carlos", 5000, 1500);

//Console.WriteLine($"{ana.Nome}: R$ {ana.Salario:F2}");
//Console.WriteLine($"{carlos.Nome}: R$ {carlos.Salario:F2} + bônus = R$ {carlos.SalarioComBonus():F2}");





//### 🚗 Exercício 3: Veículo, Carro e Moto

//Crie as classes:

//- `Veiculo` (classe pai): propriedades `Marca` e `Modelo`, 
//    um **construtor * *que recebe as duas e o método `Exibir()`, que mostra "{Marca} {Modelo}".
//- `Carro` (filha de `Veiculo`): propriedade `Portas`, construtor que recebe marca, modelo e portas, e o método `ExibirPortas()`.
//- `Moto` (filha de `Veiculo`): propriedade `Cilindradas`, construtor que recebe marca, modelo e cilindradas, e o 
//    método `ExibirCilindradas()`.

//Carro carro = new Carro("Fiat", "Uno", 4);
//Moto moto = new Moto("Honda", "CG 160", 160);

//carro.Exibir();
//carro.ExibirPortas();

//Console.WriteLine();

//moto.Exibir();
//moto.ExibirCilindradas();





//Polimorfismo





//### 👋 Exercício 1: Saudação

//Crie a classe `Saudacao` com **três versões** do método `Cumprimentar`:

//- `Cumprimentar()`: mostra "Olá!".
//- `Cumprimentar(string nome)`: mostra "Olá, {nome}!".
//- `Cumprimentar(string nome, int idade)`: mostra "Olá, {nome}! Você tem {idade} anos.".

//Saudacao s = new Saudacao();

//s.Cumprimentar();
//s.Cumprimentar("Ana");
//s.Cumprimentar("Bruno", 25);





//### 📐 Exercício 2: Calculadora de Área

//Crie a classe `CalculadoraDeArea` com duas versões do método `CalcularArea`:

//- `CalcularArea(double lado)`: **retorna * *a área do quadrado (lado × lado).
//- `CalcularArea(double largura, double altura)`: **retorna * *a área do retângulo (largura × altura).

//CalculadoraDeArea calc = new CalculadoraDeArea();

//Console.WriteLine($"Quadrado: {calc.CalcularArea(4)}");
//Console.WriteLine($"Retângulo: {calc.CalcularArea(3, 5)}");





//### 🎸 Exercício 3: Instrumento e Violão (sobrescrita)

//Crie as classes:

//- `Instrumento` (classe pai): método `virtual` `Tocar()`, que mostra "Tocando um instrumento...".
//- `Violao` (filha de `Instrumento`): **sobrescreve * * `Tocar()` para mostrar "Violão: plim plim".

//Instrumento instrumento = new Instrumento();
//Violao violao = new Violao();

//instrumento.Tocar();
//violao.Tocar();