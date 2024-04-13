using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Tips_UTF : EditorWindow
    {

        static Tips_UTF winTipsUTF;

        private string Tip1 = "Divide tus pruebas en casos de prueba simples y \nespecíficos que se centren en un comportamiento o \nfunción particular de tu código. Esto facilitará \nla identificación y corrección de errores.";
        private string Tip2 = " Asegúrate de incluir casos de prueba que cubran \nlos límites y casos extremos de tus funciones y \ncomponentes. Esto te ayudará a descubrir posibles \nerrores en condiciones inesperadas.";
        private string Tip3 = "Actualiza tus pruebas conforme actualices tu código. \nLos cambios en el código pueden afectar el \ncomportamiento de las pruebas existentes, así que \nasegúrate de mantenerlas actualizadas \npara reflejar el estado actual del código";
        private string Tip4 = "Utiliza objetos simulados (mocks) o falsos (stubs) \npara simular el comportamiento de componentes \nexternos o dependencias. Esto te permitirá probar \nunidades de código de manera aislada y \nevitará la dependencia de componentes externos \nreales";
        private string Tip5 = "Configura tus pruebas para que se ejecuten automáticamente \ncada vez que realices cambios en tu código. \nEsto te permitirá detectar errores rápidamente \ny garantizará que tus pruebas se ejecuten \nde manera consistente en todo el ciclo de d\nesarrollo.";
        private string Tip6 = "Escribe código modular y separa las preocupaciones \npara facilitar la escritura y ejecución de pruebas \nunitarias. Esto hará que tus pruebas sean más \nfáciles de mantener y actualizar a medida \nque tu proyecto crece.";
        private string Tip7 = "Utiliza las assertivas proporcionadas por el framework \nde pruebas de Unity, como Assert.AreEqual, \nAssert.IsTrue, Assert.IsFalse, entre otras, para \nverificar el comportamiento esperado de tu \ncódigo de manera clara y concisa.";

        private string Outro = "Estos consejos te ayudarán a escribir y mantener pruebas \nunitarias efectivas utilizando el Unity Test \nFramework. Recuerda que las pruebas unitarias \nson una parte importante del proceso de \ndesarrollo de software y pueden ayudarte a garantizar \nla calidad y estabilidad de tu juego o \naplicación.";

        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winTipsUTF = EditorWindow.GetWindow<Tips_UTF>("Tips para UTF");

            winTipsUTF.Show();
        }

        void OnGUI()
        {
            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Escribe pruebas simples y específicas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] Tip1lines = Tip1.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in Tip1lines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Prueba los límites y casos extremos:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip2lines = Tip2.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip2lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Mantén tus pruebas actualizadas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip3lines = Tip3.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip3lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Utiliza mocks y stubs cuando sea necesario", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip4lines = Tip4.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip4lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();



            EditorGUILayout.LabelField("Automatiza tus pruebas", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip5lines = Tip5.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip5lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();




            EditorGUILayout.LabelField("Practica la modularidad y la separación de preocupaciones:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip6lines = Tip6.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip6lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();





            EditorGUILayout.LabelField("Utiliza assertivas específicas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA



            string[] Tip7lines = Tip7.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip7lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Outro", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] Outrolines = Outro.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Outrolines)
            {
                EditorGUILayout.LabelField(line);
            }


            EditorGUILayout.EndScrollView();

            

            if (winTipsUTF != null)
            {
                winTipsUTF.Repaint();
            }

        }

    }
}

