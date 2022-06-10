using System;

namespace CadastroConsultorio
{

    class Cadastro
    {
        public string mensagemDeBoasVindas = "Boas vindas ao console de cadastros de clientes! O que você deseja fazer?";
        public string mensagemOpcao1 = "Digite 1 para ver os registros dos clientes";
        public string mensagemOpcao2 = "Digite 2 para registrar novo cliente";

        static void Main(string[] args)
        {
            ConsoleMensagens.ConsoleBoasVindas();
        }

        class ConsoleMensagens : Cadastro
        {
            public static void ConsoleBoasVindas()
            {
                /// <summary>
                /// Exibe mensagem de boas-vindas para o usuário   
                /// </summary>
                Cadastro mensagens = new Cadastro();
                Console.WriteLine(mensagens.mensagemDeBoasVindas);
                ConsoleOpcoesAdm();
            }
            public static void ConsoleOpcoesAdm()
            {
                /// <summary>
                /// Exibe mensagem das opções diponíveis para o usuário
                /// </summary>
                Cadastro mensagens = new Cadastro();
                Console.WriteLine(mensagens.mensagemOpcao1);
                Console.WriteLine(mensagens.mensagemOpcao2);
                string userInput = Console.ReadLine();
                userInputNumber.ConsoleInput(userInput);
            }
        }
        class userInputNumber
        {
            public static void ConsoleInput(string userInput)
            {
                switch (userInput)
                {
                    case "1":
                        number1 number1 = new number1();
                        number1.outputNumber();
                        ConsoleMensagens.ConsoleOpcoesAdm();
                        break;
                    case "2":
                        number2 number2 = new number2();
                        number2.outputNumber();
                        ConsoleMensagens.ConsoleOpcoesAdm();
                        break;
                    default:
                        Console.WriteLine("Por favor, digite novamente e coloque números válidos.");
                        Console.WriteLine("\n");
                        Console.WriteLine("\n");
                        break;
                }
            }

        }
        class number1 : userInputNumber
        {
            public void outputNumber()
            {
                Console.WriteLine("Você selecionou a primeira opção");
            }
        }

        class number2 : userInputNumber
        {
            public void outputNumber()
            {
                Console.WriteLine("Você selecionou a segunda opção");
                Clientes.Registropaciente registro = new Clientes.Registropaciente();
                Console.WriteLine("Digite o nome:");
                registro.name = Console.ReadLine();
                Console.WriteLine("Digite o CPF: ");
                registro.CPF = Console.ReadLine();
                Console.WriteLine("Digite a idade:");
                registro.idade = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}

