namespace AspNetSampleMvcApp.ConfigurationProviders
{
    public class TextConfigurationSource : IConfigurationSource
    {
        public IConfigurationProvider Build(IConfigurationBuilder builder)
        {
            return new TxtConfigurationProvider();
        }
    }
}
