using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP01_ALFIE_FAINSCHTEIN.Models
{
    
    public class Integrante
    {
     private int DNI; 
    private string nombre; 
    private dateTime nacimiento; 
    private string foto; 
    private List <string> Familiares;
    private List <string> Interesas;  



   public Integrante(int DNI, string nombre, dateTime nacimiento, string foto, List<string> Familiares, List<string> Intereses)
   {

    this.DNI = DNI; 
    this.nombre  = nombre; 
    this.nacimiento = nacimiento; 
    this.foto = foto; 
    this.Familiares = Familiares; 
    this.Intereses = Intereses; 

x
   }























    }




    
}