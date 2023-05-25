using kutyak;

List<KutyaNevek> kutyaNevek = new List<KutyaNevek>();
List<KutyaFajtak>kutyaFajtak = new List<KutyaFajtak>();
List<Kutyak>kutyak= new List<Kutyak>();
File.ReadAllLines("KutyaNevek.csv").Skip(1).ToList().ForEach(x => kutyaNevek.Add(new KutyaNevek(x)));
File.ReadAllLines("KutyaFajtak.csv").Skip(1).ToList().ForEach(x => kutyaFajtak.Add(new KutyaFajtak(x)));
File.ReadAllLines("Kutyak.csv").Skip(1).ToList().ForEach(x => kutyak.Add(new Kutyak(x)));


Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyaNevek.Count}");
Console.WriteLine($"6. feladat: Kutyák átlag életkora: {Math.Round(kutyak.Average(x => x.Eletkor),2)}");
int legidosebb = kutyak.Max(x => x.Eletkor);
int nevId=0;
foreach (var item in kutyak)
{
    if (item.Eletkor == kutyak.Max(x => x.Eletkor)){
        nevId = item.NevId;
        break;
    }
}
string nev = "";
foreach (var item in kutyaNevek)
{
    if (item.Id==nevId)
    {
        nev=item.Kutyanev; 
        break;
    }
}

Console.WriteLine($"7. feladat: Legidősebb kutya neve és fajtája: {nev}+");