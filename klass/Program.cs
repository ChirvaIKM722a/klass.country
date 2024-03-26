using krainaukrauna1;

krainaukrauna1.krainaukrauna1 country = new krainaukrauna1.krainaukrauna1("Бразилія", "федерація", 218000000, "бразильскій реал", "Бразиліа", "португальска" );

country.DisplayInfo();

country.Updatenasel(300000000);

if (country.ProverkaNaselenia())
{
    Console.WriteLine("Населення стабільне");
    
}
else
{
    Console.WriteLine("Бебі-бум в країні");
}