using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Nepal Regions
    /// </summary>
    public static class NepalRegions
    {
        #region Gets regions

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Madhya Pashchimanchal
        /// </summary>
        public static EnumValues MadhyaPashchimanchal => EnumValues.MadhyaPashchimanchal;

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        /// <summary>
        /// Purwanchal
        /// </summary>
        public static EnumValues Purwanchal => EnumValues.Purwanchal;

        /// <summary>
        /// Sudur Pashchimanchal
        /// </summary>
        public static EnumValues SudurPashchimanchal => EnumValues.SudurPashchimanchal;

        #endregion

        /// <summary>
        /// Enum values for Nepal regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("1")][RegionCode(1_00_128_0001)] Central,

            /// <summary>
            /// Madhya Pashchimanchal
            /// </summary>
            [AliasInShort("2")][RegionCode(1_00_128_0002)] MadhyaPashchimanchal,

            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("3")][RegionCode(1_00_128_0003)] Western,

            /// <summary>
            /// Purwanchal
            /// </summary>
            [AliasInShort("4")][RegionCode(1_00_128_0004)] Purwanchal,

            /// <summary>
            /// Sudur Pashchimanchal
            /// </summary>
            [AliasInShort("5")][RegionCode(1_00_128_0005)] SudurPashchimanchal,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="NepalRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="NepalRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"NP-{values.ToRegionCode()}";
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
            return Country.Nepal;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.NP;
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