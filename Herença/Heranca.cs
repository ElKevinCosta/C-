using System;


public class Carro{ //Class Base

//Private --> privado apenas é acessivel dentro da propria class
// Protected--> É possivel aceder na propria class e nas class que a herdam
private bool estado;
private int rodas;
protected string cor;

public Carro(int rodas){

    this.rodas=rodas;
}

public void ligar(){
    estado = true;
}

public void desligar(){
    estado =false;
}

//metodo para retornar o estado, uma vez que o parametro é privado
public string getEstado(){
    //é o mesmo de ter um if a validar o estado
    //(paramentroValidar ? Acção se for verdade : Acção se for mentira);
    return(estado? "Motor Ligado ":"Motor Desligado ");
}

public int getRodas(){

    return rodas;
}

}

//Para herdar classes pomos a classenova : classeherdar
public class Motor:Carro{ //Class derivada a que herda

public string nome;
public int cilindros;

//Herdar o constructor da classe base e passar o paramentro pedido pelas mesma ...No constructor da class que herda :base()
public  Motor(string nome, int cilindros):base(4){

    this.cor = "Black";
    desligar();
    this.nome=nome;
    this.cilindros=cilindros;

}
public string getCor(){

    return cor;
}
}
public class ComponentesMotor:Motor{

    public string intercooler;
    public string reservatorio;

    public ComponentesMotor():base("TDI",4){

        intercooler = "XXL";
        reservatorio = "Redondo";
    }


}




class herança{

public static void Main(){

Motor m = new Motor("B18",4);
m.ligar();
Console.WriteLine(m.getEstado());
Console.WriteLine(m.getRodas());
ComponentesMotor c = new ComponentesMotor();
Console.WriteLine(c.nome);
Console.WriteLine(m.getCor());





}
}