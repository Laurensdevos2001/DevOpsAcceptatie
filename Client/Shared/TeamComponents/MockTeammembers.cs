namespace Oogarts.Client.Shared.TeamComponents
{
    public class MockTeammember
    {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Role { get; set; }
            public string ImgName { get; set; }

        public string Beschrijving { get; set; } = "Dit is een teamlid van ons team, verder entertain ik u graag met het shrek script.Once upon a time there was a lovely \r\n                         princess. But she had an enchantment \r\n                         upon her of a fearful sort which could \r\n                         only be broken by love's first kiss. \r\n                         She was locked away in a castle guarded \r\n                         by a terrible fire-breathing dragon. \r\n                         Many brave knights had attempted to \r\n                         free her from this dreadful prison, \r\n                         but non prevailed. She waited in the \r\n                         dragon's keep in the highest room of \r\n                         the tallest tower for her true love \r\n                         and true love's first kiss. (laughs) \r\n                         Like that's ever gonna happen. What \r\n                         a load of - (toilet flush)    MAN1\r\n                         Think it's in there?\r\n\r\n                                     MAN2\r\n                         All right. Let's get it!\r\n\r\n                                     MAN1\r\n                         Whoa. Hold on. Do you know what that \r\n                         thing can do to you?\r\n \r\n                                     MAN3\r\n                         Yeah, it'll grind your bones for it's \r\n                         bread.\r\n \r\n               Shrek sneaks up behind them and laughs.\r\n\r\n                                     SHREK\r\n                         Yes, well, actually, that would be a \r\n                         giant. Now, ogres, oh they're much worse. \r\n                         They'll make a suit from your freshly \r\n                         peeled skin.\r\n \r\n                                     MEN\r\n                         No!\r\n\r\n                                     SHREK\r\n                         They'll shave your liver. Squeeze the \r\n                         jelly from your eyes! Actually, it's \r\n                         quite good on toast.\r\n \r\n                                     MAN1\r\n                         Back! Back, beast! Back! I warn ya! \r\n                         (waves the torch at Shrek.)\r\n \r\n               Shrek calmly licks his fingers and extinguishes the torch. The \r\n               men shrink back away from him. Shrek roars very loudly and long \r\n               and his breath extinguishes all the remaining torches until the \r\n               men are in the dark.\r\n \r\n                                     SHREK\r\n                         This is the part where you run away. \r\n                         (The men scramble to get away. He laughs.) \r\n                         And stay out! (looks down and picks \r\n                         up a piece of paper. Reads.) \"Wanted. \r\n                         Fairy tale creatures.\"(He sighs and \r\n                         throws the paper over his shoulder.)\r\n \r\n                         \r\n               THE NEXT DAY\r\n\r\n               There is a line of fairy tale creatures. The head of the guard \r\n               sits at a table paying people for bringing the fairy tale creatures \r\n               to him. There are cages all around. Some of the people in line \r\n               are Peter Pan, who is carrying Tinkerbell in a cage, Gipetto \r\n               who's carrying Pinocchio, and a farmer who is carrying the three \r\n               little pigs.\r\n \r\n                                     GUARD\r\n                         All right. This one's full. Take it \r\n                         away! Move it along. Come on! Get up!\r\n \r\n                         \r\n                                     HEAD GUARD\r\n                         Next!\r\n";


            public MockTeammember(int id, string name, string role, string image)
            {   
                Id = id;
                Name = name;
                Role = role;
                ImgName = image;

            }

    }

    public class MockTeamConstants
    {
        public static List<MockTeammember> DOCTORLIST = new List<MockTeammember>
        {
            new MockTeammember(1,"Dr. Özlem Köse", "Hoofdarts", "drkose.png"),
            new MockTeammember(2,"Dr. Julietta Mozlovotjyk", "Cataract en Cornea Chirurg", "arts2.png"),
            new MockTeammember(3,"Dr. Bezlemba Umbutuntu", "Algemene Oogheelkunde en Retinachirurg", "artsen.jpg"),
            new MockTeammember(4,"Dr. Patrick De Hemelster", "Lenschirurg", "patrick.png"),
            new MockTeammember(5,"Dr. Vanessa Klutumpule", "Oogheelkunde Manager", "vanessa.png"),
            new MockTeammember(6,"Dr. Karen Hoormans", "Glaucoom specialist", "Karen.png"),
        };

        public static List<MockTeammember> ADMINISTRATIONLIST = new List<MockTeammember>
        {
            new MockTeammember(7,"Steven", "Telefonist", "steven.png"),
            new MockTeammember(8,"Anitta Vanbladmaker", "Secretaresse en Office Manager", "secretaresse1.png"),
            new MockTeammember(9,"Svetlana Baklava", "Secretaresse", "secretaresse2.png"),
        };

        public static List<MockTeammember> OPTOMETRIELIST = new List<MockTeammember>
        {
            new MockTeammember(10,"Stefaan De Fixer", "Hoofdoptometrist", "stefaan.png"),
            new MockTeammember(11,"Sebastiaan Pottengras", "Lenzen Specialist", "sebastiaan.png"),
        };

        public static List<MockTeammember> FULLLIST = new List<MockTeammember>
        {
            new MockTeammember(1,"Dr. Özlem Köse", "Hoofdarts", "drkose.png"),
            new MockTeammember(2,"Dr. Julietta Mozlovotjyk", "Cataract en Cornea Chirurg", "arts2.png"),
            new MockTeammember(3,"Dr. Bezlemba Umbutuntu", "Algemene Oogheelkunde en Retinachirurg", "arts1.png"),
            new MockTeammember(4,"Dr. Patrick De Hemelster", "Lenschirurg", "patrick.png"),
            new MockTeammember(5,"Dr. Vanessa Klutumpule", "Oogheelkunde Manager", "vanessa.png"),
            new MockTeammember(6,"Dr. Karen Hoormans", "Glaucoom specialist", "Karen.png"),
            new MockTeammember(7,"Steven", "Telefonist", "steven.png"),
            new MockTeammember(8,"Anitta Vanbladmaker", "Secretaresse en Office Manager", "secretaresse1.png"),
            new MockTeammember(9,"Svetlana Baklava", "Secretaresse", "secretaresse2.png"),
            new MockTeammember(10,"Stefaan De Fixer", "Hoofdoptometrist", "stefaan.png"),
            new MockTeammember(11,"Sebastiaan Pottengras", "Lenzen Specialist", "sebastiaan.png"),
        };
    }

}
