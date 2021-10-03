using Microsoft.AspNetCore.Mvc;
using Anagrama.Entities;
using System;
using System.Linq;

/* Nombre de la escuela: Universidad Tecnologica Metropolitana
    Asignatura: Aplicaciones Web Orientadas a Objetos
    Nombre del Maestro: Chuc Uc Joel Ivan
    Nombre de la actividad: Actividad 1, Ejercicio 3: Anagrama
    Nombre del alumno: Rafael Salazar Perera
    Cuatrimestre: 4
    Grupo: A
    Parcial: 1
    */
namespace Anagrama.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PalabrasController:ControllerBase
     {
            [HttpPost]
        public string VerificaPalabras (Palabras palabra)

        {
            string Pala1 = "Si es un anagrama";
            string Pala2 = "No es un anagrama";
            string Palam1 = String.Concat(palabra.Palabra1.ToLower().OrderBy(c=>c));
            string palam2= String.Concat(palabra.Palabra2.ToLower().OrderBy(c=>c));

            if (Palam1 == palam2)

            {

                return Pala1;

            }

            else

            {

                return Pala2;

            }

        }

    }

}
