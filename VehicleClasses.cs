using GTA;

namespace RandomVehicles
{
    class VehicleClasses
    {

        public static VehicleHash[] badVehicles = {

            VehicleHash.CableCar,
            VehicleHash.Submersible,
            VehicleHash.Submersible2,
            VehicleHash.Freight,
            VehicleHash.FreightCar,
            VehicleHash.FreightCont1,
            VehicleHash.FreightCont2,
            VehicleHash.FreightGrain,
            VehicleHash.FreightTrailer,
            VehicleHash.MetroTrain,
            VehicleHash.TankerCar
        };

        public static VehicleHash[] trailers = {
            VehicleHash.ArmyTanker,
            VehicleHash.ArmyTrailer,
            VehicleHash.ArmyTrailer2,
            VehicleHash.BaleTrailer,
            VehicleHash.BoatTrailer,
            VehicleHash.BoatTrailer,
            VehicleHash.DockTrailer,
            VehicleHash.GrainTrailer,
            VehicleHash.PropTrailer,
            VehicleHash.RakeTrailer,
            VehicleHash.Tanker,
            VehicleHash.Tanker2,
            VehicleHash.TR2,
            VehicleHash.TR3,
            VehicleHash.TR4,
            VehicleHash.TrailerLarge,
            VehicleHash.TrailerLogs,
            VehicleHash.Trailers,
            VehicleHash.Trailers2,
            VehicleHash.Trailers3,
            VehicleHash.Trailers4,
            VehicleHash.TrailerSmall,
            VehicleHash.TrailerSmall2,
            VehicleHash.TRFlat,
            VehicleHash.TVTrailer
        };

        public static VehicleHash[] bicycles = {
            VehicleHash.Bmx,
            VehicleHash.Cruiser,
            VehicleHash.Fixter,
            VehicleHash.Scorcher,
            VehicleHash.TriBike,
            VehicleHash.TriBike2,
            VehicleHash.TriBike3
        };

        public static VehicleHash[] boats = {
            VehicleHash.Dinghy,
            VehicleHash.Dinghy2,
            VehicleHash.Dinghy3,
            VehicleHash.Dinghy4,
            VehicleHash.Jetmax,
            VehicleHash.Marquis,
            VehicleHash.Predator,
            VehicleHash.Seashark,
            VehicleHash.Seashark2,
            VehicleHash.Seashark3,
            VehicleHash.Speeder,
            VehicleHash.Speeder2,
            VehicleHash.Squalo,
            VehicleHash.Suntrap,
            VehicleHash.Toro,
            VehicleHash.Toro2,
            VehicleHash.Tropic,
            VehicleHash.Tropic2,
            VehicleHash.Tug
        };

        public static VehicleHash[] commercials = {
			//VehicleHash.Cerberus,
			//VehicleHash.Cerberus2,
			//VehicleHash.Cerberus3,
			VehicleHash.Hauler2,
			//VehicleHash.Mule4,
			VehicleHash.Phantom3,
			//VehicleHash.Pounder2,
			//VehicleHash.Terrorbyte
		};

        public static VehicleHash[] compacts = {
            VehicleHash.Blista,
            VehicleHash.Brioso,
            VehicleHash.Dilettante,
            VehicleHash.Dilettante2,
            VehicleHash.Issi2,
            VehicleHash.Issi3,
			//VehicleHash.Issi4,
			//VehicleHash.Issi5,
			//VehicleHash.Issi6,
			VehicleHash.Panto,
            VehicleHash.Prairie,
            VehicleHash.Rhapsody

        };

        public static VehicleHash[] coupes = {
            VehicleHash.CogCabrio,
            VehicleHash.Exemplar,
            VehicleHash.F620,
            VehicleHash.Faction,
            VehicleHash.Faction2,
            VehicleHash.Felon,
            VehicleHash.Felon2,
            VehicleHash.Jackal,
            VehicleHash.Sentinel,
            VehicleHash.Sentinel2,
            VehicleHash.Windsor,
            VehicleHash.Windsor2,
            VehicleHash.Zion,
            VehicleHash.Zion2
        };

        public static VehicleHash[] emergency = {
            VehicleHash.Ambulance,
            VehicleHash.Barracks,
            VehicleHash.Barracks2,
            VehicleHash.Barracks3,
            VehicleHash.Crusader,
            VehicleHash.FBI,
            VehicleHash.FBI2,
            VehicleHash.FireTruck,
            VehicleHash.Lguard,
            VehicleHash.PBus,
            VehicleHash.Police,
            VehicleHash.Police2,
            VehicleHash.Police3,
            VehicleHash.Police4,
            VehicleHash.Policeb,
            VehicleHash.PoliceOld1,
            VehicleHash.PoliceOld2,
            VehicleHash.PoliceT,
            VehicleHash.Pranger,
            VehicleHash.Riot,
			//VehicleHash.Riot2,
			VehicleHash.Sheriff,
            VehicleHash.Sheriff2
        };

