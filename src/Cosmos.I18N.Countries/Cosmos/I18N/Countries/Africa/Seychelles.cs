namespace Cosmos.I18N.Countries.Africa {
    /// <summary>
    /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
    /// Cosmos i18n code: i18n_country_saisheer <br />
    /// Cosmos region code: 300145
    /// </summary>
    public static partial class Seychelles {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Seychelles() {
            _country = new CountryInfo {
                Country = Country.Seychelles,
                CountryCode = CountryCode.SC,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Seychelles,
                M49Code = "690",
                Cep1CrCode = 3_00_145,
                Alpha2Code = "SC",
                Alpha3Code = "SYC",
                Name = "Republic of Seychelles",
                ShorterForm = "Seychelles",
                ChineseName = "塞舌尔共和国",
                ChineseShorterForm = "塞舌尔",
                Continent = Continent.Africa,
                CommonwealthOfNations = true,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 塞舌尔（Republic of Seychelles，非洲，SC，SYC，690），塞舌尔共和国 <br />
        /// Cosmos i18n code: i18n_country_saisheer <br />
        /// Cosmos region code: 300145
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_saisheer";

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