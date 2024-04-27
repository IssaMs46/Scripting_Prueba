using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Fuentes_UTF : EditorWindow
    {

        static Fuentes_UTF winFuentesUTF;


        public static void InitWindow()
        {
            winFuentesUTF = EditorWindow.GetWindow<Fuentes_UTF>("Fuentes sobre UTF");

            winFuentesUTF.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;


            EditorGUILayout.LabelField("About Unity Test Framework", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html");
            }

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("QA your code: The new Unity Test Framework ", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();



            if (GUILayout.Button("https://www.youtube.com/watch?v=wTiF2D0_vKA", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=wTiF2D0_vKA");
            }

            EditorGUILayout.Space();



            EditorGUILayout.LabelField("QuickStart guide UTF 2022", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

            if (GUILayout.Button("https://gamedevdustin.medium.com/quickstart-guide-unitys-test-framework-in-unity-2022-1ee25fe94765", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://gamedevdustin.medium.com/quickstart-guide-unitys-test-framework-in-unity-2022-1ee25fe94765");
            }

            EditorGUILayout.Space();


            if (winFuentesUTF != null)
            {
                winFuentesUTF.Repaint();
            }

        }

    }
}