        public static VehicleHash[] helicopters = {
		    (VehicleHash)0x46699F47,//.Akula,
			VehicleHash.Annihilator,
            VehicleHash.Buzzard,
            VehicleHash.Buzzard2,
            VehicleHash.Cargobob,
            VehicleHash.Cargobob2,
            VehicleHash.Cargobob3,
            VehicleHash.Cargobob4,
            VehicleHash.Frogger,
            VehicleHash.Frogger2,
            VehicleHash.Havok,
            VehicleHash.Hunter,
            VehicleHash.Maverick,
            VehicleHash.Polmav,
            VehicleHash.Savage,
            VehicleHash.SeaSparrow,
            VehicleHash.Skylift,
            VehicleHash.Supervolito,
            VehicleHash.Supervolito2,
            VehicleHash.Swift,
            VehicleHash.Swift2,
			(VehicleHash)0x58CDAF30,//VehicleHash.Thruster,
            VehicleHash.Valkyrie,
            VehicleHash.Valkyrie2,
            VehicleHash.Volatus

        };

        public static VehicleHash[] motorbikes = {
            VehicleHash.Akuma,
            VehicleHash.Avarus,
            VehicleHash.Bagger,
            VehicleHash.Bati,
            VehicleHash.Bati2,
            VehicleHash.BF400,
            VehicleHash.CarbonRS,
            VehicleHash.Chimera,
            VehicleHash.Cliffhanger,
            VehicleHash.Daemon,
            VehicleHash.Daemon2,
			//VehicleHash.Deathbike,
			//VehicleHash.Deathbike2,
			//VehicleHash.Deathbike3,
			VehicleHash.Defiler,
            VehicleHash.Diablous,
            VehicleHash.Diablous2,
            VehicleHash.Double,
            VehicleHash.Enduro,
            VehicleHash.Esskey,
            VehicleHash.Faggio,
            VehicleHash.Faggio2,
            VehicleHash.Faggio3,
            VehicleHash.FCR,
            VehicleHash.FCR2,
            VehicleHash.Gargoyle,
            VehicleHash.Hakuchou,
            VehicleHash.Hakuchou2,
            VehicleHash.Hexer,
            VehicleHash.Innovation,
            VehicleHash.Lectro,
            VehicleHash.Manchez,
            VehicleHash.Nemesis,
            VehicleHash.Nightblade,
            VehicleHash.Oppressor,
			//VehicleHash.Oppressor2,
			VehicleHash.PCJ,
            VehicleHash.RatBike,
			//(VehicleHash)916547552,
			VehicleHash.Ruffian,
            VehicleHash.Sanchez,
            VehicleHash.Sanchez2,
            VehicleHash.Sanctus,
            VehicleHash.Shotaro,
            VehicleHash.Sovereign,
            VehicleHash.Thrust,
            VehicleHash.Vader,
            VehicleHash.Vindicator,
            VehicleHash.Vortex,
            VehicleHash.Wolfsbane,
            VehicleHash.ZombieA,
            VehicleHash.ZombieB
        };

        public static VehicleHash[] military = {
			//VehicleHash.APC,
			//VehicleHash.Barrage,
			//VehicleHash.Chernobog,
			VehicleHash.HalfTrack,
			//VehicleHash.Khanjari,
			VehicleHash.Rhino,
			//VehicleHash.Scarab,
			//VehicleHash.Scarab2,
			//VehicleHash.Scarab3,
			VehicleHash.Vigilante
        };

        public static VehicleHash[] muscle = {
            VehicleHash.Blade,
            VehicleHash.BType2,
            VehicleHash.Buccaneer,
            VehicleHash.Buccaneer2,
            VehicleHash.Chino,
            VehicleHash.Chino2,
			//VehicleHash.Clique, //crash?
			//VehicleHash.Deviant,
			VehicleHash.Dominator,
            VehicleHash.Dominator2,
            VehicleHash.Dominator3,
			//VehicleHash.Dominator4,
			//VehicleHash.Dominator5,
			//VehicleHash.Dominator6,
			VehicleHash.Dukes,
            VehicleHash.Dukes2,
            VehicleHash.Ellie,
            VehicleHash.Faction3,
            VehicleHash.Gauntlet,
            VehicleHash.Gauntlet2,
			//(VehicleHash)722226637, // Gauntlet3
			//(VehicleHash)1934384720, // Gauntlet4
			//VehicleHash.Hermes,
			VehicleHash.Hotknife,
			//VehicleHash.Hustler,
			//VehicleHash.Impaler,
			//VehicleHash.Impaler2,
			//VehicleHash.Impaler3,
			//VehicleHash.Impaler4,
			//VehicleHash.Imperator,
			//VehicleHash.Imperator2,
			//VehicleHash.Imperator3,
			VehicleHash.Minivan2,
            VehicleHash.Nightshade,
			//(VehicleHash)2490551588, // Peyote2
			VehicleHash.Phoenix,
            VehicleHash.Picador,
            VehicleHash.Ruiner,
            VehicleHash.SabreGT,
            VehicleHash.SabreGT2,
            VehicleHash.SlamVan,
            VehicleHash.SlamVan2,
            VehicleHash.SlamVan3,
			//VehicleHash.SlamVan4,
			//VehicleHash.SlamVan5,
			//VehicleHash.SlamVan6,
			VehicleHash.Stalion,
            VehicleHash.Stalion2,
            VehicleHash.Tampa,
            VehicleHash.Tampa2,
            VehicleHash.Tampa3,
            VehicleHash.Tornado5,
            VehicleHash.Tornado6,
			//VehicleHash.Tulip,
			//VehicleHash.Vamos,
			VehicleHash.Vigero,
            VehicleHash.Virgo,
            VehicleHash.Virgo2,
            VehicleHash.Virgo3,
            VehicleHash.Voodoo,
            VehicleHash.Voodoo2,
			//VehicleHash.Yosemite
		};

