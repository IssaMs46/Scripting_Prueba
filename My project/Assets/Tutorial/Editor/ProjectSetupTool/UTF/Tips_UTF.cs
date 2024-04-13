using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class Tips_UTF : EditorWindow
    {

        static Tips_UTF winTipsUTF;

        private string Tip1 = "Divide tus pruebas en casos de prueba simples y \nespec�ficos que se centren en un comportamiento o \nfunci�n particular de tu c�digo. Esto facilitar� \nla identificaci�n y correcci�n de errores.";
        private string Tip2 = " Aseg�rate de incluir casos de prueba que cubran \nlos l�mites y casos extremos de tus funciones y \ncomponentes. Esto te ayudar� a descubrir posibles \nerrores en condiciones inesperadas.";
        private string Tip3 = "Actualiza tus pruebas conforme actualices tu c�digo. \nLos cambios en el c�digo pueden afectar el \ncomportamiento de las pruebas existentes, as� que \naseg�rate de mantenerlas actualizadas \npara reflejar el estado actual del c�digo";
        private string Tip4 = "Utiliza objetos simulados (mocks) o falsos (stubs) \npara simular el comportamiento de componentes \nexternos o dependencias. Esto te permitir� probar \nunidades de c�digo de manera aislada y \nevitar� la dependencia de componentes externos \nreales";
        private string Tip5 = "Configura tus pruebas para que se ejecuten autom�ticamente \ncada vez que realices cambios en tu c�digo. \nEsto te permitir� detectar errores r�pidamente \ny garantizar� que tus pruebas se ejecuten \nde manera consistente en todo el ciclo de d\nesarrollo.";
        private string Tip6 = "Escribe c�digo modular y separa las preocupaciones \npara facilitar la escritura y ejecuci�n de pruebas \nunitarias. Esto har� que tus pruebas sean m�s \nf�ciles de mantener y actualizar a medida \nque tu proyecto crece.";
        private string Tip7 = "Utiliza las assertivas proporcionadas por el framework \nde pruebas de Unity, como Assert.AreEqual, \nAssert.IsTrue, Assert.IsFalse, entre otras, para \nverificar el comportamiento esperado de tu \nc�digo de manera clara y concisa.";

        private string Outro = "Estos consejos te ayudar�n a escribir y mantener pruebas \nunitarias efectivas utilizando el Unity Test \nFramework. Recuerda que las pruebas unitarias \nson una parte importante del proceso de \ndesarrollo de software y pueden ayudarte a garantizar \nla calidad y estabilidad de tu juego o \naplicaci�n.";

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


            EditorGUILayout.LabelField("Escribe pruebas simples y espec�ficas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA


            string[] Tip1lines = Tip1.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in Tip1lines)
            {
                EditorGUILayout.LabelField(line);
            }



            EditorGUILayout.Space();

            EditorGUILayout.LabelField("Prueba los l�mites y casos extremos:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip2lines = Tip2.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip2lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Mant�n tus pruebas actualizadas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip3lines = Tip3.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip3lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Utiliza mocks y stubs cuando sea necesario", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip4lines = Tip4.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip4lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();



            EditorGUILayout.LabelField("Automatiza tus pruebas", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip5lines = Tip5.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip5lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();




            EditorGUILayout.LabelField("Practica la modularidad y la separaci�n de preocupaciones:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip6lines = Tip6.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip6lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();





            EditorGUILayout.LabelField("Utiliza assertivas espec�ficas:", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA



            string[] Tip7lines = Tip7.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);


            foreach (string line in Tip7lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();


            EditorGUILayout.LabelField("Outro", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // T�TULO EN NEGRITA


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

