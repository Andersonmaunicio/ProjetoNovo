using ExemploExplorando.Models; // Importando o nameSpace


Pessoa p1 = new Pessoa();
p1.Nome = "Ameno";
p1.SobreNome = "Lima";

Pessoa p2 = new Pessoa();
p2.Nome = "Robson";
p2.SobreNome = "Nascimento";


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