using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP01_ALFIE_FAINSCHTEIN.Models
{
    public class Grupo
    {
        
        Dictionary<int, Integrante> Integrantes;

    public Grupo(){
        this.Integrantes = new Dictionary<int, Integrante>;
          CargaDatosManual();
       }
    public void CargaDatosManual(){
List<string> Intereses = new List<string>{"Interes 1", "Interes 2"};
List<string> Familiares = new List<string>{"Persona 1", "Persona 2"};

 Integrante luca = new Integrante(50233233, luca, fainschtein, (2000,10,01), "foto", Familiares, Intereses );
 Integrante liam = new Integrante(12345678, liam, perez, (2010,01,05), "foto", Familiares, Intereses );
 Integrante martin = new Integrante(98765432, martin, torres, (2009,09,04), "foto", Familiares, Intereses );
 Integrante matias = new Integrante(12345365, matias, lopez, (2005,07,07), "foto", Familiares, Intereses );

        Integrantes.Add(luca.getDNI(), luca);     
        Integrantes.Add(liam.getDNI(), liam);     
        Integrantes.Add(martin.getDNI(), martin);     
        Integrantes.Add(matias.getDNI(), matias);     
    }
    public Dictionary<int, Integrante> DevolverIntegrantes(){
         return Integrantes;
           
        }
    public Integrante getIntegrante(int DNI){
        if(Integrantes.ContainsKey(DNI)){
            return Integrantes[DNI];
        }
        else{
            return null;
        }

    }


    }
}