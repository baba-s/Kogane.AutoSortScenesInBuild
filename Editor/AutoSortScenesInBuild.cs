using System.Linq;
using UnityEditor;

namespace Kogane.Internal
{
    [InitializeOnLoad]
    internal static class AutoSortScenesInBuild
    {
        static AutoSortScenesInBuild()
        {
            EditorBuildSettings.sceneListChanged -= OnChanged;
            EditorBuildSettings.sceneListChanged += OnChanged;
        }

        private static void OnChanged()
        {
            var pathList = AutoSortScenesInBuildSetting.instance.PathList;

            EditorBuildSettings.scenes = EditorBuildSettings.scenes
                    .OrderBy( ｘ => pathList.Any( y => ｘ.path.StartsWith( y ) ) )
                    .ToArray()
                ;
        }
    }
}