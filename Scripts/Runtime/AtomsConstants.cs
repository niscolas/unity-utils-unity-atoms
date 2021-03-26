﻿namespace Plugins.UnityAtomsUtils {
	public static class AtomsConstants {
		public const int CreateAssetMenuOrder = -20;
		
		public const string BaseCreateAssetMenuPath = "Unity Atoms/";
		public const string ActionsCreateAssetMenuPath = BaseCreateAssetMenuPath + "Actions/";
		public const string SceneManagementCreateAssetMenuPath = ActionsCreateAssetMenuPath + "Scene Management/";
		public const string FunctionsCreateAssetMenuPath = BaseCreateAssetMenuPath + "Functions/";
		public const string ConditionsCreateAssetMenuPath = BaseCreateAssetMenuPath + "Conditions/";

		public const string AtomsScriptableObjectFolderPath = "ScriptableObjects/Atoms/";
		public const string ConditionsFolderPath = AtomsScriptableObjectFolderPath + "Conditions";
		public const string FunctionsFolderPath = AtomsScriptableObjectFolderPath + "Functions";
	}
}