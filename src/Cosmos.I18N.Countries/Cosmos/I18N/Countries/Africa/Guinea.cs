namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
    /// Cosmos i18n code: i18n_country_jineiya <br />
    /// Cosmos region code: 300129
    /// </summary>
    public static  partial class Guinea {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Guinea() {
            _country = new CountryInfo {
                Country = Country.Guinea,
                CountryCode = CountryCode.GN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Guinea,
                M49Code = "324",
                Cep1CrCode = 3_00_129,
                Alpha2Code = "GN",
                Alpha3Code = "GIN",
                Name = "The Republic of Guinea",
                ShorterForm = "Guinea",
                ChineseName = "几内亚共和国",
                ChineseShorterForm = "几内亚",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 几内亚（The Republic of Guinea，非洲，GN，GIN，324），几内亚共和国 <br />
        /// Cosmos i18n code: i18n_country_jineiya <br />
        /// Cosmos region code: 300129
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_jineiya";

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