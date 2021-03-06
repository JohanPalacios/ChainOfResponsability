﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsability
{
    class Director : Jerarquía
    {
        private Jerarquía next;
        // se implementa la interfaz Jerarquía
        public void setNext(Jerarquía jerarca)
        {
            this.next= jerarca;
        }

        public Jerarquía getNext()
        {
            return this.next;
        }

        /*
         aqui en este metodo se establece la lectura de documento 
         dependiendo la jerarquia el documento llegara a la 
         jerarquia que se haya establecido
         */
        public void VerDocumento(int leer)
        {
            if (leer ==1)
            {
                Console.WriteLine("El documento 1 fue leido por el Director");
            }
            else
                this.next.VerDocumento(leer);
        }      
    }
}
