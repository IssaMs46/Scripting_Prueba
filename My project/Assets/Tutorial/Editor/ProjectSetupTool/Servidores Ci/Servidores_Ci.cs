using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MiTutorial;


namespace MiTutorial
{
    public class Servidores_Ci : EditorWindow
    {
        
        static Servidores_Ci winVinculacion;

        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("�Qu� son y para qu� sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("�Qu� son?", EditorStyles.boldLabel);  // T�TULO EN NEGRITA
            EditorGUILayout.LabelField("Aqu� va la explicacion");  //TEXTO NORMAL

           
            EditorGUILayout.EndHorizontal();

           

            if (winVinculacion != null)
            {
                winVinculacion.Repaint();
            }
        }

    }
}
