# Megoldás:

# Osztály létrehozása
- Kétféle mód közül bármelyik
  - Ctrl + .
  - Adjunk hozzá egy osztályt
- 5 tulajdonság
  - public get
  - private set 
- 1 konstruktor 
  - 1 paraméter --> string
  - Például: "Acsalapu;levél;6;8"
  - ';'-vel vannak elválasztva
  - 4 darab adat --> 5 tulajdonság?
  - átadott, fájlból beolvasott sort:
    - ';' mentén tagoljuk
    - [0] --> Nev
    - [1] --> Resz
    - [2] --> Kezd
    - [3] --> Veg
    - Idotartam --> számolás (lásd következő pont)
- 5-dik tulajdonság --> Időtartam
  - Konstruktorban számoljuk!
  - számolása: Vég - Kezdet, HA Vég > Kezdet
  - Vég > Kezdet --> Vég - Kezdet + 1
  - Egyébként --> 12 - Kezdet + Vég + 1

## Adatok beolvasása és eltárolása
- Listában tároljuk az objektum páldányokat
- Olvassuk be:
  - using System.IO;
  - StreamReader
  - while ciklussal --> amíg tart a fájl
  - Cikluson belül listához hozzáadunk egy új objektum példányt (beolvasott sor a paraméter)

## 1. feladat:
- Hány növény van? --> lista Count tulajdonság

## 2. feladat:
- Milyen gyűjthető részek vannak?
- Hány darab van ezekből?
- Dictionary<string, int>
- Milyen gyűjthető részek vannak?
  - foreach Novenyek
  - Ha a Resz nem kulcs --> akkor adjuk hozzá 0-val
- Hány darab van ezekből?
  - foreach  Novenyek
  - Ja "Resz" == Key --> Value + 1

## 3. feladat:
- Maximum keresés --> Időtartam alapján
  - maximum változó = 0
  - foreach Novenyek
  - Ha max < Idotartam --> max = Idotartam
- Növény(ek), amelyeket a legtöbb ideig szedtek
  - foreach Novenyek
  - Kiírni, ha Idotartam == max

## 4. feladat:
- Időtartam átlag számítása
  - szum változó = 0 (double típus)
  - atlag változó
  - foreach Novenyek
  - szum = szum + Idotartam
  - atlag = szum / Count