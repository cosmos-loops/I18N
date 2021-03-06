namespace Cosmos.I18N.Countries.Africa
{
    /// <summary>
    /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
    /// Cosmos i18n code: i18n_country_tunisi <br />
    /// Cosmos region code: 300120
    /// </summary>
    public static partial class Tunisia
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Tunisia()
        {
            _country = new CountryInfo
            {
                Country = Country.Tunisia,
                CountryCode = CountryCode.TN,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Tunisia,
                M49Code = "788",
                Cep1CrCode = 3_00_120,
                Alpha2Code = "TN",
                Alpha3Code = "TUN",
                Name = "The Republic of Tunisia",
                ShorterForm = "Tunisia",
                ChineseName = "突尼斯共和国",
                ChineseShorterForm = "突尼斯",
                Continent = Continent.Africa,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 突尼斯（The Republic of Tunisia，非洲，TN，TUN，788），突尼斯共和国 <br />
        /// Cosmos i18n code: i18n_country_tunisi <br />
        /// Cosmos region code: 300120
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_tunisi";

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