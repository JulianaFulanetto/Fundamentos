using FundamentosOO;

internal class Program
{
    private static void Main(string[] args)
    {
        //instanciar um obj do tipo aluno
        Alunos aluno1 = new Alunos();
        Alunos aluno2 = new Alunos();
        Alunos aluno3 = new Alunos();

        //preencher os atributos do obj
        aluno1.Nome = "Juliana Maria Fulanetto";
        aluno1.RM = 1234;
        aluno1.Email = "julianamfulanetto@gmail.com";
        aluno1.Nascimento = new DateOnly(2008, 01, 15);

        aluno2.Nome = "Maysa Silva Rondon";
        aluno2.RM = 4455;
        aluno2.Email = "maysarondon@gmail.com";
        aluno2.Nascimento = new DateOnly(2008, 06, 07);


        aluno3.Nome = "Lorena de Almeida Victor";
        aluno3.RM = 0501;
        aluno3.Email = "lorenaalmeida@gmail.com";
        aluno3.Nascimento = new DateOnly(2008, 02, 12);

        //imprimir na tela
        Console.WriteLine("Aluno 1");
        Console.WriteLine("Nome:" + aluno1.Nome);
        Console.WriteLine("RM: " + aluno1.RM);
        Console.WriteLine("Email: " + aluno1.Email);
        Console.WriteLine("==========================");

        Console.WriteLine("Aluno 2");
        Console.WriteLine("Nome:" + aluno2.Nome);
        Console.WriteLine("RM: " + aluno2.RM);
        Console.WriteLine("Email: " + aluno2.Email);

        Console.WriteLine("==========================");
        Console.WriteLine("Aluno 3");
        Console.WriteLine("Nome:" + aluno2.Nome);
        Console.WriteLine("RM: " + aluno3.RM);
        Console.WriteLine("Email: " + aluno3.Email);
        Console.WriteLine("==========================");
        //--------------------------------------------------------------------
        Console.WriteLine();
        //instancionar um obj do tipo produto
        Produto p1 = new Produto();
        p1.Codigo = 12345;
        p1.Nome = "Coca-Cola 2 Litros";
        p1.Preco = 12.99;
        p1.Estoque = 96;
        //chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();

        p1.Estoque = 85;
        //chamar o metodo QuantidadeEstoque
        p1.QuantidadeEstoque();


        Console.WriteLine("==========================");
        Console.WriteLine();

        //instanciar um obj do tipo carro
        Carro carro1 = new Carro();
        carro1.Marca = "Ferrari";
        carro1.Modelo = "488";
        carro1.Velocidade = 0;

        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Acelerar();
        carro1.Desacelerar();


        Console.WriteLine("==========================");
        Console.WriteLine();
        Pessoa pessoa1 = new Pessoa();
        pessoa1.Nome = "Robson";
        pessoa1.Idade = 98;

        Console.WriteLine("Nome:" + pessoa1.Nome);
        Console.WriteLine("Idade:" + pessoa1.Idade);
        pessoa1.Envelhecer(10);

        Console.WriteLine("==========================");
        Console.WriteLine();

        Funcionario func1 = new Funcionario();
        func1.Nome = "Rogerinho";
        func1.Idade = 24;
        func1.Cargo = "Arquiteto";
        func1.Salario = 5009;

        func1.ApresentarSe();

        Console.WriteLine("==========================");
        Console.WriteLine();
        //insrindo obj
        //Animal animal1 = new Animal();

        ////inserindo dados no atributo
        //animal1.Especie = "Cachorro";

        ////chamando o metodo do obj
        //animal1.emitirSom();

        ////imprimindo a informação na tela
        //Console.WriteLine("O animal " + animal1.Especie + " emitiu um som");

        Gato gato1 = new Gato();
        gato1.Nome = "Loki";

        Console.WriteLine(gato1.Nome + " faz: ");
        gato1.emitirSom();

        Console.WriteLine();

        Porco porco1 = new Porco();
        porco1.Nome = "Rabicó";

        Console.WriteLine(porco1.Nome + " faz: ");
        porco1.emitirSom();

        Console.WriteLine();

        Galinha galinha1 = new Galinha();
        galinha1.Nome = "Galinheta";

        Console.WriteLine(galinha1.Nome + " faz: ");
        galinha1.emitirSom();

        Console.WriteLine("==========================");
        Console.WriteLine();

        Personagem personagem1 = new Personagem();
        personagem1.Nome = "Sypha Belnades";
        personagem1.Categoria = "Maga";
        personagem1.Nivel = 85;
        personagem1.Forca = 60;
        personagem1.Agilidade = 75;
        personagem1.Vida = 70;

    }
}