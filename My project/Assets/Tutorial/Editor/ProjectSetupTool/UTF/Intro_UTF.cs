using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MiTutorial;


namespace MiTutorial
{
    public class Intro_UTF : EditorWindow
    {

        static Intro_UTF winIntro;

        private string IntroUTF1 = "El Unity Test Framework es una herramienta integrada\n en Unity que permite a los desarrolladores \nrealizar pruebas unitarias dentro del entorno de desarrollo \nde Unity. Este framework proporciona un conjunto \nde clases y m�todos que facilitan la escritura, \nejecuci�n y organizaci�n de pruebas unitarias para \nel c�digo de juegos y aplicaciones desarrolladas \ncon Unity. Con el Unity Test Framework, los desarrolladores \npueden crear pruebas para verificar el comportamiento de componentes \nindividuales, como scripts de Unity, prefabs, \ncomponentes de interfaz de usuario y m�s.";
        private string IntroUTF2 = "El Unity Test Framework sirve para asegurar la calidad \ny estabilidad del software desarrollado con \nUnity mediante la identificaci�n temprana de errores y la\n validaci�n del comportamiento esperado de las \ndistintas partes del c�digo. Al escribir pruebas \nunitarias con este framework, los desarrolladores \npueden detectar y corregir problemas de manera m�s \neficiente, garantizando un c�digo m�s robusto y confiable. \nAdem�s, el uso del Unity Test Framework promueve buenas pr�cticas de \ndesarrollo, como la modularidad y la separaci�n de \npreocupaciones, lo que conduce a un c�digo \nm�s mantenible y escalable en proyectos de \ndesarrollo de juegos y aplicaciones con Unity";


        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winIntro = EditorWindow.GetWindow<Intro_UTF>("Una peque�a introducci�n");

            winIntro.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Introducci�n", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA


            string[] IntroUTF1lines = IntroUTF1.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in IntroUTF1lines)
            {
                EditorGUILayout.LabelField(line);
            }


            EditorGUILayout.Space();

            string[] IntroUTF2lines = IntroUTF2.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in IntroUTF2lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();



            EditorGUILayout.EndScrollView();

            if (winIntro != null)
            {
                winIntro.Repaint();
            }
        }

    }
}
