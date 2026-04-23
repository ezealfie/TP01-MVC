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
    private DateTime nacimiento; 
    private string foto; 
    private List <string> Familiares;
    private List <string> Intereses;  



   public Integrante(int DNI, string nombre, DateTime nacimiento, string foto, List<string> Familiares, List<string> Intereses)
   {

    this.DNI = DNI; 
    this.nombre  = nombre; 
    this.nacimiento = nacimiento;
    this.foto = foto; 
    this.Familiares = Familiares; 
    this.Intereses = Intereses; 


   }
public int getDNI(){
    return DNI;
}

public string getFoto(){
    return $"/img/{foto}";   
}
   
public string getName(){
    return nombre;
}

    



public string getFecha(){
    return nacimiento.ToShortDateString();
}

public List<string> getFamiliares(){
    return Familiares;
}
public List<string> getIntereses(){
    return Intereses;
}


    }
      }