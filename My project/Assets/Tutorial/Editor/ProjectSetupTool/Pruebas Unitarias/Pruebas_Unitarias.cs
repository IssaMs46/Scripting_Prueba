using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Pruebas_Unitarias : EditorWindow
    {
        
        static Pruebas_Unitarias win;
        

        //private string gameName = "Game";
        

        
        public static void InitWindow ()
        {
            win = EditorWindow.GetWindow<Pruebas_Unitarias>("Project Setup");
            
            win.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Project Setup", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("Proyect Setup");  //TEXTO NORMAL

            //gameName=EditorGUILayout.TextField("Game name:", gameName);
            EditorGUILayout.EndHorizontal();

            //if(GUILayout.Button ("Create Project Structure", GUILayout.Height(30), GUILayout.ExpandWidth(true)))
            //{
            //    Debug.Log("presion de botón");
            //}

            if(win!= null) 
            {
                win.Repaint();
            }
            
        }
        
    }
}

