using System.Globalization;
using Tabloide.Platform.Display;
using Xamarin.FileStorage.Abstractions;
using Xamarin.Forms;

namespace Tabloide.Configurations
{
	public static class AppConfig
	{
		public static AppSettings Settings { get; private set; }

		public static ScreenSize ScreenSize { get; private set; }

		public static void SetUp(IFileStorage fileStorage, IDisplayMetrics displayMetrics)
		{
			LoadSettingsFromFile(fileStorage);
			SetScreenSize(displayMetrics);
			SetCultureFromSettings();
		}

		public static void AddSettings(ResourceDictionary resources)
		{
			foreach (var property in typeof(AppSettings).GetProperties()) {
				resources.Add($"{property.Name}Setting", property.GetValue(Settings));
			}

			foreach (var property in typeof(ScreenSize).GetProperties()) {
				resources.Add($"Screen{property.Name}", property.GetValue(ScreenSize));
			}
		}

		static void LoadSettingsFromFile(IFileStorage fileStorage)
		{
			Settings = fileStorage.Read<AppSettings>("settings.json");
		}

		static void SetScreenSize(IDisplayMetrics displayMetrics)
		{
			ScreenSize = displayMetrics.GetScreenSize();
		}

		static void SetCultureFromSettings()
		{
			CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(Settings.Language);
		}
	}
}
