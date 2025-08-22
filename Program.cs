using ExemploExplorando.Models; // Importando o nameSpace
using System.Globalization;

new ExemploExcecao().Metodo1();



























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