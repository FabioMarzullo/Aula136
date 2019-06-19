namespace Aula136.Entities
{
    class Individual : TaxPayer     //Informa que a classe Individual vai receber as informações contidas na classe "TaxPayer".
    {

        public double HealthExpenditures { get; set; }      //Despesas de Saúde. Construtor criado
        public Individual()     //Pessoa Física. Construtor vazio criado
        {
        }
        public Individual(string name, double anualIncome, double healthExpenditures)       //iserção de dados de pessoas
                                                                                            //física no construtor
            : base(name, anualIncome)       //dados vindos da classe "TaxPayer" (contribuinte)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()        //O Override informa que os dados serão recebidos da declaração abstrata "Tax"
                                            //na classe "TaxPayer" (contribuinte).
        {
            if (AnualIncome < 20000.0)      //Rendimento
            {
                return AnualIncome * 0.15 - HealthExpenditures * 0.5;       //Despesas de Saúde.
            }
            else
            {
                return AnualIncome * 0.25 - HealthExpenditures * 0.5;
            }
        }
    }
}
