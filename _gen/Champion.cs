﻿
// This file is automatically generated.
// Do not directly edit.
// Generated on 2019-05-25T03:00:57.479Z

using System;
using System.Linq;

namespace MingweiSamuel.Camille.Enums
{
    /// <summary>
    /// Numeric champion IDs.<br />
    /// Obsolete, use <see cref="Champion" /> instead.
    /// </summary>
    [Obsolete("ChampionId is obsolete, use the Champion enum instead.")]
    public static class ChampionId
    {
        public const int Aatrox = 266;
        public const int Ahri = 103;
        public const int Akali = 84;
        public const int Alistar = 12;
        public const int Amumu = 32;
        public const int Anivia = 34;
        public const int Annie = 1;
        public const int Ashe = 22;
        public const int AurelionSol = 136;
        public const int Azir = 268;
        public const int Bard = 432;
        public const int Blitzcrank = 53;
        public const int Brand = 63;
        public const int Braum = 201;
        public const int Caitlyn = 51;
        public const int Camille = 164;
        public const int Cassiopeia = 69;
        public const int ChoGath = 31;
        public const int Corki = 42;
        public const int Darius = 122;
        public const int Diana = 131;
        public const int Draven = 119;
        public const int DrMundo = 36;
        public const int Ekko = 245;
        public const int Elise = 60;
        public const int Evelynn = 28;
        public const int Ezreal = 81;
        public const int Fiddlesticks = 9;
        public const int Fiora = 114;
        public const int Fizz = 105;
        public const int Galio = 3;
        public const int Gangplank = 41;
        public const int Garen = 86;
        public const int Gnar = 150;
        public const int Gragas = 79;
        public const int Graves = 104;
        public const int Hecarim = 120;
        public const int Heimerdinger = 74;
        public const int Illaoi = 420;
        public const int Irelia = 39;
        public const int Ivern = 427;
        public const int Janna = 40;
        public const int JarvanIV = 59;
        public const int Jax = 24;
        public const int Jayce = 126;
        public const int Jhin = 202;
        public const int Jinx = 222;
        public const int KaiSa = 145;
        public const int Kalista = 429;
        public const int Karma = 43;
        public const int Karthus = 30;
        public const int Kassadin = 38;
        public const int Katarina = 55;
        public const int Kayle = 10;
        public const int Kayn = 141;
        public const int Kennen = 85;
        public const int KhaZix = 121;
        public const int Kindred = 203;
        public const int Kled = 240;
        public const int KogMaw = 96;
        public const int LeBlanc = 7;
        public const int LeeSin = 64;
        public const int Leona = 89;
        public const int Lissandra = 127;
        public const int Lucian = 236;
        public const int Lulu = 117;
        public const int Lux = 99;
        public const int Malphite = 54;
        public const int Malzahar = 90;
        public const int Maokai = 57;
        public const int MasterYi = 11;
        public const int MissFortune = 21;
        public const int Wukong = 62;
        public const int Mordekaiser = 82;
        public const int Morgana = 25;
        public const int Nami = 267;
        public const int Nasus = 75;
        public const int Nautilus = 111;
        public const int Neeko = 518;
        public const int Nidalee = 76;
        public const int Nocturne = 56;
        public const int NunuWillump = 20;
        public const int Olaf = 2;
        public const int Orianna = 61;
        public const int Ornn = 516;
        public const int Pantheon = 80;
        public const int Poppy = 78;
        public const int Pyke = 555;
        public const int Quinn = 133;
        public const int Rakan = 497;
        public const int Rammus = 33;
        public const int RekSai = 421;
        public const int Renekton = 58;
        public const int Rengar = 107;
        public const int Riven = 92;
        public const int Rumble = 68;
        public const int Ryze = 13;
        public const int Sejuani = 113;
        public const int Shaco = 35;
        public const int Shen = 98;
        public const int Shyvana = 102;
        public const int Singed = 27;
        public const int Sion = 14;
        public const int Sivir = 15;
        public const int Skarner = 72;
        public const int Sona = 37;
        public const int Soraka = 16;
        public const int Swain = 50;
        public const int Sylas = 517;
        public const int Syndra = 134;
        public const int TahmKench = 223;
        public const int Taliyah = 163;
        public const int Talon = 91;
        public const int Taric = 44;
        public const int Teemo = 17;
        public const int Thresh = 412;
        public const int Tristana = 18;
        public const int Trundle = 48;
        public const int Tryndamere = 23;
        public const int TwistedFate = 4;
        public const int Twitch = 29;
        public const int Udyr = 77;
        public const int Urgot = 6;
        public const int Varus = 110;
        public const int Vayne = 67;
        public const int Veigar = 45;
        public const int VelKoz = 161;
        public const int Vi = 254;
        public const int Viktor = 112;
        public const int Vladimir = 8;
        public const int Volibear = 106;
        public const int Warwick = 19;
        public const int Xayah = 498;
        public const int Xerath = 101;
        public const int XinZhao = 5;
        public const int Yasuo = 157;
        public const int Yorick = 83;
        public const int Yuumi = 350;
        public const int Zac = 154;
        public const int Zed = 238;
        public const int Ziggs = 115;
        public const int Zilean = 26;
        public const int Zoe = 142;
        public const int Zyra = 143;
    }
    /// <summary>
    /// Champion enum based on ChampionIds.
    /// </summary>
    public enum Champion : int
    {
        AATROX = 266,
        AHRI = 103,
        AKALI = 84,
        ALISTAR = 12,
        AMUMU = 32,
        ANIVIA = 34,
        ANNIE = 1,
        ASHE = 22,
        AURELION_SOL = 136,
        AZIR = 268,
        BARD = 432,
        BLITZCRANK = 53,
        BRAND = 63,
        BRAUM = 201,
        CAITLYN = 51,
        CAMILLE = 164,
        CASSIOPEIA = 69,
        CHO_GATH = 31,
        CORKI = 42,
        DARIUS = 122,
        DIANA = 131,
        DRAVEN = 119,
        DR_MUNDO = 36,
        EKKO = 245,
        ELISE = 60,
        EVELYNN = 28,
        EZREAL = 81,
        FIDDLESTICKS = 9,
        FIORA = 114,
        FIZZ = 105,
        GALIO = 3,
        GANGPLANK = 41,
        GAREN = 86,
        GNAR = 150,
        GRAGAS = 79,
        GRAVES = 104,
        HECARIM = 120,
        HEIMERDINGER = 74,
        ILLAOI = 420,
        IRELIA = 39,
        IVERN = 427,
        JANNA = 40,
        JARVAN_IV = 59,
        JAX = 24,
        JAYCE = 126,
        JHIN = 202,
        JINX = 222,
        KAI_SA = 145,
        KALISTA = 429,
        KARMA = 43,
        KARTHUS = 30,
        KASSADIN = 38,
        KATARINA = 55,
        KAYLE = 10,
        KAYN = 141,
        KENNEN = 85,
        KHA_ZIX = 121,
        KINDRED = 203,
        KLED = 240,
        KOG_MAW = 96,
        LEBLANC = 7,
        LEE_SIN = 64,
        LEONA = 89,
        LISSANDRA = 127,
        LUCIAN = 236,
        LULU = 117,
        LUX = 99,
        MALPHITE = 54,
        MALZAHAR = 90,
        MAOKAI = 57,
        MASTER_YI = 11,
        MISS_FORTUNE = 21,
        WUKONG = 62,
        MORDEKAISER = 82,
        MORGANA = 25,
        NAMI = 267,
        NASUS = 75,
        NAUTILUS = 111,
        NEEKO = 518,
        NIDALEE = 76,
        NOCTURNE = 56,
        NUNU_WILLUMP = 20,
        OLAF = 2,
        ORIANNA = 61,
        ORNN = 516,
        PANTHEON = 80,
        POPPY = 78,
        PYKE = 555,
        QUINN = 133,
        RAKAN = 497,
        RAMMUS = 33,
        REK_SAI = 421,
        RENEKTON = 58,
        RENGAR = 107,
        RIVEN = 92,
        RUMBLE = 68,
        RYZE = 13,
        SEJUANI = 113,
        SHACO = 35,
        SHEN = 98,
        SHYVANA = 102,
        SINGED = 27,
        SION = 14,
        SIVIR = 15,
        SKARNER = 72,
        SONA = 37,
        SORAKA = 16,
        SWAIN = 50,
        SYLAS = 517,
        SYNDRA = 134,
        TAHM_KENCH = 223,
        TALIYAH = 163,
        TALON = 91,
        TARIC = 44,
        TEEMO = 17,
        THRESH = 412,
        TRISTANA = 18,
        TRUNDLE = 48,
        TRYNDAMERE = 23,
        TWISTED_FATE = 4,
        TWITCH = 29,
        UDYR = 77,
        URGOT = 6,
        VARUS = 110,
        VAYNE = 67,
        VEIGAR = 45,
        VEL_KOZ = 161,
        VI = 254,
        VIKTOR = 112,
        VLADIMIR = 8,
        VOLIBEAR = 106,
        WARWICK = 19,
        XAYAH = 498,
        XERATH = 101,
        XIN_ZHAO = 5,
        YASUO = 157,
        YORICK = 83,
        YUUMI = 350,
        ZAC = 154,
        ZED = 238,
        ZIGGS = 115,
        ZILEAN = 26,
        ZOE = 142,
        ZYRA = 143,
    }

