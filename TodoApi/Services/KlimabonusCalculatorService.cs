using TodoApi.Controllers;

namespace TodoApi.Services
{
    //1. Interface definieren
    public interface IKlimabonusCalculatorService
    {
        //Abtrackt -  forder die Implementierung der Methode CalcKlimabonus
        double CalcKlimabonus(KlimabonusRequest request);
    }

    //2. Implementierung und Registrierung
    //Burgenland implementiert konkret das Interface IKlimabunusCalculatorServie
    //Registrierung unter Programm - (new ServiceDescriptor(typeof(IKlimabonusCalculatorService), 
    // new KlimabonusCalculatorServiceBurgenland()));

    public class KlimabonusCalculatorServiceBurgenland : IKlimabonusCalculatorService
    {
        public double CalcKlimabonus(KlimabonusRequest request)
        {
            double ergebnis = 0;

            if (request.Alter < 22)
                ergebnis = 120;
            else
                ergebnis = 250;
            return ergebnis;
        }
    }

    //3. Constructor Injection
    /*
     * 
     
    IKlimabonusCalculatorService _calculator;

    //Constructor Injection

    public KlimabonsuController(IKlimabonusCalculatorService calculator)
    {
        _calculator = calculator;
    }
    */


    public class KlimabonusCalculatorServiceSteiermark : IKlimabonusCalculatorService
    {
        public double CalcKlimabonus(KlimabonusRequest request)
        {
            double ergebnis = 0;

            if (request.Alter < 20)
                ergebnis = 200;
            else
                ergebnis = 250;
            return ergebnis;
        }
    }


    public class KlimabonusCalculatorService: IKlimabonusCalculatorService
    {
        public  double CalcKlimabonus(KlimabonusRequest request)
        {
            double ergebnis = 0;

            if (request.Alter < 18)
                ergebnis = 250;
            else
                ergebnis = 500;
            return ergebnis;
        }
    }
}
