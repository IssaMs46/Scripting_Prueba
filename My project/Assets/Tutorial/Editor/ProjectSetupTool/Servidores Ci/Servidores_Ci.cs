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
        private string QueEs = "Los Servidores de Integraci�n Continua (CI, por sus siglas en ingl�s) son plataformas de software que automatizan el proceso de integraci�n de cambios en el c�digo de un proyecto de software. Estas herramientas se utilizan com�nmente en entornos de desarrollo de software para automatizar la compilaci�n, prueba y distribuci�n del c�digo cada vez que se realizan cambios en el repositorio de c�digo fuente. Los servidores CI est�n dise�ados para trabajar en conjunto con sistemas de control de versiones, como Git, SVN u otros, y pueden ejecutar una serie de tareas definidas, como la compilaci�n del c�digo, la ejecuci�n de pruebas unitarias y la generaci�n de informes de cobertura de c�digo.";

        
        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("�Qu� son y para qu� sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {

            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.LabelField("�Qu� son?", EditorStyles.boldLabel);  // T�TULO EN NEGRITA
            EditorGUILayout.EndHorizontal();

            
            EditorGUILayout.BeginScrollView(Vector2.zero,false, true, GUILayout.ExpandHeight(true));
            EditorGUILayout.LabelField(QueEs, GUILayout.ExpandWidth(true));
           


            EditorGUILayout.LabelField("Aqu� va la explicacion");  //TEXTO NORMAL






            if (winVinculacion != null)
            {
                winVinculacion.Repaint();
            }
        }

    }
}