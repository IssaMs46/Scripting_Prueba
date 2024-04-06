using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Pruebas_Unitarias : EditorWindow
    {
        
        static Pruebas_Unitarias win;
        private string QueEs = "Las pruebas unitarias son pequeñas pruebas automatizadas \nque se realizan en fragmentos individuales de código, \nconocidos como unidades. Estas unidades pueden \nser funciones, métodos o clases. Las pruebas \nunitarias se centran en evaluar el \ncomportamiento de una unidad de código de \nmanera aislada, es decir, sin depender de \notros componentes del sistema.";
        private string ParaQue = "Las pruebas unitarias sirven para verificar que las \nunidades de código funcionan como se espera. Al automatizar \nestas pruebas, los desarrolladores pueden detectar \nerrores y problemas de lógica en el código de manera \ntemprana en el proceso de desarrollo. Esto permite \ncorregir los errores de manera oportuna y \ngarantizar que el software sea más confiable y robusto.\n Además, las pruebas unitarias proporcionan documentación \nviva del comportamiento esperado de cada unidad de código, \nlo que facilita el mantenimiento y la colaboración en proyectos \nde desarrollo de software.";

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


            EditorGUILayout.LabelField("¿Qué son?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA
            

            string[] QueEslines = QueEs.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in QueEslines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            EditorGUILayout.LabelField("¿Para qué sirve?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] ParaQuelines = ParaQue.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in ParaQuelines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();
            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("Más información", linkStyle))
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

