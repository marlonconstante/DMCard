using System.Globalization;
using Xamarin.FileStorage.Abstractions;
using Xamarin.Forms;

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

		public static void AddSettings(ResourceDictionary resources)
		{
			foreach (var property in typeof(AppSettings).GetProperties()) {
				resources.Add(property.Name, property.GetValue(Settings));
			}
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
