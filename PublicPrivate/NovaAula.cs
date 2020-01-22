using System;



public class Privado
{

    public string nome;
    public int idade;
    //Não é possivel aceder ao id quando estanciamos um objectos porque é private
    //Apenas é possivel aceder ao mesmo dentro da class
    private int id;

    public  Privado(string nome, int idade)
    {

        this.nome = nome;
        this.idade = idade;
        id =0;



    }

    public int gerarId()
    {

        Random rd = new Random();
        int n = rd.Next(30);
        return n;

    }

    public void info()
    {

        Console.WriteLine("Nome : " + nome);
        Console.WriteLine("Idade : " + idade);
        Console.WriteLine("ID : " + id);
    }


    public int setId(int n){
        id = n;
        return id;

    }

}





public class NovaAula
{

    public static void Main()
    {

        Privado p = new Privado("Kevin", 26);
        Privado p1 = new Privado("Roberto", 16);

 
         p.info();
         p1.info();
        




    }

}