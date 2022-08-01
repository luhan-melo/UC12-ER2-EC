// See https://aka.ms/new-console-template for more information

using UC12_ER2.Classes;

/*
PessoaFisica novaPf = new PessoaFisica();
Endereco novoEnd = new Endereco();

PessoaFisica metodoPf = new PessoaFisica();


novaPf.nome = "Luiz";
novaPf.dataNascimento = "18/02/1984";
novaPf.cpf = "12345678900";
novaPf.rendimento = 600.0f;

novoEnd.logradouro = "Alameda Barao de Limeira";
novoEnd.numero = 539;
novoEnd.complemento = "Senai Informatica" ;
novoEnd.endComercial = true;

novaPf.endereco = novoEnd;

Console.WriteLine(@$"
Nome: {novaPf.nome}
Endereço: {novaPf.endereco.logradouro}, {novaPf.endereco.numero}
Maior de idade: {metodoPf.ValidarDataNascimento(novaPf.dataNascimento)}
");
*/




/*
novaPf.nome = "Lozano";

Console.WriteLine(novaPf.nome);
Console.WriteLine("Nome: " + novaPf.nome);
Console.WriteLine($"Nome: {novaPf.nome}");
*/

// Console.WriteLine(novaPf.ValidarDataNascimento(new DateTime(2000,01,01)));

// Console.WriteLine(novaPf.ValidarDataNascimento("01/01/2000"));

PessoaJuridica metodoPj = new PessoaJuridica();
PessoaJuridica novaPj = new PessoaJuridica();
Endereco novoEndPj = new Endereco();

novaPj.nome = "NomePj";
novaPj.cnpj = "00000000000100";
novaPj.razaosocial = "Razao Social Pj";

novoEndPj.logradouro = "Alameda Barao de Limeira";
novoEndPj.numero = 539;
novoEndPj.complemento = "Senai Informatica" ;
novoEndPj.endComercial = true;
novaPj.endereco = novoEndPj;

Console.WriteLine(@$"
Nome: {novaPj.nome}
Razao social: {novaPj.razaosocial}
CNPJ: {novaPj.cnpj}
CNPJ é válido: {metodoPj.ValidarCnpj(novaPj.cnpj)}");
