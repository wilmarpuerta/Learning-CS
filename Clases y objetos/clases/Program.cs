﻿using clases.Models;
using clases;

// Imprimir interface
ImprimirInfo imprimirInfo = new ImprimirInfo();
// Objeto de poderes

SuperPoder dinero = new SuperPoder();
dinero.Nombre = "Dinero";
dinero.Descripcion = "El poder del bolsillo :v";
dinero.Nivel = NivelPoder.NivelDos;

SuperPoder condicionFisica = new SuperPoder();
condicionFisica.Nombre = "Condición física al máximo";
condicionFisica.Descripcion = "El poder de entrenar tu cuerpo al maximo";
condicionFisica.Nivel = NivelPoder.NivelDos;

SuperPoder regeneracion = new SuperPoder();
regeneracion.Nombre = "regeneracion";
regeneracion.Descripcion = "El poder de regenerar tu cuerpo";
regeneracion.Nivel = NivelPoder.NivelDos;

// Objeto de heroe
SuperHeroe batman = new SuperHeroe();

batman.Id = 1;
batman.Nombre = "   Batman   ";
batman.IdentidadSecreta = "Bruce Wayne";
batman.Ciudad = "Ciudad Gótica";
batman.PuedeVolar = false;
// Info
imprimirInfo.ImprimirSuperHeroe(batman);
// Creacion de lista de poderes
List<SuperPoder> poderesBatman = new List<SuperPoder>();
poderesBatman.Add(dinero);
poderesBatman.Add(condicionFisica);
batman.SuperPoderes = poderesBatman;
// Llamado de la clase heroe
string salvadoElMundo = batman.SalvarElMundo();
Console.WriteLine(salvadoElMundo);
string salvadoLaTierra = batman.SalvarLaTierra();
Console.WriteLine(salvadoLaTierra);

// Llamado del metodo de la clase
batman.UsarSuperPoder();

// Objeto AntiHeroe

AntiHeroe wolverine = new AntiHeroe();

wolverine.Id = 2;
wolverine.Nombre = "   wolverine   ";
wolverine.IdentidadSecreta = "Logan";
wolverine.PuedeVolar = false;
// Info
imprimirInfo.ImprimirSuperHeroe(wolverine);

List<SuperPoder> poderesWolverine = new List<SuperPoder>();
poderesWolverine.Add(regeneracion);
poderesWolverine.Add(condicionFisica);
wolverine.SuperPoderes = poderesWolverine;
wolverine.UsarSuperPoder();
string accionAntiHeroe = wolverine.RealizarAccionAntiHeroe("Atacar a la policia");
Console.WriteLine(accionAntiHeroe);

string salvarLaTierra = wolverine.SalvarLaTierra();
Console.WriteLine(salvarLaTierra);