using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Manual_UTF : EditorWindow
    {

        static Manual_UTF winManualUTF;

        private string MiniIntro = "Aquí podré el manual de UTF, el cual puede brindar mucha más información :) ";

        Vector2 scrollPosition = Vector2.zero;
        public static void InitWindow()
        {
            winManualUTF = EditorWindow.GetWindow<Manual_UTF>("Manual UTF");

            winManualUTF.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Manual UTF", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] MiniIntrolines =  MiniIntro.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in MiniIntrolines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("Manual UTF", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/manual.html");
            }

            EditorGUILayout.EndScrollView();


            if (winManualUTF != null)
            {
                winManualUTF.Repaint();
            }

        }

    }
}

