namespace Exercicio07.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salarioTotal;
            double salarioBase;
            double totalVendas;
            double percentual;
            while (true)
            {
                SalarioTotal salTotal = new SalarioTotal();
                Console.Clear();
                Console.WriteLine("=== Formula  per/100 * totalVendas + salarioBase ===");
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite a Salario Base");
                salTotal.salarioBase = Convert.ToDouble(Console.ReadLine());
                salTotal.salarioBase = Math.Round(salTotal.salarioBase, 2);
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o total de vendas");
                salTotal.totalVendas = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("====================================================");
                Console.WriteLine("Digite o percentual da comissao");
                salTotal.percentual = Convert.ToDouble(Console.ReadLine());
                percentual = Math.Round(salTotal.percentual, 2);
                salTotal.salarioTotal = salTotal.CalcularSalarioTotal();
                salTotal.salarioTotal = Math.Round(salTotal.salarioTotal, 2);
                Console.WriteLine("====================================================");
                Console.WriteLine("Salario total: R$" + salTotal.salarioTotal);
                Console.WriteLine("====================================================");
                Console.ReadLine();
            }
        }
    }
}