using UC12_ER2.Interfaces;
using System.Text.RegularExpressions;

namespace UC12_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        public string ?razaosocial { get; set; }
        
        
        
        
        public override float PagarImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        /*
            XX.XXX.XXX/0001-XX
            \d{2}
        */


        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18) 
                {
                    if(cnpj.Substring(11,4) == "0001") // ele vai iniciar no caracter 11 e pegar os próximos 4
                    {
                        return true;
                    }
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001") //ele vai iniciar no caractere 8 e pegar os próximos 4
                    {
                        return true;
                    }
                }
            }
           return false;            
        }
    }
}