        public static VehicleHash[] offroad = {
            VehicleHash.BfInjection,
            VehicleHash.Bifta,
            VehicleHash.Blazer,
            VehicleHash.Blazer2,
            VehicleHash.Blazer3,
            VehicleHash.Blazer4,
            VehicleHash.Blazer5,
            VehicleHash.Bodhi2,
            VehicleHash.Brawler,
			//VehicleHash.Bruiser,
			//VehicleHash.Bruiser2,
			//VehicleHash.Bruiser3,
			//VehicleHash.Brutus,
			//VehicleHash.Brutus2,
			//VehicleHash.Brutus3,
			VehicleHash.Caracara,
			//(VehicleHash)2945871676, // Caracara2
			VehicleHash.DLoader,
            VehicleHash.Dubsta3,
            VehicleHash.Dune,
            VehicleHash.Dune2,
            VehicleHash.Dune3,
            VehicleHash.Dune4,
            VehicleHash.Dune5,
			//VehicleHash.Freecrawler,
			VehicleHash.Guardian,
			//(VehicleHash)3932816511, // Hellion
			VehicleHash.Insurgent,
            VehicleHash.Insurgent2,
            VehicleHash.Insurgent3,
            VehicleHash.Kalahari,
			//VehicleHash.Kamacho,
			VehicleHash.Marshall,
			//VehicleHash.Menacer,
			VehicleHash.Mesa3,
            VehicleHash.Monster,
			//VehicleHash.Monster3,
			//VehicleHash.Monster4,
			//VehicleHash.Monster5,
			VehicleHash.NightShark,
            VehicleHash.RancherXL,
            VehicleHash.RancherXL2,
			//VehicleHash.RCBandito,
			VehicleHash.Rebel,
            VehicleHash.Rebel2,
			//VehicleHash.Riata,
			VehicleHash.Sandking,
            VehicleHash.Sandking2,
            VehicleHash.Technical,
            VehicleHash.Technical2,
            VehicleHash.Technical3,
            VehicleHash.TrophyTruck,
            VehicleHash.TrophyTruck2,
            VehicleHash.Wastelander
        };

        public static VehicleHash[] pickups = {
            VehicleHash.Bison,
            VehicleHash.Bison2,
            VehicleHash.Bison3,
            VehicleHash.BobcatXL,
            VehicleHash.Contender,
            VehicleHash.RatLoader,
            VehicleHash.RatLoader2,
            VehicleHash.Sadler,
            VehicleHash.Sadler2
        };

        public static VehicleHash[] planes = {
            VehicleHash.AlphaZ1,
            (VehicleHash)0x81BD2ED0, //VehicleHash.Avenger,
            (VehicleHash)0x18606535, //VehicleHash.Avenger2,
            VehicleHash.Besra,
            VehicleHash.Blimp,
            VehicleHash.Blimp2,
            (VehicleHash)0xEDA4ED97, //VehicleHash.Blimp3,
            VehicleHash.Bombushka,
            VehicleHash.CargoPlane,
            VehicleHash.Cuban800,
            VehicleHash.Dodo,
            VehicleHash.Duster,
            VehicleHash.Howard,
            VehicleHash.Hydra,
            VehicleHash.Jet,
            VehicleHash.Lazer,
            VehicleHash.Luxor,
            VehicleHash.Luxor2,
            VehicleHash.Mammatus,
            VehicleHash.Microlight,
            VehicleHash.Miljet,
            VehicleHash.Mogul,
            VehicleHash.Molotok,
            VehicleHash.Nimbus,
            VehicleHash.Nokota,
            VehicleHash.Pyro,
            VehicleHash.Rogue,
            VehicleHash.Seabreeze,
            VehicleHash.Shamal,
            VehicleHash.Starling,
            (VehicleHash)0x64DE07A1,//VehicleHash.Strikeforce,//VehicleHash.Strikeforce,
            VehicleHash.Stunt,
            VehicleHash.Titan,
            VehicleHash.Tula,
            VehicleHash.Velum,
            VehicleHash.Velum2,
            VehicleHash.Vestra,
            (VehicleHash)0x1AAD0DED,//VehicleHash.Volatol
		};

        public static VehicleHash[] suvs = {
            VehicleHash.Baller,
            VehicleHash.Baller2,
            VehicleHash.Baller3,
            VehicleHash.Baller4,
            VehicleHash.Baller5,
            VehicleHash.Baller6,
            VehicleHash.BJXL,
            VehicleHash.Cavalcade,
            VehicleHash.Cavalcade2,
            VehicleHash.Dubsta,
            VehicleHash.Dubsta2,
            VehicleHash.FQ2,
            VehicleHash.Granger,
            VehicleHash.Gresley,
            VehicleHash.Habanero,
            VehicleHash.Huntley,
            VehicleHash.Landstalker,
            VehicleHash.Mesa,
            VehicleHash.Mesa2,
			//(VehicleHash)2465530446,
			VehicleHash.Patriot,
			//(VehicleHash)3874056184,
			VehicleHash.Radi,
            VehicleHash.Rocoto,
            VehicleHash.Seminole,
            VehicleHash.Serrano,
			//VehicleHash.Toros,
			VehicleHash.XLS,
            VehicleHash.XLS2
        };

