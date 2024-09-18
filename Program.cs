using _0911_consoleapp;
#region cica lista
List<Cat> cats = [
    new() { //01
        Id = 1,
        Name = "Kolombus",
        Sex = true,
        Birth = new DateTime(2020, 06, 20),
        Weight = 3.0F,
        Breed = "házimacska"
    },
    new() { //02
        Id = 2,
        Name = "Zigzag",
        Sex = false,
        Birth = new DateTime(2016, 08, 19),
        Weight = 2.1F,
        Breed = "házimacska"
    },
    new() { //03
        Id = 3,
        Name = "Pizsama",
        Sex = false,
        Birth = new DateTime(2022, 07, 11),
        Weight = 2.5F,
        Breed = "britt rövidszőrű"
    },
    new() { //04
        Id = 4,
        Name = "Megatron",
        Sex = true,
        Birth = new DateTime(2024, 05, 01),
        Weight = 0.9F,
        Breed = "szfinx"
    },
    new() { //05
        Id = 5,
        Name = "Bogyi",
        Sex = false,
        Birth = new DateTime(2021, 02, 14),
        Weight = 2.4F,
        Breed = "britt rövidszőrű"
    },
    new() { //06
        Id = 6,
        Name = "Rozi",
        Sex = false,
        Birth = new DateTime(2021, 10, 28),
        Weight = 4.0F,
        Breed = "perzsa"
    },
    new() { //07
        Id = 7,
        Name = "Kombájn",
        Sex = true,
        Birth = new DateTime(2008, 07, 01),
        Weight = 5.1F,
        Breed = "perzsa",
    },
    ];
#endregion

/* eddig ismert nevezetes algoritmusok
 * sorozatszámítás (összegzés) => átlagszámítás
 * megszámlálás
 * szélsőérték meghatározás (minimum, maximum)
 * lineáris keresés
 * kiválasztás
 * eldöntés
 * 
 * kiválogatás
 * szétválogatás
 * "rendezés"
 * halmaztételek
 */

float linqOsszegzes = cats.Sum(c => c.Weight);
Console.WriteLine($"Cicák összsúlya: {linqOsszegzes} Kg");

double linqÁtlag = cats.Average(c => c.Age);
Console.WriteLine($"Cicák átlagéeletkora: {linqÁtlag} év");

int linqHazimacskaSzama = cats.Count(c => c.Breed == "házimacska");
Console.WriteLine($"Házimacskák száma: {linqHazimacskaSzama} db");

DateTime linqLegfiatalabbMacsa = cats.Max(c => c.Birth);
Console.WriteLine($"Legfiatalabb macska születési dátuma: {linqLegfiatalabbMacsa:yyyy-MM-dd}");

Cat? legveznabbmacska = cats.MinBy(c => c.Weight);
Console.WriteLine($"Legkisebb súlyú macska: {legveznabbmacska}");

int abcbenElsoCIca = cats.IndexOf(cats.MinBy(c => c.Name));
Console.WriteLine($"ABC-ben első cica indexe: {abcbenElsoCIca}");

Console.WriteLine("Cica neve szerint rendezve: ");
var nevSzerintRendezve = cats.OrderBy(c => c.Name);
foreach (var c in nevSzerintRendezve)
{
    Console.WriteLine($"\t- {c}");
}

Console.WriteLine("--------------------------------------------------------------------------------------------------");

Console.WriteLine("Súly szerint csökkenő:");
var sulySzerintCsokkeno = cats.OrderByDescending(c => c.Weight);
foreach (var c in sulySzerintCsokkeno)
{
    Console.WriteLine($"\t- {c}");
}


/* first
 * firstordefault
 * last
 * lastordefault
 * single
 * singleordefault
 *-------------
 * find
 * find all
 * index of
 */

var first = cats.First(c => c.Breed == "unikornis");
Console.WriteLine($"Az első perzsa cica: {first}");
//ha VAN EGYEZÉS, akkor az első "matching element"-el tár vissza
//ha nincs egyezés, akkor "sequence contains no matching element" exception-t dob


var lst = cats.Last(c => c.Sex);
Console.WriteLine($"Az utolsó kisfiú: {lst}");
//ha VAN EGYEZÉS, akkor az UTOLSÓ "matching element"-el tár vissza
//ha nincs egyezés, akkor "sequence contains no matching element" exception-t dob

var single = cats.Single(c => c.Breed == "szfinx");
Console.WriteLine($"Az egyetlen szfinx: {single}");
//ha EGYETLEN EGY egyezés van, akkor a matching element-el tér vissza
//ha több egyezés van, akkor "sequence contains more than one matching element" exception-t dob
//ha egyáltalán nincs egyezés, akkor "sequence contains no matching element" exception-t dob


var firstod = cats.FirstOrDefault(c => c.Breed == "perzsa");
Console.WriteLine($"Az első perzsa cica: {first}");
//ha VAN EGYEZÉS, akkor az első "matching element"-el tár vissza
//ha nincs egyezés, akkor ún. "default value"-val tér vissza (null, 0, false, stb.)


var lastod = cats.LastOrDefault(c => c.Sex);
Console.WriteLine($"Az utolsó kisfiú: {lastod}");
//ha VAN EGYEZÉS, akkor az UTOLSÓ "matching element"-el tár vissza
//ha nincs egyezés, akkor "sequence contains no matching element" exception-t dob


var singleod = cats.SingleOrDefault(c => c.Breed == "szfinx");
Console.WriteLine($"Az egyetlen szfinx: {singleod}");
//ha EGYETLEN EGY egyezés van, akkor a matching element-el tér vissza
//ha nincs egyezés, akkor ún. "default value"-val tér vissza (null, 0, false, stb.)

