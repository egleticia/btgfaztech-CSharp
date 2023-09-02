﻿

/*
             * Crie um projeto Cinema
             *  Crie uma classe Filme com Titulo, Ano, Duracao
             *  Crie uma classe Sala com quantidadeCadeiras
             *  Crie uma classe Sessao com private Filme, private Sala e private DataHora
             *  No construtor da Exibicao receba a data e a sala // Injeção de dependencia via construtor
             *  Crie um método para receber o Filme
            */



using Cinema;

Filme filme = new Filme("As Branquelas", 2004, 109);
Sala sala = new Sala{ QuantidadeCadeira = 60, Numero = 2 };
Sessao sessao = new Sessao(sala, new DateTime(2023, 08, 29, 14, 30, 0));
sessao.AdicionaFilme(filme);
Console.WriteLine(sessao);