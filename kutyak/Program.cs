using kutyak;

List<KutyaNevek> kutyaNevek = new List<KutyaNevek>();
List<KutyaFajtak>kutyaFajtak = new List<KutyaFajtak>();
List<Kutyak>kutyak= new List<Kutyak>();
File.ReadAllLines("KutyaNevek.csv").Skip(1).ToList().ForEach(x => kutyaNevek.Add(new KutyaNevek(x)));
File.ReadAllLines("KutyaFajtak.csv").Skip(1).ToList().ForEach(x => kutyaFajtak.Add(new KutyaFajtak(x)));
File.ReadAllLines("Kutyak.csv").Skip(1).ToList().ForEach(x => kutyak.Add(new Kutyak(x)));


Console.WriteLine($"3. feladat: Kutyanevek száma: {kutyaNevek.Count}");
Console.WriteLine($"6. feladat: Kutyák átlag életkora: {Math.Round(kutyak.Average(x => x.Eletkor),2)}");
Kutyak legidosebb = kutyak.Find(x => x.Eletkor == kutyak.Max(x => x.Eletkor));
KutyaNevek neve = kutyaNevek.Find(x => x.Id == legidosebb.NevId);
KutyaFajtak fajta = kutyaFajtak.Find(x => x.Id == legidosebb.FajtaId);
Console.WriteLine($"7. feladat: Legidősebb kutya neve és fajtája: {neve.Kutyanev}, {fajta.Nev}");
KutyaFajtak masodik;
Console.WriteLine("8.feladat: Január 10.-én vizsgált kutya fajták:");
kutyak.Where(x => x.Orvos == "2018.01.10").GroupBy(x => x.FajtaId).ToList().ForEach(x => Console.WriteLine($"{masodik = kutyaFajtak.Find(y => y.Id == x.Key)} ;{masodik.Nev}; {x.Count()}"));




