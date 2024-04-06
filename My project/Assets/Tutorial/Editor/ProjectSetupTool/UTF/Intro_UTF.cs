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
            winIntro = EditorWindow.GetWindow<Intro_UTF>("�Qu� es y para qu� sirve?");

            winIntro.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("�Qu� es?", EditorStyles.boldLabel);  // T�TULO EN NEGRITA
            EditorGUILayout.LabelField("Aqu� va la explicacion");  //TEXTO NORMAL


            EditorGUILayout.EndHorizontal();



            if (winIntro != null)
            {
                winIntro.Repaint();
            }
        }

    }
}
