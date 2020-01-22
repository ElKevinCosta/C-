using System;
static public class Estatica{

static public string nome;
static public int idade;


static public void Classes(string n, int i){

    nome = n;
    idade = i;

}

static public void info(){

  
    Console.WriteLine("Nome do jogador : " + nome + "\nIdade do jogador : " + idade);
}

}

public class Inimigo{

public string nome;
static public bool alerta;

public Inimigo(string nome){

this.nome=nome;
alerta = false;

}

public void info(){

    Console.WriteLine("----------------------");
    Console.WriteLine("Nome do Jogador : " + nome);
    Console.WriteLine("Alerta : " + alerta);

}

}

public class Class{
static void Main(){

    //Quando a Class é static não podes instanciar objectos da mesma
    //Vantagem de ser static é que quando a chamamos alteramos os dados em qualquer lado que ela esteja a ser usada
    //Quando a queremos chamar, usamos o nome da Class.Qualquer informação que la esteja
    //Static está alocada a um pedaço de memoria estatica 
    Estatica.Classes("kevin",26);
    Estatica.info();


    Inimigo i1 = new Inimigo("Andre");
    Inimigo i2 = new Inimigo("Joao");
    Inimigo i3 = new Inimigo("Daniel");


    //Como o parametro alerta está statico é independente dos objectos criados naquela instancia
    //Assim quando alteramos o parametro alerta, ele é alterado em todos os objectos criados de Inimigo
    Inimigo.alerta=true;

    i1.info();
    i2.info();
    i3.info();
}




}

