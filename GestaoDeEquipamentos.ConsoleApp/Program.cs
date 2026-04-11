﻿using GestaoDeEquipamentos.ConsoleApp.Apresentacao;

TelaEquipamento telaEquipamento = new TelaEquipamento();
TelaChamado telaChamado = new TelaChamado();

while (true)
{
    Console.Clear();
    Console.WriteLine("\nGestão de Equipamentos\n");
    Console.WriteLine("1 - Gerenciar equipamentos");
    Console.WriteLine("2 - Gerenciar chamados");
    Console.WriteLine("S - Sair");
    Console.Write("\n> ");
    string? opcaoMenuPrincipal = Console.ReadLine()?.ToUpper();

    if (opcaoMenuPrincipal == "S")
    {
        Console.Clear();
        break;
    }

    while (true)
    {
        if (opcaoMenuPrincipal == "1")
        {
            string? opcaoMenu = telaEquipamento.ObterEscolhaMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaEquipamento.Cadastrar();

            else if (opcaoMenu == "2")
                telaEquipamento.Editar();

            else if (opcaoMenu == "3")
                telaEquipamento.Excluir();

            else if (opcaoMenu == "4")
                telaEquipamento.VisualizarTodos();
        }
        else if (opcaoMenuPrincipal == "2")
        {

        }
    }
}