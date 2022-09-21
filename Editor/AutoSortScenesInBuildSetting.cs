using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    [FilePath( "ProjectSettings/Kogane/AutoSortScenesInBuildSetting.asset", FilePathAttribute.Location.ProjectFolder )]
    internal sealed class AutoSortScenesInBuildSetting : ScriptableSingleton<AutoSortScenesInBuildSetting>
    {
        [SerializeField] private string[] m_pathArray = Array.Empty<string>();

        public IReadOnlyList<string> PathList => m_pathArray;

        public void Save()
        {
            Save( true );
        }
    }
}