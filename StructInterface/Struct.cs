using System;

//class Interface --> Não podemos atribuir paramentros, não pode ter construtor e quando herdada temos que inicializar os metodos
//Não é class Struct --> Armazenamento de dados, class de referencia, pode herdar nem servir de base 


public interface Veiculo{

     void delisgar();
     void ligar();

}

struct Carro{
    public string nome;
     public string modelo;

    public Carro(string nome,string modelo){
        this.nome=nome;
        this.modelo=modelo;
       
}

public void info(){

    Console.WriteLine("Nome ..: " + this.nome);
    Console.WriteLine("Modelo : " + this.modelo);

}



}
    
class oficina:Veiculo{

public oficina(){


}

public void delisgar(){}
public void ligar(){}

}


class Struct{


public static void Main(){

Carro[] c = new Carro[3];

c[0].modelo="Ibiza";
c[0].nome = "Seat";

c[1].modelo="Inca";
c[1].nome = "Seat";

c[2].modelo="Leon";
c[2].nome = "Seat";

for (int i = 0; i< c.Length; i++){

   c[i].info();


}


}

}