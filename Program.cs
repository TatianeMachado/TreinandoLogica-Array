static int EncontrarIndiceMenorPreco(double[] precos)
{
    int indice = 0;
    
    for(int i=0; i < precos.Length; i++)
    {
        if (precos[i] < precos[indice])
        {
           indice=i;
        }
     }
    return indice;


}

static int ContarPrecosAbaixoDe(double[] precos, double limite)
{
    int total = 0;
    
    for (int i=0; i<precos.Length; i++)
    {
      
    
        if (precos[i]< limite)
        {
            total++;
        }
    }
    return total;
}

static double SomarPrecosAbaixoDe(double[] precos, double limite)
{
    double total = 0;
    for(int i=0; i < precos.Length; i++)
    {
        if (precos[i] < limite)
        {
            total += precos[i];
        }
    }
    return total;
}

static double CalcularMediaPrecosAbaixoDe(double[] precos, double limite)
{
    double soma = 0;
    int quantidade = 0;
    soma = SomarPrecosAbaixoDe(precos, limite);
    quantidade = ContarPrecosAbaixoDe(precos, limite);
    if (quantidade <= 0)
    {
        return 0;
    }
    else
    {
        return soma / quantidade;
    }
}

static void ListarPrecosAbaixoDe(double[] precos, double limite)
{
   
    int cont = 0;
    for(int i=0; i< precos.Length; i++)
    {
        if (precos[i] < limite)
        {
            Console.WriteLine($"Produto {i + 1}: {precos[i]:F2}");
            cont++;

        }
       
     
        
    }
    if (cont == 0)
    {
        Console.WriteLine($"Nenhum produto encontrado");

    }
}

static bool ExistePrecoAbaixoDe(double[] precos, double limite)
{
    for(int i=0; i<precos.Length; i++)
    {
        if (precos[i]< limite)
        {
            return true;
        }
    }
    return false;
}

static int EncontrarPrimeiroIndiceAbaixoDe(double[] precos, double limite)
{
   
    for(int i=0; i<precos.Length; i++)
    {
        
        if (precos[i]< limite)
        {

            return i;
        }
     
    }
    return -1;
  
}

static int EncontrarUltimoIndiceAbaixoDe(double[] precos, double limite) 
{
    int indice = -1;
    for( int i=0; i<precos.Length; i++)
    {
        
        
        if (precos[i] < limite) {
            indice = i;
        }
    }
    return indice;

}

static double LerLimite()
{
    bool converter = false;
    double numero = 0;
    Console.WriteLine("Digite um limite: ");
    string? entrada = Console.ReadLine();
    converter = double.TryParse(entrada, out numero);
    while (!converter || numero <= 0)
    {
        Console.WriteLine("Digite outro limite: ");

        entrada = Console.ReadLine();
        converter = double.TryParse(entrada, out numero);
    }
    return numero;
}
static int LerInteiro()

{
    bool converter = false;
    int numero = 0;
    Console.WriteLine("Digite um numéro");
    string? entrada = Console.ReadLine();
    converter = int.TryParse(entrada, out numero);

    while (!converter || numero <= 0)
    {
        Console.WriteLine("Digite outro numéro");
        entrada = Console.ReadLine();
        converter = int.TryParse(entrada, out numero);
    }
    return numero;

}

static void ExibirResumoPrecos(double[] precos, double limite)
{

    int contarQuantidadePrecoAbaixoLimite = 0;
    double somarPrecoAbaixoLimite = 0;
    double mediaPrecoAbaixoLimite = 0;
    contarQuantidadePrecoAbaixoLimite = ContarPrecosAbaixoDe(precos, limite);
  somarPrecoAbaixoLimite= SomarPrecosAbaixoDe
(precos, limite);
    mediaPrecoAbaixoLimite = CalcularMediaPrecosAbaixoDe(precos, limite);
    Console.WriteLine($"Média dos preços abaixo do limite {mediaPrecoAbaixoLimite:F2} ");
    Console.WriteLine($"Quantidade de preços abaixo do limite {contarQuantidadePrecoAbaixoLimite} ");
    Console.WriteLine($"Soma de preços abaixo do limite {somarPrecoAbaixoLimite:F2} ");
}

static void AtualizarPrecoProduto(double[] precos)
{
    int produto = 0;
    double preco = 0;
    double atualizar = 0;
    Console.WriteLine("qual produto deseja atualizar");
    produto = LerInteiro();
    for (int i = 0; i < precos.Length; i++)
    {
        if (!(precos.Length >= produto))
        {
            Console.WriteLine($"Poduto {produto} não encontrado. Tente de novo!!");
            produto = LerInteiro();

        }
        else
        {
            if (produto == i)
           preco = precos[i];
           
            
        }
    }

          Console.WriteLine($"O produto que vai ser atualizado é: {produto}");
          Console.WriteLine($"O preço que vai ser atualizado é: {preco}");
    Console.WriteLine("Dígite o nome o preço");
    atualizar = LerLimite();
    preco = atualizar;
    Console.WriteLine($"O novo preço é: {atualizar}");
        
    
}

static void ExibirMenu(double[] precos)
{
    double limite = 0;
    int opcao = 0;
    do
    {
        Console.WriteLine("Escolha a opção deseja");
        Console.WriteLine("1 — Listar preços abaixo do limite\r\n2 — Exibir resumo dos preços abaixo do limite\r\n3 — Atualizar preços\r\n4 — Sair");
        opcao = LerInteiro();
       
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Listagem de preços");
                limite = LerLimite();
                ListarPrecosAbaixoDe(precos, limite);


                break;
            case 2:
                Console.WriteLine("Exibir resumo de preços");
                limite = LerLimite();
                ExibirResumoPrecos(precos, limite);
                break;
            case 3:
                Console.WriteLine("Atualizar os preços");
                AtualizarPrecoProduto(precos);
                break;
            case 4:
                  Console.WriteLine("Você saiu!!");
                break;
            default:
                Console.WriteLine("Opção invália!");
                break;
        }
    } while (opcao != 4);
}

double[] vetPreco = { 25.50, 30.00, 9.90, 12.90 };



ExibirMenu(vetPreco);

