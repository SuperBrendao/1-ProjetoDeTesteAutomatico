namespace App.Core;

public class Caladora
{

    //Metodos publicos
    public double soma(int a, int b) {return conDou(a) + conDou(b);}
    public double subt(int a, int b) { return conDou(a) - conDou(b);}
    public double mult(int a, int b) { return conDou(a) * conDou(b); }
    public double div(int a, int b)
    {
        if (b == 0) return -1;//divisor zero não é permitido
            return conDou(a) / conDou(b);
    }
    public double raiz(int a)
    {
        if (a < 0) return -1;//raiz de numero negativo não é real
            return Math.Sqrt(conDou(a));
    }

    public bool IsPrime(int n)
    {
        if (n == 2) return true; //2 é primo
        if (n % 2 == 0 || n < 2) return false;//elimina pares e numeros menores que 2
        if (n == 3 || n == 5 || n == 7) return true;//3,5,7 são primos
        for (int i = 3; i <= (n - 1) / 2; i += 2)//verifica se é divisivel por algum numero impar ate a metade do antecessor de 'n'
            if (n % i == 0) return false;//se possuir um divisor, não é primo
        return true;//se não for divisivel por nenhum numero ate (n-1)/2, é primo
    }
    
    //------------------------------------------------------------------------------
    
    //Metodo privado
    private double conDou(int a)//converte int para double
    {
        return Convert.ToDouble(a);
    }
}
