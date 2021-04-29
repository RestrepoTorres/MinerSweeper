namespace MineSweeper
{
    public class Tripleta
    {   
        /*
         No se crearon métodos adicionales para Tripletas aparte
         de los vistos en el curso
         */

        private int fila, columna;
        private object valor;

        public Tripleta(int fila, int columna, object valor) {
            this.fila = fila;
            this.columna = columna;
            this.valor = valor;
        }

        public int retornaFila() {
            return fila;
        }

        public int retornaColumna() {
            return columna;
        }

        public object retornaValor() {
            return valor;
        }

        public void asignaFila(int fila) {
            this.fila = fila;
        }

        public void asignaColumna(int columna) {
            this.columna = columna;
        }

        public void asignaValor(object valor) {
            this.valor = valor;
        }
    }
}