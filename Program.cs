using ExemploExplorando.Models; // Importando o nameSpace


Pessoa p1 = new Pessoa(nome: "Ameno", sobrenome: "Lima");
Pessoa p2 = new Pessoa(nome: "Ronar", sobrenome: "Nascimento");

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();








// Pessoa p1 = new Pessoa();
// p1.Nome = "Ameno";
// p1.SobreNome = "Lima";
// p1.Idade = 33;
// p1.Apresentar();