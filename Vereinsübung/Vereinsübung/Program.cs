namespace Vereinsübung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> feldspieler = new List<string>()
            {
                "Felix",
                "Luca",
                "Livio",
                "Rafael",
                "Julian",
                "Bennett",
                "Max",
                "Tobias",
                "Damian",
                "Janik"
            };
            List<string> torwarte = new List<string>()
            {
                "Alex",
                "Mirco"
            };
            
            
            
            Verein FCRJ = new Verein("Fussball Club Rapperswil-Jona", "Thomas");
            FCRJ.setMannschaft("Wir sind die Besten!", feldspieler, torwarte);

        }
    }
}
