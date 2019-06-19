namespace Aula136.Entities
{
    abstract class TaxPayer     //Uma vez tendo uma declaração abstrata, a classe toda será abstrata.
    {
        public string Name { get; set; }        //Nome
        public double AnualIncome { get; set; }     //Rendimento anual

        public TaxPayer()       //Contribuinte. Construtor vazio
        {
        }

        protected TaxPayer(string name, double anualIncome)         //Contribuinte. Dados do contribuinte inseridos
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();           //Imposto. Declaração abstrata para que seja calculada individualmente
                                                // em cada caso, seja pessoa física, jurídica...
    }
}
