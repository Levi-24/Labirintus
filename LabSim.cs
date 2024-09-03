
namespace Labirintus
{
    internal class LabSim
    {
        private List<string> adatsorok;
        private char[,] lab;

        public bool KeresesKesz { get; set; }
        public int KijaratOszlopIndex { get; }
        public int KijaratSorIndex { get; }
        public bool NincsMegoldas { get; set; }
        public int OszlopokSzama { get; }
        public int SorokSzama { get; }

        public void AdatsorokBeolvasasa(string forras)
        {
            using StreamReader sr = new(@$"..\..\..\src\{forras}");
        }

        public LabSim(string fileName)
        {
            AdatsorokBeolvasasa(fileName);
        }
    }
}
