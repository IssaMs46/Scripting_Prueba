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



        public static void InitWindow()
        {
            winFuentesPU = EditorWindow.GetWindow<Fuentes_PU>("Project Setup");

            winFuentesPU.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Fuentes de informacion", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("links");  //TEXTO NORMAL

            //gameName=EditorGUILayout.TextField("Game name:", gameName);
            EditorGUILayout.EndHorizontal();

            //if(GUILayout.Button ("Create Project Structure", GUILayout.Height(30), GUILayout.ExpandWidth(true)))
            //{
            //    Debug.Log("presion de botón");
            //}

            if (winFuentesPU != null)
            {
                winFuentesPU.Repaint();
            }

        }

    }
}

