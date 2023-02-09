// Calcular o imposto sobre folha de pagamento
double salarioBruto;
double calculo;
double descontoFaixa1 = 5;
double descontoFaixa2 = 10;
double descontoFaixa3 = 20;

//ToString("C") ao imprimir o resultado transforma o número em valor monetário;
//ToString("F") " "                     transforma em valor numérico sem separador de milhar;
//ToString("N") " "                                                  com separador de milhar;
//ToString("P") " "                                em porcentagem.

Console.WriteLine("Olá! Vamos calcular o imposto sobre a sua folha de pagamento. Para isso, digite o valor do seu salário bruto:");
salarioBruto = double.Parse(Console.ReadLine());
if (salarioBruto > 2500){
    calculo = (salarioBruto / 100) * descontoFaixa3;
    Console.Write($"O seu desconto do imposto será de {descontoFaixa3}%, no valor total de {calculo.ToString("C")}");
}
else if (salarioBruto <= 2500 && salarioBruto > 1500){
    calculo = (salarioBruto / 100) * descontoFaixa2;
    Console.Write($"O seu desconto do imposto será de {descontoFaixa2}%, no valor total de {calculo.ToString("C")}");
}
else if (salarioBruto <= 1500 && salarioBruto > 900){
    calculo = (salarioBruto / 100) * descontoFaixa1;
    Console.Write($"O seu desconto do imposto será de {descontoFaixa1}%, no valor total de {calculo.ToString("C")}");
}
else {
     Console.Write($"Você não sofrerá desconto, pois está isento!");
}