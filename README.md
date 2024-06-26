# Prototype-CarReportApp
KODPROV – Reflektion kring problemet

Jag börjar med att prata med personerna som testade produkten, för att få en klarare bild av deras behov och önskemål. Jag frågar dom om vad dom tycker om det nuvarande systemet och vilka utmaningar dom möts av när dom försöker använda det. Detta hjälper mig att identifiera vilka funktioner som är viktigast att förbättra i systemet. Jag frågar även om hur dom skulle kunna tänka sig att mobilfunktionerna såg ut, och vilka funktioner som är viktigast att ha med.

Jag tar sedan kontakt med kontaktpersonen hos leverantören för att lära mig mer om deras systems möjligheter och begränsningar när det kommer till att integrera nya funktioner. Genom att fråga detta kan jag få en bättre bild om vilka möjligheter och utmaningar som finns med att implementera mobil funktionerna. Jag frågar också bland annat om det redan finns ett bra sätt att hämta data om fordonen eller om jag behöver skapa ett eget sätt.

Jag tar också kontakt med projektledaren angående ifall det finns en skiss på hur dom vill ha frontenden, med till exempel färgscheman eller om jag ska hitta på någonting själv. Detta gör jag för att försäkra mig hur dom visuellt vill ha det, om dom har några preferenser eller inte.

Efter att jag pratat med personerna i fråga tar jag beslutet att skapa en ny API som tar in ett registreringsnummer, en titel och en beskrivning av problemet, och APIet skapar en ny rapport. Det går också att hämta alla rapporter som finns samt alla rapporter som finns på en specifik bil. Då detta bara är en prototyp valde jag att inte skapa en databas med hjälp av Entity Framework, utan istället skapade jag bara lite testdata att använda till detta. 

Efter att backenden är skapad går jag över till frontenden som jag beslutar att skapa med hjälp av Blazor. Jag gör sidan mobilanpassad med funktioner som ett formulär där man kan skicka en rapport till APIet, (inte kopplad i programmet då vi inte lärt oss att koppla frontend med backend ännu. Utan det kommer till hösten. API går dok att kalla på via t ex Swagger) Det finns också en sida där man kan hämta historik för tidigare rapporter.
