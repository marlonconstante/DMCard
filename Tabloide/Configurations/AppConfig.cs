using System.Globalization;
using Xamarin.FileStorage.Abstractions;

namespace Tabloide.Configurations
{
	public static class AppConfig
	{
		public static AppSettings Settings { get; private set; }

		public static void SetUp(IFileStorage fileStorage)
		{
			LoadSettingsFromFile(fileStorage);
			SetCultureFromSettings();
		}

		static void LoadSettingsFromFile(IFileStorage fileStorage)
		{
			Settings = fileStorage.Read<AppSettings>("settings.json");
		}

		static void SetCultureFromSettings()
		{
			CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(Settings.Language);
		}
	}
}
