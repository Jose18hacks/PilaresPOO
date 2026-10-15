using PilaresPOO;

//Carro carro1 = new Carro("Hyundai", "HB20");

//Console.WriteLine(carro1.Marca);
//Console.WriteLine(carro1.Modelo);

//Metodo construtor - Obriga o objeto a ser criado de uma forma
//Pilares da POO

//Evitar estados inválidos

//ContaBancaria conta1 = new ContaBancaria();

//conta1.Saldo = -500;
//conta1.Saldo = 99999999;

//Livro livro = new Livro("1984", "George Owell", 232);

//livro.Exibir();

//Viagem v1 = new Viagem("Paris", 5, 200);
//Viagem v2 = new Viagem("Gramado", 3, 350);

//v1.Exibir();
//Console.WriteLine("============================");
//v2.Exibir();

//Contato c1 = new Contato("Ana", "(11) 99999-0000", "ana@email.com");
//Contato c2 = new Contato("Bruno", "(21) 98888-1111");

//c1.Exibir();
//c2.Exibir();

//ContadorDeVisitas contador = new ContadorDeVisitas();

//contador.RegistrarVisita();
//contador.RegistrarVisita();
//contador.RegistrarVisita();

//Console.WriteLine($"Total de visitas: {contador.ObterTotal()}");

Usuario usuario = new Usuario("ana123", "segredo");

Console.WriteLine(usuario.ConferirSenha("1234"));
Console.WriteLine(usuario.ConferirSenha("segredo"));

usuario.TrocarSenha("errada", "novaSenha");
usuario.TrocarSenha("segredo", "novaSenha");

Console.WriteLine(usuario.ConferirSenha("novaSenha"));