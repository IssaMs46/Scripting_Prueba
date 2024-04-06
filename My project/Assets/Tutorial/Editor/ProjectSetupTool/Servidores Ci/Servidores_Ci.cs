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
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("¿Qué son y para qué sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("¿Qué son?", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.LabelField("Aquí va la explicacion");  //TEXTO NORMAL

           
            EditorGUILayout.EndHorizontal();

           

            if (winVinculacion != null)
            {
                winVinculacion.Repaint();
            }
        }

    }
}
