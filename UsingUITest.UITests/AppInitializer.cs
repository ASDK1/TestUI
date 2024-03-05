using System;
using System.IO;
using System.Linq;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
namespace UsingUITest.UITests
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if(platform == Platform.Android)
			{
                string Folder = "/Users/devm/Documents/Dev/TestUI/Droid/";
                string app = "bin/Debug/com.xamarin.usinguitest-Signed.apk"; //com.xamarin.usinguitest-Signed.apk
                string completo = Path.Combine(Folder, app);

				string signfile = Path.Combine("/Users/devm/Documents/Dev/TestUI/Data/asdk.keystore");

                return ConfigureApp
					.Android
					//.DeviceSerial("emulator-5554")
					.ApkFile(completo)
					.PreferIdeSettings()
                    //.SigningInfoFile(signfile)
                    .StartApp();
			}

			string iosFolder = "/Users/devm/Documents/dev/TestUI/iOS/";
			string iosapp = "bin/iPhoneSimulator/Debug/UsingUITestiOS.app";
			string comppletoios = System.IO.Path.Combine(iosFolder, iosapp);
            return ConfigureApp
				.iOS
				.EnableLocalScreenshots()
                .PreferIdeSettings()
                .DeviceIdentifier("9A1D0A24-095F-4F4C-A6ED-2E7EE67014B7")

				.AppBundle(comppletoios)

                .StartApp();
		}
	}
}

