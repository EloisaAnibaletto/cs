using System;
using System.Collections.Generic;
					
namespace Animais {
	public class Animal{
		int id;
		string nome;
		
		public Animal(
        	int id,
        	string nome)
		{
        	this.id = id;
        	this.nome = nome;
    	}
		public Animal()
		{
		}
		
		public int Id {get;set;}
		public string Nome {get;set;}
		
		public class Leao : Animal{
			public Leao() : base (){}
		}
	 	
		public static void Main()
		{
			List<Leao> Leao = new List<Leao>();
			
			//Adicionando itens na lista
			Leao.Add(new Leao() {id=1,nome="tufi"});
			Leao.Add(new Leao() {id=2,nome="simba"});
			Console.WriteLine("Lista de leões: ");
			
			foreach(Leao leoes in Leao)
			{
				Console.WriteLine(leoes.id + " " + leoes.nome);
			}
			Console.WriteLine("\n");
			try
			{
				//Simulando erro
				Leao.RemoveAt(5);
				Console.WriteLine("\nLista após remoção: ");
				foreach(Leao leoes in Leao)
				{
					Console.WriteLine(leoes.id + " " + leoes.nome);
				}
			}catch(Exception ex)
			{
				Console.Write(ex.Message);	
			}
			
			try
			{
				//Removendo índice 1
				Leao.RemoveAt(1);
				Console.WriteLine("\n\nLista após remoção: ");
				foreach(Leao leoes in Leao)
				{
					Console.WriteLine(leoes.id + " " + leoes.nome);
				}
			}
			catch(Exception ex)
			{
				Console.Write(ex.Message);	
			}
			
			//Alterando nome do leão
			Leao[0].nome = "fofo";
			Console.WriteLine("\nNome alterado:");
			foreach(Leao leoes in Leao)
				{
					Console.WriteLine(leoes.id + " " + leoes.nome);
				}
		}
	}
}