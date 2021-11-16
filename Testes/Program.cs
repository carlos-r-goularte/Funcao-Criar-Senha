using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            char opcao;
            int senha = 0;
            do
            {
                Console.WriteLine("Digite uma opcao: ");
                Console.WriteLine("1 - Criar Senha");
                Console.WriteLine("2 - Entrar na Conta");
                Console.WriteLine("X - Sair");
                opcao = char.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case '1':
                        senha = criarsenha();
                        Console.WriteLine("Sua Senha é #{0}", senha);
                        break;
                    case '2':
                        entrarconta(senha);
                        break;
                    default:
                        break;
                }
            } while (opcao != 'X');

            Console.WriteLine("Até Logo!");
        }


        static int criarsenha()
        {
            int senhacorreta = 0;
            Console.Write("Digite uma senha de 4 dígitos: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Repita sua nova senha: ");
            int b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                senhacorreta = b;
            }
            return senhacorreta;
        }


        static int entrarconta(int senha)
        {
            Console.Write("Digite sua senha de 4 dígitos: ");
            int senhadigitada = int.Parse(Console.ReadLine());

            if (senhadigitada != senha)
            {
                Console.WriteLine("Senha Inválida!");
            }
            else
            {
                Console.WriteLine("Acesso Permitido!");
                Environment.Exit(1);
            }
            return 0;
        }
    }
}