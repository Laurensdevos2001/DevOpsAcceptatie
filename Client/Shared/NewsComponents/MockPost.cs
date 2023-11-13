using System.Diagnostics.Metrics;
using System.Net;
using System.Text.RegularExpressions;
using System;

namespace Oogarts.Client.Shared.NewsComponents
{
    public class MockPost
    {
        public int Id { get; set; }
        public String Title;
        public String Image;
        public String Date;
        public String Description;

        public MockPost(int id, String title, String image, String date, String description)
        {
            this.Id = id;
            this.Title = title;
            this.Image = image;
            this.Date = date;
            this.Description = description;
        }
    }

    public class PostConstants
    {
        private static String mockDescription = @"Lorem Ipsum is slechts een proeftekst uit het drukkerij- en zetterijwezen. Lorem Ipsum is de standaard proeftekst in deze bedrijfstak sinds de 16e eeuw, toen een onbekende drukker een zethaak met letters nam en ze door elkaar husselde om een font-catalogus te maken. Het heeft niet alleen vijf eeuwen overleefd maar is ook, vrijwel onveranderd, overgenomen in elektronische letterzetting. Het is in de jaren '60 populair geworden met de introductie van Letraset vellen met Lorem Ipsum passages en meer recentelijk door desktop publishing software zoals Aldus PageMaker die versies van Lorem Ipsum bevatten.
            n tegenstelling tot wat algemeen aangenomen wordt is Lorem Ipsum niet zomaar willekeurige tekst.het heeft zijn wortels in een stuk klassieke latijnse literatuur uit 45 v.Chr.en is dus meer dan 2000 jaar oud. Richard McClintock, een professor latijn aan de Hampden-Sydney College in Virginia, heeft één van de meer obscure latijnse woorden, consectetur, uit een Lorem Ipsum passage opgezocht, en heeft tijdens het zoeken naar het woord in de klassieke literatuur de onverdachte bron ontdekt.Lorem Ipsum komt uit de secties 1.10.32 en 1.10.33 van de Finibus Bonorum et Malorum (De uitersten van goed en kwaad) door Cicero, geschreven in 45 v.Chr.Dit boek is een verhandeling over de theorie der ethiek, erg populair tijdens de renaissance.De eerste regel van Lorem Ipsum, Lorem ipsum dolor sit amet.., komt uit een zin in sectie 1.10.32.
            Het standaard stuk van Lorum Ipsum wat sinds de 16e eeuw wordt gebruikt is hieronder, voor wie er interesse in heeft, weergegeven.Secties 1.10.32 en 1.10.33 van de Finibus Bonorum et Malorum door Cicero zijn ook weergegeven in hun exacte originele vorm, vergezeld van engelse versies van de 1914 vertaling door H.Rackham.";

        private static String mockDescription2 = @"In een wereld die steeds digitaler wordt, is het essentieel voor medische praktijken om gelijke tred te houden en patiënten een naadloze en informatieve ervaring te bieden. Met trots kondigen wij de lancering aan van de splinternieuwe website van ons Oogcentrum: Vision Oogcentrum.

De website, die vandaag live gaat, is ontworpen met het oog op gebruiksgemak en toegankelijkheid, en stelt patiënten in staat om op een intuïtieve manier kennis te maken met onze praktijk, diensten en professionele team.

Wat kunt u verwachten van onze nieuwe website?

1. Informatieve Pagina's:

Leer meer over de missie en visie van Vision Oogcentrum.
Ontdek onze uitgebreide lijst van oogzorgdiensten en specialisaties.
2. Ons Team:

Maak kennis met de hooggekwalificeerde oogartsen en ondersteunend personeel die zich inzetten voor uw gezichtsvermogen.
3. Patiëntgerichte Informatie:

Vind antwoorden op veelgestelde vragen over oogaandoeningen en behandelingen.
Ontvang praktische tips voor ooggezondheid en onderhoud.
4. Online Afspraken:

Maak snel en eenvoudig online afspraken voor oogonderzoeken en consultaties.
5. Nieuws en Updates:

Blijf op de hoogte van het laatste nieuws over ooggezondheid en technologische ontwikkelingen binnen ons centrum.
6. Virtuele Rondleiding:

Neem een virtuele rondleiding door onze moderne faciliteiten en ontdek de geavanceerde technologieën die we gebruiken.
Waarom deze verandering?

Ons streven naar continue verbetering en patiëntgerichte zorg heeft geleid tot de ontwikkeling van deze website. We begrijpen dat transparantie en toegankelijkheid cruciaal zijn voor het opbouwen van vertrouwen met onze patiënten. Met de nieuwe online aanwezigheid willen we niet alleen informatie verschaffen, maar ook een platform bieden waarop we in direct contact kunnen blijven met degenen die we dienen.

Bezoek vandaag nog onze nieuwe website op vision-oogcentrum.be en ontdek hoe Vision Oogcentrum zich inzet voor uw heldere toekomst.

Wij danken u voor uw voortdurende steun en kijken ernaar uit u online te verwelkomen op vision-oogcentrum.be.";

        private static String mockImage = "https://media.istockphoto.com/id/1316501954/vector/female-doctor-with-black-hair-standing-hands-in-pocket.jpg?s=612x612&w=0&k=20&c=sTV-oLBqna2ZuEG1qNwZl4LgHj4WtFkrN8bDnHQPBxo=";

        private static String mockTitle = "Nieuwe Website: Onze praktijk in een nieuw jasje";

        private static String mockDate = "4 oktober 2023";


        public static List<MockPost> MOCKPOSTS = new List<MockPost>{
            new MockPost(1, mockTitle, mockImage, mockDate, mockDescription2),
            new MockPost(2, mockTitle, mockImage, mockDate, mockDescription),
            new MockPost(3, mockTitle, mockImage, mockDate, mockDescription2),
            new MockPost(4, mockTitle, mockImage, mockDate, mockDescription),
            new MockPost(5, mockTitle, mockImage, mockDate, mockDescription2),
        };
    }

   
}
