using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// SriLanka Regions
    /// </summary>
    public static class SriLankaRegions
    {
        #region Gets regions

        /// <summary>
        /// Western
        /// </summary>
        public static EnumValues Western => EnumValues.Western;

        /// <summary>
        /// Central
        /// </summary>
        public static EnumValues Central => EnumValues.Central;

        /// <summary>
        /// Southern
        /// </summary>
        public static EnumValues Southern => EnumValues.Southern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// North Western
        /// </summary>
        public static EnumValues NorthWestern => EnumValues.NorthWestern;

        /// <summary>
        /// North Central
        /// </summary>
        public static EnumValues NorthCentral => EnumValues.NorthCentral;

        /// <summary>
        /// Uva
        /// </summary>
        public static EnumValues Uva => EnumValues.Uva;

        /// <summary>
        /// Sabaragamuwa
        /// </summary>
        public static EnumValues Sabaragamuwa => EnumValues.Sabaragamuwa;

        #endregion

        /// <summary>
        /// Enum values for SriLanka regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Western
            /// </summary>
            [AliasInShort("1")][RegionCode(1_00_135_0001)] Western,

            /// <summary>
            /// Central
            /// </summary>
            [AliasInShort("2")][RegionCode(1_00_135_0002)] Central,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("3")][RegionCode(1_00_135_0003)] Southern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("4")][RegionCode(1_00_135_0004)] Northern,

            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("5")][RegionCode(1_00_135_0005)] Eastern,

            /// <summary>
            /// North Western
            /// </summary>
            [AliasInShort("6")][RegionCode(1_00_135_0006)] NorthWestern,

            /// <summary>
            /// North Central
            /// </summary>
            [AliasInShort("7")][RegionCode(1_00_135_0007)] NorthCentral,

            /// <summary>
            /// Uva
            /// </summary>
            [AliasInShort("8")][RegionCode(1_00_135_0008)] Uva,

            /// <summary>
            /// Sabaragamuwa
            /// </summary>
            [AliasInShort("9")][RegionCode(1_00_135_0009)] Sabaragamuwa,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SriLankaRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SriLankaRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"LK-{values.ToRegionCode()}";
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
            return Country.SriLanka;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.LK;
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