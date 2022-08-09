using System;
using System.Threading.Tasks;
using com.FatBassStats.Interface.Lyrics;
using com.FatBassStats.Interface.Lyrics.Models;
using com.FatBassStats.Models;

namespace com.FatBassStatsTests.Mocks
{
    public class StubLyricsApi : ILyricsApi
    {
        public Task<ISongLyrics> GetLyrics(string artistName, string songName)
        {
            // Using a switch here so that we can control the data per song from the ArtistWork.xml
            return Task.Run(() =>
            {
                ISongLyrics artistSong;

                switch (songName.ToUpper())
                {
                    case "LAST REQUEST":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "Slow down, Lie down,\nRemember it's just you and me.\nDon't sell out, bow out,\nRemember how this used to be.\n\nI just want you closer,\n\nIs that alright?\n\nBaby let's get closer tonight\n\n\n\nGrant my last request,\n\nAnd just let me hold you.\n\nDon't shrug your shoulders,\n\nLay down beside me.\n\nSure I can accept that we're going nowhere,\n\nBut one last time let's go there,\n\nLay down beside me\n\n\n\nOh, I've found, that I'm bound\n\nTo wander down that one way road.\n\nAnd I realise all about your lies\n\nBut I'm no wiser than the fool I was before.\n\n\n\nI just want you closer,\n\nIs that alright?\n\nBaby let's get closer tonight\n\n\n\nGrant my last request,\n\nAnd just let me hold you.\n\nDon't shrug your shoulders,\n\nLay down beside me.\n\nSure I can accept that we're going nowhere,\n\nBut one last time let's go there,\n\nLay down beside me\n\n\n\nOh, baby, baby, baby,\n\nTell me how can, how can this be wrong?\n\n\n\nGrant my last request,\n\nAnd just let me hold you.\n\nDon't shrug your shoulders,\n\nLay down beside me.\n\nSure I can accept that we're going nowhere,\n\nBut one last time let's go there,\n\nLay down beside me\n\n\n\nGrant my last request,\n\nAnd just let me hold you.\n\nDon't shrug your shoulders,\n\nLay down beside me.\n\nSure I can accept that we're going nowhere,\n\nBut one last time let's go there,\n\nLay down beside me\n\nYeah, lay down beside me.\n\n\n\nOne last time let's go there,\n\nLay down beside me"
                        };
                        break;
                    case "JENNY DON’T BE HASTY":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "You said you'd marry me if I was 23\nBut I'm one that you can't see if I'm only 18\nTell me who made these rules\nObviously not you\nWho are you answering to?\n\n\nOh, Jenny don't be hasty\n\nNo, don't treat me like a baby\n\nLet me take you where you'll let me\n\nBecause leaving just upsets me\n\n\n\nI'll be around again to see the other men\n\nThey're more adequate in the age department\n\nI did not think you cared.\n\nThere'd be no problems here\n\nBut now you're looking at me like you're disgusted\n\nThen I'm definitely waiting for you to smile and change your mind\n\nThen I'll say I'm sorry and I'll wrap my arms 'round your body\n\nI really hope that you forgive in a hurry\n\nAnd don't just ask me to leave\n\n\n\nOh, Jenny don't be hasty\n\nDon't treat me like a baby\n\nLet me take you where you'll let me\n\nBecause leaving just upsets me\n\n\n\nOh, Jenny you are crazy!\n\nFirst I'm perfect, then I'm lazy\n\nAnd I was calling you my baby\n\nNow it sounds like you just left me.\n\nAnd it kills me!\n\n\n\nOh, Jenny don't be hasty\n\nDon't treat me like a baby\n\nLet me take you where you'll let me\n\nBecause leaving just upsets me\n\n\n\nOh, Jenny you are crazy!\n\nFirst I'm perfect, then I'm lazy\n\nAnd I was calling you my baby\n\nNow it sounds like you just left me.\n\nAnd it kills me!"
                        };
                        break;
                    case "CANDY":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "I was perched outside in the pouring rain\nTrying to make myself a sail\nThen I'll float to you my darlin'\nWith the evening on my tail\nAlthough not the most honest means of travel\nIt gets me there nonetheless\n\nÂ‘Cause I'm a heartless man at worst, babe\nAnd a helpless one at best\n\nDarling I'll bathe your skin\nI'll even wash your clothes\nJust give me some candy\nBefore I go\n\nOh, darling I'll kiss your eyes\n\nAnd lay you down on your rug\nJust give me some candy\nAfter my hug\n\nOh, and I've tried and tried explaining\nBut to her it plays out all the same\nWhen no matter what I give her\nIt gets held against my name\n\nI wouldn't change nothing about you baby\nBut I guess I've taken quite enough\nÂ‘Cause I'm that stain there on your bedsheet\nYou're the diamond in my rough\n\nDarling I'll bathe your skin\nI'll even wash your clothes\nJust give me some candy\nBefore I go\n\n\nOh, darling I'll kiss your eyes\nLay you down on your rug\nBut give me some candy\nAfter my hug (2x)\n\nOh, and I'll be there waiting for you\nOh, I'll be there waiting for you\nI'll be there waiting for you\nOh, I'll be there waiting for you\nOh, I'll be there waiting for you\nOh, then I'll be there waiting for you\nI'll be there waiting for you\nOh, then I'll be there waiting on you\nI'll be there waiting for you\nI'll be there waiting for you"
                        };
                        break;
                    case "PENCIL FULL OF LEAD":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "1, 2, 3, 4\n\nI got a sheet for my bed,\n\nAnd a pillow for my head\n\nI got a pencil full of lead,\n\nAnd some water for my throat\n\nI've got buttons for my coat; and sails on my boat\n\nSo much more than I needed before\n\nI got money in the meter and a two bar heater\n\nNow it's getting hotter;\n\nOh it's oly getting sweeter\n\nI got legs on my chairs and a head full of hear\n\nPot and a pan\n\nAnd some shoes on my feet;\n\nI got a shelf full of books and most of my teeth\n\nA few pairs of socks and a door with a lock\n\nI got food in my belly and a license for my telly\n\n\nAnd nothing's going to bring me down\n\nI got a nice guitar and tyres on my car\n\nI got most of the means; and scripts for the scenes\n\nI'm out and about, so I'm in with a shout\n\nI got a fair bit of chat but better than that\n\nFood in my belly and a license for my telly\n\nAnd nothing's going to bring me down\n\nNothing's going to bring me down\n\n\n\nBut best of all (best of all)\n\nI've got my baby\n\nShe's mighty fine and says she's all mine\n\nAnd nothing's going to bring me down\n\nBest of all\n\nI've got my baby\n\nShe's mighty fine and says she's all mine\n\nAnd nothing's going to bring me down\n\n\nNot today, no, no"
                        };
                        break;
                    case "AUTUMN":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "Autumn leaves under frozen souls,\nHungry hands turing soft and old,\nMy hero crying as we stood out their in the cold,\nLike these autumn leaves I dont have nothing to hold.\n\nHandsome smiles wearing handsome shoes,\nToo young to say, though I swear he knew,\nAnd I hear him singing while he sits there in his chair,\nWhile these autumn leaves float around everywhere.\n\nAnd I look at you, and I see me,\nMaking noise so restlessly,\nBut now its quiet and I can hear you sing,\n\n'My little fish dont cry, my little fish dont cry.'\n\nAutumn leaves how fading now,\nThat smile i lost, well ive found some how,\nBecause you still live on in my fathers eyes,\nThese autumn leaves,ohh these autumn leave, ooh these autumn leaves are yours tonite."
                        };
                        break;
                    case "IRON SKY":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "We are proud\r\nIndividuals\r\nLiving for the city\r\nBut the flames\r\nCouldn't go much higher\n\nWe find God and religions\n\nTo bait us with salvation\n\nBut no one, no nobody\n\nCan give you the power\n\n\n\nTo rise\n\nOver love\n\nOver hate\n\nThrough this iron sky that's fast becoming our mind\n\nOver fear and into freedom\n\n\n\nOh, that's life\n\nThat's dripping down the walls\n\nOf a dream that cannot breathe\n\nIn this harsh reality\n\nMass confusion spoon fed to the blind\n\nServes now to define our cold society\n\n\n\nFrom which we'll rise\n\nOver love\n\nOver hate\n\nThrough this iron sky that's fast becoming our mind\n\nOver fear and into freedom\n\n\n\nYou've just got to hold on\n\nYou've just got to hold on\n\n\n\nTo those who can hear me, I say - do not despair.\n\nThe misery that is now upon us is but the passing of greed\n\nthe bitterness of men who fear the way of human progress.\n\nThe hate of men will pass, and dictators die,\n\nand the power they took from the people will return to the people.\n\nAnd so long as men die, liberty will never perish.\n\nDon't give yourselves to these unnatural men -\n\nmachine men with machine minds and machine hearts!\n\nYou are not machines! You are not cattle!\n\nYou are men!\n\nYou, the people, have the power to make this life free and beautiful,\n\nto make this life a wonderful adventure.\n\nlet us use that power -\n\nlet us all unite.\n\n\n\nAnd we'll rise\n\nOver love\n\nOver hate\n\nThrough this iron sky that's fast becoming our mind\n\nOver fear and into freedom\n\nInto freedom\n\n\n\nFrom which we'll rise\n\nOver love\n\nOver hate\n\nThrough this iron sky that's fast becoming our mind\n\nOver fear and into freedom\n\nFreedom, freedom\n\n\n\nOh, rain\n\nOver love\n\nOver hate\n\nThrough this iron sky that's fast becoming our mind\n\nOver fear and into freedom\n\nFreedom\n\n\n\nFreedom\n\nRain on me\n\nRain on me"
                        };
                        break;
                    case "NUMPTY":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "La la\nLa la\nBuilding a house so we can fall at the first brick\nIf the cement don't stick\nBut I've been told\nThat it only gets harder from there!\n\nHmm, now that I'm young I just do what I do\nI don't second guess too much.\nShed my ties and I'm not that wise\nI'm all grown up as such.\nBut all the talk about the ring and the baby\nGets me every time\nAm I big enough, strong enough to walk along your line?\n\nYeah, baby\n\nBuilding a house so we can fall at the first brick\nIf the cement don't stick\nBut I've been told\nThat it only gets harder from there!\n\nYou see, I'm always on the hustle\nThat I don't know just how good I get it\nThat it's plenty of men out there with money and muscle\nLook at these hips, baby, don't you forget them\nOh, but the curls will go, the money will spend\nWhat we left within the end?\nShe's more than happy, she's taken her play\nI'm saying, 'who's that bitch with my second name? '\n\n\nOh, he's building a house so we can fall at the first brick\nIf the cement don't stick\nBut I've been told\nThat it only gets harder from there!\n\nYeah, baby, truth be told\nI'm only trying to keep my head above the water\nResponsibility, turn on monogamy,\nI'm not a father, child\nAre you a mother, are you?\nUh, my pride and joy\nYeah, you, you are my pride and joy!\n\nOh, building a house so we can fall at the first brick\nIf the cement don't stick\n\nBut I've been told\nThat it only gets harder from there!\nYeah, baby,\nBuilding a house so we can fall at the first brick\nIf the cement don't stick\nBut I've been told\nThat it only gets harder from there!\nBut I've been told\nThat it only gets harder from there!\nBut I've been told\nThat it only gets harder from there!\nEeeee uuuuuuuu\nUuuuuuuuuu\nUuuuuuuuuu\nEeeeeeeee"
                        };
                        break;
                    case "BETTER MAN":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "She makes me smile\nshe thinks the way i think\nthat girl makes me wanna be better\nTook her down Bleecker Street\nsaw she drank the way I drink\nI kiss the sky to send her blue a letter\nThat girl\nmakes me wanna be a better man\nye should she see fit\ngonna treat her like a real man can\nShe's fearless, she's free\nshe is a real life wire\nand that girl\nshe's got me feeling so much better\noh you trade all the money in the world\njust to see this girl's smile\n\nall the while, she'll make you feel so much better\noh that girl, makes me wanna be a better\nsure she sees, gonna treat her like a real man can\nah, ah, la la la\ncome on in my arms\nyou make me feel alright\nyou make me feel alright\nyou know I might get eager\nI might lose my cool\nif you like, I'm in detention\nin the hall of the school\nand you live to love me\nor you hate me\nbut I can see you've got no tires\nfor the end of ..\nbut the reflection in your eyes\n\ngonna look so much better\nI said that girl makes me wanna be a better man\nyeah yeah yeah\nsure she see she fit, gonna treat her like a real man can\ngonna treat her like a real man can\ngonna treat her like a real man can\ngonna treat her like a real man can"
                        };
                        break;
                    case "SCREAM (FUNK MY LIFE UP)":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "How was I to know you just come along\r\n(and funk my life up)\r\nLips like Debbie's, sing sex like strawberry songs\r\n(Just funk my life up)\r\nNever heard it coming, but she's just another woman\r\nWith a shotgun in her hand\n\n(Funk my life up)\n\nShe's a bait, she's a beat, she's the rhythm, she's the band\n\n(Just funk my life up)\n\n\n\nAnd the girl's so fine\n\nMakes you wanna scream Hallelujah\n\nYea-aaaah, ye-eeeeah\n\n\n\nSly hand, spinning wax like silk\n\nBeats are dripping on me, are like spider milk\n\nAnd I never had a warning when I woke up this morning\n\nWith my sunshine on a drip\n\nshe's my rock, she's my ball, she's the teenage, she's the trip\n\n\n\nAnd the girl's so fine\n\nMakes you wanna scream Hallelujah\n\nYea-aaaah, ye-eeeeah\n\n\n\nHow could i refuse I'm not fit to use\n\n(and funk my life up)\n\nsay the only way I win is the way I lose\n\n(just funk my life up)\n\nAnd I never got a script, got a tip, got a little up in my brain\n\nshe's the church, she's a sin, she's a diamond chaser\n\nshe's the rain\n\n\n\nAnd the girl's so fine\n\nyou wanna scream yea-aaaah, ye-eeeeah\n\n\n\nshe gets me silly\n\nshe's like a trick on me\n\nI don't even know her name, yeah she sticks to me\n\nand in the climax, she would scream to me\n\nyeah she sticks to me\n\n\n\nshe gets me funny, she doesn't want any of my money\n\nso i poured it over her like gasoline\n\nhadn't mentioned i'd back in my team\n\nmean super girl smoking my green\n\nsuper girl smoking my green\n\n\n\noh Lord, reload, eyes bags, scream\n\nfree thing, oh rings, yet back sing\n\nbound house, knocked out, let's go\n\nAnd the girl's so fine\n\nMakes you wanna scream Hallelujah\n\nHallelujah\n\nAnd the girl's so fine\n\nyou wanna scream yea-aaaah, ye-eeeeah\n\n\n\n(Grazie a Silvia Zotti per questo testo)"
                        };
                        break;
                    case "SUPERFLY (INTERLUDE)":
                        artistSong = new SongLyrics
                        {
                            Lyrics = "Just some random words as the API seems to be unable to find the lyrics."
                        };
                        break;
                    case "LOOKING FOR SOMETHING":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "Another day is washed away\nAnd all alibis are out\nAnd the hand that used to heal me only cursed me now.\nThe echoes of a woman so kind\nRain like waterfalls and ice-cream on my worried mind.\nI lay there in the puddle of myself\n\nFishing from a brand new wish from that bucket down the well.\n\nAnd in her colors I find my faith,\n\nCause I remember every word that lady used to say.\n\n\n\nShe said that hearts can't break themselves\n\nLooking for something, leaving with nothing\n\nBut souls can't save themselves\n\nLearning to fly, sweet mother of mine!\n\nBe a long home without you\n\nIt's just a long way home without you\n\nYeah, yeah!\n\n\n\nThat's my mother, like no other,\n\nMade me human, made me brother\n\nAnd it's swelling with blister for my sake and my sisters\n\nThe guardian of my karma, keep my feet on terrain firmer\n\nAnd then release me like a scient to the sky!\n\n\n\nShe said that hearts can't break themselves\n\nLooking for something, leaving with nothing\n\nBut souls can't save themselves\n\nLearning to fly, sweet mother of mine!\n\nIt's just a long way home \n\n\n\nSister, you have some hungry eyes\n\nAnd by back you're hypnotized\n\nSmiling faces in disguise\n\nBy back you're hypnotized.\n\nKeep going against the grain\n\nAnd soon that's all, soon that's all you'll know\n\nAnd soon that's all you'll know\n\nAnd let's get this straight\n\nSometimes you'll rise, and there's time you'll fall\n\nAfter all, you're just blood and bones\n\nAnd you don't owe no one, oh\n\nNo, you don't owe no one\n\nSo don't live like one price is right,\n\nCause there is some things in your life that you can't fight!\n\n\n\nShe said that hearts can't break themselves\n\nLooking for something, wind up with nothing\n\nBut souls can't save themselves\n\nLearning to fly, sweet mother of mine!\n\n\n\nShe said that hearts can't break themselves\n\nLooking for something, leaving with nothing\n\nBut souls can't save themselves\n\nLearning to fly, learning to fly\n\nShe said that souls can't save themselves\n\nLearning to fly, learning to fly\n\nOh souls can't save themselves\n\nLearning to fly, learning to fly\n\nOh momma, how I love you!\n\nLearning to fly, learning to fly\n\nNo momma, how I love you\n\nLearning to fly, sweet mother of mine!\n\n\n\nWe're a long way home without you"
                        };
                        break;
                    case "DIANA":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "Drowning in you. Askin' nothin', aching'.\nDo you believe in passion and romance?\nNeeding to be within us and around us?\n\nDiana, she loves me\nNo innocence or compromise\n\nDiana, she loves me\n\nThe only way she knows\n\n\n\nWhen your soul's in flight, you set your body free\n\nAnd under your lightning glistens, in all its fantasy\n\nAnd there's a shiver of velvet tension\n\nFrom an astralised dimension\n\n\n\nEmanating beneath our liberty\n\nWhile for some love is whips and chains\n\nAnd perpetual parlour games\n\nI stand for you, you open up to me\n\nShe said she wants the loneliness to go\n\nBut she won't give up for nothing\n\n\n\nDiana, she loves me\n\nNo innocence or compromise\n\nDiana, she loves me\n\nThe only way she knows\n\n\n\nDiana, she loves me\n\nNo innocence or compromise\n\nDiana, she loves me\n\nThe only way she knows"
                        };
                        break;
                    case "SOMEONE LIKE YOU":
                        artistSong = new SongLyrics
                        {
                            Lyrics =
                                "Someone like you wasn't meant to be defined\nOr confined or even met eye to eye\nJust meant to be explored and then adored\nSomeone like you, someone like you\n\nSomeone like you, is so beautifully designed\n\nFrom the hands, all the way to the mind\n\nJust meant to be explored, and oh, adored\n\nSomeone like you, someone like you\n\n\n\n\n\nLa la la la lalalalala\n\nLa lalalala\n\nLa la la la lalalalala\n\nLa lalalala"
                        };
                        break;
                    default:
                        throw new Exception("404");
                }
                return artistSong;
            });
        }

        public void Dispose()
        {
            //Nothing to do at the moment
        }
    }
}