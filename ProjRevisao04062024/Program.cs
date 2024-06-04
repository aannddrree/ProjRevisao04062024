using ProjRevisao04062024.Models;

Console.WriteLine("Hello, World!");

//RevisaoFuncoesBasicas fb = RevisaoFuncoesBasicas.GetInstance();


Terra terra = new Terra() { Id = 1, Nome = "Terra" };
Saturno saturno = new Saturno() { Id = 2, Nome = "Saturno" };

terra.rotacao(100);
terra.translacao(200);

saturno.translacao(100);
saturno.rotacao(50);

Console.WriteLine(saturno.ToString());
Console.WriteLine(terra.ToString());
