using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;

[StandardModule]
public sealed class Declarer
{
	public class DescComparer : Comparer<string>
	{
		public override int Compare(string x, string y)
		{
			return Comparer<double>.Default.Compare(Conversions.ToDouble(y), Conversions.ToDouble(x));
		}
	}

	public static Dictionary<long, List<string>> ScannedResult = new Dictionary<long, List<string>>();

	public static Dictionary<string, List<string>> ComparedResult = new Dictionary<string, List<string>>();

	public static SortedDictionary<string, List<string>> finalResult = new SortedDictionary<string, List<string>>();

	public static List<string> selectedDrives = new List<string>();

	public static bool loadFromMain = false;

	public static string allPicExts = string.Empty;

	public static int scannedFolders;

	public static long scannedFiles;

	public static long scannedSize;

	public static long dupSize;

	public static Color lightGray = Color.FromArgb(103, 103, 103);

	public static Color darkGray = Color.FromArgb(77, 77, 77);

	public static string startPath = string.Empty;

	public static string licenseType = string.Empty;

	public static string licensedPCs = string.Empty;

	public static XmlDocument xd = new XmlDocument();

	public static XmlElement xeL;

	public const string MAIN_VER = "8.0";

	public const string BUILD_VER = "022";

	public const string COPYRIGHT = "2013-2018";

	public const string HOMEPAGE = "http://DuplicateFileFinder4PC.com/duplicate-photo-finder-plus.htm";

	public const int BS = 9;

	public const string EFN = "Duplicate Photo Finder Plus";

	public const string DE = "Deutsch";

	public const string EN = "English";

	public const string ES = "Español";

	public const string FR = "Français";

	public const string PL = "Polski";

	public const string PT_BR = "Português (Brasil)";

	public const string SL = "Slovenščina";

	public const string TR = "Türkçe";

	public const string RU = "Русский";

	public const string SC = "简体中文";

	public const string TC = "繁體中文";

	public const string AR = "العربية";

	public const string NO_UPGRADE_KEYS = "|XXXX-XXXX-XXXX-XXXX@5.0|TDPF-CYZG-ZYSG-ZGYY@7.0|";
}
