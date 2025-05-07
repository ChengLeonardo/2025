// See https://aka.ms/new-console-template for more information
using Biblioteca;
Habilidad tirarFuego = new Habilidad("Tira fuego por la boca", 45, "Tira Fuego");
Habilidad tirarTormenta = new Habilidad("Tira tormenta por la nariz", 34, "Tira Tormenta");
Habilidad tiraHielo = new Habilidad("Tira hielo con temperatura -257 con la mano", 78, "Tira Hielo");
Pelea Kaiju1 = new Kaiju(new List<Habilidad>{tiraHielo, tirarFuego, tirarTormenta}, new Categoria(1, 34, 34, 43), ETamanio.Chico);
Pelea Kaiju2 = new Kaiju(new List<Habilidad>{tiraHielo, tirarFuego}, new Categoria(1, 34, 34, 43), ETamanio.Grande);

System.Console.WriteLine(Kaiju1.GetPoderPelea());
System.Console.WriteLine(Kaiju2.GetPoderPelea());

bool gano = Kaiju2.Pelear(Kaiju1);

System.Console.WriteLine(gano);