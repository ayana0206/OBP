namespace Vereinsübung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Verein FCRJ = new Verein("Fussball Club Rapperswil-Jona", "Thomas");
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
            FCRJ.addMannschaft("u21M", feldspieler, torwarte);

        }
    }
}
