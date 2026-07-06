using UnityEngine;
using UnityEditor;
using System.Text.RegularExpressions;
using ProBuilder2.Common;

namespace ProBuilder2.EditorCommon
{
	/**
	 *	Check for updates to ProBuilder.
	 */
	[InitializeOnLoad]
	static class pb_UpdateCheck
	{
		const string UPDATE_CHECK_DISABLED_MESSAGE =
			"This legacy ProBuilder 2 update check is disabled for Unity 6000 compatibility.";

		static pb_UpdateCheck()
		{
		}

		[MenuItem("Tools/" + pb_Constant.PRODUCT_NAME + "/Check for Updates", false, pb_Constant.MENU_ABOUT + 1)]
		static void MenuCheckForUpdate()
		{
			EditorUtility.DisplayDialog("ProBuilder Update Check", UPDATE_CHECK_DISABLED_MESSAGE, "Okay");
		}

		public static void CheckForUpdate()
		{
		}
	}
}