        public static VehicleHash[] sedans = {
            VehicleHash.Asea,
            VehicleHash.Asea2,
            VehicleHash.Asterope,
            VehicleHash.Cog55,
            VehicleHash.Cog552,
            VehicleHash.Cognoscenti,
            VehicleHash.Cognoscenti2,
            VehicleHash.Emperor,
            VehicleHash.Emperor2,
            VehicleHash.Emperor3,
            VehicleHash.Fugitive,
            VehicleHash.Glendale,
            VehicleHash.Ingot,
            VehicleHash.Intruder,
            VehicleHash.Limo2,
            VehicleHash.Oracle,
            VehicleHash.Oracle2,
            VehicleHash.Premier,
            VehicleHash.Primo,
            VehicleHash.Primo2,
            VehicleHash.Regina,
            VehicleHash.Romero,
            VehicleHash.Schafter2,
            VehicleHash.Schafter3,
            VehicleHash.Schafter4,
            VehicleHash.Schafter5,
            VehicleHash.Schafter6,
			//VehicleHash.Stafford,
			VehicleHash.Stanier,
            VehicleHash.Stratum,
            VehicleHash.Stretch,
            VehicleHash.Superd,
            VehicleHash.Surge,
            VehicleHash.Tailgater,
            VehicleHash.Taxi,
            VehicleHash.Warrener,
            VehicleHash.Washington
        };

        public static VehicleHash[] service = {
            VehicleHash.Airbus,
            VehicleHash.Airtug,
            VehicleHash.Brickade,
            VehicleHash.Bulldozer,
            VehicleHash.Bus,
            VehicleHash.Caddy,
            VehicleHash.Caddy2,
            VehicleHash.Caddy3,
            VehicleHash.Coach,
            VehicleHash.Forklift,
            VehicleHash.Mower,
			//VehicleHash.PBus2,
			VehicleHash.RentalBus,
            VehicleHash.Ripley,
            VehicleHash.Tourbus,
            VehicleHash.Tractor,
            VehicleHash.Tractor2,
            VehicleHash.Tractor3,
            VehicleHash.Trash,
            VehicleHash.Trash2,
            VehicleHash.UtilityTruck,
            VehicleHash.UtilityTruck2,
            VehicleHash.UtilityTruck3
        };

        public static VehicleHash[] sports = {
            VehicleHash.Alpha,
            VehicleHash.Banshee,
            VehicleHash.BestiaGTS,
            VehicleHash.Blista2,
            VehicleHash.Blista3,
            VehicleHash.Buffalo,
            VehicleHash.Buffalo2,
            VehicleHash.Buffalo3,
            VehicleHash.Carbonizzare,
            VehicleHash.Comet2,
            VehicleHash.Comet3,
			// VehicleHash.Comet4,
			//VehicleHash.Comet5,
			VehicleHash.Coquette,
			//(VehicleHash)686471183, // Drafter
			VehicleHash.Elegy,
            VehicleHash.Elegy2,
            VehicleHash.Feltzer2,
            VehicleHash.FlashGT,
            VehicleHash.Furoregt,
            VehicleHash.Fusilade,
            VehicleHash.Futo,
            VehicleHash.GB200,
            VehicleHash.HotringSabre,
            VehicleHash.Infernus2,
			//(VehicleHash)1854776567, // Issi7
			//VehicleHash.ItaliGTO,
			VehicleHash.Jester,
            VehicleHash.Jester2,
			//(VehicleHash)4086055493, //Jugular
			VehicleHash.Khamelion,
            VehicleHash.Kuruma,
            VehicleHash.Kuruma2,
			//(VehicleHash)3353694737, // Locust
			VehicleHash.Lynx,
            VehicleHash.Mamba,
            VehicleHash.Massacro,
            VehicleHash.Massacro2,
			//(VehicleHash)2674840994, // Neo
			//VehicleHash.Neon,
			VehicleHash.Ninef,
            VehicleHash.Ninef2,
            VehicleHash.Omnis,
			//(VehicleHash)3847255899, // Paragon
			//(VehicleHash)1416466158, // Paragon2
			//VehicleHash.Pariah,
			VehicleHash.Penumbra,
			//VehicleHash.Raiden,
			VehicleHash.RapidGT,
            VehicleHash.RapidGT2,
            VehicleHash.Raptor,
			//VehicleHash.Revolter,
			VehicleHash.Ruiner2,
            VehicleHash.Ruiner3,
            VehicleHash.Ruston,
			//VehicleHash.Schlagen,
			VehicleHash.Schwarzer,
			//VehicleHash.Sentinel3,
			VehicleHash.Seven70,
            VehicleHash.Specter,
            VehicleHash.Specter2,
			//VehicleHash.Streiter,
			VehicleHash.Sultan,
            VehicleHash.Surano,
            VehicleHash.Tropos,
            VehicleHash.Verlierer2,
			//VehicleHash.ZR380,
			//VehicleHash.ZR3802,
			//VehicleHash.ZR3803
		};

