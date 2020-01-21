using System;

class Aula{

enum DiasDaSemana{Segunda,Terça,Quarta,Quinta,Sexta,Sabado,Domingo};

static void Main(){

    //Atribuir a variavel ds o dia segunda
    DiasDaSemana ds = DiasDaSemana.Segunda;
    Console.WriteLine(ds);

    //Atribuir a ds1 a posição 3(Quinta) do enum, cast (DiasDaSemana)
    DiasDaSemana ds1 = (DiasDaSemana)3;
    Console.WriteLine(ds1);

    //Atribuir ao ds3 um valor(int),neste caso da posição Domingo do enum (6), cast (int)
    int ds3=(int)DiasDaSemana.Domingo;
    Console.WriteLine(ds3);



}


}