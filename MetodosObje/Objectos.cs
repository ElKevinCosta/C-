using System;


class Galinha
{

    public string nome;
    public int ovo;

    public Galinha(string nome)
    {

        this.nome = nome;
        this.ovo = 0;

    }

    //Metodo que retonra um novo objecto da classe OVO
    //Sempre que é chamado o paramentro ovo recebe 1
    //Como o construtor da claa Ovo tem de receber um valor, enviamos o parametro ovo
    public Ovo por()
    {

        ovo++;
        return new Ovo(ovo,nome);
    }


  
}

class Ovo
{

    //Criamos um parametro para que possa receber o nr de ovos metidos
    private int ovo;
    private string nomeGalinha;

    public Ovo(int ovo,string nomeGalinha)
    {

        this.ovo = ovo;
        this.nomeGalinha=nomeGalinha;
        Console.WriteLine("Pus um ovo!");
        Console.WriteLine("É o ovo numero : " + ovo);
        Console.WriteLine("O meu nome é : " + nomeGalinha);
        Console.WriteLine("--------------------");
        {
            
        }
    }

}


class Mat{

    public static double pi=3.14;
    public static int dois = 2;

    public static int dobro(int n){

        int res = n*2;
        return res;

    }

}



class Objectos
{


    public static void Main()
    {

        Galinha g = new Galinha("Bruna");
        Galinha g1 = new Galinha("Nicole");
        g.por();
        g1.por();
        g.por();
        g1.por();
       
       Objectos o = new Objectos();
       Console.WriteLine(o.soma(4,5,3,6,8));
       Console.WriteLine(o.soma(4.4,5,3.8,6,8));
       Console.WriteLine("O fatorial é : " + o.fatorial(5));

       
       //Usar a class MAT criada por nos sem instanciar, pois o seu conteudo é estatico
       Console.WriteLine ("O valor de pi é : " + Mat.pi);
       int num = 2;
       Console.WriteLine("O dobro de 2 é : " + Mat.dobro(num));
        
    }
    //Sobrecarga de Metodos, dois metodos com o mesmo nome mas fazem coisa diferentes
     public int soma(params int[]n){

        int s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
            return s;
    }
    public double soma(params double[]n){

        double s=0;
        for(int i=0;i<n.Length;i++){
            s+=n[i];
        }
            return s;
    }

    //Recursividade, funçao que se chama a ela propria 
    //Fatorial 5! 5*4*3*2*1

    public int fatorial(int n){

        int res;
        if(n<=1){
            res =1;
        }else {
            res = n*fatorial(n-1);

        }
            return res;
    }


}