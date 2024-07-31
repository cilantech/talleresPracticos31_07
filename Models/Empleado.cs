using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace talleresPracticos31_07.Models;

public class Empleado
{
public Guid Id { get; set; }
public string? Nombre { get; set; }
public string? Apellido { get; set; }
public string? NumeroDeIdentidficacion { get; set; }
public byte Edad { get; set; }
public string? Posicion { get; set; }
public double Salario { get; set; }

public Empleado( string nombre, string apellido, string numeroDeIdentidficacion, byte edad, string posicion, double salario)
{
    
    Id = Guid.NewGuid();
    Nombre = nombre;
    Apellido = apellido;
    NumeroDeIdentidficacion = numeroDeIdentidficacion;
    Edad = edad;
    Posicion = posicion;
    Salario = salario;
}


public void CalcularBonificacion()
{
    Console.WriteLine(Salario * 0.1);
}

public void MostrarInformacion()
{
    Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Número de Identificación: {NumeroDeIdentidficacion}, Edad: {Edad}, Posición: {Posicion}, Salario: {Salario}");
}


}
