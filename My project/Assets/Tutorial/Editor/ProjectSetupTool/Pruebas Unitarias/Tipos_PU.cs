using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Tipos_PU : EditorWindow
    {

        static Tipos_PU winPU;






        public static void InitWindow()
        {
            winPU = EditorWindow.GetWindow<Tipos_PU>("Tipos de Pruebas unitarias");

            winPU.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("Tipos de pruebas unitarias", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("descripcion");  //TEXTO NORMAL

            //gameName=EditorGUILayout.TextField("Game name:", gameName);
            EditorGUILayout.EndHorizontal();

            //if(GUILayout.Button ("Create Project Structure", GUILayout.Height(30), GUILayout.ExpandWidth(true)))
            //{
            //    Debug.Log("presion de botón");
            //}

            if (winPU != null)
            {
                winPU.Repaint();
            }

        }

    }
}
