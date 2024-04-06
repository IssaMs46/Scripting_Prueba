using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Pruebas_Unitarias : EditorWindow
    {
        
        static Pruebas_Unitarias win;
        private string QueEs = "Las pruebas unitarias son peque�as pruebas automatizadas \nque se realizan en fragmentos individuales de c�digo, \nconocidos como unidades. Estas unidades pueden \nser funciones, m�todos o clases. Las pruebas \nunitarias se centran en evaluar el \ncomportamiento de una unidad de c�digo de \nmanera aislada, es decir, sin depender de \notros componentes del sistema.";
        private string ParaQue = "Las pruebas unitarias sirven para verificar que las \nunidades de c�digo funcionan como se espera. Al automatizar \nestas pruebas, los desarrolladores pueden detectar \nerrores y problemas de l�gica en el c�digo de manera \ntemprana en el proceso de desarrollo. Esto permite \ncorregir los errores de manera oportuna y \ngarantizar que el software sea m�s confiable y robusto.\n Adem�s, las pruebas unitarias proporcionan documentaci�n \nviva del comportamiento esperado de cada unidad de c�digo, \nlo que facilita el mantenimiento y la colaboraci�n en proyectos \nde desarrollo de software.";

        Vector2 scrollPosition = Vector2.zero;

        //private string gameName = "Game";



        public static void InitWindow ()
        {
            win = EditorWindow.GetWindow<Pruebas_Unitarias>("Pruebas Unitarias");
            
            win.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("�Qu� son?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA
            

            string[] QueEslines = QueEs.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in QueEslines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            EditorGUILayout.LabelField("�Para qu� sirve?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] ParaQuelines = ParaQue.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in ParaQuelines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();
            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("M�s informaci�n", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            }

            EditorGUILayout.EndScrollView();

            //REVISAR SI USAR ESTE LINK O SI USAR OTRO

            if (win!= null) 
            {
                win.Repaint();
            }
            
        }
        
    }
}

