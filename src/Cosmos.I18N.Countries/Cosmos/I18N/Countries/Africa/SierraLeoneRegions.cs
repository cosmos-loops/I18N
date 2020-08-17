using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// Sierra Leone Regions
    /// </summary>
    public static class SierraLeoneRegions
    {
        #region Gets region

        /// <summary>
        /// Eastern
        /// </summary>
        public static EnumValues Eastern => EnumValues.Eastern;

        /// <summary>
        /// Northern
        /// </summary>
        public static EnumValues Northern => EnumValues.Northern;

        /// <summary>
        /// Southern
        /// </summary>
        public static EnumValues Southern => EnumValues.Southern;

        /// <summary>
        /// Western Area
        /// </summary>
        public static EnumValues WesternArea => EnumValues.WesternArea;

        #endregion

        /// <summary>
        /// Enum values for Sierra Leone regions
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Eastern
            /// </summary>
            [AliasInShort("E")][RegionCode(3_00_153_0001)] Eastern,

            /// <summary>
            /// Northern
            /// </summary>
            [AliasInShort("N")][RegionCode(3_00_153_0002)] Northern,

            /// <summary>
            /// Southern
            /// </summary>
            [AliasInShort("S")][RegionCode(3_00_153_0003)] Southern,

            /// <summary>
            /// Western Area
            /// </summary>
            [AliasInShort("W")][RegionCode(3_00_153_0004)] WesternArea,

            /// <summary>
            /// Unknown<br />未知
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="SierraLeoneRegions.EnumValues"/> to region code likes 'MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="SierraLeoneRegions.EnumValues"/> to full region code likes 'VU-MAP'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"SL-{values.ToRegionCode()}";
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
            return Country.SierraLeone;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.SL;
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