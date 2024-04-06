using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Tips_UTF : EditorWindow
    {

        static Tips_UTF winTipsUTF;


        public static void InitWindow()
        {
            winTipsUTF = EditorWindow.GetWindow<Tips_UTF>("Tips para UTF");

            winTipsUTF.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Tips para UTF", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("lista de tips");  //TEXTO NORMAL

            EditorGUILayout.EndHorizontal();


            if (winTipsUTF != null)
            {
                winTipsUTF.Repaint();
            }

        }

    }
}

