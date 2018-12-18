# Data en databases

**Wouter Vlaeyen**  
18-12-2018

## Dataformaten

- Wat is een dataformaat?
- Welke dataformaten zijn er?
- Wat zijn de verschillen?

## Databases

- Wat is een databank?
- Welke databanken zijn er?
- Wat zijn de verschillen?

Databases worden enrom vaak gebruikt in applicaties voor het opslaan van allerhande data die te maken heeft met die applicatie. In een webapplicatie is het bijvoorbeeld makkelijker om data op te slaan in een database dan te proberen dit lokaal te doen. Maar wat is een database?

In de simpelste vorm van het woord is een database gewoon een collectie van data. Deze data wordt gebruikelijk elektronisch opgeslagen en opgehaald door middel van een computer. Om communicatie tussen de eindgebruiker en de database makkelijker te maken, wordt er tegenwoordig gebruik gemaakt van een **DBMS** (**D**ata**b**ase **M**anagment **S**ystem).

Doorheen de geschiedenis van databases zijn er verschillende vormen van databases ontstaan en gebruikt.

De oudste vorm van databases is de **navigationele database**, die samen met de introductie van de term database werd geïntroduceerd rond 1965. De Database Task Group bracht zijn standaard voor dit type databases uit in 1971, wat kwam met de introductie van 3 manieren om data op te zoeken.

1. Het gebruik van een primary key
2. Navigeren via relaties tussen verschillende records
3. Het achtereenvolgens scannen van alle records.

Een tweede vorm van databases is de **relationele database**. In de jaren 1970 kwam er een nieuw idee voor databases. Het idee was om data op te slaan in genormalizeerde tabellen, en niet noodzakelijke data op te slaan buiten de hoofdtabel. Deze tabellen worden dan gelinkt door een "key". Dit is een record dat in beide tabellen dezelfde is.  
Omdat het opzoeken van data in de relationele database op een gelijkaardige manier moest als bij de navigationele database, namelijk door het achtereenvolgend loopen door data om informatie over één record te vinden, kwam het idee voor een set-georiënteerde taal, wat uiteindelijk SQL werd. Relationele databases worden tegenwoordig ook nog vaak gebruikt.

Sinds 2000 komen er nieuwere vormen van databases, zoals **XML databases**, **NoSQL** en **NewSQL**. XML databases zijn document georiënteerd. Deze zijn handig wanneer de data van een applicatie wordt gezien als een collectie van ducumenten. NoSQL is een enorm snelle manier van dataopslag aangezien hier gebruik wordt gemaakt van gedenormaliseerde data en geen gebruik maakt van een vaste tabelstructuur. NewSQL is dan weer een upgrade van de gewone relationele database. Het doel van NewSQL is dezelfde performantie te hebben als NoSQL databases terwijl deze wel nog gebruik maakt van SQL voor het aanpassen en lezen van data.