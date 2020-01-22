using System;

//ref --> referencia uma variavel fora do metodo para ser alterar aquando a chamada do metodo
//out para retorna uma segunda coisa do metodo

//Criar uma nova classe publica
public class Pessoa{

public int energia;
public bool vivo;
public string nome;
//metodo construror com parametros default ,atribuir sempre o nome da class
public Pessoa(){
    this.energia = 100;
    this.vivo = true;
    //THIS refere-se a class, o segundo "nome" é o parametro que estamos a receber ao instanciar um novo objecto
    this.nome = "Jogador";
}

//metodo construtor onde recebemos os parametros
public Pessoa(string nome, int energia, bool vivo){

    this.nome = nome;
    this.energia= energia;
    this.vivo = vivo;

}

//metodo para retornar as informações do jogadores
public void info() {

    Console.WriteLine("Nome do jogador... : " + nome);
    Console.WriteLine("Energia do jogador : " + energia);
    Console.WriteLine("Status do jogador. : " + vivo + "\n");
}   


//metodo destructor é chamado quando o programa termina todas as acções
~Pessoa(){

    Console.WriteLine("Fim de jogo! Jogador removido : " + this.nome);
}


}
public class Metodos{


    public static void Main(){

        //Instanciar um objectos pessoa sem passar parametros, vai ao construtor vazio
        Pessoa p1 = new Pessoa();
        //Instanciar um objecto Pessoa com parametros, vai ao construtor que recebe parametros
        Pessoa p2 = new Pessoa("Kevin",100,true);
        Pessoa p3 = new Pessoa("Roberto",40,true);
        Pessoa p4 = new Pessoa("Silva",0,false);
        //mostrar a informação de cada Pessoa
        p1.info();
        p2.info();
        p3.info();
        p4.info();

/*
        //Pedir que o nome seja digitado
        Console.WriteLine("Digite o nome do Jogador 2 : ");
        //Atribuir o digitado a uma variavel nova
        string nome = Console.ReadLine();

        Soma(1,3,4,5,8,10);
        //Instanciar um novo objecto da classe Pessoa, enviar uma "string" porque o metodo construtor da classe pede uma
        Pessoa p1 = new Pessoa("Kevin");
        //Instanciar um novo objecto Pessoa e manda como parametro um nome digitado no teclado
        Pessoa p2 = new Pessoa(nome);
        //Alterar uma proprieda do objecto p2 criado
        p2.energia = 50;
        //Aceder a propriedade energia do p2 ja alterada
        Console.WriteLine(p2.energia);
        Console.WriteLine(p2.nome);
        //Aceder a uma propriedade do objecto criado
        Console.WriteLine(p1.energia);
        

    }

    //params--> serve para enviarmos algo para dentro do metodo sem especificar o que é, neste caso defenimos um array
    static void Soma(params int[]n)
    {
        int resultado=0;
    
        if(n.Length<1){
            Console.WriteLine("Não existem valores para ser somados !");
        } else if (n.Length<2){
            Console.WriteLine("Falta de valores para a soma!");
        }else {
               for (int i=0;i<n.Length;i++){
                   resultado += n[i];
               }
            Console.WriteLine("A soma dos valores é : " + resultado);
        }

*/
    }

}