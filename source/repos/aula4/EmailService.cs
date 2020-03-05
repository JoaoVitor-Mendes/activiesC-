using System;



	internal class EmailService()
	{
		public static void EnviarEmail(Pessoa pessoa){
			=> Console.WriteLine($"Para: {pessoa.Email}, Mensagem: Olá {pessoa.Nome}");
	}

