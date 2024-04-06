using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class GitHub_Actions : EditorWindow
    {

        static GitHub_Actions winGit;


        



        public static void InitWindow()
        {
            winGit = EditorWindow.GetWindow<GitHub_Actions>("GitHub Actions");

            winGit.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("GitHub Actions", EditorStyles.boldLabel);  // T�TULO EN NEGRITA
            EditorGUILayout.LabelField("descripcion");  //TEXTO NORMAL

            //gameName=EditorGUILayout.TextField("Game name:", gameName);
            EditorGUILayout.EndHorizontal();

            //if(GUILayout.Button ("Create Project Structure", GUILayout.Height(30), GUILayout.ExpandWidth(true)))
            //{
            //    Debug.Log("presion de bot�n");
            //}

            if (winGit != null)
            {
                winGit.Repaint();
            }

        }

    }
}