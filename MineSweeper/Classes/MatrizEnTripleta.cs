using System;
namespace MineSweeper
{
    public class MatrizEnTripleta
    {
        /*
         Aparte de los métodos vistos en el curso para matrices en tripletas, se creo el método 
         llamado generarCoordenadasAleatorias

         */
     private Tripleta []V; 
     public MatrizEnTripleta(Tripleta t){
         
        int m = t.retornaFila();
        int n = t.retornaColumna();
        int p = (m*n)+2;
        V = new Tripleta[p];
        V[0] = t;

        for(int i = 1 ; i <V.Length; i++){
            V[i]= null;
        }
    }

    public void asignaNumeroTripletas(int n){
        Tripleta t = V[0];
        t.asignaValor(n);
        V[0]=t;
    }

    public void asignaTripleta(Tripleta tx , int i){
        V[i] = tx;
    }

    public int retornaNumeroFilas(){
        Tripleta t = V[0];
        return t.retornaFila();
    }

    public int retornaNumeroColumnas(){
        Tripleta t = V[0];
        return t.retornaColumna();
    }

    public int retornaNumeroTripletas(){
        Tripleta t = V[0];
        return (int) t.retornaValor();
    }

    public Tripleta retornaTripleta(int i){
        return V[i];
    }

    public void insertaTripleta (Tripleta ti){
        int i,j,p;
        Tripleta t, tx;
        tx = retornaTripleta(0);
        p = (int) tx.retornaValor();
        i = 1;
        t = retornaTripleta(i);
        while(t!=null && i<=p && t.retornaFila()<ti.retornaFila()){
            i = i + 1;
            t = retornaTripleta(i);
        }

        while(t!= null && i<= p && t.retornaFila()==ti.retornaFila() && t.retornaColumna() <ti.retornaColumna()){
            i = i + 1;
            t = retornaTripleta(i);
        }
        p = p + 1;
        j = p -1 ;

        while(j>= i){
            V[j+1] = V[j];
            j=j-1;
        }
        V[i]= ti;
        asignaNumeroTripletas(p);
    }
        public bool posicion(int fila, int columna)
        {
            for (int i = 1; i <= this.retornaNumeroTripletas(); i++)
            {
                if (this.V[i].retornaFila() == fila & this.V[i].retornaColumna() == columna)
                {
                    return true;
                }
            }
            return false;
        }


    //Genera n numero de coordenadas aleatorias sin repetir
    public void generarCoordenadasAleatorias(int coordenadasAGenerar)
        {
            Random random = new Random();
            int fila;
            int columna;
            int i = 0;
            while(i < coordenadasAGenerar) { 
                fila = random.Next(1, this.retornaNumeroFilas() + 1);
                columna = random.Next(1, this.retornaNumeroColumnas() + 1);
                if(!this.posicion(fila, columna))
                {
                    this.insertaTripleta(new Tripleta(fila, columna, 0));
                    i++;
                }
            }
            

        }

    public string muestraMatrizEnTripletas(){
        int i = 1;
            string resultado = "";
        Tripleta t = retornaTripleta(0);
        int datos = (int) t.retornaValor();
        while(i <= datos){
                resultado += +V[i].retornaFila() + ", " + V[i].retornaColumna() +
                                  ", " + V[i].retornaValor() + "\n";
            i = i + 1;
        }
            return resultado + this.retornaTripleta(0).retornaValor();
    }

    
    }
}