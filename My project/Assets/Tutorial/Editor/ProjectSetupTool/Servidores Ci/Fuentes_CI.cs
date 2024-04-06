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

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Fuentes sobre servidores CI", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("lista de fuentes, links");  //TEXTO NORMAL

            EditorGUILayout.EndHorizontal();


            if (winFuentesCI != null)
            {
                winFuentesCI.Repaint();
            }

        }

    }
}

