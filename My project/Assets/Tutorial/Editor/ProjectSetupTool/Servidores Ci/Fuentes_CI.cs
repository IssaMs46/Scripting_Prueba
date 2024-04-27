using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Fuentes_CI : EditorWindow
    {

        static Fuentes_CI winFuentesCI;


        public static void InitWindow()
        {
            winFuentesCI = EditorWindow.GetWindow<Fuentes_CI>("Fuentes sobre servidores CI");

            winFuentesCI.Show();
        }

        void OnGUI()
        {
            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;


            EditorGUILayout.LabelField("�Qu� son?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA;

            EditorGUILayout.Space();

            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("�Qu� son los servidores de integraci�n continua?", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.jetbrains.com/es-es/teamcity/ci-cd-guide/ci-cd-tools/servers/");
            }

            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Github Actions como servidor CI", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA;

            EditorGUILayout.Space();



            if (GUILayout.Button("Unit Testing pero ligado a UTF", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://docs.unity3d.com/Manual/testing-editortestsrunner.html");
            }

            EditorGUILayout.Space();

            if (GUILayout.Button("Tuutorial b�sico", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://www.youtube.com/watch?v=pr5FBtu5SvQ");
            }

            EditorGUILayout.Space();


            if (winFuentesCI != null)
            {
                winFuentesCI.Repaint();
            }

        }

    }
}

