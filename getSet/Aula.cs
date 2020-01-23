using System;


public class Carro{

private int velMax;

//Criar acessores get e set, onde value é o valor recebido
public int vm{

get{
        return velMax;
}
set{
        if (value <0){
            velMax=0;
        }else if(velMax > 300){
            velMax = 300;
        }else {
            velMax =value;
        }

}

}

public Carro(){

    velMax =120;
}



}



class Aula{


public static void Main(){

Carro c = new Carro();
//Utilizar o atribuidor set c.vm = ;
c.vm=200;
//Usar o atribuir get c.vm
Console.WriteLine(c.vm);





}

}