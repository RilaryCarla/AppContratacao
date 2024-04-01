internal class Program
{
    private static void Main(string[] args)
    {
        string resp;
        int cont = 0;
        double sb = 0;
        double total = 0;
        Console.WriteLine("Deseja começar S-sim ou N-Não?");
        resp = Console.ReadLine();

        while (resp == "S")
        {
            Console.WriteLine("Digite a forma de contratação A-Assalariado,C-Comissionado, H-Horista: ");
            string fc = Console.ReadLine();

            switch (fc)
            {

                case "A":

                    Console.Write("Digite o salário de funcionário: ");
                    double sal = double.Parse(Console.ReadLine());

                    Console.Write("Digite o desconto: ");
                    double desc = double.Parse(Console.ReadLine());

                    sb = sal - desc;
                    Console.WriteLine("O salário bruto é " + sb);

                    total += sb;
                    cont++;
                    break;

                case "C":

                    Console.Write("Digite quantas peças o funcionário vendeu: ");
                    int qp = int.Parse(Console.ReadLine());
                    Console.Write("Digite o valor por peça: ");
                    double vp = double.Parse(Console.ReadLine());

                    sb = qp * vp;
                    Console.WriteLine("O salário bruto é " + sb);
                    total += sb;
                    cont++;
                    break;

                case "H":

                    Console.Write("Digite o valor por hora: ");
                    double vh = double.Parse(Console.ReadLine());

                    Console.Write("Digite a quantidade de horas trabalhadas: ");
                    int hrs = int.Parse(Console.ReadLine());

                    sb = vh * hrs;
                    Console.WriteLine("O salário bruto é " + sb);
                    total += sb;
                    cont++;
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }

            Console.WriteLine("Deseja continuar: ");
            resp = Console.ReadLine();

        }

        Console.WriteLine("A quantidade de funcionários cadastrados foi: " + cont);
        Console.WriteLine("O total da folha de pagamento é de: " + total);
        Console.WriteLine("A média de salário é: " + (total / cont));
        Console.ReadKey();
    }
}