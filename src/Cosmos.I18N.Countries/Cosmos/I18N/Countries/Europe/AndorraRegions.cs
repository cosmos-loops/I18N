using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// Andorra Regions
    /// </summary>
    public static class AndorraRegions
    {
        #region Gets regions

        /// <summary>
        /// Andorra la Vella
        /// </summary>
        public static EnumValues AndorraLaVella => EnumValues.AndorraLaVella;

        /// <summary>
        /// Canillo
        /// </summary>
        public static EnumValues Canillo => EnumValues.Canillo;

        /// <summary>
        /// Massana
        /// </summary>
        public static EnumValues Massana => EnumValues.Massana;

        /// <summary>
        /// Sant Julia de Loria
        /// </summary>
        public static EnumValues SantJuliaDeLoria => EnumValues.SantJuliaDeLoria;

        /// <summary>
        /// Encamp
        /// </summary>
        public static EnumValues Encamp => EnumValues.Encamp;

        /// <summary>
        /// Les Escaldes-Engordany
        /// </summary>
        public static EnumValues LesEscaldesEngordany => EnumValues.LesEscaldesEngordany;

        /// <summary>
        /// Ordino
        /// </summary>
        public static EnumValues Ordino => EnumValues.Ordino;

        #endregion

        /// <summary>
        /// Enum values for Andorra regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Andorra la Vella
            /// </summary>
            [AliasInShort("07")] [RegionCode(2_00_103_0007)]
            AndorraLaVella,

            /// <summary>
            /// Canillo
            /// </summary>
            [AliasInShort("02")] [RegionCode(2_00_103_0002)]
            Canillo,

            /// <summary>
            /// Massana
            /// </summary>
            [AliasInShort("04")] [RegionCode(2_00_103_0004)]
            Massana,

            /// <summary>
            /// Sant Julia de Loria
            /// </summary>
            [AliasInShort("06")] [RegionCode(2_00_103_0006)]
            SantJuliaDeLoria,

            /// <summary>
            /// Encamp
            /// </summary>
            [AliasInShort("03")] [RegionCode(2_00_103_0003)]
            Encamp,

            /// <summary>
            /// Les Escaldes-Engordany
            /// </summary>
            [AliasInShort("01")] [RegionCode(2_00_103_0001)]
            LesEscaldesEngordany,

            /// <summary>
            /// Ordino
            /// </summary>
            [AliasInShort("05")] [RegionCode(2_00_103_0005)]
            Ordino,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="AndorraRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="AndorraRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"AD-{values.ToRegionCode()}";
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
            return Country.Andorra;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.AD;
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