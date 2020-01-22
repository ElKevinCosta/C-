using System;


//ABSTRACT não pode ser instaciada, so serve para as clases que a herdam
//SEALED a class não pode ser herdada
abstract class Base
{

    protected int valor;
    protected int acelarar;
    public Base()
    {
        acelarar = 0;

    }

    //Quando temos nas classes herdadas metodos com o mesmo nome, usamos na base a palavra VIRTUAL e nas derivadas OVERRIDE
    virtual public void getInfo()
    {

        Console.WriteLine("BaseInfo");
    }

    //o metodo como é abstract apenas é obrigatorio implementar o mesmo na classe que o herda
    abstract public void SetValor();

    public int getValor(){

        return valor;

    }

}

class Derivada1 : Base
{

    public Derivada1()
    {
        valor =0;


    }
    override public void getInfo()
    {
        Console.WriteLine("Derivada1Info");

    }

    //Como o metodo abstract esta a ser subescrito temos de colocar o override
    override public void SetValor(){

        valor+=1;
    }

}

class Derivada2 : Derivada1
{

    public Derivada2()
    {


    }

    override public void getInfo()
    {
        Console.WriteLine("Derivada2Info");

    }

}


class Virtuais
{

    public static void Main()
    {

        //elemento de referencia que pode receber as classes derivadas
        Base Ref;
        Derivada1 d1 = new Derivada1();
        Derivada2 d2 = new Derivada2();

        //Neste caso estamos a associar a base ao objecto da derivada1
        Ref = d1;
        //Ref vai imprimir o metodo getInfo() da derivada1
        Ref.getInfo();
        d1.getInfo();
        d2.getInfo();
        d1.SetValor();
        Console.WriteLine(d1.getValor());
    }

}