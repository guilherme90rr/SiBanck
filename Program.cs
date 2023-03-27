using SiBanck;

ContaCorrente contaDoAndre = new ContaCorrente();
contaDoAndre.titular = "André Silva";
contaDoAndre.numero_agencia = 15;
contaDoAndre.conta = "1010-x";
contaDoAndre.saldo = 100;
Console.WriteLine("Saldo da conta do André = " + contaDoAndre.saldo);

//ContaCorrente contaDoAndre2 = new ContaCorrente();
//contaDoAndre2.titular = "André Silva";
//contaDoAndre2.numero_agencia = 15;
//contaDoAndre2.conta = "1010-x";
//contaDoAndre2.saldo = 100;

//Console.WriteLine("Saldo da conta do André = " + contaDoAndre2.saldo);
//Console.WriteLine(contaDoAndre == contaDoAndre2);

ContaCorrente contaDaMaria = new ContaCorrente();
contaDaMaria.titular = "Maria Souza";
contaDaMaria.numero_agencia = 17;
contaDaMaria.conta = "1015-x";
contaDaMaria.saldo = 350;

Console.WriteLine("Saldo da conta do Maria = " + contaDaMaria.saldo);

contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo do André =" + contaDoAndre.saldo);
Console.WriteLine("Saldo da Maria =" + contaDaMaria.saldo);

ContaCorrente contadoPedro = new ContaCorrente();
contadoPedro.titular = "Pedro Silva";
Console.WriteLine(contadoPedro.titular);
Console.WriteLine(contadoPedro.saldo);
Console.WriteLine(contadoPedro.numero_agencia);
Console.WriteLine(contadoPedro.conta);

