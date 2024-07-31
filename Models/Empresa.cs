using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace talleresPracticos31_07.Models;

public class Empresa
{

    public string? Nombre { get; set; }
    public string? Direccion { get; set; }
    public static List<Estudiante>? Profesores { get; set; } = new List<Estudiante>();

    public Empresa(string nombre, string direccion, List<Estudiante)
    {
        Nombre = nombre;
        Direccion = direccion;
    }

    public void AgregarEmpleado()
    {
        //agregar un empleado a la empresa
    }

    public void EliminarEmpleado()
    {
        //eliminar un empleado de la empresa
    }
    public void MostrarTodosLosEmpleados()
    {
        //mostrar todos los empleados de la empresa
    }

    public void ActualizarEmpleado(){
        //actualizar un empleado de la empresa
    }

    public void BuscarEmpleado(){
        //buscar un empleado de la empresa
    }

    public void MostrarEmpleadosPorCargo(){
        //mostrar todos los empleados de la empresa por cargo
    }



}
