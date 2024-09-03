
namespace Labirintus
{
    internal class LabSim
    {
        private List<string> adatsorok = [];
        private char[,] lab;

        public bool KeresesKesz { get; set; }
        public bool NincsMegoldas { get; set; }
        public int OszlopokSzama => adatsorok[0].Length;
        public int SorokSzama => adatsorok.Count;
        public int KijaratOszlopIndex => OszlopokSzama - 1;
        public int KijaratSorIndex => SorokSzama - 2;

        public void AdatsorokBeolvasasa(string forras)
        {
            using StreamReader sr = new(@$"..\..\..\src\{forras}");
            while (!sr.EndOfStream)adatsorok.Add(sr.ReadLine());
        }

        public void LabFeltoltese()
        {
            for (int s = 0; s < adatsorok.Count; s++)
            {
                for (int o = 0; o < adatsorok[s].Length; o++)
                {
                    lab[s, o] = adatsorok[s][o];
                }
            }
        }

        public LabSim(string fileName)
        {
            AdatsorokBeolvasasa(fileName);
            lab = new char[SorokSzama,OszlopokSzama];
            LabFeltoltese();
        }
    }
}
