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

        private string IntroUTF1 = "El Unity Test Framework es una herramienta integrada\n en Unity que permite a los desarrolladores \nrealizar pruebas unitarias dentro del entorno de desarrollo \nde Unity. Este framework proporciona un conjunto \nde clases y métodos que facilitan la escritura, \nejecución y organización de pruebas unitarias para \nel código de juegos y aplicaciones desarrolladas \ncon Unity. Con el Unity Test Framework, los desarrolladores \npueden crear pruebas para verificar el comportamiento de componentes \nindividuales, como scripts de Unity, prefabs, \ncomponentes de interfaz de usuario y más.";
        private string IntroUTF2 = "El Unity Test Framework sirve para asegurar la calidad \ny estabilidad del software desarrollado con \nUnity mediante la identificación temprana de errores y la\n validación del comportamiento esperado de las \ndistintas partes del código. Al escribir pruebas \nunitarias con este framework, los desarrolladores \npueden detectar y corregir problemas de manera más \neficiente, garantizando un código más robusto y confiable. \nAdemás, el uso del Unity Test Framework promueve buenas prácticas de \ndesarrollo, como la modularidad y la separación de \npreocupaciones, lo que conduce a un código \nmás mantenible y escalable en proyectos de \ndesarrollo de juegos y aplicaciones con Unity";


        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winIntro = EditorWindow.GetWindow<Intro_UTF>("Una pequeña introducción");

            winIntro.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Introducción", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


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
