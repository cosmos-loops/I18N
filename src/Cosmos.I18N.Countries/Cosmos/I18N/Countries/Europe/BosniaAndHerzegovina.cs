namespace Cosmos.I18N.Countries.Europe
{
    /// <summary>
    /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
    /// Cosmos i18n code: i18n_country_bohei <br />
    /// Cosmos region code: 200106
    /// </summary>
    public static partial class BosniaAndHerzegovina
    {
        // ReSharper disable once InconsistentNaming
        private static readonly CountryInfo _country;

        static BosniaAndHerzegovina()
        {
            _country = new CountryInfo
            {
                Country = Country.BosniaAndHerzegovina,
                CountryCode = CountryCode.BA,
                CountryType = CountryType.Country,
                BelongsToCountry = Country.BosniaAndHerzegovina,
                M49Code = "070",
                Cep1CrCode = 2_00_106,
                Alpha2Code = "BA",
                Alpha3Code = "BIH",
                Name = "Bosnia and Herzegovina",
                ShorterForm = "Azerbaijan",
                ChineseName = "波斯尼亚和黑塞哥维那",
                ChineseShorterForm = "波黑",
                Continent = Continent.Europe,
                I18NIdentityCode = I18N_IDENTITY_CODE,
                GetRegionEnumValue = GetRegionEnumValue
            };
        }

        /// <summary>
        /// 波黑（Bosnia and Herzegovina，欧洲，BA，BIH，070），波斯尼亚和黑塞哥维那 <br />
        /// Cosmos i18n code: i18n_country_bohei <br />
        /// Cosmos region code: 200106
        /// </summary>
        public static CountryInfo Instance => _country;

        /// <summary>
        /// i18n
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public const string I18N_IDENTITY_CODE = "i18n_country_bohei";

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