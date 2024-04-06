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

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Fuentes sobre UTF", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("lista de fuentes, links");  //TEXTO NORMAL

            EditorGUILayout.EndHorizontal();


            if (winFuentesUTF != null)
            {
                winFuentesUTF.Repaint();
            }

        }

    }
}

