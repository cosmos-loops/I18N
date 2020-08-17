using System.Collections.Generic;
using System.Linq;
using Cosmos.I18N.Core;
using EnumsNET;

namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// Kazakhstan Regions
    /// </summary>
    public static class KazakhstanRegions
    {
        #region Gets regions

        /// <summary>
        /// Akmola
        /// </summary>
        public static EnumValues Akmola => EnumValues.Akmola;

        /// <summary>
        /// Aktobe
        /// </summary>
        public static EnumValues Aktobe => EnumValues.Aktobe;

        /// <summary>
        /// Almaty
        /// </summary>
        public static EnumValues Almaty => EnumValues.Almaty;

        /// <summary>
        /// Almaty Region
        /// </summary>
        public static EnumValues AlmatyRegion => EnumValues.AlmatyRegion;

        /// <summary>
        /// Astana
        /// </summary>
        public static EnumValues Astana => EnumValues.Astana;

        /// <summary>
        /// Atyrau
        /// </summary>
        public static EnumValues Atyrau => EnumValues.Atyrau;

        /// <summary>
        /// Karagandy
        /// </summary>
        public static EnumValues Karagandy => EnumValues.Karagandy;

        /// <summary>
        /// Kostanay
        /// </summary>
        public static EnumValues Kostanay => EnumValues.Kostanay;

        /// <summary>
        /// Kyzylorda
        /// </summary>
        public static EnumValues Kyzylorda => EnumValues.Kyzylorda;

        /// <summary>
        /// Mangystau
        /// </summary>
        public static EnumValues Mangystau => EnumValues.Mangystau;

        /// <summary>
        /// Pavlodar
        /// </summary>
        public static EnumValues Pavlodar => EnumValues.Pavlodar;

        /// <summary>
        /// North Kazakhstan
        /// </summary>
        public static EnumValues NorthKazakhstan => EnumValues.NorthKazakhstan;

        /// <summary>
        /// East Kazakhstan
        /// </summary>
        public static EnumValues EastKazakhstan => EnumValues.EastKazakhstan;

        /// <summary>
        /// South Kazakhstan
        /// </summary>
        public static EnumValues SouthKazakhstan => EnumValues.SouthKazakhstan;

        /// <summary>
        /// West Kazakhstan
        /// </summary>
        public static EnumValues WestKazakhstan => EnumValues.WestKazakhstan;

        /// <summary>
        /// Jambyl
        /// </summary>
        public static EnumValues Jambyl => EnumValues.Jambyl;

        #endregion

        /// <summary>
        /// Enum values for Kazakhstan regions.
        /// </summary>
        public enum EnumValues
        {
            /// <summary>
            /// Akmola
            /// </summary>
            [AliasInShort("AKM")][RegionCode(1_00_119_0001)] Akmola,

            /// <summary>
            /// Aktobe
            /// </summary>
            [AliasInShort("AKT")][RegionCode(1_00_119_0002)] Aktobe,

            /// <summary>
            /// Almaty
            /// </summary>
            [AliasInShort("ALA")][RegionCode(1_00_119_0003)] Almaty,

            /// <summary>
            /// Almaty Region
            /// </summary>
            [AliasInShort("ALM")][RegionCode(1_00_119_0004)] AlmatyRegion,

            /// <summary>
            /// Astana
            /// </summary>
            [AliasInShort("AST")][RegionCode(1_00_119_0005)] Astana,

            /// <summary>
            /// Atyrau
            /// </summary>
            [AliasInShort("ATY")][RegionCode(1_00_119_0006)] Atyrau,

            /// <summary>
            /// Karagandy
            /// </summary>
            [AliasInShort("KAR")][RegionCode(1_00_119_0007)] Karagandy,

            /// <summary>
            /// Kostanay
            /// </summary>
            [AliasInShort("KUS")][RegionCode(1_00_119_0008)] Kostanay,

            /// <summary>
            /// Kyzylorda
            /// </summary>
            [AliasInShort("KZY")][RegionCode(1_00_119_0009)] Kyzylorda,

            /// <summary>
            /// Mangystau
            /// </summary>
            [AliasInShort("MAN")][RegionCode(1_00_119_0010)] Mangystau,

            /// <summary>
            /// Pavlodar
            /// </summary>
            [AliasInShort("PAV")][RegionCode(1_00_119_0011)] Pavlodar,

            /// <summary>
            /// North Kazakhstan
            /// </summary>
            [AliasInShort("SEV")][RegionCode(1_00_119_0012)] NorthKazakhstan,

            /// <summary>
            /// East Kazakhstan
            /// </summary>
            [AliasInShort("VOS")][RegionCode(1_00_119_0013)] EastKazakhstan,

            /// <summary>
            /// South Kazakhstan
            /// </summary>
            [AliasInShort("YUS")][RegionCode(1_00_119_0014)] SouthKazakhstan,

            /// <summary>
            /// West Kazakhstan
            /// </summary>
            [AliasInShort("ZAP")][RegionCode(1_00_119_0015)] WestKazakhstan,

            /// <summary>
            /// Jambyl
            /// </summary>
            [AliasInShort("ZHA")][RegionCode(1_00_119_0016)] Jambyl,

            /// <summary>
            /// Unknown
            /// </summary>
            [IgnoreRegion] [AliasInShort("??")] Unknown,
        }

        #region Extension methods

        /// <summary>
        /// Convert <see cref="KazakhstanRegions.EnumValues"/> to region code likes 'DE', 'WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToRegionCode(this EnumValues values)
        {
            return values.GetAttr<EnumValues, AliasInShortAttribute>().Alias;
        }

        /// <summary>
        /// Convert <see cref="KazakhstanRegions.EnumValues"/> to full region code likes 'BE-DE', 'BE-WAL'.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static string ToFullRegionCode(this EnumValues values)
        {
            return $"KZ-{values.ToRegionCode()}";
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
            return Country.Kazakhstan;
        }

        /// <summary>
        /// Convert to <see cref="CountryCode"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static CountryCode ToCountryCode(this EnumValues value)
        {
            return CountryCode.KZ;
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