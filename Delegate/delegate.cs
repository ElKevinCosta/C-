using System;

//Defenir o apontador delegate
delegate int Op(int n1,int n2);


class Delegate{


 static void Main(){

    int res;
    //defenir um novo delegate e atribuir o metodo que queremos que ele aponte   
    Op kk = new Op(soma);
    //Enviar os valores para o metodo
    res = kk(10,5);
    Console.WriteLine(res);

   

}
public static int soma(int n1,int n2){
        return n1 + n2;

}


}