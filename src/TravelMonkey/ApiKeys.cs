namespace TravelMonkey
{
	public static class ApiKeys
	{
        #warning You need to set up your API keys.
		public static string ComputerVisionApiKey = "97b1da07f16741f48d8861209540a96e";
		public static string TranslationsApiKey = "2ea25ad535a44d42bd0f4fced94aff94";
		public static string BingImageSearch = "74dfc133ae6c47f6bbd5ec2f554ff002";

		// Change this to the Azure Region you are using
		public static string ComputerVisionEndpoint = "https://xam-challenge-ddtechboy.cognitiveservices.azure.com/";
		public static string TranslationsEndpoint = "https://xam-challenge-translator-ddtechboy.cognitiveservices.azure.com/sts/v1.0/issuetoken";
		public static string SearchEndpoint = "https://xam-challenge-search-ddtechboy.cognitiveservices.azure.com/bing/v7.0";
	}
}