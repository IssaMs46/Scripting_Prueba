using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Manual_UTF : EditorWindow
    {

        static Manual_UTF winManualUTF;


        public static void InitWindow()
        {
            winManualUTF = EditorWindow.GetWindow<Manual_UTF>("Manual UTF");

            winManualUTF.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Manual UTF", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("link y cosas");  //TEXTO NORMAL

            EditorGUILayout.EndHorizontal();


            if (winManualUTF != null)
            {
                winManualUTF.Repaint();
            }

        }

    }
}

