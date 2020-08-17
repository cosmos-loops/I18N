using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Kyrgyzstan Regions
    /// </summary>
    public static class KyrgyzstanRegions
    {
        #region Gets regions

        /// <summary>
        /// Batken
        /// </summary>
        public static EnumValues Batken => EnumValues.Batken;

        /// <summary>
        /// Chuy
        /// </summary>
        public static EnumValues Chuy => EnumValues.Chuy;

        /// <summary>
        /// Bishkek
        /// </summary>
        public static EnumValues Bishkek => EnumValues.Bishkek;

        /// <summary>
        /// Osh
        /// </summary>
        public static EnumValues Osh => EnumValues.Osh;

        /// <summary>
        /// Jalal-Abad
        /// </summary>
        public static EnumValues JalalAbad => EnumValues.JalalAbad;

        /// <summary>
        /// Naryn
        /// </summary>
        public static EnumValues Naryn => EnumValues.Naryn;

        /// <summary>
        /// Osh Region
        /// </summary>
        public static EnumValues OshRegion => EnumValues.OshRegion;

        /// <summary>
        /// Talas
        /// </summary>
        public static EnumValues Talas => EnumValues.Talas;

        /// <summary>
        /// Issyk-Kul
        /// </summary>
        public static EnumValues IssykKul => EnumValues.IssykKul;

        #endregion

        /// <summary>
        /// Enum values for Kyrgyzstan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Batken
            /// </summary>
            [AliasInShort("B")][RegionCode(1_00_121_0001)] Batken,

            /// <summary>
            /// Chuy
            /// </summary>
            [AliasInShort("C")][RegionCode(1_00_121_0002)] Chuy,

            /// <summary>
            /// Bishkek
            /// </summary>
            [AliasInShort("GB")][RegionCode(1_00_121_0003)] Bishkek,

            /// <summary>
            /// Osh
            /// </summary>
            [AliasInShort("GO")][RegionCode(1_00_121_0004)] Osh,

            /// <summary>
            /// Jalal-Abad
            /// </summary>
            [AliasInShort("J")][RegionCode(1_00_121_0005)] JalalAbad,

            /// <summary>
            /// Naryn
            /// </summary>
            [AliasInShort("N")][RegionCode(1_00_121_0006)] Naryn,

            /// <summary>
            /// Osh Region
            /// </summary>
            [AliasInShort("O")][RegionCode(1_00_121_0007)] OshRegion,

            /// <summary>
            /// Talas
            /// </summary>
            [AliasInShort("T")][RegionCode(1_00_121_0008)] Talas,

            /// <summary>
            /// Issyk-Kul
            /// </summary>
            [AliasInShort("Y")][RegionCode(1_00_121_0009)] IssykKul,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KyrgyzstanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KyrgyzstanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KG-{values.ToRegionCode()}";
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
            return Country.Kyrgyzstan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KG;
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