        public static VehicleHash[] sportsClassic = {
            VehicleHash.Ardent,
            VehicleHash.BType,
            VehicleHash.BType3,
            VehicleHash.Casco,
            VehicleHash.Cheburek,
            VehicleHash.Cheetah2,
            VehicleHash.Coquette2,
            VehicleHash.Coquette3,
			//VehicleHash.Deluxo,
			//(VehicleHash)310284501, // Dynasty
			VehicleHash.Fagaloa,
            VehicleHash.Feltzer3,
			//VehicleHash.GT500,
			VehicleHash.JB700,
            VehicleHash.Jester3,
            VehicleHash.Lurcher,
            VehicleHash.Manana,
            VehicleHash.Michelli,
            VehicleHash.Monroe,
			//(VehicleHash)3412338231, // Nebula
			VehicleHash.Peyote,
            VehicleHash.Pigalle,
            VehicleHash.RapidGT3,
            VehicleHash.Retinue,
			//VehicleHash.Savestra,
			VehicleHash.Stinger,
            VehicleHash.StingerGT,
			//VehicleHash.Stromberg,
			//VehicleHash.Swinger,
			VehicleHash.Torero,
            VehicleHash.Tornado,
            VehicleHash.Tornado2,
            VehicleHash.Tornado3,
            VehicleHash.Tornado4,
			//VehicleHash.Viseris,
			//VehicleHash.Z190,
			//(VehicleHash)1862507111, // Zion3
			VehicleHash.ZType
        };

        public static VehicleHash[] super = {
            VehicleHash.Adder,
			//VehicleHash.Autarch,
			VehicleHash.Banshee2,
            VehicleHash.Bullet,
            VehicleHash.Cheetah,
            VehicleHash.Cyclone,
			//VehicleHash.Deveste,
			//(VehicleHash)1323778901, //Emerus
			VehicleHash.EntityXXR,
            VehicleHash.EntityXF,
            VehicleHash.FMJ,
            VehicleHash.GP1,
            VehicleHash.Infernus,
            VehicleHash.ItaliGTB,
            VehicleHash.ItaliGTB2,
			//(VehicleHash)3630826055, // Krieger
			//VehicleHash.LE7B,
			VehicleHash.Nero,
            VehicleHash.Nero2,
            VehicleHash.Osiris,
            VehicleHash.Penetrator,
            VehicleHash.Pfister811,
            VehicleHash.Prototipo,
            VehicleHash.Reaper,
			//(VehicleHash)3970348707, // S80
			//VehicleHash.SC1,
			//VehicleHash.Scramjet,
			VehicleHash.Sheava,
            VehicleHash.SultanRS,
            VehicleHash.T20,
            VehicleHash.Taipan,
            VehicleHash.Tempesta,
            VehicleHash.Tezeract,
			//(VehicleHash)1044193113, // Thrax
			VehicleHash.Turismo2,
            VehicleHash.Turismor,
            VehicleHash.Tyrant,
            VehicleHash.Tyrus,
            VehicleHash.Vacca,
            VehicleHash.Vagner,
            VehicleHash.Visione,
            VehicleHash.Voltic,
            VehicleHash.Voltic2,
            VehicleHash.XA21,
            VehicleHash.Zentorno,
			//(VehicleHash)3612858749 // Zorrusso
		};

        public static VehicleHash[] trucks = {
            VehicleHash.Benson,
            VehicleHash.Biff,
            VehicleHash.Boxville,
            VehicleHash.Boxville2,
            VehicleHash.Boxville3,
            VehicleHash.Boxville4,
            VehicleHash.Boxville5,
            VehicleHash.Cutter,
            VehicleHash.Docktug,
            VehicleHash.Dump,
            VehicleHash.Flatbed,
            VehicleHash.Handler,
            VehicleHash.Hauler,
            VehicleHash.Mixer,
            VehicleHash.Mixer2,
            VehicleHash.Mule,
            VehicleHash.Mule2,
            VehicleHash.Mule3,
            VehicleHash.Packer,
            VehicleHash.Phantom,
            VehicleHash.Phantom2,
            VehicleHash.Pounder,
            VehicleHash.RallyTruck,
            VehicleHash.Rubble,
            VehicleHash.Scrap,
            VehicleHash.Stockade,
            VehicleHash.Stockade3,
            VehicleHash.TipTruck,
            VehicleHash.TipTruck2,
            VehicleHash.TowTruck,
            VehicleHash.TowTruck2
        };

        public static VehicleHash[] vans = {
            VehicleHash.Burrito,
            VehicleHash.Burrito2,
            VehicleHash.Burrito3,
            VehicleHash.Burrito4,
            VehicleHash.Burrito5,
            VehicleHash.Camper,
            VehicleHash.GBurrito,
            VehicleHash.GBurrito2,
            VehicleHash.Journey,
            VehicleHash.Minivan,
            VehicleHash.Moonbeam,
            VehicleHash.Moonbeam2,
            VehicleHash.Paradise,
            VehicleHash.Pony,
            VehicleHash.Pony2,
            VehicleHash.Rumpo,
            VehicleHash.Rumpo2,
            VehicleHash.Rumpo3,
            VehicleHash.Speedo,
            VehicleHash.Speedo2,
			//VehicleHash.Speedo4,
			VehicleHash.Surfer,
            VehicleHash.Surfer2,
            VehicleHash.Taco,
            VehicleHash.Youga,
            VehicleHash.Youga2
        };

