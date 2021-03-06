using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.NorthAmerica
{
    /// <summary>
    /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
    /// Cosmos i18n code: i18n_country_aluba <br />
    /// Cosmos region code: 400104
    /// </summary>
    public static class Aruba
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Aruba()
        {
            _country = new CountryInfo
            {
                Country = Country.Aruba,
                CountryCode = CountryCode.AW,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.Netherlands,
                M49Code = "533",
                Cep1CrCode = 4_00_104,
                Alpha2Code = "AW",
                Alpha3Code = "ABW",
                Name = "Aruba",
                ChineseName = "阿鲁巴（荷兰海外属地） ",
                ChineseShorterForm = "阿鲁巴 ",
                Continent = Continent.NorthAmerica,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 阿鲁巴（Aruba，北美洲，AW，ABW，533），荷兰海外属地 <br />
        /// Cosmos i18n code: i18n_country_aluba <br />
        /// Cosmos region code: 400104
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_aluba";

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