using System;

class Primeiro{


    static void Main(){

      int num=10,num2=10;

      //BITWISE a esquerda Dobra o Valor + as vezes do indice n,neste caso 1;  
      num = num<<1;
      Console.WriteLine(num);
      //BITWISE a direita parte em metade o valor + as vezes do indice neste caso 1;
      num2 =num2>>1;
      Console.WriteLine(num2);



    }



}