using System;

class Principal {


    static void Main(){

            inicio:

        //array unidimensional
        int[] num = new int[3]{0,1,2};
        //array bidimensional
        int[,] num1 = new int[2,4]{{10,20,30,40},{60,70,80,90}};
        int[] num2 = new int[10];
        int[] num3 = new int[5];

        //preenchero array num3 ,com ciclo do{}while(); garantimos que é feito pelo menos 1 vez
        int x=0;
        do{
        
                num3[x] =2;

                x++;
        }while(x<num3.Length);

        //preencher o array num2 com 1 
        int t=0;
        while(t<num2.Length)
        {
                num2[t] =1;
                t++;
        }
        
        //percorrer um array com foreach(){}; não permite a atribuiçao de elementos
        foreach(int n in num){
                Console.WriteLine(n);

        }

        //output do que esta dentro do array num2
        for(int i=0;i<num3.Length;i++){

                Console.WriteLine(num3[i]);

        }
        

        char escolha,escolha2,deseja;
        Console.WriteLine("Escola a modificação: [m]Motor | [b]Body | [i]Interior :");
        escolha =char.Parse(Console.ReadLine());

        switch(escolha){

            case 'm':
                    Console.WriteLine("[t]Turbo | [b]Bielas | [e]Escape :");
                    Console.WriteLine("Escolha uma nova opção");
                    escolha2=char.Parse(Console.ReadLine());
                    switch(escolha2){

                        case 't':   
                        case 'T': 
                                Console.WriteLine("Disponivel Garret 27");
                                break;
                        case 'b':
                                Console.WriteLine("Bielas Sport");
                                break;
                        case 'e':
                                Console.WriteLine("Linha INOX 76");                
                                break;

                    }
                    break;
            case 'b' :
                    Console.WriteLine("Para-Choques | Farois | Aileron");
                    break;

            case 'i' : 
                    Console.WriteLine("Estofos | Volante| Radio");
                    break;            
            default : 
                    Console.WriteLine("Escolha uma opção valida!");
                    break;
        }

                fim:
            Console.WriteLine("Deseja efectuar a encomenda? [s]Sim [n]Não");
            deseja = char.Parse(Console.ReadLine());
            if(deseja == 's'){

                Console.WriteLine("Desloque-se a nossa loja fisica Peças e Pecinhas");
                goto inicio;

            } else if(deseja == 'n'){

                Console.WriteLine("Vai tomar no cu!!");
                //volta para o label imposto por nos
                goto inicio;
            }else {

                Console.WriteLine("Opte por [s] ou [n]");
                 //volta para o label imposto por nos
                goto fim;
            }



    }
}