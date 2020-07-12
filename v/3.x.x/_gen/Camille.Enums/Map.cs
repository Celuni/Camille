
// This file is automatically generated.
// Do not directly edit.
// Generated on 2020-07-12T20:20:07.719Z

using System.ComponentModel.DataAnnotations;

namespace Camille.Enums
{
    /// <summary>
    /// Maps enum based on maps.json.
    /// </summary>
#if USE_SYSTEXTJSON
    [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
#endif
    public enum Map
    {
        [Display(Name = "Summoner's Rift", Description = "Original Summer variant")]
        SUMMONERS_RIFT_ORIGINAL_SUMMER_VARIANT = 1,
        [Display(Name = "Summoner's Rift", Description = "Original Autumn variant")]
        SUMMONERS_RIFT_ORIGINAL_AUTUMN_VARIANT = 2,
        [Display(Name = "The Proving Grounds", Description = "Tutorial Map")]
        THE_PROVING_GROUNDS_TUTORIAL_MAP = 3,
        [Display(Name = "Twisted Treeline", Description = "Original Version")]
        TWISTED_TREELINE_ORIGINAL_VERSION = 4,
        [Display(Name = "The Crystal Scar", Description = "Dominion map")]
        THE_CRYSTAL_SCAR_DOMINION_MAP = 8,
        [Display(Name = "Twisted Treeline", Description = "Last TT map")]
        TWISTED_TREELINE_LAST_TT_MAP = 10,
        [Display(Name = "Summoner's Rift", Description = "Current Version")]
        SUMMONERS_RIFT_CURRENT_VERSION = 11,
        [Display(Name = "Howling Abyss", Description = "ARAM map")]
        HOWLING_ABYSS_ARAM_MAP = 12,
        [Display(Name = "Butcher's Bridge", Description = "Alternate ARAM map")]
        BUTCHERS_BRIDGE_ALTERNATE_ARAM_MAP = 14,
        [Display(Name = "Cosmic Ruins", Description = "Dark Star: Singularity map")]
        COSMIC_RUINS_DARK_STAR_SINGULARITY_MAP = 16,
        [Display(Name = "Valoran City Park", Description = "Star Guardian Invasion map")]
        VALORAN_CITY_PARK_STAR_GUARDIAN_INVASION_MAP = 18,
        [Display(Name = "Substructure 43", Description = "PROJECT: Hunters map")]
        SUBSTRUCTURE_43_PROJECT_HUNTERS_MAP = 19,
        [Display(Name = "Crash Site", Description = "Odyssey: Extraction map")]
        CRASH_SITE_ODYSSEY_EXTRACTION_MAP = 20,
        [Display(Name = "Nexus Blitz", Description = "Nexus Blitz map")]
        NEXUS_BLITZ_NEXUS_BLITZ_MAP = 21,
    }
}
