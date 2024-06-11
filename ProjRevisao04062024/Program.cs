using Controllers;
using ProjRevisao04062024.Models;

Console.WriteLine("Hello, World!");

//RevisaoFuncoesBasicas fb = RevisaoFuncoesBasicas.GetInstance();
/*

Terra terra = new Terra() { Id = 1, Nome = "Terra" };
Saturno saturno = new Saturno() { Id = 2, Nome = "Saturno" };

terra.rotacao(100);
terra.translacao(200);
terra.QtdPopulacao = 1000;

saturno.translacao(100);
saturno.rotacao(50);

Console.WriteLine(saturno.ToString());
Console.WriteLine(terra.ToString());

TerraController terraController = new TerraController();

if (terraController.Insert(terra))
{
    Console.WriteLine("Sucesso");
}
else
{
    Console.WriteLine("Erro");
}*/

TerraController controller = new TerraController();
List<Terra> lst = controller.GetAll();

foreach (Terra terra in lst)
{
    Console.WriteLine(terra);   
}

lst.ForEach(terra => Console.WriteLine(terra));