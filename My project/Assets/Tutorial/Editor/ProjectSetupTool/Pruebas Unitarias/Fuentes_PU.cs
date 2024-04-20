using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Fuentes_PU : EditorWindow
    {

        static Fuentes_PU winFuentesPU;


        //private string gameName = "Game";

        Vector2 scrollPosition = Vector2.zero;


        public static void InitWindow()
        {
            winFuentesPU = EditorWindow.GetWindow<Fuentes_PU>("Project Setup");

            winFuentesPU.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;


            EditorGUILayout.LabelField("Unit Testing en Unity", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("Unit Testing en Unity", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://histeriagamedev.wordpress.com/2020/06/20/unit-testing-en-unity/");
            }

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Unit Testing en Unity", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA;

            EditorGUILayout.Space();

           

            if (GUILayout.Button("Unit Testing pero ligado a UTF", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://docs.unity3d.com/Manual/testing-editortestsrunner.html");
            }

            EditorGUILayout.Space();

            if (GUILayout.Button("Tuutorial básico", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=pr5FBtu5SvQ");
            }

            EditorGUILayout.Space();








            if (winFuentesPU != null)
            {
                winFuentesPU.Repaint();
            }

        }

    }
}

