using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    interface Jerarquía
    {

        // se define la interfaz con los metodos que requiera el programa

        public void setNext (Jerarquía jerarca);
        //asigna el siguiente jerarca en la cadena de responsabilidad

        public Jerarquía getNext ();
        //retorna el siguiente jerarca en la cadena de responsabilidad.

        public void VerDocumento(int  leer );
        // este metodo permite ver el documento 
    


       

    }
}
