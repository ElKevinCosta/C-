using System;

class Aula
{

    enum DiasDaSemana { Segunda, Terça, Quarta, Quinta, Sexta, Sabado, Domingo };


    static void Main()
    {

    
        string nota1 = "Reprovado";
        string kk = "";

        Console.WriteLine("Escreva a sua nota");
        //receber  um numero inteiro do teclado
       // int nota = Convert.ToInt32(Console.ReadLine());
       //receber um numero inteiro do teclado
       int nota = int.Parse(Console.ReadLine());
        
        if(nota<50 && nota >=0){

            Console.WriteLine("Nota : " + nota1);
        } else if(nota >=50 && nota <=100){

            nota1="Aprovado";
            Console.WriteLine(nota1);
        } else {

            Console.WriteLine("Nota inserida inválida!");

        }



        //Atribuir a variavel ds o dia segunda
        //DiasDaSemana ds = DiasDaSemana.Segunda;
        // Console.WriteLine(ds);

        //Atribuir a ds1 a posição 3(Quinta) do enum, cast (DiasDaSemana)
        //DiasDaSemana ds1 = (DiasDaSemana)3;
        //Console.WriteLine(ds1);

        //Atribuir ao ds3 um valor(int),neste caso da posição Domingo do enum (6), cast (int)
        //int ds3=(int)DiasDaSemana.Domingo;
        //Console.WriteLine(ds3);





    }


}