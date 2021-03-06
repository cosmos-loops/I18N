using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
    /// Cosmos i18n code: i18n_country_buweidao <br />
    /// Cosmos region code: 200107
    /// </summary>
    public static class BouvetIsland
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BouvetIsland()
        {
            _country = new CountryInfo
            {
                Country = Country.BouvetIsland,
                CountryCode = CountryCode.BV,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Norway,
                M49Code = "074",
                Cep1CrCode = 2_00_107,
                Alpha2Code = "BV",
                Alpha3Code = "BVT",
                Name = "Bouvet Island",
                ChineseName = "布韦岛",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 布韦岛（Bouvet Island，欧洲，BV，BVT，074） <br />
        /// Cosmos i18n code: i18n_country_buweidao <br />
        /// Cosmos region code: 200107
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_buweidao";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.Cep1CrCode;

        /// <summary>
        /// Get Cosmos Region Identity Code (CEP-1/IICode)
        /// </summary>
        public static string CosmosIdentityCode => _country.I18NIdentityCode;

        /// <summary>
        /// Get M49 code / ISO 3166-1 numeric
        /// </summary>
        public static string M49Code => _country.M49Code;

        /// <summary>
        /// Get Alpha2 code / ISO 3166-1 alpha-2
        /// </summary>
        public static string Alpha2Code => _country.Alpha2Code;

        /// <summary>
        /// Get Alpha3 code / ISO 3166-1 alpha-3
        /// </summary>
        public static string Alpha3Code => _country.Alpha3Code;
    }
}