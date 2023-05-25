using kutyak;

List<KutyaNevek> kutyaNevek = new List<KutyaNevek>();
List<KutyaFajtak>kutyaFajtak = new List<KutyaFajtak>();
List<Kutyak>kutyak= new List<Kutyak>();
File.ReadAllLines("KutyaNevek.csv").ToList().ForEach(x => kutyaNevek.Add(new KutyaNevek(x)));
File.ReadAllLines("KutyaFajtak.csv").ToList().ForEach(x => kutyaFajtak.Add(new KutyaFajtak(x)));
File.ReadAllLines("Kutyak.csv").ToList().ForEach(x => kutyak.Add(new Kutyak(x)));
