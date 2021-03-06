namespace Cosmos.I18N.Countries.Asia
{
    /// <summary>
    /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
    /// Cosmos i18n code: i18n_country_wuzibiekesitan <br />
    /// Cosmos region code: 100141
    /// </summary>
    public static partial class Uzbekistan
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Uzbekistan()
        {
            _country = new CountryInfo
            {
                Country = Country.Uzbekistan,
                CountryCode = CountryCode.UZ,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Uzbekistan,
                M49Code = "860",
                Cep1CrCode = 1_00_141,
                Alpha2Code = "UZ",
                Alpha3Code = "UZB",
                Name = "The Republic Of Uzbekistan",
                ShorterForm = "Uzbekistan",
                ChineseName = "乌兹别克斯坦共和国",
                ChineseShorterForm = "乌兹别克斯坦",
                ChineseAlias = "乌兹别克",
                Continent = Continent.Asia,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 乌兹别克斯坦（The Republic Of Uzbekistan，亚洲，UZ，UZB，860），乌兹别克斯坦共和国 <br />
        /// Cosmos i18n code: i18n_country_wuzibiekesitan <br />
        /// Cosmos region code: 100141
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_wuzibiekesitan";

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