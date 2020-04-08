using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace My.Resources
{

	public class Resources
	{
		public static ResourceManager resourceMan;

		public static CultureInfo resourceCulture;


		public static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					resourceMan = new ResourceManager("Resources", typeof(Resources).Assembly);
				}
				return resourceMan;
			}
		}


		public static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}

		public static Bitmap add32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("add32", resourceCulture));

		public static Bitmap cls32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("cls32", resourceCulture));

		public static Bitmap del32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("del32", resourceCulture));

		public static Bitmap del32_white => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("del32-white", resourceCulture));

		public static Bitmap del64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("del64", resourceCulture));

		public static Bitmap drive16 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("drive16", resourceCulture));

		public static Bitmap edit32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("edit32", resourceCulture));

		public static Bitmap facebook32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("facebook32", resourceCulture));

		public static Bitmap file16 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("file16", resourceCulture));

		public static Bitmap find128 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("find128", resourceCulture));

		public static Bitmap find32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("find32", resourceCulture));

		public static Bitmap find64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("find64", resourceCulture));

		public static Bitmap folder16 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("folder16", resourceCulture));

		public static Bitmap g_32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("g+32", resourceCulture));

		public static Bitmap help32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("help32", resourceCulture));

		public static Bitmap home32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("home32", resourceCulture));

		public static Bitmap info32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("info32", resourceCulture));

		public static Bitmap invert32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("invert32", resourceCulture));

		public static Bitmap invert64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("invert64", resourceCulture));

		public static Bitmap lang32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("lang32", resourceCulture));

		public static Bitmap license32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("license32", resourceCulture));

		public static Bitmap load32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("load32", resourceCulture));

		public static Bitmap load32_white => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("load32-white", resourceCulture));

		public static Bitmap load64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("load64", resourceCulture));

		public static Bitmap location32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("location32", resourceCulture));

		public static Bitmap location64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("location64", resourceCulture));

		public static Bitmap logo128 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("logo128", resourceCulture));

		public static Bitmap logo64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("logo64", resourceCulture));

		public static Bitmap more32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("more32", resourceCulture));

		public static Bitmap move32_3 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("move32_3", resourceCulture));

		public static Bitmap move64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("move64", resourceCulture));

		public static Bitmap network16 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("network16", resourceCulture));

		public static Bitmap opt32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("opt32", resourceCulture));

		public static Bitmap path32_2 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("path32_2", resourceCulture));

		public static Bitmap path64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("path64", resourceCulture));

		public static Bitmap properties32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("properties32", resourceCulture));

		public static Bitmap properties64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("properties64", resourceCulture));

		public static Bitmap recycle32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("recycle32", resourceCulture));

		public static Bitmap recycle64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("recycle64", resourceCulture));

		public static Bitmap reset32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("reset32", resourceCulture));

		public static Bitmap rom16 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("rom16", resourceCulture));

		public static Bitmap run32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("run32", resourceCulture));

		public static Bitmap run64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("run64", resourceCulture));

		public static Bitmap save32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("save32", resourceCulture));

		public static Bitmap save32_green => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("save32-green", resourceCulture));

		public static Bitmap save64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("save64", resourceCulture));

		public static Bitmap stop128 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("stop128", resourceCulture));

		public static Bitmap support32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("support32", resourceCulture));

		public static Bitmap tsslogo => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("tsslogo", resourceCulture));

		public static Bitmap twitter32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("twitter32", resourceCulture));

		public static Bitmap uncheck32 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("uncheck32", resourceCulture));

		public static Bitmap uncheck64 => (Bitmap)RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("uncheck64", resourceCulture));
	}
}