        public static VehicleHash[] missingHashes = { (VehicleHash) 0x3201DD49,
			//  Sports Classics     Z190                z190                190z
			//0x46699F47, //  Helicopters         AKULA               akula               Akula
			(VehicleHash) 0xED552C74,
			//  Super               AUTARCH             autarch             Autarch
			//0x81BD2ED0, //  Planes              AVENGER             avenger             Avenger
			//0x18606535, //  Planes              AVENGER             avenger2            Avenger
			(VehicleHash) 0xF34DFB25,
			//  Military            BARRAGE             barrage             Barrage
			(VehicleHash) 0xD6BC7523,
			//  Military            CHERNOBOG           chernobog           Chernobog
			(VehicleHash) 0x276D98A3,
			//  Sports              COMET5              comet5              Comet SR
			(VehicleHash) 0x5D1903F9,
			//  Sports              COMET4              comet4              Comet Safari
			(VehicleHash) 0x586765FB,
			//  Sports Classics     DELUXO              deluxo              Deluxo
			(VehicleHash) 0x8408F33A,
			//  Sports Classics     GT500               gt500               GT500
			(VehicleHash) 0x00E83C17,
			//  Muscle              HERMES              hermes              Hermes
			(VehicleHash) 0x23CA25F2,
			//  Muscle              HUSTLER             hustler             Hustler
			(VehicleHash) 0xF8C2E0E7,
			//  Off-Road            KAMACHO             kamacho             Kamacho
			(VehicleHash) 0x91CA96EE,
			//  Sports              NEON                neon                Neon
			(VehicleHash) 0x33B98FE2,
			//  Sports              PARIAH              pariah              Pariah
			(VehicleHash) 0x9B16A3B4,
			//  Emergency           RIOT2               riot2               RCV
			(VehicleHash) 0xA4D99B7D,
			//  Sports              RAIDEN              raiden              Raiden
			(VehicleHash) 0xE78CC3D9,
			//  Sports              REVOLTER            revolter            Revolter
			(VehicleHash) 0xA4A4E453,
			//  Off-Road            RIATA               riata               Riata
			(VehicleHash) 0x5097F589,
			//  Super               SC1                 sc1                 SC1
			(VehicleHash) 0x35DED0DD,
			//  Sports Classics     SAVESTRA            savestra            Savestra
			(VehicleHash) 0x41D149AA,
			//  Sports              sentinel3           sentinel3           Sentinel Classic
			(VehicleHash) 0x67D2B389,
			//  Sports              STREITER            streiter            Streiter
			(VehicleHash) 0x34DBA661,
			//  Sports Classics     STROMBERG           stromberg           Stromberg
			(VehicleHash) 0xAA6F980A,
			//  Military            KHANJALI            khanjali            TM - 02 Khanjali
			//0x58CDAF30, //  Military            THRUSTER            thruster            Thruster
			(VehicleHash) 0xE8A8BA94,
			//  Sports Classics     VISERIS             viseris             Viseris
			//0x1AAD0DED, //  Planes              VOLATOL             volatol             Volatol
			(VehicleHash) 0x6F946279,
			//  Muscle              YOSEMITE            yosemite            Yosemite
			//   (VehicleHash) 0x64DE07A1, //  Planes              STRIKEFORCE         strikeforce         B - 11 Strikeforce
			//(VehicleHash)0xEDA4ED97, //  Planes              BLIMP3              blimp3              Blimp
			(VehicleHash) 0x149BD32A,
			//  Service             PBUS2               pbus2               Festival Bus
			(VehicleHash) 0xFCC2F483,
			//  Off-Road            FREECRAWLER         freecrawler         Freecrawler
			(VehicleHash) 0x79DD18AE,
			//  Off-Road            MENACER             menacer             Menacer
			(VehicleHash) 0x73F4110E,
			//  Commercial          MULE4               mule4               Mule Custom
			(VehicleHash) 0x7B54A9D3,
			//  Motorcycles         OPPRESSOR2          oppressor2          Oppressor Mk II
			(VehicleHash) 0xE6E967F8,
			//  SUVs                PATRIOT2            patriot2            Patriot Stretch
			(VehicleHash) 0x6290F15B,
			//  Commercial          pounder2            pounder2            Pounder Custom
			(VehicleHash) 0xD9F0503D,
			//  Super               SCRAMJET            scramjet            Scramjet
			(VehicleHash) 0x0D17099D,
			//  Vans                SPEEDO4             speedo4             Speedo Custom
			(VehicleHash) 0x1324E960,
			//  Sedans              STAFFORD            stafford            Stafford
			(VehicleHash) 0x1DD4C0FF,
			//  Sports Classics     Swinger             swinger             Swinger
			(VehicleHash) 0x897AFC65,
			//  Commercial          terbyte             terbyte             Terrorbyte
			(VehicleHash) 0x27D79225,
			//  Off - Road          BRUISER             bruiser             Apocalypse Bruiser
			(VehicleHash) 0x7F81A829,
			//  Off - Road          BRUTUS              brutus              Apocalypse Brutus
			(VehicleHash) 0xD039510B,
			//  Commercial          cerberus            cerberus            Apocalypse Cerberus
			(VehicleHash) 0xFE5F0722,
			//  Motorcycles         DEATHBIKE           deathbike           Apocalypse Deathbike
			(VehicleHash) 0xD6FB0F30,
			//  Muscle              DOMINATOR4          dominator4          Apocalypse Dominator
			(VehicleHash) 0x3C26BD0C,
			//  Muscle              IMPALER2            impaler2            Apocalypse Impaler
			(VehicleHash) 0x1A861243,
			//  Muscle              IMPERATOR           imperator           Apocalypse Imperator
			(VehicleHash) 0x256E92BA,
			//  Compacts            ISSI4               issi4               Apocalypse Issi
			(VehicleHash) 0x669EB40A,
			//  Off - Road          MONSTER3            monster3            Apocalypse Sasquatch
			(VehicleHash) 0xBBA2A2F7,
			//  Military            SCARAB              scarab              Apocalypse Scarab
			(VehicleHash) 0x8526E2F5,
			//  Muscle              SLAMVAN4            slamvan4            Apocalypse Slamvan
			(VehicleHash) 0x20314B42,
			//  Sports              ZR380               zr380               Apocalypse ZR380
			(VehicleHash) 0xA29F78B0,
			//  Muscle              CLIQUE              clique              Clique
			(VehicleHash) 0x5EE005DA,
			//  Super               DEVESTE             deveste             Deveste Eight
			(VehicleHash) 0x4C3FFF49,
			//  Muscle              DEVIANT             deviant             Deviant
			(VehicleHash) 0x9B065C9E,
			//  Off - Road          BRUISER2            bruiser2            Future Shock Bruiser
			(VehicleHash) 0x8F49AE28,
			//  Off - Road          BRUTUS2             brutus2             Future Shock Brutus
			(VehicleHash) 0x287FA449,
			//  Commercial          cerberus2           cerberus2           Future Shock Cerberus
			(VehicleHash) 0x93F09558,
			//  Motorcycles         DEATHBIKE2          deathbike2          Future Shock Deathbike
			(VehicleHash) 0xAE0A3D4F,
			//  Muscle              DOMINATOR5          dominator5          Future Shock Dominator
			(VehicleHash) 0x8D45DF49,
			//  Muscle              IMPALER3            impaler3            Future Shock Impaler
			(VehicleHash) 0x619C1B82,
			//  Muscle              IMPERATOR2          imperator2          Future Shock Imperator
			(VehicleHash) 0x5BA0FF1E,
			//  Compacts            ISSI5               issi5               Future Shock Issi
			(VehicleHash) 0x32174AFC,
			//  Off - Road          MONSTER4            monster4            Future Shock Sasquatch
			(VehicleHash) 0x5BEB3CE0,
			//  Military            SCARAB2             scarab2             Future Shock Scarab
			(VehicleHash) 0x163F8520,
			//  Muscle              SLAMVAN5            slamvan5            Future Shock Slamvan
			(VehicleHash) 0xBE11EFC6,
			//  Sports              ZR3802              zr3802              Future Shock ZR380
			(VehicleHash) 0x83070B62,
			//  Muscle              IMPALER             impaler             Impaler
			(VehicleHash) 0xEC3E3404,
			//  Sports              ITALIGTO            italigto            Itali GTO
			(VehicleHash) 0x8644331A,
			//  Off - Road          BRUISER3            bruiser3            Nightmare Bruiser
			(VehicleHash) 0x798682A2,
			//  Off - Road          BRUTUS3             brutus3             Nightmare Brutus
			(VehicleHash) 0x71D3B6F0,
			//  Commercial          cerberus3           cerberus3           Nightmare Cerberus
			(VehicleHash) 0xAE12C99C,
			//  Motorcycles         DEATHBIKE3          deathbike3          Nightmare Deathbike
			(VehicleHash) 0xB2E046FB,
			//  Muscle              DOMINATOR6          dominator6          Nightmare Dominator
			(VehicleHash) 0x9804F4C7,
			//  Muscle              IMPALER4            impaler4            Nightmare Impaler
			(VehicleHash) 0xD2F77E37,
			//  Muscle              IMPERATOR3          imperator3          Nightmare Imperator
			(VehicleHash) 0x49E25BA1,
			//  Compacts            ISSI6               issi6               Nightmare Issi
			(VehicleHash) 0xD556917C,
			//  Off - Road          MONSTER5            monster5            Nightmare Sasquatch
			(VehicleHash) 0xDD71BFEB,
			//  Military            SCARAB3             scarab3             Nightmare Scarab
			(VehicleHash) 0x67D52852,
			//  Muscle              SLAMVAN6            slamvan6            Nightmare Slamvan
			(VehicleHash) 0xA7DCC35C,
			//  Sports              ZR3803              zr3803              Nightmare ZR380
			(VehicleHash) 0xEEF345EC,
			//  Off - Road          RCBANDITO           rcbandito           RC Bandito
			(VehicleHash) 0xE1C03AB0,
			//  Sports              SCHLAGEN            schlagen            Schlagen GT
			(VehicleHash) 0xBA5334AC,
			//  SUVs                TOROS               toros               Toros
			(VehicleHash) 0x56D42971,
			//  Muscle              TULIP               tulip               Tulip
			(VehicleHash) 0xFD128DFD,
			//  Muscle              VAMOS               vamos               Vamos
			(VehicleHash) 0x28EAB80F,
			//  Sports              DRAFTER             drafter             8F Drafter
			(VehicleHash) 0xAF966F3C,
			//  Off - Road            CARACARA2           caracara2           Caracara 4x4
			(VehicleHash) 0x127E90D5,
			//  Sports Classics     Dynasty             Dynasty             Dynasty
			(VehicleHash) 0x4EE74355,
			//  Super               EMERUS              emerus              Emerus
			(VehicleHash) 0x2B0C4DCD,
			//  Muscle              GAUNTLET3           gauntlet3           Gauntlet Classic
			(VehicleHash) 0x734C5E50,
			//  Muscle              GAUNTLET4           gauntlet4           Gauntlet Hellfire
			(VehicleHash) 0xEA6A047F,
			//  Off - Road            HELLION             hellion             Hellion
			(VehicleHash) 0x6E8DA4F7,
			//  Sports              ISSI7               issi7               Issi Sport
			(VehicleHash) 0xF38C4245,
			//  Sports              JUGULAR             jugular             Jugular
			(VehicleHash) 0xD86A0247,
			//  Super               krieger             krieger             Krieger
			(VehicleHash) 0xC7E55211,
			//  Sports              LOCUST              locust              Locust
			(VehicleHash) 0xCB642637,
			//  Sports Classics     NEBULA              nebula              Nebula Turbo
			(VehicleHash) 0x9F6ED5A2,
			//  Sports              NEO                 neo                 Neo
			(VehicleHash) 0x92F5024E,
			//  SUVs                Novak               Novak               Novak
			(VehicleHash) 0xE550775B,
			//  Sports              PARAGON             paragon             Paragon R
			(VehicleHash) 0x546D8EEE,
			//  Sports              PARAGON2            paragon2            Paragon R(Armored)
			(VehicleHash) 0x9472CD24,
			//  Muscle              PEYOTE2             peyote2             Peyote Gasser
			(VehicleHash) 0x36A167E0,
			//  Motorcycles         RROCKET             rrocket             Rampant Rocket
			(VehicleHash) 0xECA6B6A3,
			//  Super               S80                 s80                 S80RR
			(VehicleHash) 0x3E3D1F59,
			//  Super               THRAX               thrax               Thrax
			(VehicleHash) 0x6F039A67,
			//  Sports Classics     zion3               zion3               Zion Classic
			(VehicleHash) 0xD757D97D,
			//  Super               ZORRUSSO            zorrusso            Zorrusso
			(VehicleHash) 1118611807,
			// asbo, compact
			(VehicleHash) 2538945576,
			// everon, offroad
			(VehicleHash) 340154634,
			// formula (pr4), openwheel
			(VehicleHash) 2334210311,
			// formula2 (r88), openwheel
			(VehicleHash) 960812448,
			// furia, super
			(VehicleHash) 3162245632,
			// imorgon, sport
			(VehicleHash) 394110044,
			// jb7002, sportsclassic
			(VehicleHash) 409049982,
			// kanjo, compact
			(VehicleHash) 3460613305,
			// komoda, sport
			(VehicleHash) 3040635986,
			// minitank, military
			(VehicleHash) 408825843,
			// outlaw, offroad
			(VehicleHash) 83136452,
			// rebla, suv
			(VehicleHash) 2031587082,
			// retinue2, sportsclassic
			(VehicleHash) 301304410,
			// stryder, motorcycle
			(VehicleHash) 987469656,
			// sugoi, sport
			(VehicleHash) 872704284,
			// sultan2, sport
			(VehicleHash) 740289177,
			// vagrant, offroad
			(VehicleHash) 1456336509,
			// vstr, sport
			(VehicleHash) 1693751655,
			// yosemite2, muscle
			(VehicleHash) 1284356689 // zhaba, offroad
		};

        /* public static VehicleHash[] newCars =
   {
       (VehicleHash)1118611807, // asbo, compact
       (VehicleHash)2538945576, // everon, offroad
       (VehicleHash)340154634,  // formula (pr4), openwheel
       (VehicleHash)2334210311, // formula2 (r88), openwheel
       (VehicleHash)960812448,  // furia, super
       (VehicleHash)3162245632, // imorgon, sport
       (VehicleHash)394110044,  // jb7002, sportsclassic
       (VehicleHash)409049982,  // kanjo, compact
       (VehicleHash)3460613305, // komoda, sport
       (VehicleHash)3040635986, // minitank, military
       (VehicleHash)408825843,  // outlaw, offroad
       (VehicleHash)83136452,   // rebla, suv
       (VehicleHash)2031587082, // retinue2, sportsclassic
       (VehicleHash)301304410,  // stryder, motorcycle
       (VehicleHash)987469656,  // sugoi, sport
       (VehicleHash)872704284,  // sultan2, sport
       (VehicleHash)740289177,  // vagrant, offroad
       (VehicleHash)1456336509, // vstr, sport
       (VehicleHash)1693751655, // yosemite2, muscle
       (VehicleHash)1284356689  // zhaba, offroad
   };*/

    }
}