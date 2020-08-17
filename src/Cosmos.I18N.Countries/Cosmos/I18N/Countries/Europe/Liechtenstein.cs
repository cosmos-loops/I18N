namespace Cosmos.I18N.Countries.Europe {
    /// <summary>
    /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
    /// Cosmos i18n code: i18n_country_liezhidunshideng <br />
    /// Cosmos region code: 200122
    /// </summary>
    public static class Liechtenstein {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static Liechtenstein() {
            _country = new CountryInfo {
                Country = Country.Liechtenstein,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.Liechtenstein,
                M49Code = "438",
                CRCode = 2_00_122,
                Alpha2Code = "LI",
                Alpha3Code = "LIE",
                Name = "Principality of Liechtenstein",
                ShorterForm = "Liechtenstein",
                ChineseName = "列支敦士登公国",
                ChineseShorterForm = "列支敦士登",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
            };
        }

        /// <summary>
        /// 列支敦士登（Principality of Liechtenstein，欧洲，LI，LIE，438），列支敦士登公国 <br />
        /// Cosmos i18n code: i18n_country_liezhidunshideng <br />
        /// Cosmos region code: 200122
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_liezhidunshideng";

        /// <summary>
        /// Get Cosmos Region Code (CEP-1/CRCode)
        /// </summary>
        public static long CosmosRegionCode => _country.CRCode;

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