using System;

class Aula03{

    enum DiasDaSemana{Segunda,Terca,Quarta,Quinta,Sexta,Sabado,Domingo};

    static void Main(){

    int kk;
    string nome;
    char letra='c';
    float dec=5.3f;
    DiasDaSemana ds = DiasDaSemana.Segunda;

    Console.WriteLine(ds);
    Console.WriteLine("Imprimir variavel no indice 0 com espaçamento de 10:{0,10}",dec);
    Console.WriteLine("Imprimir variavel no indice 0 com espaçamento de 10 e percentagem:{0,10:p}",dec);
    //Ler a linha digitada no programa
    nome =Console.ReadLine();
    Console.Write(nome);
     //Converter para int int.Parse(); ou convert.Int32();

    }

}