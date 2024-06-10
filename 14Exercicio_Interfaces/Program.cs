using _14Exercicio_Interfaces;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarXml1 = new SalvarXml();
salvarXml1.Compactar();

ISalvar salvarJson1 = new SalvarJson();
salvarJson1.Compactar();

Console.ReadKey();
