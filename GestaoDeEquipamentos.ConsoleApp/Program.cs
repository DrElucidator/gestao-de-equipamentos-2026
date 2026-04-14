﻿using GestaoDeEquipamentos.ConsoleApp.Apresentacao;
using GestaoDeEquipamentos.ConsoleApp.Dominio;
using GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

RepositorioEquipamento repositorioEquipamento = new RepositorioEquipamento();
RepositorioChamado repositorioChamado = new RepositorioChamado();
RepositorioFabricante repositorioFabricante = new RepositorioFabricante();
repositorioFabricante.CarregarFabricantes();
repositorioEquipamento.CarregarEquipamentos();

TelaFabricante telaFabricante = new TelaFabricante();
telaFabricante.repositorio = repositorioFabricante;
telaFabricante.repositorioEquipamento = repositorioEquipamento;

TelaEquipamento telaEquipamento = new TelaEquipamento();
telaEquipamento.repositorio = repositorioEquipamento;
telaEquipamento.repositorioFabricante = repositorioFabricante;

TelaChamado telaChamado = new TelaChamado();
telaChamado.repositorioChamado = repositorioChamado;
telaChamado.repositorioEquipamento = repositorioEquipamento;
telaChamado.repositorioFabricante = repositorioFabricante;

while (true)
{
    Console.Clear();
    Console.WriteLine("\nGestão de Equipamentos\n");
    Console.WriteLine("1 - Gerenciar fabricantes");
    Console.WriteLine("2 - Gerenciar equipamentos");
    Console.WriteLine("3 - Gerenciar chamados");
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
            string? opcaoMenu = telaFabricante.ObterEscolhaMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaFabricante.Cadastrar();

            else if (opcaoMenu == "2")
                telaFabricante.Editar();

            else if (opcaoMenu == "3")
                telaFabricante.Excluir();

            else if (opcaoMenu == "4")
                telaFabricante.VisualizarTodos();
        }
        if (opcaoMenuPrincipal == "2")
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
        else if (opcaoMenuPrincipal == "3")
        {
            string? opcaoMenu = telaChamado.ObterEscolhaMenuPrincipal();

            if (opcaoMenu == "S")
            {
                Console.Clear();
                break;
            }

            if (opcaoMenu == "1")
                telaChamado.Cadastrar();

            else if (opcaoMenu == "2")
                telaChamado.Editar();

            else if (opcaoMenu == "3")
                telaChamado.Excluir();

            else if (opcaoMenu == "4")
                telaChamado.VisualizarTodos();
        }
    }
}