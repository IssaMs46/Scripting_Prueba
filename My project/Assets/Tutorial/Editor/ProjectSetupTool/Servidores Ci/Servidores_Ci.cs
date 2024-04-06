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
        private string QueEs = "Los Servidores de Integración Continua (CI, por sus siglas en inglés) son plataformas de software que automatizan el proceso de integración de cambios en el código de un proyecto de software. Estas herramientas se utilizan comúnmente en entornos de desarrollo de software para automatizar la compilación, prueba y distribución del código cada vez que se realizan cambios en el repositorio de código fuente. Los servidores CI están diseñados para trabajar en conjunto con sistemas de control de versiones, como Git, SVN u otros, y pueden ejecutar una serie de tareas definidas, como la compilación del código, la ejecución de pruebas unitarias y la generación de informes de cobertura de código.";

        
        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("¿Qué son y para qué sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("¿Qué son?", EditorStyles.boldLabel);  // TÍTULO EN NEGRITA
            EditorGUILayout.EndHorizontal();

            
            EditorGUILayout.BeginScrollView(Vector2.zero,false, true, GUILayout.ExpandHeight(true));
            EditorGUILayout.LabelField(QueEs, GUILayout.ExpandWidth(true));
           


            EditorGUILayout.LabelField("Aquí va la explicacion");  //TEXTO NORMAL






            if (winVinculacion != null)
            {
                winVinculacion.Repaint();
            }
        }

    }
}