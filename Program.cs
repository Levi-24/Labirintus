using Labirintus;

Console.WriteLine($"5.Feladat: Labirintus adatai:");

LabSim labSim = new LabSim("Lab1.txt");

Console.WriteLine($"\tOszlopok száma: {labSim.OszlopokSzama}");
Console.WriteLine($"\tSorok száma: {labSim.SorokSzama}");
Console.WriteLine($"\tKijárat indexe: {labSim.KijaratSorIndex}, {labSim.KijaratOszlopIndex}");

Console.WriteLine($"\n6.Feladat: Labirintus megjelenitese:");
labSim.LabKiiras();
