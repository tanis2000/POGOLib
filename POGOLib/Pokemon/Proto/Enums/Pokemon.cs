// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/Pokemon.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOLib.Pokemon.Proto.Enums {

  /// <summary>Holder for reflection information generated from Enums/Pokemon.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PokemonReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/Pokemon.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokemonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChNFbnVtcy9Qb2tlbW9uLnByb3RvEhtQT0dPTGliLlBva2Vtb24uUHJvdG8u",
            "RW51bXMqkRAKB1Bva2Vtb24SDQoJTUlTU0lOR05PEAASDQoJQlVMQkFTQVVS",
            "EAESCwoHSVZZU0FVUhACEgwKCFZFTlVTQVVSEAMSDgoKQ0hBUk1FTkRFUhAE",
            "Eg4KCkNIQVJNRUxFT04QBRINCglDSEFSSVpBUkQQBhIMCghTUVVJUlRMRRAH",
            "Eg0KCVdBUlRPUlRMRRAIEg0KCUJMQVNUT0lTRRAJEgwKCENBVEVSUElFEAoS",
            "CwoHTUVUQVBPRBALEg4KCkJVVFRFUkZSRUUQDBIKCgZXRUVETEUQDRIKCgZL",
            "QUtVTkEQDhIMCghCRUVEUklMTBAPEgoKBlBJREdFWRAQEg0KCVBJREdFT1RU",
            "TxAREgsKB1BJREdFT1QQEhILCgdSQVRUQVRBEBMSDAoIUkFUSUNBVEUQFBIL",
            "CgdTUEVBUk9XEBUSCgoGRkVBUk9XEBYSCQoFRUtBTlMQFxIJCgVBUkJPSxAY",
            "EgsKB1BJS0FDSFUQGRIKCgZSQUlDSFUQGhINCglTQU5EU0hSRVcQGxIMCghT",
            "QU5ETEFTSBAcEhIKDk5JRE9SQU5fRkVNQUxFEB0SDAoITklET1JJTkEQHhIN",
            "CglOSURPUVVFRU4QHxIQCgxOSURPUkFOX01BTEUQIBIMCghOSURPUklOTxAh",
            "EgwKCE5JRE9LSU5HECISCwoHQ0xFRkFSWRAjEgwKCENMRUZBQkxFECQSCgoG",
            "VlVMUElYECUSDQoJTklORVRBTEVTECYSDgoKSklHR0xZUFVGRhAnEg4KCldJ",
            "R0dMWVRVRkYQKBIJCgVaVUJBVBApEgoKBkdPTEJBVBAqEgoKBk9ERElTSBAr",
            "EgkKBUdMT09NECwSDQoJVklMRVBMVU1FEC0SCQoFUEFSQVMQLhIMCghQQVJB",
            "U0VDVBAvEgsKB1ZFTk9OQVQQMBIMCghWRU5PTU9USBAxEgsKB0RJR0xFVFQQ",
            "MhILCgdEVUdUUklPEDMSCgoGTUVPV1RIEDQSCwoHUEVSU0lBThA1EgsKB1BT",
            "WURVQ0sQNhILCgdHT0xEVUNLEDcSCgoGTUFOS0VZEDgSDAoIUFJJTUVBUEUQ",
            "ORINCglHUk9XTElUSEUQOhIMCghBUkNBTklORRA7EgsKB1BPTElXQUcQPBIN",
            "CglQT0xJV0hJUkwQPRINCglQT0xJV1JBVEgQPhIICgRBQlJBED8SCwoHS0FE",
            "QUJSQRBAEg0KCUFMQUtIQVpBTRBBEgoKBk1BQ0hPUBBCEgsKB01BQ0hPS0UQ",
            "QxILCgdNQUNIQU1QEEQSDgoKQkVMTFNQUk9VVBBFEg4KCldFRVBJTkJFTEwQ",
            "RhIPCgtWSUNUUkVFQkVMTBBHEg0KCVRFTlRBQ09PTBBIEg4KClRFTlRBQ1JV",
            "RUwQSRILCgdHRU9EVUdFEEoSDAoIR1JBVkVMRVIQSxIJCgVHT0xFTRBMEgoK",
            "BlBPTllUQRBNEgwKCFJBUElEQVNIEE4SDAoIU0xPV1BPS0UQTxILCgdTTE9X",
            "QlJPEFASDQoJTUFHTkVNSVRFEFESDAoITUFHTkVUT04QUhINCglGQVJGRVRD",
            "SEQQUxIJCgVET0RVTxBUEgoKBkRPRFJJTxBVEggKBFNFRUwQVhILCgdERVdH",
            "T05HEFcSCgoGR1JJTUVSEFgSBwoDTVVLEFkSDAoIU0hFTExERVIQWhIMCghD",
            "TE9ZU1RFUhBbEgoKBkdBU1RMWRBcEgsKB0hBVU5URVIQXRIKCgZHRU5HQVIQ",
            "XhIICgRPTklYEF8SCwoHRFJPV1pFRRBgEgkKBUhZUE5PEGESCgoGS1JBQkJZ",
            "EGISCwoHS0lOR0xFUhBjEgsKB1ZPTFRPUkIQZBINCglFTEVDVFJPREUQZRIN",
            "CglFWEVHR0NVVEUQZhINCglFWEVHR1VUT1IQZxIKCgZDVUJPTkUQaBILCgdN",
            "QVJPV0FLEGkSDQoJSElUTU9OTEVFEGoSDgoKSElUTU9OQ0hBThBrEg0KCUxJ",
            "Q0tJVFVORxBsEgsKB0tPRkZJTkcQbRILCgdXRUVaSU5HEG4SCwoHUkhZSE9S",
            "ThBvEgoKBlJIWURPThBwEgsKB0NIQU5TRVkQcRILCgdUQU5HRUxBEHISDgoK",
            "S0FOR0FTS0hBThBzEgoKBkhPUlNFQRB0EgoKBlNFQURSQRB1EgsKB0dPTERF",
            "RU4QdhILCgdTRUFLSU5HEHcSCgoGU1RBUllVEHgSCwoHU1RBUk1JRRB5EgsK",
            "B01SX01JTUUQehILCgdTQ1lUSEVSEHsSCAoESllOWBB8Eg4KCkVMRUNUQUJV",
            "WloQfRIKCgZNQUdNQVIQfhIKCgZQSU5TSVIQfxILCgZUQVVST1MQgAESDQoI",
            "TUFHSUtBUlAQgQESDQoIR1lBUkFET1MQggESCwoGTEFQUkFTEIMBEgoKBURJ",
            "VFRPEIQBEgoKBUVFVkVFEIUBEg0KCFZBUE9SRU9OEIYBEgwKB0pPTFRFT04Q",
            "hwESDAoHRkxBUkVPThCIARIMCgdQT1JZR09OEIkBEgwKB09NQU5ZVEUQigES",
            "DAoHT01BU1RBUhCLARILCgZLQUJVVE8QjAESDQoIS0FCVVRPUFMQjQESDwoK",
            "QUVST0RBQ1RZTBCOARIMCgdTTk9STEFYEI8BEg0KCEFSVElDVU5PEJABEgsK",
            "BlpBUERPUxCRARIMCgdNT0xUUkVTEJIBEgwKB0RSQVRJTkkQkwESDgoJRFJB",
            "R09OQUlSEJQBEg4KCURSQUdPTklURRCVARILCgZNRVdUV08QlgESCAoDTUVX",
            "EJcBYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOLib.Pokemon.Proto.Enums.Pokemon), }, null));
    }
    #endregion

  }
  #region Enums
  public enum Pokemon {
    [pbr::OriginalName("MISSINGNO")] Missingno = 0,
    [pbr::OriginalName("BULBASAUR")] Bulbasaur = 1,
    [pbr::OriginalName("IVYSAUR")] Ivysaur = 2,
    [pbr::OriginalName("VENUSAUR")] Venusaur = 3,
    [pbr::OriginalName("CHARMENDER")] Charmender = 4,
    [pbr::OriginalName("CHARMELEON")] Charmeleon = 5,
    [pbr::OriginalName("CHARIZARD")] Charizard = 6,
    [pbr::OriginalName("SQUIRTLE")] Squirtle = 7,
    [pbr::OriginalName("WARTORTLE")] Wartortle = 8,
    [pbr::OriginalName("BLASTOISE")] Blastoise = 9,
    [pbr::OriginalName("CATERPIE")] Caterpie = 10,
    [pbr::OriginalName("METAPOD")] Metapod = 11,
    [pbr::OriginalName("BUTTERFREE")] Butterfree = 12,
    [pbr::OriginalName("WEEDLE")] Weedle = 13,
    [pbr::OriginalName("KAKUNA")] Kakuna = 14,
    [pbr::OriginalName("BEEDRILL")] Beedrill = 15,
    [pbr::OriginalName("PIDGEY")] Pidgey = 16,
    [pbr::OriginalName("PIDGEOTTO")] Pidgeotto = 17,
    [pbr::OriginalName("PIDGEOT")] Pidgeot = 18,
    [pbr::OriginalName("RATTATA")] Rattata = 19,
    [pbr::OriginalName("RATICATE")] Raticate = 20,
    [pbr::OriginalName("SPEAROW")] Spearow = 21,
    [pbr::OriginalName("FEAROW")] Fearow = 22,
    [pbr::OriginalName("EKANS")] Ekans = 23,
    [pbr::OriginalName("ARBOK")] Arbok = 24,
    [pbr::OriginalName("PIKACHU")] Pikachu = 25,
    [pbr::OriginalName("RAICHU")] Raichu = 26,
    [pbr::OriginalName("SANDSHREW")] Sandshrew = 27,
    [pbr::OriginalName("SANDLASH")] Sandlash = 28,
    [pbr::OriginalName("NIDORAN_FEMALE")] NidoranFemale = 29,
    [pbr::OriginalName("NIDORINA")] Nidorina = 30,
    [pbr::OriginalName("NIDOQUEEN")] Nidoqueen = 31,
    [pbr::OriginalName("NIDORAN_MALE")] NidoranMale = 32,
    [pbr::OriginalName("NIDORINO")] Nidorino = 33,
    [pbr::OriginalName("NIDOKING")] Nidoking = 34,
    [pbr::OriginalName("CLEFARY")] Clefary = 35,
    [pbr::OriginalName("CLEFABLE")] Clefable = 36,
    [pbr::OriginalName("VULPIX")] Vulpix = 37,
    [pbr::OriginalName("NINETALES")] Ninetales = 38,
    [pbr::OriginalName("JIGGLYPUFF")] Jigglypuff = 39,
    [pbr::OriginalName("WIGGLYTUFF")] Wigglytuff = 40,
    [pbr::OriginalName("ZUBAT")] Zubat = 41,
    [pbr::OriginalName("GOLBAT")] Golbat = 42,
    [pbr::OriginalName("ODDISH")] Oddish = 43,
    [pbr::OriginalName("GLOOM")] Gloom = 44,
    [pbr::OriginalName("VILEPLUME")] Vileplume = 45,
    [pbr::OriginalName("PARAS")] Paras = 46,
    [pbr::OriginalName("PARASECT")] Parasect = 47,
    [pbr::OriginalName("VENONAT")] Venonat = 48,
    [pbr::OriginalName("VENOMOTH")] Venomoth = 49,
    [pbr::OriginalName("DIGLETT")] Diglett = 50,
    [pbr::OriginalName("DUGTRIO")] Dugtrio = 51,
    [pbr::OriginalName("MEOWTH")] Meowth = 52,
    [pbr::OriginalName("PERSIAN")] Persian = 53,
    [pbr::OriginalName("PSYDUCK")] Psyduck = 54,
    [pbr::OriginalName("GOLDUCK")] Golduck = 55,
    [pbr::OriginalName("MANKEY")] Mankey = 56,
    [pbr::OriginalName("PRIMEAPE")] Primeape = 57,
    [pbr::OriginalName("GROWLITHE")] Growlithe = 58,
    [pbr::OriginalName("ARCANINE")] Arcanine = 59,
    [pbr::OriginalName("POLIWAG")] Poliwag = 60,
    [pbr::OriginalName("POLIWHIRL")] Poliwhirl = 61,
    [pbr::OriginalName("POLIWRATH")] Poliwrath = 62,
    [pbr::OriginalName("ABRA")] Abra = 63,
    [pbr::OriginalName("KADABRA")] Kadabra = 64,
    [pbr::OriginalName("ALAKHAZAM")] Alakhazam = 65,
    [pbr::OriginalName("MACHOP")] Machop = 66,
    [pbr::OriginalName("MACHOKE")] Machoke = 67,
    [pbr::OriginalName("MACHAMP")] Machamp = 68,
    [pbr::OriginalName("BELLSPROUT")] Bellsprout = 69,
    [pbr::OriginalName("WEEPINBELL")] Weepinbell = 70,
    [pbr::OriginalName("VICTREEBELL")] Victreebell = 71,
    [pbr::OriginalName("TENTACOOL")] Tentacool = 72,
    [pbr::OriginalName("TENTACRUEL")] Tentacruel = 73,
    [pbr::OriginalName("GEODUGE")] Geoduge = 74,
    [pbr::OriginalName("GRAVELER")] Graveler = 75,
    [pbr::OriginalName("GOLEM")] Golem = 76,
    [pbr::OriginalName("PONYTA")] Ponyta = 77,
    [pbr::OriginalName("RAPIDASH")] Rapidash = 78,
    [pbr::OriginalName("SLOWPOKE")] Slowpoke = 79,
    [pbr::OriginalName("SLOWBRO")] Slowbro = 80,
    [pbr::OriginalName("MAGNEMITE")] Magnemite = 81,
    [pbr::OriginalName("MAGNETON")] Magneton = 82,
    [pbr::OriginalName("FARFETCHD")] Farfetchd = 83,
    [pbr::OriginalName("DODUO")] Doduo = 84,
    [pbr::OriginalName("DODRIO")] Dodrio = 85,
    [pbr::OriginalName("SEEL")] Seel = 86,
    [pbr::OriginalName("DEWGONG")] Dewgong = 87,
    [pbr::OriginalName("GRIMER")] Grimer = 88,
    [pbr::OriginalName("MUK")] Muk = 89,
    [pbr::OriginalName("SHELLDER")] Shellder = 90,
    [pbr::OriginalName("CLOYSTER")] Cloyster = 91,
    [pbr::OriginalName("GASTLY")] Gastly = 92,
    [pbr::OriginalName("HAUNTER")] Haunter = 93,
    [pbr::OriginalName("GENGAR")] Gengar = 94,
    [pbr::OriginalName("ONIX")] Onix = 95,
    [pbr::OriginalName("DROWZEE")] Drowzee = 96,
    [pbr::OriginalName("HYPNO")] Hypno = 97,
    [pbr::OriginalName("KRABBY")] Krabby = 98,
    [pbr::OriginalName("KINGLER")] Kingler = 99,
    [pbr::OriginalName("VOLTORB")] Voltorb = 100,
    [pbr::OriginalName("ELECTRODE")] Electrode = 101,
    [pbr::OriginalName("EXEGGCUTE")] Exeggcute = 102,
    [pbr::OriginalName("EXEGGUTOR")] Exeggutor = 103,
    [pbr::OriginalName("CUBONE")] Cubone = 104,
    [pbr::OriginalName("MAROWAK")] Marowak = 105,
    [pbr::OriginalName("HITMONLEE")] Hitmonlee = 106,
    [pbr::OriginalName("HITMONCHAN")] Hitmonchan = 107,
    [pbr::OriginalName("LICKITUNG")] Lickitung = 108,
    [pbr::OriginalName("KOFFING")] Koffing = 109,
    [pbr::OriginalName("WEEZING")] Weezing = 110,
    [pbr::OriginalName("RHYHORN")] Rhyhorn = 111,
    [pbr::OriginalName("RHYDON")] Rhydon = 112,
    [pbr::OriginalName("CHANSEY")] Chansey = 113,
    [pbr::OriginalName("TANGELA")] Tangela = 114,
    [pbr::OriginalName("KANGASKHAN")] Kangaskhan = 115,
    [pbr::OriginalName("HORSEA")] Horsea = 116,
    [pbr::OriginalName("SEADRA")] Seadra = 117,
    [pbr::OriginalName("GOLDEEN")] Goldeen = 118,
    [pbr::OriginalName("SEAKING")] Seaking = 119,
    [pbr::OriginalName("STARYU")] Staryu = 120,
    [pbr::OriginalName("STARMIE")] Starmie = 121,
    [pbr::OriginalName("MR_MIME")] MrMime = 122,
    [pbr::OriginalName("SCYTHER")] Scyther = 123,
    [pbr::OriginalName("JYNX")] Jynx = 124,
    [pbr::OriginalName("ELECTABUZZ")] Electabuzz = 125,
    [pbr::OriginalName("MAGMAR")] Magmar = 126,
    [pbr::OriginalName("PINSIR")] Pinsir = 127,
    [pbr::OriginalName("TAUROS")] Tauros = 128,
    [pbr::OriginalName("MAGIKARP")] Magikarp = 129,
    [pbr::OriginalName("GYARADOS")] Gyarados = 130,
    [pbr::OriginalName("LAPRAS")] Lapras = 131,
    [pbr::OriginalName("DITTO")] Ditto = 132,
    [pbr::OriginalName("EEVEE")] Eevee = 133,
    [pbr::OriginalName("VAPOREON")] Vaporeon = 134,
    [pbr::OriginalName("JOLTEON")] Jolteon = 135,
    [pbr::OriginalName("FLAREON")] Flareon = 136,
    [pbr::OriginalName("PORYGON")] Porygon = 137,
    [pbr::OriginalName("OMANYTE")] Omanyte = 138,
    [pbr::OriginalName("OMASTAR")] Omastar = 139,
    [pbr::OriginalName("KABUTO")] Kabuto = 140,
    [pbr::OriginalName("KABUTOPS")] Kabutops = 141,
    [pbr::OriginalName("AERODACTYL")] Aerodactyl = 142,
    [pbr::OriginalName("SNORLAX")] Snorlax = 143,
    [pbr::OriginalName("ARTICUNO")] Articuno = 144,
    [pbr::OriginalName("ZAPDOS")] Zapdos = 145,
    [pbr::OriginalName("MOLTRES")] Moltres = 146,
    [pbr::OriginalName("DRATINI")] Dratini = 147,
    [pbr::OriginalName("DRAGONAIR")] Dragonair = 148,
    [pbr::OriginalName("DRAGONITE")] Dragonite = 149,
    [pbr::OriginalName("MEWTWO")] Mewtwo = 150,
    [pbr::OriginalName("MEW")] Mew = 151,
  }

  #endregion

}

#endregion Designer generated code
