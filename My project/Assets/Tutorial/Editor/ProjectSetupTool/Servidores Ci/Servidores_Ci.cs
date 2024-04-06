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
        private string QueEs = "Los Servidores de Integración Continua (CI, por sus siglas en inglés) \nson plataformas de software que automatizan el proceso \n de integración de cambios en el código de un proyecto \nde software. Estas herramientas se utilizan comúnmente en entornos \nde desarrollo de software para automatizar la compilación, prueba \ny distribución del código cada vez que se realizan cambios \nen el repositorio de código fuente. Los servidores CI \nestán diseñados para trabajar en conjunto con sistemas \nde control de versiones, como Git, SVN u otros, y pueden ejecutar una serie \nde tareas definidas, como la compilación del código, la \nejecución de pruebas unitarias y la generación \nde informes de cobertura de código.";
        private string ParaQue = "La integración de Unity Test Framework (UTF) con Servidores de \nIntegración Continua permite a los equipos de desarrollo automatizar \nlas pruebas unitarias de sus proyectos de Unity \ncomo parte del proceso de integración continua. Esto significa que \ncada vez que se realizan cambios en el código, el servidor CI \npuede ejecutar automáticamente las pruebas unitarias escritas \ncon UTF para verificar que el código nuevo o modificado no \ncause regresiones o errores. Al automatizar las pruebas \nunitarias con un servidor CI, los equipos pueden identificar rápidamente \nproblemas en el código y mantener la calidad del software \na lo largo del tiempo, lo que resulta en un \ndesarrollo más eficiente y confiable.";

        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("¿Qué son y para qué sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {
            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general

            EditorGUILayout.LabelField("¿Qué son?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


             // Espacio entre el título y el texto


            //QueEs = EditorGUILayout.TextArea(QueEs, GUILayout.ExpandHeight(true));  // TEXTO NORMAL con Texto

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
                Application.OpenURL("https://www.youtube.com/watch?v=u5LGtbsodpE");
            }

            EditorGUILayout.EndScrollView();

            //REVISAR SI USAR ESTE LINK O SI USAR OTRO




            if (winVinculacion != null)
            {
                winVinculacion.Repaint();
            }
        }

    }
}