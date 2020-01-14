using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class Institución : Jerarquía
    {
        private Jerarquía next;
        // se implementa la interfaz Jerarca
        public void setNext(Jerarquía jerarca)
        {
            this.next = jerarca;
        }

        public Jerarquía getNext()
        {
            return this.next;
        }
            
        /*
         una vez que se tienen las clases se crea la cadena, se define
         el primero en la sucesion, y los sucesores de cada uno de los miembros
         de la cadena
        */
        public void VerDocumento(int leer)
        {
            Director director = new Director();
            Delegado delegado = new Delegado();
            Rector rector = new Rector();

        
            this.next = director;
            director.setNext(delegado);
            this.next = delegado;
            delegado.setNext(director);
            director.setNext(rector);
            //se inicia la cadena
            this.next.VerDocumento(leer);
        }
    }
}
