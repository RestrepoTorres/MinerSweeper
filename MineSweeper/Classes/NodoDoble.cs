namespace MineSweeper
{
    public class NodoDoble
    {    /*
         No se crearon métodos adicionales para nodos dobles aparte
         de los vistos en lógica 2
         */
        private object dato;
        private NodoDoble ligaIzquierda, ligaDerecha;
        public NodoDoble(object dato)
        {
            this.dato = dato;
            ligaDerecha = null;
            ligaIzquierda = null;
        }

        public void asignaDato(object dato)
        {
            dato = this.dato;
        }

        public void asignaLigaDerecha(NodoDoble x)
        {
            ligaDerecha = x;
        }

        public void asignaLigaIzquierda(NodoDoble x)
        {
            ligaIzquierda = x;
        }

        public object retornaDato()
        {
            return dato;
        }

        public NodoDoble retornaLigaDerecha()
        {
            return ligaDerecha;
        }
        
        public NodoDoble retornaLigaIzquierda()
        {
            return ligaIzquierda;
        } 
    }
}