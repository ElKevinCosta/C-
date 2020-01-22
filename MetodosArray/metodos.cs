using System;

class Metodos
{

    static void Main()
    {

        int[] vetor = new int[5];
        int[] vetor1 = new int[5]{6,12,24,33,24};
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,2]{{10,20},{30,40}};



        //Gerar numeros aleatorios 
        Random numeros = new Random();

        //Preencher o array vetor com numeros aleatorios e imprimir o array
        for (int i = 0; i < vetor.Length; i++)
        {
            //numeros.Next(); Gera numeros  aleatorio, neste caso entre 0-30
            vetor[i] = numeros.Next(30);
           // Console.WriteLine(vetor[i]);

        }

        //public static int BinarySearch(array,valor), Serve para procurar um elmento dentro de um array
        int procurar=49;
        int posicao=Array.BinarySearch(vetor1,procurar);
        Console.WriteLine("O elemento procurado está na posição : "+posicao);

        //public static void Copy(arrayOrigem,arrayDestino,QuantidadeElemntos),serve para copiar um array para outro
        Array.Copy(vetor1,vetor2,vetor1.Length);
        Console.WriteLine("O vetor2 copiado do vetor1 : ");
        foreach(int n in vetor2){
        Console.WriteLine (n);
        }

        //public void CopyTo(ArrayDestino,A partir de que posiçao),serve para copiar de um array para outro apartir de uma certa posiçao
        vetor1.CopyTo(vetor3,0);
        Console.WriteLine("Vetor1 copiado para o Vector3 apartir da posição 0 do vector3 : ");
        foreach(int n in vetor3){

            Console.WriteLine(n);
        }

        //public int GetLowerBound(dimensão do array ou matriz)
        //Obter menor indice(posição do menor valor) do array dimensao(0) pois é um vetor
        int menorIndice = vetor1.GetLowerBound(0);
        //Obter menor indice da matriz (0) ou (1),depedende de qual vetor da matriz que queremos
        int menorMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Obter o menor indice do Array : ");
        Console.WriteLine(menorIndice);
        Console.WriteLine("Obter o menor indice da Matriz : ");
        Console.WriteLine(menorMatriz);

        //public long GetLongLength(dimensao), serve para descobrir o tamanho do array
        long tamanho = vetor1.GetLongLength(0);
        long tamanhoMatriz = matriz.GetLongLength(1);
        Console.WriteLine("Tamanho do array : ");
        Console.WriteLine(tamanho);
        Console.WriteLine("Tamanho da Matriz : ");
        Console.WriteLine(tamanhoMatriz);

        //public int GetUpperBound(dimensão do array ou matriz)
        //Obter menor indice(posição do maior valor) do array dimensao(0) pois é um vetor
        int maiorIndice = vetor1.GetUpperBound(0);
        //Obter menor indice da matriz (0) ou (1),depedende de qual vetor da matriz que queremos
        int maiorMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Obter o maior indice do Array : ");
        Console.WriteLine(maiorIndice);
        Console.WriteLine("Obter o menor indice da Matriz : ");
        Console.WriteLine(maiorMatriz);

        //public object GetValue(long indice)
        Console.WriteLine("Obter o valor na posição 3 do array vetor1 : ");
        int indice =Convert.ToInt32(vetor1.GetValue(3));
        Console.WriteLine(indice);

        //public static int IndexOf(array,valor), retorna a primeira posição do valor que procuramos
        Console.WriteLine("Indice da primeira posição do valor 24 no array vetor1 : ");
        int indValor = Array.IndexOf(vetor1,24);
        Console.WriteLine(indValor);

        //public static int LastIndexOf(array,valor), retorna o ultima posição com o valor que procuramos
        Console.WriteLine("Indice da ultima posição do valor 24 no array vetor1 : ");
        int indUlValor = Array.LastIndexOf(vetor1,24);
        Console.WriteLine(indUlValor);
        
        //public static void Reverse(array)
        Console.WriteLine("Reverter o array vetor1 : ");
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
        Console.WriteLine(n);
        }

        //public static void SetValue(Object valor, posição)
        Console.WriteLine("Adicionar na posição 1 do vetor1 o elemento 99 : ");
        vetor1.SetValue(99,1);
        foreach(int n in vetor1){
        Console.WriteLine(n);
        }

        //public static void Sort(Array), serve para ordenar o array por ordem crescente
        Console.WriteLine("Ordenar o array vetor1 por ordem crescente : ");
        Array.Sort(vetor1);
        foreach(int n in vetor1){
        Console.WriteLine(n);
        }
        //int v1 =Valor();
        //int v2 =Valor();
        //Soma(v1,v2);
        int valorMult = Valor();
        //Quando o metodo recebe o parametro por ref temos que o colocar
        multiplicar(ref valorMult);
        Console.WriteLine(valorMult);
        //Declara o v2 para enviar para o out
        int v2;
        //Igual o return do metodo na variavel v1
        int v1 = valores(out v2);
        Console.WriteLine(v1);
        Console.WriteLine(v2);




    }

    static void Soma(int n1,int n2){

        int  res = n1 + n2;
        Console.WriteLine("Soma do valor {0} e {1} é : {2}",n1,n2,res);
    }

    static int Valor(){

        Console.WriteLine("Digite um valor : ");
        int v = Convert.ToInt32(Console.ReadLine());
        return v;

    }

    //ref --> Usado como quando queremos alterar o valor da variavel que estamos a receber
    static void multiplicar(ref int valor){

            valor*=2;
    }

    // OUT --> Serve para retorna um segundo valor do metodo metodo -->(Out in EX), int EX1 ;chamada --> valores(out EX1)
    static int valores(out int v2){

        Console.WriteLine("Introduza o primeiro valor : ");
        int v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduza o segundo valor : ");
        v2 = Convert.ToInt32(Console.ReadLine());

        return v1;

    }

}