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
        this.Integrantes = new Dictionary<int, Integrante>();
          CargaDatosManual();
       }
    public void CargaDatosManual(){


 Integrante luca = new Integrante(50233233, "Luca Fainschtein", new DateTime(2000,10,01), "luca.jpg",  new List<string>{"Mamá: Marta Einmas", "papá: Martin Fainschtein "},  new List<string>{"Jugar a la play", "Ver la tele"});
 Integrante liam = new Integrante(12345678, "Liam   Galanternik",  new DateTime(2010,01,05), "liam.jpg",  new List<string>{"Papá: Nicolas Galanternik", "Mamá: Romina Lopez "},  new List<string>{"Viajar", "Leer"} );
 Integrante martin = new Integrante(98765432, "Martin Torres", new DateTime(2009,09,04), "martin.jpg",  new List<string>{"Mamá: Sofia Cohen", "Papá: Lucas Torres "},  new List<string>{"Aprender idiomas", "Yoga"} );
 Integrante matias = new Integrante(12345365, "Matias Lopez", new DateTime(2005,07,07), "matias.gif",  new List<string>{"Mamá: Priscila Levy", "Papá: Nicolas Lopez"},  new List<string>{"Programar", "Estudiar"} );

        Integrantes.Add(luca.getDNI(), luca);     
        Integrantes.Add(liam.getDNI(), liam);     
        Integrantes.Add(martin.getDNI(), martin);     
        Integrantes.Add(matias.getDNI(), matias);     
    }
    public Dictionary<int, Integrante> DevolverIntegrantes(){
         return Integrantes;
           
        }
    public Integrante getIntegrante(int DNI){
        if(Integrantes.ContainsKey(DNI))
            return Integrantes[DNI];
        return null;
        

    }


    }
}