    public static class ChampionUtils
    {
        /// <summary>
        /// Return's the champion's human-readable name (en-US).
        /// </summary>
        /// <param name="val">The Champion value.</param>
        /// <param name="throwOnUnknown">
        /// If false (default), will return "UNKNOWN" on unknown champions.
        /// If true, throws an InvalidOperationException on unknown champions.
        /// </param>
        /// <returns>Champion's name or "UNKNOWN".</returns>
        public static string Name(this Champion val, bool throwOnUnknown = false)
        {
            switch ((int) val)
            {
                case 266: return "Aatrox";
                case 103: return "Ahri";
                case 84: return "Akali";
                case 12: return "Alistar";
                case 32: return "Amumu";
                case 34: return "Anivia";
                case 1: return "Annie";
                case 22: return "Ashe";
                case 136: return "Aurelion Sol";
                case 268: return "Azir";
                case 432: return "Bard";
                case 53: return "Blitzcrank";
                case 63: return "Brand";
                case 201: return "Braum";
                case 51: return "Caitlyn";
                case 164: return "Camille";
                case 69: return "Cassiopeia";
                case 31: return "Cho'Gath";
                case 42: return "Corki";
                case 122: return "Darius";
                case 131: return "Diana";
                case 119: return "Draven";
                case 36: return "Dr. Mundo";
                case 245: return "Ekko";
                case 60: return "Elise";
                case 28: return "Evelynn";
                case 81: return "Ezreal";
                case 9: return "Fiddlesticks";
                case 114: return "Fiora";
                case 105: return "Fizz";
                case 3: return "Galio";
                case 41: return "Gangplank";
                case 86: return "Garen";
                case 150: return "Gnar";
                case 79: return "Gragas";
                case 104: return "Graves";
                case 120: return "Hecarim";
                case 74: return "Heimerdinger";
                case 420: return "Illaoi";
                case 39: return "Irelia";
                case 427: return "Ivern";
                case 40: return "Janna";
                case 59: return "Jarvan IV";
                case 24: return "Jax";
                case 126: return "Jayce";
                case 202: return "Jhin";
                case 222: return "Jinx";
                case 145: return "Kai'Sa";
                case 429: return "Kalista";
                case 43: return "Karma";
                case 30: return "Karthus";
                case 38: return "Kassadin";
                case 55: return "Katarina";
                case 10: return "Kayle";
                case 141: return "Kayn";
                case 85: return "Kennen";
                case 121: return "Kha'Zix";
                case 203: return "Kindred";
                case 240: return "Kled";
                case 96: return "Kog'Maw";
                case 7: return "LeBlanc";
                case 64: return "Lee Sin";
                case 89: return "Leona";
                case 127: return "Lissandra";
                case 236: return "Lucian";
                case 117: return "Lulu";
                case 99: return "Lux";
                case 54: return "Malphite";
                case 90: return "Malzahar";
                case 57: return "Maokai";
                case 11: return "Master Yi";
                case 21: return "Miss Fortune";
                case 62: return "Wukong";
                case 82: return "Mordekaiser";
                case 25: return "Morgana";
                case 267: return "Nami";
                case 75: return "Nasus";
                case 111: return "Nautilus";
                case 518: return "Neeko";
                case 76: return "Nidalee";
                case 56: return "Nocturne";
                case 20: return "Nunu & Willump";
                case 2: return "Olaf";
                case 61: return "Orianna";
                case 516: return "Ornn";
                case 80: return "Pantheon";
                case 78: return "Poppy";
                case 555: return "Pyke";
                case 133: return "Quinn";
                case 497: return "Rakan";
                case 33: return "Rammus";
                case 421: return "Rek'Sai";
                case 58: return "Renekton";
                case 107: return "Rengar";
                case 92: return "Riven";
                case 68: return "Rumble";
                case 13: return "Ryze";
                case 113: return "Sejuani";
                case 35: return "Shaco";
                case 98: return "Shen";
                case 102: return "Shyvana";
                case 27: return "Singed";
                case 14: return "Sion";
                case 15: return "Sivir";
                case 72: return "Skarner";
                case 37: return "Sona";
                case 16: return "Soraka";
                case 50: return "Swain";
                case 517: return "Sylas";
                case 134: return "Syndra";
                case 223: return "Tahm Kench";
                case 163: return "Taliyah";
                case 91: return "Talon";
                case 44: return "Taric";
                case 17: return "Teemo";
                case 412: return "Thresh";
                case 18: return "Tristana";
                case 48: return "Trundle";
                case 23: return "Tryndamere";
                case 4: return "Twisted Fate";
                case 29: return "Twitch";
                case 77: return "Udyr";
                case 6: return "Urgot";
                case 110: return "Varus";
                case 67: return "Vayne";
                case 45: return "Veigar";
                case 161: return "Vel'Koz";
                case 254: return "Vi";
                case 112: return "Viktor";
                case 8: return "Vladimir";
                case 106: return "Volibear";
                case 19: return "Warwick";
                case 498: return "Xayah";
                case 101: return "Xerath";
                case 5: return "Xin Zhao";
                case 157: return "Yasuo";
                case 83: return "Yorick";
                case 350: return "Yuumi";
                case 154: return "Zac";
                case 238: return "Zed";
                case 115: return "Ziggs";
                case 26: return "Zilean";
                case 142: return "Zoe";
                case 143: return "Zyra";
                default:
                    if (throwOnUnknown)
                        throw new InvalidOperationException("Unknown champion ID: " + val);
                    return "UNKNOWN";
            }
        }

