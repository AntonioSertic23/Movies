# Filmovi

## Aplikacija za vođenje evidencije filmova

Aplikacija Filmovi je nastala na faksu kao projekt za konstrukcijske vježbe za predmet **Programiranje u .NET okolini**

Aplikacija služi za vođenje evidencije filmova kako bi si korisnik mogao pratiti omiljene pogledane filmove.

---

### Nakon uspješne prijave, u aplikaciji je moguće:

- pretražiti filmove po nazivu i godini
- pogledati detalje pojedinog filma
- dodavanje filmova u svoju listu uz dodjelu vlastite ocjene
- pogledati svoju listu filmova
- pretražiti filmove u svojoj listi po nazivu, godini i žanru
- ažurirati dodjeljene ocjene
- uklanjanje filmova iz svoje liste

---

Projekt je rađen u Visual Studiu unutar **Windows Forms(.NET)** programskog okvira koji koristi **C#**, a za rad sa bazom podataka koristi se **Microsoft SQL Server**.

[![My Skills](https://skills.thijs.gg/icons?i=visualstudio,cs,sqlite)](https://skills.thijs.gg)

Aplikacija sadrži prijavu i registraciju uz potrebne provjere unesenih parametara. Za vec spremljene filmove ima provjera i ažuriranje imdb ocjena kada korisnik klikne na button Refresh.

Za dohvaćanje filmova i njihovih podataka koristi se [OMDb API](https://www.omdbapi.com/).

---

### Pokretanje projekta

Za pokretanje projekta potrebno je kreirati vlastiti _api key_ na službenoj stranici **OMDb API-a**, potom dobiveni _api key_ zalijepiti u `Form1.cs` unutar:

```sh
const string ApiKey = "";
```

Potebno je kreirati bazu podataka sa sljedećim tablicama. _sertic_Movies_ po modelu `Movie.cs` i _sertic_Users_ po modelu `Users.cs`.

- Nazivi tablica mogu biti i proizvoljni, ali u tom slučaju potrebno je izmjeniti query-je unutar `MoviesRepository.cs` i `RegForma.cs`

Zatim dodati putanju na bazu podataka u `MoviesRepository.cs` i `RegForma.cs` unutar:

```sh
readonly string ConnectionString = @"";
```
