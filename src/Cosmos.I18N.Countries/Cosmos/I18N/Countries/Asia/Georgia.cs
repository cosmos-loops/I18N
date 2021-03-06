namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
    /// Cosmos i18n code: i18n_country_gelujiya <br />
    /// Cosmos region code: 100115
    /// </summary>
    public static partial class Georgia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Georgia()
        {
            _country = new CountryInfo
            {
                Country = Country.Georgia,
                CountryCode = CountryCode.GE,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Georgia,
                M49Code = "268",
                Cep1CrCode = 1_00_115,
                Alpha2Code = "GE",
                Alpha3Code = "GEO",
                Name = "Georgia",
                ChineseName = "格鲁吉亚",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 格鲁吉亚（Georgia，亚洲，GE，GEO，268） <br />
        /// Cosmos i18n code: i18n_country_gelujiya <br />
        /// Cosmos region code: 100115
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_gelujiya";

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