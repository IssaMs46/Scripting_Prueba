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
        private string QueEs = "Los Servidores de Integraci�n Continua (CI, por sus siglas en ingl�s) \nson plataformas de software que automatizan el proceso \n de integraci�n de cambios en el c�digo de un proyecto \nde software. Estas herramientas se utilizan com�nmente en entornos \nde desarrollo de software para automatizar la compilaci�n, prueba \ny distribuci�n del c�digo cada vez que se realizan cambios \nen el repositorio de c�digo fuente. Los servidores CI \nest�n dise�ados para trabajar en conjunto con sistemas \nde control de versiones, como Git, SVN u otros, y pueden ejecutar una serie \nde tareas definidas, como la compilaci�n del c�digo, la \nejecuci�n de pruebas unitarias y la generaci�n \nde informes de cobertura de c�digo.";
        private string ParaQue = "La integraci�n de Unity Test Framework (UTF) con Servidores de \nIntegraci�n Continua permite a los equipos de desarrollo automatizar \nlas pruebas unitarias de sus proyectos de Unity \ncomo parte del proceso de integraci�n continua. Esto significa que \ncada vez que se realizan cambios en el c�digo, el servidor CI \npuede ejecutar autom�ticamente las pruebas unitarias escritas \ncon UTF para verificar que el c�digo nuevo o modificado no \ncause regresiones o errores. Al automatizar las pruebas \nunitarias con un servidor CI, los equipos pueden identificar r�pidamente \nproblemas en el c�digo y mantener la calidad del software \na lo largo del tiempo, lo que resulta en un \ndesarrollo m�s eficiente y confiable.";

        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("�Qu� son y para qu� sirven?");

            winVinculacion.Show();
        }

        void OnGUI()
        {
            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general

            EditorGUILayout.LabelField("�Qu� son?", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA


             // Espacio entre el t�tulo y el texto


            //QueEs = EditorGUILayout.TextArea(QueEs, GUILayout.ExpandHeight(true));  // TEXTO NORMAL con Texto

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