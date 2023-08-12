using Library.Entities;


Pessoa pessoa = new() { Nome = "Letícia", Sobrenome = "Egle" };
Livro livro = new() { Nome = "Código Limpo", Autor = "Robert Cecil Martin" };
Emprestimo emp = new();

emp.RealizarEmprestimo(pessoa, livro);
emp.DataEmprestimoFinal = DateTime.Now.AddDays(20);

emp.GerarMulta();
emp.GerarValorMulta();



