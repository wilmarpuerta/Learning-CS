﻿
// Hola mundo en c#

Console.WriteLine("Hello world");

// Tipos de valiables

string name = "wilmar"; // Cadena de caracteres
int age = 20; // entero
double height = 1.75; // decimal
//bool girlfriend = false; // booleano

Console.WriteLine($"Hola me llamo {name} y tengo {age} años, mido {height} y estos son mis primeros pasos en C#");

// Entrada de datos

string inputName;
Console.WriteLine("Ingrese su nombre:");
inputName = Console.ReadLine();

Console.WriteLine($"Hola {inputName}, Bienvenido a mi programa :)");


// Operadores relacionales

/*
== Igual a
!= Diferente a
> Mayor a
< Menor a
>= Mayor o igual
<= Menor o igual
*/

var (valor1, valor2, valor3) = (10, 5, 6);

Console.WriteLine($"Los valores son: {valor1}, {valor2}, {valor3} ");
Console.WriteLine($"El valor1 es mayor que el valor2: {valor1 > valor2} ");
Console.WriteLine($"El valor3 es menor que el valor2: {valor3 < valor2} ");

