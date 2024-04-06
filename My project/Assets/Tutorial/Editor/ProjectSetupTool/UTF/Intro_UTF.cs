using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MiTutorial;


namespace MiTutorial
{
    public class Intro_UTF : EditorWindow
    {

        static Intro_UTF winIntro;

        public static void InitWindow()
        {
            winIntro = EditorWindow.GetWindow<Intro_UTF>("¿Qué es y para qué sirve?");

            winIntro.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("¿Qué es?", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("Aquí va la explicacion");  //TEXTO NORMAL


            EditorGUILayout.EndHorizontal();



            if (winIntro != null)
            {
                winIntro.Repaint();
            }
        }

    }
}
