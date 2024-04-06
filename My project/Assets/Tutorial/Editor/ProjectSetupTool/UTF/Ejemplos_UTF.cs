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

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Ejemplos de UTF", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("Ejemplos, links, codigos");  //TEXTO NORMAL

            EditorGUILayout.EndHorizontal();


            if (winEjemplosUTF != null)
            {
                winEjemplosUTF.Repaint();
            }

        }

    }
}

