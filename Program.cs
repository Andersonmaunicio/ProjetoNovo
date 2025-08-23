using ExemploExplorando.Models; // Importando o nameSpace
using System.Globalization;
using Models;
using Newtonsoft.Json;

DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);


string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);




























// int numero = 20;
// bool ehPar = false;


// //IF Ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar" ));


// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é impar");
// }






















// Pessoa p1 = new Pessoa("Anderson", "Lima");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} + {sobrenome}");























// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, _) =  arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // _ Utilizado apra discartar informação que não usa

// if (sucesso)
// {
//     //Console.WriteLine("Quantidade linhas do arquivo:" + QuantidadeLinhas);
//     foreach (string linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possível ler o arquivo");
// }




















// (int, string, string, decimal) tupla = (1, "Anderson", "Lima", 1.80M); // Maneira mais recomendada criar tupla

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Anderson", "Lima", 1.80M); // Outra forma criar tupla sem nomear objeto
// // var outroExemploTuplaCreate = Tuple.Create(1, "Anderson", "Lima", 1.80M); // Outra forma criar tupla sem nomear objeto

// Console.WriteLine($"Id: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}");























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("PE", "Pernambuco");
// estados.Add("SP", "São Paulo");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine(estados["MG"]); // Busca por 1 estado

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("---------------------------");

// estados.Remove("SP");
// estados["PE"] = "Pernambuco - valor alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "SP"; 
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Não existe. É seguro adicionar a chave: {chave}");
// }

















// Stack<int> pilha = new Stack<int>();
// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }






















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item); // Mostra a fila
// }

// Console.WriteLine ($"Removendo o elemento: {fila.Dequeue()}"); // Remove o primeiro elemento
// fila.Enqueue(10); // Acrescenta a fila
// foreach (int item in fila) // Reimprime a fila
// {
//     Console.WriteLine(item);
// }











// new ExemploExcecao().Metodo1();



























// try // Tenta executar o código a baixo com possível erro
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }

// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Arquivo não encontrado. {ex.Message}"); // Erro Não encontra o arquivo
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro de leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}"); // Erro de caminho da pasta
// }

// catch (Exception ex) // Apresenta a imagem a baixo, em caso de exception
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui"); // Processo executado Independente de erros
// }




























// string dataString = "2025-08-22 10:00";

// bool sucesso = DateTime.TryParseExact(dataString, // Se verdadeiro converte
//                      "yyyy-MM-dd HH:mm", // Formato esperado
//                      CultureInfo.InvariantCulture, // Padroniza de acordo com a cultura do país informada
//                      DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! Data: {data}"); // Caso verdadeiro Apresenta essa mensagem
// }
// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida"); // Apresenta essa mensagem caso seja falso
// }

























// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2")); // C2 indica duas casas decimais

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); // Porcentagem


// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##")); // Casas decimais



















// string numero1 = "10"; //resultado Concatenação
// string numero2 = "20"; //resultado Concatenação


// // int numero1 = "10"; // Resultado adição
// // int numero2 = "20"; // Resultado adição

// // string numero1 = "10"; //resultado Concatenação
// // // int numero2 = "20"; //resultado Concatenação

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);

















// Pessoa p1 = new Pessoa(nome: "Ameno", sobrenome: "Lima");
// Pessoa p2 = new Pessoa(nome: "Ronar", sobrenome: "Nascimento");

// Curso cursoDeingles = new Curso();
// cursoDeingles.Nome = "Inglês";
// cursoDeingles.Alunos = new List<Pessoa>();

// cursoDeingles.AdicionarAluno(p1);
// cursoDeingles.AdicionarAluno(p2);
// cursoDeingles.ListarAlunos();








// Pessoa p1 = new Pessoa();
// p1.Nome = "Ameno";
// p1.SobreNome = "Lima";
// p1.Idade = 33;
// p1.Apresentar();