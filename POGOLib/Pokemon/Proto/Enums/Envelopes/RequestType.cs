// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Enums/Envelopes/RequestType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOLib.Pokemon.Proto.Enums.Envelopes {

  /// <summary>Holder for reflection information generated from Enums/Envelopes/RequestType.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class RequestTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for Enums/Envelopes/RequestType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RequestTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFFbnVtcy9FbnZlbG9wZXMvUmVxdWVzdFR5cGUucHJvdG8SJVBPR09MaWIu",
            "UG9rZW1vbi5Qcm90by5FbnVtcy5FbnZlbG9wZXMqwQwKC1JlcXVlc3RUeXBl",
            "EhAKDE1FVEhPRF9VTlNFVBAAEhEKDVBMQVlFUl9VUERBVEUQARIOCgpHRVRf",
            "UExBWUVSEAISEQoNR0VUX0lOVkVOVE9SWRAEEhUKEURPV05MT0FEX1NFVFRJ",
            "TkdTEAUSGwoXRE9XTkxPQURfSVRFTV9URU1QTEFURVMQBhIiCh5ET1dOTE9B",
            "RF9SRU1PVEVfQ09ORklHX1ZFUlNJT04QBxIPCgtGT1JUX1NFQVJDSBBlEg0K",
            "CUVOQ09VTlRFUhBmEhEKDUNBVENIX1BPS0VNT04QZxIQCgxGT1JUX0RFVEFJ",
            "TFMQaBIMCghJVEVNX1VTRRBpEhMKD0dFVF9NQVBfT0JKRUNUUxBqEhcKE0ZP",
            "UlRfREVQTE9ZX1BPS0VNT04QbhIXChNGT1JUX1JFQ0FMTF9QT0tFTU9OEG8S",
            "EwoPUkVMRUFTRV9QT0tFTU9OEHASEwoPVVNFX0lURU1fUE9USU9OEHESFAoQ",
            "VVNFX0lURU1fQ0FQVFVSRRByEhEKDVVTRV9JVEVNX0ZMRUUQcxITCg9VU0Vf",
            "SVRFTV9SRVZJVkUQdBIQCgxUUkFERV9TRUFSQ0gQdRIPCgtUUkFERV9PRkZF",
            "UhB2EhIKDlRSQURFX1JFU1BPTlNFEHcSEAoMVFJBREVfUkVTVUxUEHgSFgoS",
            "R0VUX1BMQVlFUl9QUk9GSUxFEHkSEQoNR0VUX0lURU1fUEFDSxB6EhEKDUJV",
            "WV9JVEVNX1BBQ0sQexIQCgxCVVlfR0VNX1BBQ0sQfBISCg5FVk9MVkVfUE9L",
            "RU1PThB9EhQKEEdFVF9IQVRDSEVEX0VHR1MQfhIfChtFTkNPVU5URVJfVFVU",
            "T1JJQUxfQ09NUExFVEUQfxIVChBMRVZFTF9VUF9SRVdBUkRTEIABEhkKFENI",
            "RUNLX0FXQVJERURfQkFER0VTEIEBEhEKDFVTRV9JVEVNX0dZTRCFARIUCg9H",
            "RVRfR1lNX0RFVEFJTFMQhgESFQoQU1RBUlRfR1lNX0JBVFRMRRCHARIPCgpB",
            "VFRBQ0tfR1lNEIgBEhsKFlJFQ1lDTEVfSU5WRU5UT1JZX0lURU0QiQESGAoT",
            "Q09MTEVDVF9EQUlMWV9CT05VUxCKARIWChFVU0VfSVRFTV9YUF9CT09TVBCL",
            "ARIbChZVU0VfSVRFTV9FR0dfSU5DVUJBVE9SEIwBEhAKC1VTRV9JTkNFTlNF",
            "EI0BEhgKE0dFVF9JTkNFTlNFX1BPS0VNT04QjgESFgoRSU5DRU5TRV9FTkNP",
            "VU5URVIQjwESFgoRQUREX0ZPUlRfTU9ESUZJRVIQkAESEwoORElTS19FTkNP",
            "VU5URVIQkQESIQocQ09MTEVDVF9EQUlMWV9ERUZFTkRFUl9CT05VUxCSARIU",
            "Cg9VUEdSQURFX1BPS0VNT04QkwESGQoUU0VUX0ZBVk9SSVRFX1BPS0VNT04Q",
            "lAESFQoQTklDS05BTUVfUE9LRU1PThCVARIQCgtFUVVJUF9CQURHRRCWARIZ",
            "ChRTRVRfQ09OVEFDVF9TRVRUSU5HUxCXARIVChBHRVRfQVNTRVRfRElHRVNU",
            "EKwCEhYKEUdFVF9ET1dOTE9BRF9VUkxTEK0CEhwKF0dFVF9TVUdHRVNURURf",
            "Q09ERU5BTUVTEJEDEh0KGENIRUNLX0NPREVOQU1FX0FWQUlMQUJMRRCSAxIT",
            "Cg5DTEFJTV9DT0RFTkFNRRCTAxIPCgpTRVRfQVZBVEFSEJQDEhQKD1NFVF9Q",
            "TEFZRVJfVEVBTRCVAxIbChZNQVJLX1RVVE9SSUFMX0NPTVBMRVRFEJYDEhYK",
            "EUxPQURfU1BBV05fUE9JTlRTEPQDEgkKBEVDSE8QmgUSGwoWREVCVUdfVVBE",
            "QVRFX0lOVkVOVE9SWRC8BRIYChNERUJVR19ERUxFVEVfUExBWUVSEL0FEhcK",
            "ElNGSURBX1JFR0lTVFJBVElPThCgBhIVChBTRklEQV9BQ1RJT05fTE9HEKEG",
            "EhgKE1NGSURBX0NFUlRJRklDQVRJT04QogYSEQoMU0ZJREFfVVBEQVRFEKMG",
            "EhEKDFNGSURBX0FDVElPThCkBhIRCgxTRklEQV9ET1dTRVIQpQYSEgoNU0ZJ",
            "REFfQ0FQVFVSRRCmBmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOLib.Pokemon.Proto.Enums.Envelopes.RequestType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum RequestType {
    [pbr::OriginalName("METHOD_UNSET")] MethodUnset = 0,
    [pbr::OriginalName("PLAYER_UPDATE")] PlayerUpdate = 1,
    [pbr::OriginalName("GET_PLAYER")] GetPlayer = 2,
    [pbr::OriginalName("GET_INVENTORY")] GetInventory = 4,
    [pbr::OriginalName("DOWNLOAD_SETTINGS")] DownloadSettings = 5,
    [pbr::OriginalName("DOWNLOAD_ITEM_TEMPLATES")] DownloadItemTemplates = 6,
    [pbr::OriginalName("DOWNLOAD_REMOTE_CONFIG_VERSION")] DownloadRemoteConfigVersion = 7,
    [pbr::OriginalName("FORT_SEARCH")] FortSearch = 101,
    [pbr::OriginalName("ENCOUNTER")] Encounter = 102,
    [pbr::OriginalName("CATCH_POKEMON")] CatchPokemon = 103,
    [pbr::OriginalName("FORT_DETAILS")] FortDetails = 104,
    [pbr::OriginalName("ITEM_USE")] ItemUse = 105,
    [pbr::OriginalName("GET_MAP_OBJECTS")] GetMapObjects = 106,
    [pbr::OriginalName("FORT_DEPLOY_POKEMON")] FortDeployPokemon = 110,
    [pbr::OriginalName("FORT_RECALL_POKEMON")] FortRecallPokemon = 111,
    [pbr::OriginalName("RELEASE_POKEMON")] ReleasePokemon = 112,
    [pbr::OriginalName("USE_ITEM_POTION")] UseItemPotion = 113,
    [pbr::OriginalName("USE_ITEM_CAPTURE")] UseItemCapture = 114,
    [pbr::OriginalName("USE_ITEM_FLEE")] UseItemFlee = 115,
    [pbr::OriginalName("USE_ITEM_REVIVE")] UseItemRevive = 116,
    [pbr::OriginalName("TRADE_SEARCH")] TradeSearch = 117,
    [pbr::OriginalName("TRADE_OFFER")] TradeOffer = 118,
    [pbr::OriginalName("TRADE_RESPONSE")] TradeResponse = 119,
    [pbr::OriginalName("TRADE_RESULT")] TradeResult = 120,
    [pbr::OriginalName("GET_PLAYER_PROFILE")] GetPlayerProfile = 121,
    [pbr::OriginalName("GET_ITEM_PACK")] GetItemPack = 122,
    [pbr::OriginalName("BUY_ITEM_PACK")] BuyItemPack = 123,
    [pbr::OriginalName("BUY_GEM_PACK")] BuyGemPack = 124,
    [pbr::OriginalName("EVOLVE_POKEMON")] EvolvePokemon = 125,
    [pbr::OriginalName("GET_HATCHED_EGGS")] GetHatchedEggs = 126,
    [pbr::OriginalName("ENCOUNTER_TUTORIAL_COMPLETE")] EncounterTutorialComplete = 127,
    [pbr::OriginalName("LEVEL_UP_REWARDS")] LevelUpRewards = 128,
    [pbr::OriginalName("CHECK_AWARDED_BADGES")] CheckAwardedBadges = 129,
    [pbr::OriginalName("USE_ITEM_GYM")] UseItemGym = 133,
    [pbr::OriginalName("GET_GYM_DETAILS")] GetGymDetails = 134,
    [pbr::OriginalName("START_GYM_BATTLE")] StartGymBattle = 135,
    [pbr::OriginalName("ATTACK_GYM")] AttackGym = 136,
    [pbr::OriginalName("RECYCLE_INVENTORY_ITEM")] RecycleInventoryItem = 137,
    [pbr::OriginalName("COLLECT_DAILY_BONUS")] CollectDailyBonus = 138,
    [pbr::OriginalName("USE_ITEM_XP_BOOST")] UseItemXpBoost = 139,
    [pbr::OriginalName("USE_ITEM_EGG_INCUBATOR")] UseItemEggIncubator = 140,
    [pbr::OriginalName("USE_INCENSE")] UseIncense = 141,
    [pbr::OriginalName("GET_INCENSE_POKEMON")] GetIncensePokemon = 142,
    [pbr::OriginalName("INCENSE_ENCOUNTER")] IncenseEncounter = 143,
    [pbr::OriginalName("ADD_FORT_MODIFIER")] AddFortModifier = 144,
    [pbr::OriginalName("DISK_ENCOUNTER")] DiskEncounter = 145,
    [pbr::OriginalName("COLLECT_DAILY_DEFENDER_BONUS")] CollectDailyDefenderBonus = 146,
    [pbr::OriginalName("UPGRADE_POKEMON")] UpgradePokemon = 147,
    [pbr::OriginalName("SET_FAVORITE_POKEMON")] SetFavoritePokemon = 148,
    [pbr::OriginalName("NICKNAME_POKEMON")] NicknamePokemon = 149,
    [pbr::OriginalName("EQUIP_BADGE")] EquipBadge = 150,
    [pbr::OriginalName("SET_CONTACT_SETTINGS")] SetContactSettings = 151,
    [pbr::OriginalName("GET_ASSET_DIGEST")] GetAssetDigest = 300,
    [pbr::OriginalName("GET_DOWNLOAD_URLS")] GetDownloadUrls = 301,
    [pbr::OriginalName("GET_SUGGESTED_CODENAMES")] GetSuggestedCodenames = 401,
    [pbr::OriginalName("CHECK_CODENAME_AVAILABLE")] CheckCodenameAvailable = 402,
    [pbr::OriginalName("CLAIM_CODENAME")] ClaimCodename = 403,
    [pbr::OriginalName("SET_AVATAR")] SetAvatar = 404,
    [pbr::OriginalName("SET_PLAYER_TEAM")] SetPlayerTeam = 405,
    [pbr::OriginalName("MARK_TUTORIAL_COMPLETE")] MarkTutorialComplete = 406,
    [pbr::OriginalName("LOAD_SPAWN_POINTS")] LoadSpawnPoints = 500,
    [pbr::OriginalName("ECHO")] Echo = 666,
    [pbr::OriginalName("DEBUG_UPDATE_INVENTORY")] DebugUpdateInventory = 700,
    [pbr::OriginalName("DEBUG_DELETE_PLAYER")] DebugDeletePlayer = 701,
    [pbr::OriginalName("SFIDA_REGISTRATION")] SfidaRegistration = 800,
    [pbr::OriginalName("SFIDA_ACTION_LOG")] SfidaActionLog = 801,
    [pbr::OriginalName("SFIDA_CERTIFICATION")] SfidaCertification = 802,
    [pbr::OriginalName("SFIDA_UPDATE")] SfidaUpdate = 803,
    [pbr::OriginalName("SFIDA_ACTION")] SfidaAction = 804,
    [pbr::OriginalName("SFIDA_DOWSER")] SfidaDowser = 805,
    [pbr::OriginalName("SFIDA_CAPTURE")] SfidaCapture = 806,
  }

  #endregion

}

#endregion Designer generated code
