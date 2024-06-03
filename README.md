<h2>Et projekt med håndtering af Json-filer</h2>
<h4>Programmet er lavet i Visual Studio og anvender:</h4>
<table>
  <tr>
    <td>C#</td>
    <td>JSON</td>
  </tr>
    <tr>
    <td><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/csharp/csharp-original.svg" / width=60px"></td>
<td><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/json/json-original.svg" / width=60px></td>
  </tr>
</table>


# Quiz-med-JSON-serialisering
<em><strong>Resume:</strong></em>
Quiz der anvender JSON-serialisering som data input

## Danskerne bruger for meget vand når der er tørke. Bliv klogere på, hvad der bruger mest vand i hjemmet

### Oplæg til opgaven
Ved tørkeperioder ønsker vandværker over hele landet at opfordrer danskerne til at spare på vandet, fordi tørken og den manglede regn udsulter vandforsyningen. Selvom der er nok drikkevand i Danmark, er der grænser for, hvor meget vandværker kan og må indvinde. Derfor indføre flere vandværker restriktioner ved tørke på eksempelvis havevanding, og hvilke dage der må vandes. I stedet for skal vi bruges vores drikkevand på det mest nødvendige. Men hvor meget vand bruger vi egentlig på eksempelvis at tage et bad og vande græsset? Vandværker er gået sammen om at lave en oplysningskampagne, for at få befolkningen til at bruge mindre vand når der er tørke.

<img src="images/DrinkingWater.png">

### Opgaven fra vandværkerne: 
<ol>
<li>Vandværker ønsker at udarbejet en Quiz, som en del af deres oplysningskampagne. For at gøre forbrugerne klogere på vores fælles vandforsyning.</li>
<li>Vandværkerne har stillet spørgsmål og svar til rådighed, se Bilag 1.</li>
<li>De ønsker en konsol-applikation eller en hjemmeside-applikation.</li>
</ol>

### Hvordan vi ser opgaven i vores organisation.
<ol>
<li>Det aftales med din instruktør, hvilken applikation du skal sætte i produktion. Konsol eller hjemmeside baseret på Blazer.</li>
<li>Du konventer data i Bilag 1, til at være i JSON-format.</li>
<li>Du skal udvikle et program, som tage en JSON-fil som input og som afvikler quizzens spørgsmål en efter en.</li>
<li>Det er vigtigt at programmet kan bruges i anden sammenhæng, så vi kan tjenepenge på produktet, blot ved at indlæse en ny JSON-fil, med spørgsmål i fx programmering.</li>
</ol>
<h4>Eksempel:</h4>

Syntaksen for JSON:
```json
Syntaks for en enkelt key value:
{
  "tekst" : "tekst"
}
Implementering for en enkelt key value:
{
  "name":"John"
}


Syntaks for multiple key values:
{" tekst ":" tekst "," tekst ":" tekst "," tekst ":" tekst "," tekst ":" tekst ", "..."}

Implementering for multiple key values:
{
  "fornavn" : "Henrik",
  "efternavn" : "møller",
  "adresse" : "Telegrafvej 9",
  "bynavn" : "Ballerup",
  "postnr" : 2750
}
```
<h3>Godkendelse:</h3>
<strong><em>Når opgaven er gennemført skal du, skal den godkendes at din instruktør.</strong></em>

<h3>Forsættelse af opgaven - Test af din viden og dit program</h3>
Herefter skal du oprettet to nye JSON-fil med samme formatering, som kan indlæses i samme program som du lige har udviklede til overstående quiz program.
<ol>
<li>Skriv ti spørgsmål vedrørende det programmeringssprog du har brugt til løsningen, med tilhørende svarmuligheder samt en forklaring til det korrekte svar.</li>
<li>Skriv ti spørgsmål vedrørende SQL, med tilhørende svarmuligheder samt en forklaring til det korrekt svar</li>
</ol>
 
