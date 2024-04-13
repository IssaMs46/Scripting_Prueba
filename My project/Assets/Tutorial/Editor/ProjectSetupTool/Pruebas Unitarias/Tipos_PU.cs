using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Tipos_PU : EditorWindow
    {

        static Tipos_PU winPU;

        private string Intro = "Las pruebas unitarias son un aspecto fundamental \ndel desarrollo de software, ya que permiten probar \npartes individuales de código de manera aislada para \nasegurar que funcionen correctamente. Aquí hay \nvarios tipos de pruebas unitarias comunes:";

        private string PUB = "Son las pruebas más simples y comunes. Se centran \nen verificar que las funciones o métodos produzcan \nel resultado esperado cuando se les proporcionan ciertos \ndatos de entrada. Estas pruebas son esenciales \npara garantizar la funcionalidad básica del código.";
        private string PCL = " Estas pruebas se enfocan en los límites de entrada \nválidos e inválidos para una función o método. \nEl objetivo es asegurarse de que el código maneje correctamente \nestos límites y no produzca errores o resultados \ninesperados.";
        private string PDE = "Estas pruebas se centran en verificar que el código \nmaneje correctamente las excepciones o errores \nque puedan ocurrir durante su ejecución. Se aseguran de que el \ncódigo capture y maneje adecuadamente las excepciones\n para evitar fallos inesperados.";
        private string PDR = " Estas pruebas se utilizan para asegurarse de que \nlos cambios realizados en el código no introduzcan \nnuevos errores o rompan funcionalidades existentes. Se ejecutan \ndespués de cada modificación en el código para \ngarantizar que todo siga funcionando como se espera.\r\n";
        private string PMS = "Estas pruebas utilizan objetos simulados (mocks) o \nobjetos falsos (stubs) para simular el comportamiento \nde componentes externos o dependencias. Se utilizan para \nprobar unidades de código de manera aislada, evitando \nla dependencia de componentes externos reales.\r\n";
        private string PCC = " Estas pruebas se centran en medir la cantidad de \ncódigo que es ejecutada por las pruebas. El objetivo es \nasegurarse de que todas las líneas de código sean probadas \nal menos una vez, lo que ayuda a identificar áreas \ndel código que no están siendo probadas adecuadamente.\r\n";

        private string outro = "Estos son solo algunos de los tipos de pruebas \nunitarias que existen. Cada tipo tiene su propia importancia \ny propósito en el proceso de desarrollo de software, y \nla elección del tipo de prueba dependerá de las necesidades \nespecíficas del proyecto y del código que \nestés desarrollando.";

        Vector2 scrollPosition = Vector2.zero;


        public static void InitWindow()
        {
            winPU = EditorWindow.GetWindow<Tipos_PU>("Tipos de Pruebas unitarias");

            winPU.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Introducción", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] Introlines = Intro.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in Introlines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Pruebas Unitarias Básicas", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PUBlines = PUB.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PUBlines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Pruebas de casos límite (boundary tests)", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PCLlines = PCL.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PCLlines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Pruebas de excepciones (exception tests)", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PDElines = PDE.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PDElines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();



            EditorGUILayout.LabelField("Pruebas de regresión (regression tests)", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PDRlines = PDR.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PDRlines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();




            EditorGUILayout.LabelField("Pruebas de mocks y stubs", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PMSlines = PMS.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PMSlines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();





            EditorGUILayout.LabelField("Pruebas de cobertura de código (code coverage tests", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] PCClines = PCC.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in PCClines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Outro", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] outrolines = outro.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in outrolines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();










            // LINKS
            GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
            linkStyle.normal.textColor = Color.blue;
            if (GUILayout.Button("Más información", linkStyle))
            {
                // Abrir el enlace en el navegador
                Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            }

            EditorGUILayout.EndScrollView();

            //REVISAR SI USAR ESTE LINK O SI USAR OTRO

            

            if (winPU != null)
            {
                winPU.Repaint();
            }

        }

    }
}
