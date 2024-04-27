using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Ejemplos_UTF : EditorWindow
    {

        static Ejemplos_UTF winEjemplosUTF;


        public static void InitWindow()
        {
            winEjemplosUTF = EditorWindow.GetWindow<Ejemplos_UTF>("Ejemplos de UTF");

            winEjemplosUTF.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;


            EditorGUILayout.LabelField("Tutorial de pruebas automatizadas en unity", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("https://www.youtube.com/watch?v=YsNVOvGMkS0", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=YsNVOvGMkS0");
            }

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Pruebas unitarias y Test-Driven Development | Ejemplo desde cero", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();



            if (GUILayout.Button("https://www.youtube.com/watch?v=YuRdaR6wwWU", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=YuRdaR6wwWU");
            }

            EditorGUILayout.Space();

            

            EditorGUILayout.LabelField("How to Setup a Project for Testing (Unity Tutorial)", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

            if (GUILayout.Button("https://www.youtube.com/watch?v=Dox5aZjuy3M", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=Dox5aZjuy3M");
            }

            EditorGUILayout.Space();

            if (winEjemplosUTF != null)
            {
                winEjemplosUTF.Repaint();
            }

        }

    }
}