        /// <summary>
        /// Returns the champion's string identifier.
        /// 
        /// This is generally the same as their Name with spaces and symbols removed
        /// with notable exceptions in "MonkeyKing" (Wu Kong) and "Nunu" (Nunu &amp; Willump).
        /// </summary>
        /// <param name="val">The Champion value.</param>
        /// <param name="throwOnUnknown">
        /// If false (default), will return "UNKNOWN" on unknown champions.
        /// If true, throws an InvalidOperationException on unknown champions.
        /// </param>
        /// <returns>Champion's string identifier or "UNKNOWN".</returns>
        public static string Identifier(this Champion val, bool throwOnUnknown = false)
        {
            switch ((int) val)
            {
                case 266: return "Aatrox";
                case 103: return "Ahri";
                case 84: return "Akali";
                case 12: return "Alistar";
                case 32: return "Amumu";
                case 34: return "Anivia";
                case 1: return "Annie";
                case 22: return "Ashe";
                case 136: return "AurelionSol";
                case 268: return "Azir";
                case 432: return "Bard";
                case 53: return "Blitzcrank";
                case 63: return "Brand";
                case 201: return "Braum";
                case 51: return "Caitlyn";
                case 164: return "Camille";
                case 69: return "Cassiopeia";
                case 31: return "Chogath";
                case 42: return "Corki";
                case 122: return "Darius";
                case 131: return "Diana";
                case 119: return "Draven";
                case 36: return "DrMundo";
                case 245: return "Ekko";
                case 60: return "Elise";
                case 28: return "Evelynn";
                case 81: return "Ezreal";
                case 9: return "Fiddlesticks";
                case 114: return "Fiora";
                case 105: return "Fizz";
                case 3: return "Galio";
                case 41: return "Gangplank";
                case 86: return "Garen";
                case 150: return "Gnar";
                case 79: return "Gragas";
                case 104: return "Graves";
                case 120: return "Hecarim";
                case 74: return "Heimerdinger";
                case 420: return "Illaoi";
                case 39: return "Irelia";
                case 427: return "Ivern";
                case 40: return "Janna";
                case 59: return "JarvanIV";
                case 24: return "Jax";
                case 126: return "Jayce";
                case 202: return "Jhin";
                case 222: return "Jinx";
                case 145: return "Kaisa";
                case 429: return "Kalista";
                case 43: return "Karma";
                case 30: return "Karthus";
                case 38: return "Kassadin";
                case 55: return "Katarina";
                case 10: return "Kayle";
                case 141: return "Kayn";
                case 85: return "Kennen";
                case 121: return "Khazix";
                case 203: return "Kindred";
                case 240: return "Kled";
                case 96: return "KogMaw";
                case 7: return "Leblanc";
                case 64: return "LeeSin";
                case 89: return "Leona";
                case 127: return "Lissandra";
                case 236: return "Lucian";
                case 117: return "Lulu";
                case 99: return "Lux";
                case 54: return "Malphite";
                case 90: return "Malzahar";
                case 57: return "Maokai";
                case 11: return "MasterYi";
                case 21: return "MissFortune";
                case 62: return "MonkeyKing";
                case 82: return "Mordekaiser";
                case 25: return "Morgana";
                case 267: return "Nami";
                case 75: return "Nasus";
                case 111: return "Nautilus";
                case 518: return "Neeko";
                case 76: return "Nidalee";
                case 56: return "Nocturne";
                case 20: return "Nunu";
                case 2: return "Olaf";
                case 61: return "Orianna";
                case 516: return "Ornn";
                case 80: return "Pantheon";
                case 78: return "Poppy";
                case 555: return "Pyke";
                case 133: return "Quinn";
                case 497: return "Rakan";
                case 33: return "Rammus";
                case 421: return "RekSai";
                case 58: return "Renekton";
                case 107: return "Rengar";
                case 92: return "Riven";
                case 68: return "Rumble";
                case 13: return "Ryze";
                case 113: return "Sejuani";
                case 35: return "Shaco";
                case 98: return "Shen";
                case 102: return "Shyvana";
                case 27: return "Singed";
                case 14: return "Sion";
                case 15: return "Sivir";
                case 72: return "Skarner";
                case 37: return "Sona";
                case 16: return "Soraka";
                case 50: return "Swain";
                case 517: return "Sylas";
                case 134: return "Syndra";
                case 223: return "TahmKench";
                case 163: return "Taliyah";
                case 91: return "Talon";
                case 44: return "Taric";
                case 17: return "Teemo";
                case 412: return "Thresh";
                case 18: return "Tristana";
                case 48: return "Trundle";
                case 23: return "Tryndamere";
                case 4: return "TwistedFate";
                case 29: return "Twitch";
                case 77: return "Udyr";
                case 6: return "Urgot";
                case 110: return "Varus";
                case 67: return "Vayne";
                case 45: return "Veigar";
                case 161: return "Velkoz";
                case 254: return "Vi";
                case 112: return "Viktor";
                case 8: return "Vladimir";
                case 106: return "Volibear";
                case 19: return "Warwick";
                case 498: return "Xayah";
                case 101: return "Xerath";
                case 5: return "XinZhao";
                case 157: return "Yasuo";
                case 83: return "Yorick";
                case 350: return "Yuumi";
                case 154: return "Zac";
                case 238: return "Zed";
                case 115: return "Ziggs";
                case 26: return "Zilean";
                case 142: return "Zoe";
                case 143: return "Zyra";
                default:
                    if (throwOnUnknown)
                        throw new InvalidOperationException("Unknown champion ID: " + val);
                    return "UNKNOWN";
            }
        }

