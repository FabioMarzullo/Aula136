namespace Aula136.Entities
{
    class Company : TaxPayer        //Informa que a classe "Company" vai receber as informações contidas na classe "TaxPayer".
    {
        public int NumberOfEmployees { get; set; }      //Número de Empregados
        public Company()        //Empresa. Construtor vazio
        {
        }
        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)       //dados vindos da classe "TaxPayer" (contribuinte)
        {
            NumberOfEmployees = numberOfEmployees;      //Número de Empregados
        }

        public override double Tax()        //O Override informa que os dados serão recebidos da declaração abstrata "Tax"
                                            //na classe "TaxPayer" (contribuinte).
        {
            if (NumberOfEmployees > 10)
            {
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
