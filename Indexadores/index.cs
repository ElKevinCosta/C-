using System;


public class Carro{

//Criar um parametro do tipo array
private int[] velMax = new int[5]{0,80,120,160,200};

//Criar a atribuição daquele array
public int this[int i]{

get{
        return velMax[i];
}
set{
        if (value <0){
            velMax[i]=0;
        }else if(velMax[i] > 300){
            velMax[i] = 300;
        }else {
            velMax[i] =value;
        }

}

}

public Carro(){

}
}

class Aula{


public static void Main(){

Carro c = new Carro();
//Utilizar o atribuidor set c[i] na posição do array que queremos
c[1]=200;
//Usar o atribuir get c[i] na posiçao do array que queremos
Console.WriteLine(c[1]);





}

}