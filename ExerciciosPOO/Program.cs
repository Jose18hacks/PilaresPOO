using ExerciciosPOO.Heranca;
using ExerciciosPOO.Heranca.Exercicio1;
using ExerciciosPOO.Heranca.Exercicio2;
using ExerciciosPOO.Heranca.Exercicio3;
using PilaresPOO;
using POOFundamentos;




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