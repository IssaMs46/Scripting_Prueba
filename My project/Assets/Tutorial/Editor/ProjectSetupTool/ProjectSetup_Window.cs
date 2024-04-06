using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class ProjectSetup_Window : EditorWindow
    {
        //#region Variables
        static ProjectSetup_Window win;
        //#endregion

        //#region Main Methods
        public static void InitWindow ()
        {
            win = EditorWindow.GetWindow<ProjectSetup_Window>("Project Setup");
            win.Show();
        }

        void OnGUI()
        {
            EditorGUILayout.LabelField("Proyect Setup");
        }
        //#endregion



    }
}

