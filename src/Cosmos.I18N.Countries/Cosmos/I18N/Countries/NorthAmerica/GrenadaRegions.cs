using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// Grenada Regions
    /// </summary>
    public static class GrenadaRegions
    {
        #region Gets regions

        /// <summary>
        /// Saint Andrew
        /// </summary>
        public static EnumValues SaintAndrew => EnumValues.SaintAndrew;

        /// <summary>
        /// Saint David
        /// </summary>
        public static EnumValues SaintDavid => EnumValues.SaintDavid;

        /// <summary>
        /// Saint George
        /// </summary>
        public static EnumValues SaintGeorge => EnumValues.SaintGeorge;

        /// <summary>
        /// Saint John
        /// </summary>
        public static EnumValues SaintJohn => EnumValues.SaintJohn;

        /// <summary>
        /// Saint Mark
        /// </summary>
        public static EnumValues SaintMark => EnumValues.SaintMark;

        /// <summary>
        /// Saint Patrick
        /// </summary>
        public static EnumValues SaintPatrick => EnumValues.SaintPatrick;

        /// <summary>
        /// Carriacou and Petite Martinique
        /// </summary>
        public static EnumValues CarriacouAndPetiteMartinique => EnumValues.CarriacouAndPetiteMartinique;

        #endregion

        /// <summary>
        /// Enum values for Grenada regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Saint Andrew
            /// </summary>
            [AliasInShort("01")] [RegionCode(4_00_117_0001)]
            SaintAndrew,

            /// <summary>
            /// Saint David
            /// </summary>
            [AliasInShort("02")] [RegionCode(4_00_117_0002)]
            SaintDavid,

            /// <summary>
            /// Saint George
            /// </summary>
            [AliasInShort("03")] [RegionCode(4_00_117_0003)]
            SaintGeorge,

            /// <summary>
            /// Saint John
            /// </summary>
            [AliasInShort("04")] [RegionCode(4_00_117_0004)]
            SaintJohn,

            /// <summary>
            /// Saint Mark
            /// </summary>
            [AliasInShort("05")] [RegionCode(4_00_117_0005)]
            SaintMark,

            /// <summary>
            /// Saint Patrick
            /// </summary>
            [AliasInShort("06")] [RegionCode(4_00_117_0006)]
            SaintPatrick,

            /// <summary>
            /// Carriacou and Petite Martinique
            /// </summary>
            [AliasInShort("10")] [RegionCode(4_00_117_0010)]
            CarriacouAndPetiteMartinique,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="GrenadaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="GrenadaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"GD-{values.ToRegionCode()}";
        }

        /// <summary>
        /// Get CEP-1 / Cosmos Region Code.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static long ToNumericRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, RegionCodeAttribute>().CRCode;
        }

        /// <summary>
        /// Convert to <see cref="Country"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Country ToCountry(this EnumValues value)
        {
            return Country.Grenada;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.GD;
        }

        #endregion

        #region Getters

        private static IEnumerable<EnumMember<EnumValues>> InternalEnumMembersCache { get; }
            = Enums.GetMembers<EnumValues>().Where(member => !member.HasAttr<EnumValues, IgnoreRegionAttribute>());

        /// <summary>
        /// Get all region code
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<string> GetAllRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToFullRegionCode());

        /// <summary>
        /// Get all numeric region code(CEP-1 / Cosmos Region Code).
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<long> GetAllNumericRegionCodes()
            => InternalEnumMembersCache.Select(member => member.Value.ToNumericRegionCode());

        #endregion
    }
}