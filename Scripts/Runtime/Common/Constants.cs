namespace niscolas.UnityUtils.UnityAtoms
{
    public static class Constants
    {
        public const string AddComponentMenuPrefix = CreateAssetMenuPrefix;
        public const string ActionsCreateAssetMenuPrefix = CreateAssetMenuPrefix + "Actions/";
        public const string ConditionsCreateAssetMenuPrefix = CreateAssetMenuPrefix + "Conditions/";

        public const string CreateAssetMenuPrefix =
            Core.Constants.UnityUtilsCreateAssetMenuPrefix + "[ " + ModuleName + " ]/";

        public const int CreateAssetMenuOrder = Core.Constants.CreateAssetMenuOrder;
        public const string FunctionsCreateAssetMenuPrefix = CreateAssetMenuPrefix + "Functions/";
        public const string ModuleName = "Unity Atoms";
        public const string SceneManagementCreateAssetMenuPrefix = ActionsCreateAssetMenuPrefix + "Scene Management/";
    }
}