        /// <summary>
        /// Return's the Champion corresponding to a champion's string identifier or (en-US) name.
        ///
        /// This method will only look at the first four alphabetic characters in the given string.
        /// </summary>
        /// <param name="val">
        /// The string identifier or name. Only the first four alphabetic characters will be looked at.
        /// </param>
        /// <param name="throwOnUnknown">
        /// If false (default), will return 0 on unknown strings.
        /// If true, throws an InvalidOperationException on unknown strings.
        /// </param>
        /// <returns>Champion enum or 0.</returns>
        public static Champion Parse(string val, bool throwOnUnknown = false)
        {
            switch (val.ToCharArray()
                .Select(char.ToUpperInvariant)
                .Where(c => 'A' <= c && c <= 'Z')
                .Take(4).Aggregate(0, (hash, next) => hash * 32 + next))
            {
                case 2199250 /* AATR */: return (Champion) 266;
                case 2206345 /* AHRI */: return (Champion) 103;
                case 2208876 /* AKAL */: return (Champion) 84;
                case 2210163 /* ALIS */: return (Champion) 12;
                case 2211565 /* AMUM */: return (Champion) 32;
                case 2212214 /* ANIV */: return (Champion) 34;
                case 2212361 /* ANNI */: return (Champion) 1;
                case 2217285 /* ASHE */: return (Champion) 22;
                case 2219653 /* AURE */: return (Champion) 136;
                case 2224498 /* AZIR */: return (Champion) 268;
                case 2231940 /* BARD */: return (Champion) 432;
                case 2242932 /* BLIT */: return (Champion) 53;
                case 2248814 /* BRAN */: return (Champion) 63;
                case 2248821 /* BRAU */: return (Champion) 201;
                case 2264436 /* CAIT */: return (Champion) 51;
                case 2264553 /* CAMI */: return (Champion) 164;
                case 2264755 /* CASS */: return (Champion) 69;
                case 2271783 /* CHOG */:
                case 70991   /* CHO  */: return (Champion) 31;
                case 2279051 /* CORK */: return (Champion) 42;
                case 2297481 /* DARI */: return (Champion) 122;
                case 2305134 /* DIAN */: return (Champion) 131;
                case 2314358 /* DRAV */: return (Champion) 119;
                case 2314741 /* DRMU */:
                case 2258    /* DR   */: return (Champion) 36;
                case 2340271 /* EKKO */: return (Champion) 245;
                case 2341235 /* ELIS */: return (Champion) 60;
                case 2351340 /* EVEL */: return (Champion) 28;
                case 2355845 /* EZRE */: return (Champion) 81;
                case 2370756 /* FIDD */: return (Champion) 9;
                case 2371122 /* FIOR */: return (Champion) 114;
                case 2371482 /* FIZZ */: return (Champion) 105;
                case 2395593 /* GALI */: return (Champion) 3;
                case 2395655 /* GANG */: return (Champion) 41;
                case 2395781 /* GARE */: return (Champion) 86;
                case 2408562 /* GNAR */: return (Champion) 150;
                case 2412647 /* GRAG */: return (Champion) 79;
                case 2412662 /* GRAV */: return (Champion) 104;
                case 2432161 /* HECA */: return (Champion) 120;
                case 2432365 /* HEIM */: return (Champion) 74;
                case 2472385 /* ILLA */: return (Champion) 420;
                case 2478316 /* IREL */: return (Champion) 39;
                case 2482418 /* IVER */: return (Champion) 427;
                case 2493966 /* JANN */: return (Champion) 40;
                case 2494102 /* JARV */: return (Champion) 59;
                case 77944   /* JAX  */: return (Champion) 24;
                case 2494307 /* JAYC */: return (Champion) 126;
                case 2500974 /* JHIN */: return (Champion) 202;
                case 2502168 /* JINX */: return (Champion) 222;
                case 2526579 /* KAIS */:
                case 78953   /* KAI  */: return (Champion) 145;
                case 2526665 /* KALI */: return (Champion) 429;
                case 2526861 /* KARM */: return (Champion) 43;
                case 2526868 /* KART */: return (Champion) 30;
                case 2526899 /* KASS */: return (Champion) 38;
                case 2526913 /* KATA */: return (Champion) 55;
                case 2527084 /* KAYL */: return (Champion) 10;
                case 2527086 /* KAYN */: return (Champion) 141;
                case 2530830 /* KENN */: return (Champion) 85;
                case 2533498 /* KHAZ */:
                case 79169   /* KHA  */: return (Champion) 121;
                case 2534916 /* KIND */: return (Champion) 203;
                case 2537700 /* KLED */: return (Champion) 240;
                case 2540845 /* KOGM */:
                case 79399   /* KOG  */: return (Champion) 96;
                case 2563212 /* LEBL */: return (Champion) 7;
                case 2563315 /* LEES */:
                case 80101   /* LEE  */: return (Champion) 64;
                case 2563630 /* LEON */: return (Champion) 89;
                case 2567859 /* LISS */: return (Champion) 127;
                case 2579625 /* LUCI */: return (Champion) 236;
                case 2579925 /* LULU */: return (Champion) 117;
                case 80632   /* LUX  */: return (Champion) 99;
                case 2592208 /* MALP */: return (Champion) 54;
                case 2592218 /* MALZ */: return (Champion) 90;
                case 2592299 /* MAOK */: return (Champion) 57;
                case 2592436 /* MAST */: return (Champion) 11;
                case 2600627 /* MISS */: return (Champion) 21;
                case 2940335 /* WUKO */:
                case 2606603 /* MONK */: return (Champion) 62;
                case 2606724 /* MORD */: return (Champion) 82;
                case 2606727 /* MORG */: return (Champion) 25;
                case 2625001 /* NAMI */: return (Champion) 267;
                case 2625205 /* NASU */: return (Champion) 75;
                case 2625268 /* NAUT */: return (Champion) 111;
                case 2628843 /* NEEK */: return (Champion) 518;
                case 2632897 /* NIDA */: return (Champion) 76;
                case 2639028 /* NOCT */: return (Champion) 56;
                case 2645525 /* NUNU */: return (Champion) 20;
                case 2668646 /* OLAF */: return (Champion) 2;
                case 2675041 /* ORIA */: return (Champion) 61;
                case 2675214 /* ORNN */: return (Champion) 516;
                case 2690580 /* PANT */: return (Champion) 80;
                case 2704976 /* POPP */: return (Champion) 78;
                case 2715045 /* PYKE */: return (Champion) 555;
                case 2743662 /* QUIN */: return (Champion) 133;
                case 2756001 /* RAKA */: return (Champion) 497;
                case 2756077 /* RAMM */: return (Champion) 33;
                case 2760115 /* REKS */:
                case 86251   /* REK  */: return (Champion) 421;
                case 2760197 /* RENE */: return (Champion) 58;
                case 2760199 /* RENG */: return (Champion) 107;
                case 2764549 /* RIVE */: return (Champion) 92;
                case 2776546 /* RUMB */: return (Champion) 68;
                case 2781061 /* RYZE */: return (Champion) 13;
                case 2792853 /* SEJU */: return (Champion) 113;
                case 2795619 /* SHAC */: return (Champion) 35;
                case 2795758 /* SHEN */: return (Champion) 98;
                case 2796406 /* SHYV */: return (Champion) 102;
                case 2797063 /* SING */: return (Champion) 27;
                case 2797102 /* SION */: return (Champion) 14;
                case 2797321 /* SIVI */: return (Champion) 15;
                case 2798706 /* SKAR */: return (Champion) 72;
                case 2803201 /* SONA */: return (Champion) 37;
                case 2803329 /* SORA */: return (Champion) 16;
                case 2810985 /* SWAI */: return (Champion) 50;
                case 2813377 /* SYLA */: return (Champion) 517;
                case 2813444 /* SYND */: return (Champion) 134;
                case 2821453 /* TAHM */: return (Champion) 223;
                case 2821577 /* TALI */: return (Champion) 163;
                case 2821583 /* TALO */: return (Champion) 91;
                case 2821769 /* TARI */: return (Champion) 44;
                case 2825453 /* TEEM */: return (Champion) 17;
                case 2828933 /* THRE */: return (Champion) 412;
                case 2838899 /* TRIS */: return (Champion) 18;
                case 2839278 /* TRUN */: return (Champion) 48;
                case 2839406 /* TRYN */: return (Champion) 23;
                case 2844019 /* TWIS */: return (Champion) 4;
                case 2844020 /* TWIT */: return (Champion) 29;
                case 2857842 /* UDYR */: return (Champion) 77;
                case 2871599 /* URGO */: return (Champion) 6;
                case 2887317 /* VARU */: return (Champion) 110;
                case 2887534 /* VAYN */: return (Champion) 67;
                case 2891111 /* VEIG */: return (Champion) 45;
                case 2891211 /* VELK */:
                case 90348   /* VEL  */: return (Champion) 161;
                case 2825    /* VI   */: return (Champion) 254;
                case 2895284 /* VIKT */: return (Champion) 112;
                case 2898020 /* VLAD */: return (Champion) 8;
                case 2901449 /* VOLI */: return (Champion) 106;
                case 2920087 /* WARW */: return (Champion) 19;
                case 2953057 /* XAYA */: return (Champion) 498;
                case 2956929 /* XERA */: return (Champion) 101;
                case 2960922 /* XINZ */:
                case 92526   /* XIN  */: return (Champion) 5;
                case 2985653 /* YASU */: return (Champion) 157;
                case 2999945 /* YORI */: return (Champion) 83;
                case 3006189 /* YUUM */: return (Champion) 350;
                case 94307   /* ZAC  */: return (Champion) 154;
                case 94436   /* ZED  */: return (Champion) 238;
                case 3026215 /* ZIGG */: return (Champion) 115;
                case 3026373 /* ZILE */: return (Champion) 26;
                case 94757   /* ZOE  */: return (Champion) 142;
                case 3042945 /* ZYRA */: return (Champion) 143;
                default:
                    if (throwOnUnknown)
                        throw new InvalidOperationException("Unknown champion string identifier: " + val);
                    return 0;
            }
        }
    }
}
