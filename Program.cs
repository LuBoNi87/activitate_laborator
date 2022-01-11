using System;
using System.Media;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activitate_laborator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(@"1. Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si 
invers utilizand instructiunea switch.
2. Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică: 
adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru 
selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să 
ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii, 
înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.
3. Fie i,j,k. Să se determine restul împărţirii numărului natural ij
la k.
4. Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma 
divizorilor lui diferiţi de n; exemplu: 6=1+2+3).
5. Să se determine numerele perfecte din intervalul [a,b], pentru a,b date.
6. Două numere întregi x şi y sunt ""prietene"" dacă suma divizorilor numărului x este egală cu 
suma divizorilor numărului y.Să se găsească numerele ""prietene"" din intervalul[a, b].
7.Fie n, k.Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte
k.
8.Fie a.Să se scrie un algoritm pentru calculul mediei aritmetice, geometrice şi armonice a
tuturor divizorilor lui a.
9.Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două
numere întregi aşi b.
10.Să se afişeze primele n numere prime.
11.Să se determine dacă două numere sunt prime între ele sau nu.
12.Elaboraţi un program care să tipărească tabela de temperaturi Fahrenheit şi echivalenţele lor
în centigrade sau grade Celsius, folosind formula: C = (5 / 9) * (F - 32), între valorile extreme 0 şi
300 grade Fahrenheit.
13.Elaboraţi un program care să tipărească tabela corespunzătoare Celsius - Fahrenheit.
14.Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, şi să
determine cel mai mic număr şi cel mai mare număr citit.
15.Scrieţi un program care să calculeze factorialul unui număr întreg n.
16.O carte are n foi şi r rânduri pe fiecare pagină.Câte rânduri are cartea ?
17.Un punct material se află la distanţa x0 de origine, la momentul iniţial t0, când începe să se
mişte rectiliniu uniform.Çtiind că la momentul t se află la distanţa x faţă de origine, să se
determine viteza v de mişcare a punctului material, la momentul t.
18.Să se scrie un program care să citească două numere reale a şi b.Apoi să pună utilizatorului o
întrebare: Ce doriţi să calculăm ? Media aritmetică(1) sau geometrică(2)?.Dacă se va
răspunde prin 1, se va calcula şi afişa media aritmetică, iar pentru 2 media geometrică(numai
dacă numerele sunt pozitive!, iar de nu, se va afişa ‘eroare!’).Dacă nu se răspunde prin 1
sau 2 se va produce un sunet în difuzor.
19.Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de
genul: Ce doriţi să calculăm ? Aria sau perimetrul?.Dacă se va răspunde prin ‘aria’ atunci se
va calcula şi afişa aria, altfel perimetrul.
20.Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0.Să se calculeze media
aritmetică a numerelor din şir.
21.Se citesc 3 numere naturale n, p şi k, apoi un şir de n numere naturale.Câte dintre acestea,
împărţite la p dau restul k ?
22.Să se calculeze produsul a două numere naturale prin adunări repetate.
23.Efectuaţi împărţirea întreagă a două numere, făra a utiliza operatorii / şi %, ci doar scăderi
repetate.
24.Se citeşte un număr natural.Câte cifre conţine ?
25.Un număr se numeşte “palindrom” dacă citit invers este acelaşi număr.Să se verifice dacă un
număr este sau nu palindrom.
26.Să se afişeze toate numerele prime mai mici sau egale cu un numar m dat.
27.Să se afişeze primele n numere prime care au suma cifrelor ≤m.
28.Să se afişeze toate numerele de 3 cifre care, citite invers, sunt tot numere prime.
29.Să se listeze toate numerele ≤n, a căror sumă a cifrelor este divizibilă prin 5.
30.Să se transforme un număr din baza 10 în baza p < 10.Să se transforme un număr din baza
p < 10 în baza 10.
31.Să se genereze toate numerele prime mai mici decât numărul natural n dat.
32.Să se afişeze primele n numere prime care au suma cifrelor mai mică sau egală cu m.
33.Să se afişeze toate numerele prime de 3 cifre care citite invers sunt tot numere prime.
34.Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în
grade şi una care să facă transformarea inversă.
35.Scrieti o functie cu numele putere care primeste prin parametrul n un numar natural cu cel mult
9 cifre si care furnizeaza prin parametrii x si k doua numere naturale cu proprietatea ca n = xk si x
este minim.
36. 1.Scrie o metodă care primește ca parametru un număr natural x și apoi afișează:
-cifrele numărului(în ordine inversă)
- suma cifrelor
// n == 21304
Cifrele numărului sunt: 4, 0, 3, 1, 2,
Suma cifrelor este: 10
37.Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci, şir definit de relaţia de
recurenta: f(n) = f(n - 2) + f(n - 1); f(1) = 1, f(2) = 1.
38.Scrieţi o functie care să calculeze factorialul unui număr întreg n.
39.Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore, 
minute şi secunde.
40.Viteza unui automobil este de v km/ h.Scrieti o functie prin care sa exprimaţi această viteză
în m/ s.
41.Un muncitor lucrează n zile pentru a termina o lucrare.Scrieti o functie prin care sa se
determine câte zile sunt necesare pentru a termina aceeaşi lucrare o echipă de mmuncitori.
42.Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.
43.Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou.
De exemplu introduceți lungimea tabloului: 5.
Introduceți elementele tabloului: 9 10 20 8 7
Tabloul inițial este: 9 10 20 8 7
Pătratul elementelor tabloului inițial este: 81 100 400 64 49
44.Să se scrie o functie pentru aflarea tablei inmulțirii unui număr utilizând bucla for și
reprezentați - o în formatul corespunzător.
45.Să se scrie o funcție care inversează elementele memorate într - un tablou.
46.Un palindrom este un număr sau o frază care se citește la fel de la început cât și de la sfârșit.
De exemplu, fiecare dintre următoarele numere întregi formate din cinci cifre este un
palindrom: 12321, 55555, 45554 și 11611.Să se scrie o functie care primeste un număr și
verifică dacă este palindrom sau nu. (Utilizați operatorii de împărțit și rest pentru a separa
numărul în cifre individuale.).
47.Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99 întrun tablou și care afișează numerele care se repetă în tablou.
48.Să se scrie un program care adună două matrici de dimensiune nxn.
49.Sa se scrie o functie care calculeaza media aritmetica a elementelor pare dintr - un vector de
numere intregi.
50.Functia care determina daca un vector dat e ordonat crescator.
51.Functia care determina minimul unui vector dat.
52.Functia care determina daca un vector dat are numai elem impare.
53.Functia care determina daca un vector dat are numai elem pare.
54.Functia care determina raportul dintre elem pare si elem impare dintr - un vector.
55.Fie X un vector cu n componente numere întregi.Să se calculeze expresia:
e = x1 - x2 + x3 - x4 +….±xn.
56.Să se construiască un vector v cu primii termeni ai şirului lui Fibonacci.Şirul are primii
doi termeni egali cu 1 şi fiecare din termenii următori este egal cu suma dintre termenul
precedent şi termenul anteprecedent.
57.Se citesc de la tastatură n <= 100, un număr natural și n numere întregi.Determinați poziția
primului element din vector cu proprietatea că este medie aritmetică între succesorul și
predecesorul său. (Pentru a determina primul element(de indice minim) cu o anumită
proprietate, se parcurge vectorul de la stânga la dreapta până când găsim primul element cu
proprietatea cerută sau până când epuizăm elementele vectorului).
58.Se citesc de la tastatură k, un număr întreg, n <= 1000, un număr natural și n numere întregi.
Determinați poziția ultimului element din vector cu proprietatea că este egal cu k. (Pentru a
determina ultimul element cu o anumită proprietate, se parcurge vectorul de la dreapta spre
stânga(în ordinea descrescătoare a indicilor până când găsim primul element cu proprietatea
cerută sau până când epuizăm elementele vectorului).
59.Se citesc de la tastatură poz <= n <= 1000, două numere naturale și n numere întregi.Eliminați
din vector elementul aflat pe poziția poz. (pentru eliminarea elementului din poziţia poz, se
observă că primele poz - 1 elemente rămân neschimbate, în timp ce elementele din poziţiile
poz + 1, poz + 2,……., n se deplasează cu o poziţie spre stânga pentru a “umple” golul rămas
prin eliminarea elementului din poziţia poz.Evident, dimensiunea vectorului scade cu o
unitate).
60.Se citesc de la tastatură k, un număr întreg, n <= 1000, un număr natural și n numere întregi.
Eliminați din vector toate elementele egale cu k. (Pentru a determina ultimul element cu o
anumită proprietate, se parcurge vectorul de la dreapta spre stânga(în ordinea descrescătoare
a indicilor până când găsim primul element cu proprietatea cerută sau până când epuizăm
elementele vectorului).
61.Se citesc de la tastatură un număr întreg x, k <= n <= 1000, două numere naturale și n numere
întregi.Inserați elementul x în vector pe poziția k. (elementele din poziţiile k, k + 1, .......n
trebuie să se deplaseze cu o poziţie spre dreapta pentru a face loc noii valori x introduse în
poziţia k; dimensiunea vectorului creşte cu o unitate).
62.Se citesc de la tastatură n, un număr natural mai mic decât 100 și cele n elemente reale ale
unui vector. Se cere să se insereze între oricare două elemente ale vectorului media lor
aritmetică.
63.Să se extragă dintr - un vector elementele care au ultima cifră egală cu k şi să se formeze cu
ele un alt vector. Să se afişeze cei doi vectori, unul sub altul. Exemplu: dacă se dau n = 3, k = 7,
v[] = { 17, 23, 47 }, atunci vectorul u va fi { 17, 47}.
64.Se dau n, un număr natural și n numere întregi. Folosind un alt vector, să se aşeze numerele
pare la început. Exemplu: Date de intrare: n = 4 și numerele: 3, 4, 6, 5 Date de ieşire: 4 6 3 5.
65.Se dă un şir cu n elemente, numere naturale.Să se afişeze, în ordine crescătoare, toate valorile
distincte care se pot obţine ca sumă de două elemente distincte din şir.
66.CRB are un șir cu n numere naturale diferite. Nu știe ce să facă cu ele și le aranjează în ordine
descrescătoare.Apoi observă că anumite numere se află pe aceeași poziție ca în șirul inițial. 
Ajutați pe CRB să determine câte elemente din șir respectă această regulă. 
67.Să se scrie un program care ordonează crescător elementele din prima jumătate a unui vector
și descrescător elementele din a doua jumătate.
68.Se citește un șir cu n numere naturale.Să se verifice dacă prin rearajarea elementelor șirului se
poate obține un șir palindrom. 
69.Se dau înălțimile a n copii, numerotați de la 1 la n, exprimate prin numere naturale.Afișați
numerele de ordine ale copiilor în ordinea crescătoare a înălțimii lor. ");
            Console.WriteLine("Numarul problemei pe care vrei sa o rezolvi: ");
            int nrProblema = int.Parse(Console.ReadLine());
            switch (nrProblema)
            {
                case 1: Console.Clear(); Problema1(); break;
                case 2: Console.Clear(); Problema2(); break;
                case 3: Console.Clear(); Problema3(); break;
                case 4: Console.Clear(); Problema4(); break;
                case 5: Console.Clear(); Problema5(); break;
                case 6: Console.Clear(); Problema6(); break;
                case 7: Console.Clear(); Problema7(); break;
                case 8: Console.Clear(); Problema8(); break;
                case 9: Console.Clear(); Problema9(); break;
                case 10: Console.Clear(); Problema10(); break;
                case 11: Console.Clear(); Problema11(); break;
                case 12: Console.Clear(); Problema12(); break;
                case 13: Console.Clear(); Problema13(); break;
                case 14: Console.Clear(); Problema14(); break;
                case 15: Console.Clear(); Problema15(); break;
                case 16: Console.Clear(); Problema16(); break;
                case 17: Console.Clear(); Problema17(); break;
                case 18: Console.Clear(); Problema18(); break;
                case 19: Console.Clear(); Problema19(); break;
                case 20: Console.Clear(); Problema20(); break;
                case 21: Console.Clear(); Problema21(); break;
                case 22: Console.Clear(); Problema22(); break;
                case 23: Console.Clear(); Problema23(); break;
                case 24: Console.Clear(); Problema24(); break;
                case 25: Console.Clear(); Problema25(); break;
                case 26: Console.Clear(); Problema26(); break;
                case 27: Console.Clear(); Problema27(); break;
                case 28: Console.Clear(); Problema28(); break;
                case 29: Console.Clear(); Problema29(); break;
                case 30: Console.Clear(); Problema30(); break;
                case 31: Console.Clear(); Problema31(); break;
                case 32: Console.Clear(); Problema32(); break;
                case 33: Console.Clear(); Problema33(); break;
                case 34: Console.Clear(); Problema34(); break;
                case 35: Console.Clear(); Problema35(); break;
                case 36: Console.Clear(); Problema36(); break;
                case 37: Console.Clear(); Problema37(); break;
                case 38: Console.Clear(); Problema38(); break;
                case 39: Console.Clear(); Problema39(); break;
                case 40: Console.Clear(); Problema40(); break;
                case 41: Console.Clear(); Problema41(); break;
                case 42: Console.Clear(); Problema42(); break;
                case 43: Console.Clear(); Problema43(); break;
                case 44: Console.Clear(); Problema44(); break;
                case 45: Console.Clear(); Problema45(); break;
                case 46: Console.Clear(); Problema46(); break;
                case 47: Console.Clear(); Problema47(); break;
                case 48: Console.Clear(); Problema48(); break;
                case 49: Console.Clear(); Problema49(); break;
                case 50: Console.Clear(); Problema50(); break;
                case 51: Console.Clear(); Problema51(); break;
                case 52: Console.Clear(); Problema52(); break;
                case 53: Console.Clear(); Problema53(); break;
                case 54: Console.Clear(); Problema54(); break;
                case 55: Console.Clear(); Problema55(); break;
                case 56: Console.Clear(); Problema56(); break;
                case 57: Console.Clear(); Problema57(); break;
                case 58: Console.Clear(); Problema58(); break;
                case 59: Console.Clear(); Problema59(); break;
                case 60: Console.Clear(); Problema60(); break;
                case 61: Console.Clear(); Problema61(); break;
                case 62: Console.Clear(); Problema62(); break;
                case 63: Console.Clear(); Problema63(); break;
                case 64: Console.Clear(); Problema64(); break;
                case 65: Console.Clear(); Problema65(); break;
                case 66: Console.Clear(); Problema66(); break;
                case 67: Console.Clear(); Problema67(); break;
                case 68: Console.Clear(); Problema68(); break;
                case 69: Console.Clear(); Problema69(); break;
                default:
                    break;
            }
        }

        private static void Problema1()
        {
            Console.WriteLine(@"1. Sa se scrie un program care converteste temperatura din grade celsius in grade fahrenheit si 
invers utilizand instructiunea switch.");
            Console.WriteLine("Scrie temperatura:");
            double temperature = double.Parse(Console.ReadLine());
            Console.WriteLine("Unitatea de masura(C - celsius , F - fahrenheit):");
            string um = Console.ReadLine();
            switch (um)
            {
                case "C":
                    temperature = temperature * 1.8 + 32;
                    Console.WriteLine($"Temperatura in grade Fahrenheit este {temperature}");
                    break;
                case "F":
                    temperature = (temperature - 32)/ 1.8;
                    Console.WriteLine($"Temperatura in grade Celsius este {temperature}");
                    break;
                default:
                    break;
            }
        }

        private static void Problema2()
        {
            Console.WriteLine(@"2. Să se scrie un program care efectuează mai multe operații la cererea utilizatorului, adică: 
adunare, scădere, înmulțire, împărțire, radical, modulul. (Ulilizați operatorul switch pentru 
selectarea funcției calculatorului.). După selectarea opțiunii dorite, programul trebuie să 
ceară utilizatorului introducerea datelor necesare, respectiv, în cazul adunării, scăderii, 
înmulțirii și împărțirii, două numere, iar în cazul radicalului și modulului, un singur număr.");
            string operatia = "";
            int a = 0, b = 0;
            while(operatia != "x")
            {
                Console.WriteLine(@"Operatia (""x"" - pentru a iesi) :");
                operatia = Console.ReadLine();
                switch (operatia)
                {
                    case "adunare":
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{a+b}");
                        break;
                    case "scadere":
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{a-b}");
                        break;
                    case "inmultire":
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{a * b}");
                        break;
                    case "impartire":
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{(double)a / b}");
                        break;
                    case "radical":
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{Math.Sqrt(a)}");
                        break;
                    case "modul":
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine($"{Math.Abs(a)}");
                        break;
                    default:
                        break;
                }
            }
        }

        private static void Problema3()
        {
            Console.WriteLine(@"3. Fie i,j,k. Să se determine restul împărţirii numărului natural ij la k.");
            Console.Write("Citeste numerele:");
            int i = int.Parse(Console.ReadLine());
            int j = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            double a = Math.Pow(i, j);
            Console.WriteLine($"Restul impartirii lui {i}^{j} la {k} este {a%k}");
        }

        private static void Problema4()
        {
            Console.WriteLine(@"4. Să se verifice dacă numărul n este perfect. (Un număr n este perfect dacă este egal cu suma divizorilor lui diferiţi de n; exemplu: 6=1+2+3)");
            Console.Write("n=");
            int n= int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n/2; i++)
            {
                if (n % i == 0)
                    sum += i;
            }
            if(sum==n)
                Console.WriteLine($"Numarul {n} este perfect");
        }

        private static void Problema5()
        {
            Console.WriteLine(@"5. Să se determine numerele perfecte din intervalul [a,b], pentru a,b date.");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = a; j <= b; j++)
            {
                sum = 0;
                for (int i = 1; i <= j/2; i++)
                {
                    if (j % i == 0)
                        sum += i;
                }
                if (sum == j)
                    Console.WriteLine($"{j} ");
            }
        }

        private static void Problema6()
        {
            Console.WriteLine(@"6. Două numere întregi x şi y sunt ""prietene"" dacă suma divizorilor numărului x este egală cu 
suma divizorilor numărului y.Să se găsească numerele ""prietene"" din intervalul[a, b].");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int sum1 = 0, sum2 = 0;
            for (int i = a; i < b; i++)
            {
                sum1 = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        sum1 += j;
                }
                for (int j = i+1; j <= b; j++)
                {
                    sum2 = 0;
                    for (int k = 1; k <= j; k++)
                    {
                        if (j % k == 0)
                            sum2 += k;
                    }
                    if(sum1 == sum2)
                        Console.Write($"[{i},{j}] ");
                }
            }
            Console.WriteLine();
        }

        private static void Problema7()
        {
            Console.WriteLine(@"7. Fie n,k. Să se scrie un algoritm pentru calculul numărului combinărilor de n elemente luate câte k");
            Console.Write("n=");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.Write("k=");
            ulong k = ulong.Parse(Console.ReadLine());
            ulong comb = 0;
            comb = fact(n)/(fact(k)*fact(n-k));
            Console.WriteLine($"Exista {comb} combinari ne {n} elemente luate cate {k}");
        }

        private static ulong fact(ulong n)
        {
            ulong rez = 1;
            for (ulong i = 1; i <= n; i++)
            {
                rez *= i;
            }
            return rez;
        }

        private static void Problema8()
        {
            Console.WriteLine(@"8. Fie a. Să se scrie un algoritm pentru calculul mediei aritmetice, geometrice şi armonice a 
tuturor divizorilor lui a.");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            double ma = 1;
            double mg = 1;
            double mh = 1;
            for (int i = 2; i <= a; i++)
            {
                if(a%i==0)
                {
                    ma = (ma + i) / 2;
                    mg = Math.Sqrt(mg * i);
                    mh = (2 * mh * i) / (mh + i);
                }
            }
            Console.WriteLine($"Media aritmetica este {ma}");
            Console.WriteLine($"Media geometrica este {mg}");
            Console.WriteLine($"Media armonica este {mh}");
        }

        private static void Problema9()
        {
            Console.WriteLine(@"9. Să se determine cel mai mare divizor comun şi cel mai mic multiplu comun pentru două 
numere întregi aşi b.");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int ca = a;
            int cb = b;
            while(a!=b)
            {
                if (a < b)
                    a += ca;
                if (b < a)
                    b += cb;
            }
            while(ca != cb)
            {
                if (ca > cb)
                    ca -= cb;
                if (ca < cb)
                    cb -= ca;
            }
            Console.WriteLine($"Cel mai mare divizor comun este: {ca}");
            Console.WriteLine($"Cel mai mic multiplu comun este: {a}");
        }

        private static void Problema10()
        {
            Console.WriteLine(@"10. Să se afişeze primele n numere prime.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] prime = new int[n+1];
            for (int i = 2; i <= n; i = i + 2)
                prime[i] = 1;
            if(n>=2)
                Console.Write("2");
            for (int i = 3; i <= n; i = i + 2)
            {
                if(prime[i]==0)
                    Console.Write($" {i}");
                for (int j = 2 * i; j <= n; j = j + i)
                prime[j] = 1;
            }
            Console.WriteLine();
        }

        private static void Problema11()
        {
            Console.WriteLine(@"11. Să se determine dacă două numere sunt prime între ele sau nu.");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            int ca = a;
            int cb = b;
            while (ca != cb)
            {
                if (ca > cb)
                    ca -= cb;
                if (ca < cb)
                    cb -= ca;
            }
            if(ca==1)
                Console.WriteLine("Numerele sunt prime intre ele");
            else
                Console.WriteLine("Numerele nu sunt prime intre ele");
        }

        private static void Problema12()
        {
            Console.WriteLine(@"12. Elaboraţi un program care să tipărească tabela de temperaturi Fahrenheit şi echivalenţele lor 
în centigrade sau grade Celsius, folosind formula: C=(5/9)*(F-32), între valorile extreme 0 şi 
300 grade Fahrenheit.");
            Console.WriteLine("F   C");
            double nr = (double)5/9;
            for(int i=0; i<=300; i++)
            {
                double grade = nr * (i - 32);
                Console.WriteLine($"{i}   {grade}");
            }
        }

        private static void Problema13()
        {
            Console.WriteLine(@"13. Elaboraţi un program care să tipărească tabela corespunzătoare Celsius-Fahrenheit.");
            Console.WriteLine("C   F");
            for (int i = 0; i <= 300; i++)
            {
                double grade = i * 1.8 + 32;
                Console.WriteLine($"{i}   {grade}");
            }
        }

        private static void Problema14()
        {
            Console.WriteLine(@"14. Scrieţi un program care să citească mai multe numere întregi, până la întâlnirea lui zero, şi să 
determine cel mai mic număr şi cel mai mare număr citit.");
            int mx = 0;
            int mn = 100900000;
            int nr = 1;
            while(nr!=0)
            {
                nr = int.Parse(Console.ReadLine());
                if (nr > mx)
                    mx = nr;
                if (nr < mn)
                    mn = nr;
            }
            Console.WriteLine($"Cel mai mic numar este {mn}");
            Console.WriteLine($"Cel mai mare numar este {mx}");
        }

        private static void Problema15()
        {
            Console.WriteLine(@"15. Scrieţi un program care să calculeze factorialul unui număr întreg n.");
            Console.Write("n=");
            ulong n = ulong.Parse(Console.ReadLine());
            Console.WriteLine($"{fact(n)}");
        }

        private static void Problema16()
        {
            Console.WriteLine(@"16. O carte are n foi şi r rânduri pe fiecare pagină. Câte rânduri are cartea?");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("r=");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine($"{n*r}");
        }

        private static void Problema17()
        {
            Console.WriteLine(@"17. Un punct material se află la distanţa x0 de origine, la momentul iniţial t0, când începe să se 
mişte rectiliniu uniform. Çtiind că la momentul t se află la distanţa x faţă de origine, să se 
determine viteza v de mişcare a punctului material, la momentul t.");
            Console.Write("x0=");
            double x0 = int.Parse(Console.ReadLine());
            Console.Write("t0=");
            double t0 = int.Parse(Console.ReadLine());
            Console.Write("x=");
            double x = int.Parse(Console.ReadLine());
            Console.Write("t=");
            double t = int.Parse(Console.ReadLine());
            double v = (x - x0) / (t - t0);
            Console.WriteLine($"Viteza este {v}");
        }

        private static void Problema18()
        {
            Console.WriteLine(@"18. Să se scrie un program care să citească două numere reale a şi b. Apoi să pună utilizatorului o 
întrebare: Ce doriţi să calculăm ? Media aritmetică (1) sau geometrică (2)?. Dacă se va 
răspunde prin 1, se va calcula şi afişa media aritmetică, iar pentru 2 media geometrică (numai 
dacă numerele sunt pozitive !, iar de nu, se va afişa ‘eroare !’). Dacă nu se răspunde prin 1 
sau 2 se va produce un sunet în difuzor.");
            Console.Write("a=");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ce doriţi să calculăm ? Media aritmetică (1) sau geometrică (2)?");
            string ce = Console.ReadLine();
            if (ce != "1" && ce != "2" && a>=0 && b>=0)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("eroare !");
            }
            else if(ce == "1")
                Console.WriteLine($"Media aritmetica este {a+b/2}");
            else if(ce == "2")
                Console.WriteLine($"Media geometrica este {Math.Sqrt(a*b)}");
        }

        private static void Problema19()
        {
            Console.WriteLine(@"19. Să se scrie un program care să citească trei numere reale a, b şi c, apoi să pună o întrebare de 
genul: Ce doriţi să calculăm? Aria sau perimetrul?. Dacă se va răspunde prin ‘aria’ atunci se 
va calcula şi afişa aria, altfel perimetrul.");
            Console.Write("a=");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            double c = int.Parse(Console.ReadLine());
            Console.WriteLine(" Ce doriţi să calculăm? Aria sau perimetrul?");
            string ce = Console.ReadLine();
            if (ce != "aria" && ce != "perimetrul" && a > 0 && b > 0 && c > 0)
            {
                SystemSounds.Asterisk.Play();
                Console.WriteLine("eroare !");
            }
            else if (ce == "aria")
            {
                double p = (a + b + c) / 2;
                Console.WriteLine($"Aria este {Math.Sqrt(p*(p-a)*(p-b)*(p-c))}");
            }
            else if (ce == "perimetrul")
                Console.WriteLine($"Perimetrul este {a + b + c}");
        }

        private static void Problema20()
        {
            Console.WriteLine(@"20. Se citeşte un şir de numere întregi pâna la întâlnirea numărului 0. Să se calculeze media 
aritmetică a numerelor din şir.");
            double sum = 0;
            double b = 1;
            int nr = 0;
            while(b!=0)
            {
                b = int.Parse(Console.ReadLine());
                if (b != 0)
                {
                    sum += b;
                    nr++;
                }
            }
            Console.WriteLine($"Media aritmetica este {sum/nr}");
        }

        private static void Problema21()
        {
            Console.WriteLine(@"21. Se citesc 3 numere naturale n, p şi k, apoi un şir de n numere naturale. Câte dintre acestea, 
împărţite la p dau restul k ?");
            Console.Write("n=");
            double n = int.Parse(Console.ReadLine());
            Console.Write("p=");
            double p = int.Parse(Console.ReadLine());
            Console.Write("k=");
            double k = int.Parse(Console.ReadLine());
            int x = 0;
            int nr= 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % p == k)
                    nr++;
            }
            Console.WriteLine($"{nr} numere dau restul {k}");
        }

        private static void Problema22()
        {
            Console.WriteLine(@"22. Să se calculeze produsul a două numere naturale prin adunări repetate.");
            Console.Write("a=");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = int.Parse(Console.ReadLine());
            double ca = a;
            for (int i = 1; i < b; i++)
            {
                a += ca;
            }
            Console.WriteLine($"{a}");
        }

        private static void Problema23()
        {
            Console.WriteLine(@"23. Efectuaţi împărţirea întreagă a două numere, făra a utiliza operatorii / şi %, ci doar scăderi 
repetate.");
            Console.Write("a=");
            double a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = int.Parse(Console.ReadLine());
            int nr = 0;
            while(a>0)
            {
                if(a-b>=0)
                {
                    a -= b;
                    nr++;
                }
                else a -= b;
            }
            Console.WriteLine($"{nr}");
        }

        private static void Problema24()
        {
            Console.WriteLine(@"24. Se citeşte un număr natural. Câte cifre conţine ?");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            int nr = 0;
            while(a>0)
            {
                nr++;
                a /= 10;
            }
            Console.WriteLine($"{nr}");
        }

        private static void Problema25()
        {
            Console.WriteLine(@"24. Se citeşte un număr natural. Câte cifre conţine ?");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            int ca = a;
            int o = 0;
            while(a>0)
            {
                o = o * 10 + a % 10;
                a /= 10;
            }
            if(o==ca)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }

        private static void Problema26()
        {
            Console.WriteLine(@"26. Să se afişeze toate numerele prime mai mici sau egale cu un numar m dat.");
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            for (int i = 2; i <= m; i++)
            {
                bool prim = true;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if(prim)
                    Console.Write($"{i} ");
            }
        }

        private static void Problema27()
        {
            Console.WriteLine(@"27. Să se afişeze primele n numere prime care au suma cifrelor ≤m.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int nr = 0;
            int i = 2;
            while(nr<n)
            {
                if(sumaCifre(i)<=m)
                {
                    if(prim(i))
                    {
                        nr++;
                        Console.Write($"{i} ");
                    }
                }
                i++;
            }
        }

        private static bool prim(int n)
        {
            bool prim = true;
            for(int i=2; i<=n/2; i++)
            {
                if (n % i == 0)
                {
                    prim = false;
                    break;
                }
            }
            return prim;
        }

        private static int sumaCifre(int n)
        {
            int sum = 0;
            while (n>0)
            {
                sum += n % 10;
                n /= 10;
            }
                return sum;
        }

        private static void Problema28()
        {
            Console.WriteLine(@"28. Să se afişeze toate numerele de 3 cifre care, citite invers, sunt tot numere prime.");
            for(int i=101; i<=997; i=i+2)
            {
                if(prim(i) && prim(invers(i)))
                    Console.Write($"{i} ");
            }
        }

        private static int invers(int n)
        {
            int inv=0;
            while(n>0)
            {
                inv = inv * 10 + n % 10;
                n /= 10;
            }
            return inv;
        }

        private static void Problema29()
        {
            Console.WriteLine(@"29. Să se listeze toate numerele ≤n, a căror sumă a cifrelor este divizibilă prin 5.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if(sumaCifre(i)%5==0)
                    Console.Write($"{i} ");
            }
        }

        private static void Problema30()
        {
            Console.WriteLine(@"30. Să se transforme un număr din baza 10 în baza p<10. Să se transforme un număr din baza 
p<10 în baza 10.");
            Console.Write("n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(@"Baza numarului ""n"": ");
            int baza = int.Parse(Console.ReadLine());
            Console.Write(@"Baza ""p"" in care transformi nr ""n"": ");
            int p = int.Parse(Console.ReadLine());
            int cifra, nr = 0;
            if (baza == 10)
            {
                int x = 1;
                while (n > 0)
                {
                    cifra = n % p;
                    n /= p;
                    nr += cifra * x;
                    x *= 10;
                }
            }
            else if (baza < 10)
            {
                int x = 1;
                while(n>0)
                {
                    cifra = (n % 10) * x;
                    nr += cifra;
                    n /= 10;
                    x *= baza;
                }
            }
            Console.WriteLine($"{nr}");
        }

        private static void Problema31()
        {
            Console.WriteLine(@"31. Să se genereze toate numerele prime mai mici decât numărul natural n dat.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                bool prim = true;
                for (int j = 2; j <= i / 2; j++)
                    if (i % j == 0)
                        prim = false;
                if (prim)
                    Console.Write($"{i} ");
            }
        }

        private static void Problema32()
        {
            Console.WriteLine(@"32. Să se afişeze primele n numere prime care au suma cifrelor mai mică sau egală cu m.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            int nr = 0;
            int i = 2;
            while (nr < n)
            {
                if (sumaCifre(i) <= m)
                {
                    if (prim(i))
                    {
                        nr++;
                        Console.Write($"{i} ");
                    }
                }
                i++;
            }
        }
        
        private static void Problema33()
        {
            Console.WriteLine(@"33. Să se afişeze toate numerele prime de 3 cifre care citite invers sunt tot numere prime.");
            for (int i = 101; i <= 997; i = i + 2)
            {
                if (prim(i) && prim(invers(i)))
                    Console.Write($"{i} ");
            }
        }

        private static void Problema34()
        {
            Console.WriteLine(@"34. Scrieţi o funcţie care să transforme un unghi exprimat în radiani în valoarea sa exprimată în 
grade şi una care să facă transformarea inversă.");
            Console.Write("n=");
            double n = int.Parse(Console.ReadLine());
            Console.Write("g(grade) sau r(radiani)=");
            string m = Console.ReadLine();
            if (m == "g")
                n = FromGradeToRadiani(n);
            else if (m == "r")
                n = FromRadianiToGrade(n);
            else Console.WriteLine("Eroare");
            Console.WriteLine($"{n}");
        }

        private static double FromRadianiToGrade(double n)
        {
            n = n * 180 / Math.PI;
            return n;
        }

        private static double FromGradeToRadiani(double n)
        {
            n = n * Math.PI / 180;
            return n;
        }

        private static void Problema35()
        {
            Console.WriteLine(@"35. Scrieti o functie cu numele putere care primeste prin parametrul n un numar natural cu cel mult 
9 cifre si care furnizeaza prin parametrii x si k doua numere naturale cu proprietatea ca n=xk si x 
este minim.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int x=1, k=1;
            putere(n, ref x, ref k);
            Console.WriteLine($"{x} ^ {k}");
        }

        private static void putere(int n, ref int x, ref int k)
        {
            for (int i = 2; i <= n; i++)
            {
                int nr = i;
                k = 1; 
                x = i;
                while(nr<n)
                {
                    k++;
                    nr *= i;
                }
                if (nr == n)
                    break;
            }
        }

        private static void Problema36()
        {
            Console.WriteLine(@"36. 1. Scrie o metodă care primește ca parametru un număr natural x și apoi afișează: 
-cifrele numărului (în ordine inversă)
-suma cifrelor");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int sumacifre = sumaCifre(n);
            Console.Write("Cifrele numarului sunt:");
            while(n>0)
            {
                Console.Write($" {n%10}");
                n /= 10;
            }
            Console.WriteLine();
            Console.WriteLine($"Suma cifrelor este {sumacifre}");
        }

        private static void Problema37()
        {
            Console.WriteLine(@"37. Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci, şir definit de relaţia de 
recurenta: f(n)=f(n-2)+f(n-1); f(1)=1, f(2)=1.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int a = 1, b = 1, c = 0;
            if(n>=1)
                Console.Write($"{a}");
            if(n>=2)
                Console.Write($" {b}");
            int nr = 2;
            while(nr<n)
            {
                c = a + b;
                Console.Write($" {c}");
                a = b;
                b = c;
                nr++;
            }
            Console.WriteLine();
        }

        private static void Problema38()
        {
            Console.WriteLine(@"38. Scrieţi o functie care să calculeze factorialul unui număr întreg n.");
            Console.Write("n=");
            ulong n = ulong.Parse(Console.ReadLine());
            BigInteger big=0;
            Console.WriteLine($"{BigFact(n)}");
        }

        private static object BigFact(BigInteger n)
        {
            BigInteger big = 1;
            for (int i = 1; i <= n; i++)
            {
                big = big * i;
            }
            return big;
        }

        private static void Problema39()
        {
            Console.WriteLine(@"39. Scrieţi o funcţie care să determine diferenţa dintre două momente de timp, date prin ore, 
minute şi secunde.");
            Console.Write("data1=");
            string[] data1 = Console.ReadLine().Split();
            Console.Write("data2=");
            string[] data2 = Console.ReadLine().Split();
            int[] date1 = new int[3];
            int[] date2 = new int[3];
            int[] date3 = new int[3];
            for (int i = 0; i <= 2; i++)
            {
                date1[i] = int.Parse(data1[i]);
                date2[i] = int.Parse(data2[i]);
            }
            for (int i = 2; i >= 0; i--)
            {
                if (i > 0)
                { if (date1[i] < date2[i])
                    {
                        date3[i] = date1[i] + 60 - date2[i];
                        date1[i - 1]--;
                    }
                    else
                        date3[i] = date1[i]  -date2[i];
                }
                else if (i == 0)
                    date3[i] = date1[i] - date2[i];
            }
            if(date3[0]<0)
                Console.WriteLine("date gresite");
            else
                    Console.Write($"{date3[0]} ore {date3[1]} minute {date3[2]} secunde");
            Console.WriteLine();
        }
        
        private static void Problema40()
        {
            Console.WriteLine(@"40. Viteza unui automobil este de v km/h. Scrieti o functie prin care sa exprimaţi această viteză 
în m/s.");
            Console.Write("v=");
            double v = int.Parse(Console.ReadLine());
            Console.WriteLine($"Viteza in m/s este {KmphToMps(v)}");
        }

        private static double KmphToMps(double v)
        {
            v = v * 5 / 18;
            return v;
        }

        private static void Problema41()
        {
            Console.WriteLine(@"41. Un muncitor lucrează n zile pentru a termina o lucrare. Scrieti o functie prin care sa se 
determine câte zile sunt necesare pentru a termina aceeaşi lucrare o echipă de mmuncitori.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            float zile = (float)n / m;
            Console.WriteLine($"{zile} zile");
        }

        private static void Problema42()
        {
            Console.WriteLine(@"42. Scrieti o functie care să se verifice dacă un număr natural este sau nu cub perfect.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            isCub(n);
        }

        private static void isCub(int n)
        {
            bool ok = false;
            for (int i = 1; i <= Math.Sqrt(n); i++)
            {
                if (i * i * i == n)
                    ok = true;
            }
            if(ok)
                Console.WriteLine("Este cub perfect");
            else Console.WriteLine("Nu este cub perfect");
        }

        private static void Problema43()
        {
            Console.WriteLine(@"43. Să se scrie o funcție care calculează pătratul elementelor memorate într-un tablou. 
De exemplu introduceți lungimea tabloului: 5.
Introduceți elementele tabloului: 9 10 20 8 7
Tabloul inițial este: 9 10 20 8 7
Pătratul elementelor tabloului inițial este: 81 100 400 64 49");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
                v[i] = v[i] * v[i];
            }
            foreach (var item in v)
            {
                Console.WriteLine($"{item} ");
            }
        }

        private static void Problema44()
        {
            Console.WriteLine(@"44. Să se scrie o functie pentru aflarea tablei inmulțirii unui număr utilizând bucla for și 
reprezentați-o în formatul corespunzător.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write($"  ");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i} ");
                if (i * n >= 10)
                    Console.Write(" ");
            }
            Console.WriteLine();
            Console.Write($"{n} ");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write($"{i*n} ");
            }
            Console.WriteLine();
        }

        private static void Problema45()
        {
            Console.WriteLine(@"45. Să se scrie o funcție care inversează elementele memorate într-un tablou.");
            Console.WriteLine("elementele tabloului:");
            string[] tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] v = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                v[i] = invers(v[i]);
            }
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
        }

        private static void Problema46()
        {
            Console.WriteLine(@"46. Un palindrom este un număr sau o frază care se citește la fel de la început cât și de la sfârșit. 
De exemplu, fiecare dintre următoarele numere întregi formate din cinci cifre este un 
palindrom: 12321, 55555, 45554 și 11611. Să se scrie o functie care primeste un număr și 
verifică dacă este palindrom sau nu. (Utilizați operatorii de împărțit și rest pentru a separa 
numărul în cifre individuale.).");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int cn = n;
            int o = 0;
            while (n > 0)
            {
                o = o * 10 + n % 10;
                n /= 10;
            }
            if (o == cn)
                Console.WriteLine("Numarul este palindrom");
            else
                Console.WriteLine("Numarul nu este palindrom");
        }

        private static void Problema47()
        {
            Console.WriteLine(@"47. Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99 întrun tablou și care afișează numerele care se repetă în tablou");
            int[] rand = new int[100];
            int[] freq = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                rand[i] = rnd.Next(0, 99);
                freq[rand[i]]++;
            }
            for (int i = 0; i < 100; i++)
            {
                if(freq[i]>1)
                    Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void Problema48()
        {
            Console.WriteLine(@"48. Să se scrie un program care adună două matrici de dimensiune nxn.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            int[][] b = new int[n][];
            Console.WriteLine("Citeste prima matrice");
            string[] tokens = new string[n];
            for (int i = 0; i < n; i++)
            {
                tokens = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries);
                a[i] = new int[n];
                for (int j = 0; j < tokens.Length; j++)
                {
                    a[i][j] = int.Parse(tokens[j]);
                }
            }
            Console.WriteLine("Citeste a doua matrice");
            for (int i = 0; i < n; i++)
            {
                tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                b[i] = new int[n];
                for (int j = 0; j < tokens.Length; j++)
                {
                    b[i][j] = int.Parse(tokens[j])+a[i][j];
                }
            }
            Console.WriteLine("Matricile adunate");
            for (int i = 0; i < n; i++)
            {
                foreach (var item in b[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        private static void Problema49()
        {
            Console.WriteLine(@"49. Sa se scrie o functie care calculeaza media aritmetica a elementelor pare dintr-un vector de 
numere intregi.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0, nr = 0;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if(v[i]%2==0)
                {
                    sum += v[i];
                    nr++;
                }
            }
            Console.WriteLine($"{sum/nr}");
            }

        private static void Problema50()
        {
            Console.WriteLine(@"50. Functia care determina daca un vector dat e ordonat crescator.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool ascending = true;
            v[0]= int.Parse(tokens[0]);
            for (int i = 1; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] < v[i - 1])
                    ascending = false;
            }
            if(ascending)
                Console.WriteLine("Vectorul este crescator");
            else
                Console.WriteLine("Vectorul nu este crescator");
        }

        private static void Problema51()
        {
            Console.WriteLine(@"51. Functia care determina minimul unui vector dat.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int minim = 10000;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] < minim)
                    minim=v[i];
            }
            Console.WriteLine($"Mninimul vectorului este {minim}");
        }

        private static void Problema52()
        {
            Console.WriteLine(@"52. Functia care determina daca un vector dat are numai elem impare.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool impare = true;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] % 2 != 1)
                    impare = false;
            }
            if (impare)
                Console.WriteLine("Vectorul are doar elemente impare");
            else
                Console.WriteLine("Vectorul nu are doar elemente impare");
        }

        private static void Problema53()
        {
            Console.WriteLine(@"53. Functia care determina daca un vector dat are numai elem pare.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            bool pare = true;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] % 2 == 1)
                    pare = false;
            }
            if (pare)
                Console.WriteLine("Vectorul are doar elemente pare");
            else
                Console.WriteLine("Vectorul nu are doar elemente pare");

        }

        private static void Problema54()
        {
            Console.WriteLine("54. Functia care determina raportul dintre elem pare si elem impare dintr-un vector.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int impare = 0,pare=0;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                if (v[i] % 2 == 1)
                    impare++;
                else pare++;
            }
            Console.WriteLine($"Raportul este {pare}/{impare}");
        }

        private static void Problema55()
        {
            Console.WriteLine(@"55. Fie X un vector cu n componente numere întregi. Să se calculeze expresia:
e=x1-x2+x3-x4+….±xn.");
            Console.WriteLine("Citeste vectorul:");
            int[] v = new int[100];
            string[] tokens = new string[100];
            tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int sum = 0, semn = 1;
            for (int i = 0; i < tokens.Length; i++)
            {
                v[i] = int.Parse(tokens[i]);
                sum += v[i] * semn;
                semn *= -1;
            }
            Console.WriteLine($"Expresia este {sum}");
        }

        private static void Problema56()
        {
            Console.WriteLine(@"56. Să se construiască un vector v cu primii termeni ai şirului lui Fibonacci. Şirul are primii
doi termeni egali cu 1 şi fiecare din termenii următori este egal cu suma dintre termenul
precedent şi termenul anteprecedent.");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            v[0] = 1;
            v[1] = 1;
            for (int i = 2; i < n; i++)
            {
                v[i] = v[i - 1] + v[i - 2];
            }
            foreach (var item in v)
            {
                Console.Write($"{item} ");
            }
        }

        private static void Problema57()
        {
            Console.WriteLine(@"57. Se citesc de la tastatură n<=100, un număr natural și n numere întregi. Determinați poziția 
primului element din vector cu proprietatea că este medie aritmetică între succesorul și 
predecesorul său. (Pentru a determina primul element (de indice minim) cu o anumită 
proprietate, se parcurge vectorul de la stânga la dreapta până când găsim primul element cu 
proprietatea cerută sau până când epuizăm elementele vectorului).");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            bool found = false;
            int poz = 0;
            for (int i = 1; i < n-1; i++)
            {
                if(v[i]==((float)v[i-1]+v[i+1])/2)
                {
                    found = true;
                    poz = i;
                }
                if (found)
                    break;
            }

            if(!found)
                Console.WriteLine("Nu exista astfel de numar");
            else Console.WriteLine($"Numarul se afla pe pozitia {poz}");
        }

        private static void Problema58()
        {
            Console.WriteLine(@"58. Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi. 
Determinați poziția ultimului element din vector cu proprietatea că este egal cu k. (Pentru a 
determina ultimul element cu o anumită proprietate, se parcurge vectorul de la dreapta spre 
stânga (în ordinea descrescătoare a indicilor până când găsim primul element cu proprietatea 
cerută sau până când epuizăm elementele vectorului).");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("k=");
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            bool found = false;
            int poz = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] == k)
                {
                    found = true;
                    poz = i;
                }
            }

            if (!found)
                Console.WriteLine("Nu exista astfel de numar");
            else Console.WriteLine($"Numarul se afla pe pozitia {poz}");
        }

        private static void Problema59()
        {
            Console.WriteLine(@"59. Se citesc de la tastatură poz<=n<=1000, două numere naturale și n numere întregi. Eliminați 
din vector elementul aflat pe poziția poz. (pentru eliminarea elementului din poziţia poz, se 
observă că primele poz-1 elemente rămân neschimbate, în timp ce elementele din poziţiile 
poz+1, poz+2,…….,n se deplasează cu o poziţie spre stânga pentru a “umple” golul rămas 
prin eliminarea elementului din poziţia poz. Evident, dimensiunea vectorului scade cu o 
unitate).");
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("poz=");
            int poz = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
            {
                v[i] = int.Parse(Console.ReadLine());
            }
            for (int i = poz; i < n-1; i++)
            {
                v[i] = v[i + 1];
            }
            for (int i = 0; i < n-1; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        private static void Problema60()
        {
            Console.WriteLine(@"60. Se citesc de la tastatură k, un număr întreg, n<=1000, un număr natural și n numere întregi. 
Eliminați din vector toate elementele egale cu k. (Pentru a determina ultimul element cu o 
anumită proprietate, se parcurge vectorul de la dreapta spre stânga (în ordinea descrescătoare 
a indicilor până când găsim primul element cu proprietatea cerută sau până când epuizăm 
elementele vectorului).");
        }

        private static void Problema61()
        {
            Console.WriteLine(@"61. Se citesc de la tastatură un număr întreg x, k<=n<=1000, două numere naturale și n numere 
întregi. Inserați elementul x în vector pe poziția k. (elementele din poziţiile k, k+1,.......n 
trebuie să se deplaseze cu o poziţie spre dreapta pentru a face loc noii valori x introduse în 
poziţia k;dimensiunea vectorului creşte cu o unitate).");
        }

        private static void Problema62()
        {
            Console.WriteLine(@"62. Se citesc de la tastatură n, un număr natural mai mic decât 100 și cele n elemente reale ale 
unui vector. Se cere să se insereze între oricare două elemente ale vectorului media lor 
aritmetică.");
        }

        private static void Problema63()
        {
            Console.WriteLine(@"63. Să se extragă dintr-un vector elementele care au ultima cifră egală cu k şi să se formeze cu 
ele un alt vector. Să se afişeze cei doi vectori, unul sub altul. Exemplu: dacă se dau n=3, k=7, 
v[]={17, 23, 47}, atunci vectorul u va fi {17, 47}.");
        }

        private static void Problema64()
        {
            Console.WriteLine(@"64. Se dau n, un număr natural și n numere întregi. Folosind un alt vector, să se aşeze numerele 
pare la început. Exemplu: Date de intrare: n=4 și numerele: 3, 4, 6, 5 Date de ieşire: 4 6 3 5.");
        }

        private static void Problema65()
        {
            Console.WriteLine(@"65. Se dă un şir cu n elemente, numere naturale. Să se afişeze, în ordine crescătoare, toate valorile 
distincte care se pot obţine ca sumă de două elemente distincte din şir.");
        }

        private static void Problema66()
        {
            Console.WriteLine(@"66. CRB are un șir cu n numere naturale diferite. Nu știe ce să facă cu ele și le aranjează în ordine 
descrescătoare. Apoi observă că anumite numere se află pe aceeași poziție ca în șirul inițial. 
Ajutați pe CRB să determine câte elemente din șir respectă această regulă.");
        }

        private static void Problema67()
        {
            Console.WriteLine(@"67. Să se scrie un program care ordonează crescător elementele din prima jumătate a unui vector 
și descrescător elementele din a doua jumătate. ");
        }

        private static void Problema68()
        {
            Console.WriteLine(@"68. Se citește un șir cu n numere naturale. Să se verifice dacă prin rearajarea elementelor șirului se 
poate obține un șir palindrom.");
        }

        private static void Problema69()
        {
            Console.WriteLine(@"69. Se dau înălțimile a n copii, numerotați de la 1 la n, exprimate prin numere naturale. Afișați 
numerele de ordine ale copiilor în ordinea crescătoare a înălțimii lor.");
        }
    }
}
