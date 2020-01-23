using System;


class Cenas{

//Defenir no construtor Main o array "string[] args",para receber o que é escrito no teclado quando iniciamos o programa
// .\Main.exe 5 5 j 4 ... cada inserção vai ser alocada a cada posição do array args
public static void Main( string[] args){

    if(args.Length>0){
        Console.WriteLine("Nr de argumentos : " + args.Length);

    }else {
        Console.WriteLine("Não foram passados argumentos!");
    }



}



}