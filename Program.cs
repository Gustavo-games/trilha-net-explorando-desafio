using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Console.WriteLine("Bem vindo ao sistema de hospedagem!");
Console.ReadLine();
// Adiciona hóspedes a lista "hospedes"
while (true)
{
    Console.WriteLine("Digite o nome de cada Hospede (Digite 0 para parar): ");
    string nome = Console.ReadLine();
    if (nome == "0") break;
    else hospedes.Add(new Pessoa(nome: nome));
    
}

// Cria a suíte
Console.Clear();
Console.WriteLine("Digite o nome da suite: ");
string nomeSuite = Console.ReadLine();
Console.WriteLine("Digite a capacidade da suite: ");
int capacidade = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Digite o valor diario da suite: ");
decimal valorDiario = Convert.ToDecimal(Console.ReadLine());

Suite suite = new Suite(tipoSuite: nomeSuite, capacidade: capacidade, valorDiaria: valorDiario);

// Cria uma nova reserva, passando a suíte, os hóspedes e os dias reservados
Console.Clear();
Console.WriteLine("Digite o numero de dias reservados: ");
Reserva reserva = new Reserva(diasReservados: Convert.ToInt32(Console.ReadLine()));
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.Clear();
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");