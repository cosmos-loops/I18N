using Cosmos.I18N.Core;

namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
    /// Cosmos i18n code: i18n_country_zhibuluotuo <br />
    /// Cosmos region code: 200114
    /// </summary>
    public static class Gibraltar
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Gibraltar()
        {
            _country = new CountryInfo
            {
                Country = Country.Gibraltar,
                CountryCode = CountryCode.GI,
                CountryType = CountryType.Region,
                BelongsToCountry = Country.UnitedKingdom,
                M49Code = "292",
                Cep1CrCode = 2_00_114,
                Alpha2Code = "GI",
                Alpha3Code = "GIB",
                Name = "Gibraltar",
                ChineseName = "直布罗陀",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = RegionEnumHelper.Unknown
            };
        }

        /// <summary>
        /// 直布罗陀（Gibraltar，欧洲，GI，GIB，292） <br />
        /// Cosmos i18n code: i18n_country_zhibuluotuo <br />
        /// Cosmos region code: 200114
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// I18N
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_zhibuluotuo";

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