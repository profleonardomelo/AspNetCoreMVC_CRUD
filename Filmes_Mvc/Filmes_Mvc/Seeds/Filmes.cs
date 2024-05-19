using Filmes_Mvc.Data;
using Filmes_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Filmes_Mvc.Seeds
{
    public static class Filmes
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ContextoBD(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ContextoBD>>()))
            {
                
                if (context.Filme.Any())
                {
                    return;   
                }

                context.Filme.AddRange(
                    new Filme
                    {
                        Titulo = "Matrix",
                        DataDeLancamento = DateTime.Parse("1999-05-21"),
                        Genero = "Ação, Ficção Científica",
                        Preco = 19.97M
                    },
                    new Filme
                    {
                        Titulo = "Duna",
                        DataDeLancamento = DateTime.Parse("2021-10-21"),
                        Genero = "Drama, Ficção Científica",
                        Preco = 29.96M
                    }, 
                    new Filme
                    {
                        Titulo = "Duna 2",
                        DataDeLancamento = DateTime.Parse("2024-02-29"),
                        Genero = "Drama, Ficção Científica",
                        Preco = 49.99M
                    },
                    new Filme
                    {
                        Titulo = "A Origem",
                        DataDeLancamento = DateTime.Parse("2010-07-05"),
                        Genero = "Ação, Ficção Científica",
                        Preco = 25.99M
                    },
                    new Filme
                    {
                        Titulo = "Vanilla Sky",
                        DataDeLancamento = DateTime.Parse("2002-01-25"),
                        Genero = "Thriller, Ficção Científica",
                        Preco = 9.56M
                    },
                    new Filme
                    {
                        Titulo = "O Preço do Amanhã",
                        DataDeLancamento = DateTime.Parse("2011-11-04"),
                        Genero = "Thriller, Ação",
                        Preco = 5.97M
                    },
                    new Filme
                    {
                        Titulo = "O Senhor dos Anéis - O Retorno do Rei",
                        DataDeLancamento = DateTime.Parse("2003-12-25"),
                        Genero = "Aventura, Fantasia",
                        Preco = 5.67M
                    },
                    new Filme
                    {
                        Titulo = "Batman - O Cavaleiro Das Trevas",
                        DataDeLancamento = DateTime.Parse("2008-07-18"),
                        Genero = "Ação, Suspense",
                        Preco = 5.67M
                    },
                    new Filme
                    {
                        Titulo = "A Vida é Bela",
                        DataDeLancamento = DateTime.Parse("1999-02-05"),
                        Genero = "Comédia, Comédia dramática, Drama",
                        Preco = 7.68M
                    },
                    new Filme
                    {
                        Titulo = "Vingadores: Ultimato",
                        DataDeLancamento = DateTime.Parse("2019-04-25"),
                        Genero = "Ação, Aventura, Ficção Científica",
                        Preco = 10.64M
                    },
                    new Filme
                    {
                        Titulo = "Vingadores: Guerra Infinita",
                        DataDeLancamento = DateTime.Parse("2018-04-26"),
                        Genero = "Ação, Aventura, Ficção Científica",
                        Preco = 11.88M
                    },
                    new Filme
                    {
                        Titulo = "De Volta para o Futuro",
                        DataDeLancamento = DateTime.Parse("1985-12-25"),
                        Genero = "Aventura, Comédia, Ficção Científica",
                        Preco = 4.99M
                    },
                    new Filme
                    {
                        Titulo = "O Resgate do Soldado Ryan",
                        DataDeLancamento = DateTime.Parse("1998-09-11"),
                        Genero = "Drama, Guerra",
                        Preco = 10.48M
                    },
                    new Filme
                    {
                        Titulo = "O Senhor dos Anéis - As Duas Torres",
                        DataDeLancamento = DateTime.Parse("2002-12-27"),
                        Genero = "Aventura, Fantasia",
                        Preco = 15.89M
                    },
                    new Filme
                    {
                        Titulo = "O Senhor dos Anéis - A Sociedade do Anel",
                        DataDeLancamento = DateTime.Parse("2002-01-01"),
                        Genero = "Aventura, Fantasia",
                        Preco = 12.58M
                    },
                    new Filme
                    {
                        Titulo = "Interestelar",
                        DataDeLancamento = DateTime.Parse("2014-11-06"),
                        Genero = "Drama, Ficção Científica",
                        Preco = 22.55M
                    },
                    new Filme
                    {
                        Titulo = "Toy Story - Um Mundo de Aventuras",
                        DataDeLancamento = DateTime.Parse("1995-12-22"),
                        Genero = "Animação, Comédia, Família",
                        Preco = 13.28M
                    },
                    new Filme
                    {
                        Titulo = "Divertida Mente",
                        DataDeLancamento = DateTime.Parse("2015-07-15"),
                        Genero = "Animação, Comédia, Família",
                        Preco = 15.75M
                    },
                    new Filme
                    {
                        Titulo = "Top Gun: Maverick",
                        DataDeLancamento = DateTime.Parse("2022-05-26"),
                        Genero = "Ação",
                        Preco = 44.29M
                    },
                    new Filme
                    {
                        Titulo = "O Exterminador do Futuro 2 - O Julgamento Final",
                        DataDeLancamento = DateTime.Parse("1991-08-01"),
                        Genero = "Ação, Ficção Científica",
                        Preco = 16.27M
                    },
                    new Filme
                    {
                        Titulo = "Curtindo a Vida Adoidadoa",
                        DataDeLancamento = DateTime.Parse("1986-12-19"),
                        Genero = "Comédia",
                        Preco = 19.87M
                    },
                    new Filme
                    {
                        Titulo = "Ratatouille",
                        DataDeLancamento = DateTime.Parse("2007-07-06"),
                        Genero = "Animação, Comédia, Família",
                        Preco = 19.78M
                    },
                    new Filme
                    {
                        Titulo = "O Jogo Da Imitação",
                        DataDeLancamento = DateTime.Parse("2015-02-05"),
                        Genero = "Biopic, Drama",
                        Preco = 25.27M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
