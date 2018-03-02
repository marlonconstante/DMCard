using Xamarin.FileStorage.Abstractions;

namespace Tabloide.Configurations
{
	public static class AppConfig
	{
		public static AppSettings Settings { get; private set; }

		public static void LoadFromFile(IFileStorage fileStorage)
		{
			Settings = fileStorage.Read<AppSettings>("settings.json");
		}
	}
}
