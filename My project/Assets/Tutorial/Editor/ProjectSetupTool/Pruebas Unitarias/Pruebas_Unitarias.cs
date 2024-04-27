using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Pruebas_Unitarias : EditorWindow
    {
        
        static Pruebas_Unitarias win;
        
        private string QueEs = "Las pruebas unitarias son pequeñas pruebas automatizadas que se realizan en fragmentos individuales de código, conocidos como unidades. Estas unidades pueden ser funciones, métodos o clases. Las pruebas unitarias se centran en evaluar el comportamiento de una unidad de código de manera aislada, es decir, sin depender de otros componentes del sistema.";
        private string ParaQue = "Las pruebas unitarias sirven para verificar que las unidades de código funcionan como se espera. Al automatizar estas pruebas, los desarrolladores pueden detectar errores y problemas de lógica en el código de manera temprana en el proceso de desarrollo. Esto permite corregir los errores de manera oportuna y garantizar que el software sea más confiable y robusto. Además, las pruebas unitarias proporcionan documentación viva del comportamiento esperado de cada unidad de código, lo que facilita el mantenimiento y la colaboración en proyectos de desarrollo de software.";


        
       //Vector2 scrollPosition = Vector2.zero;

        //private string gameName = "Game";



        public static void InitWindow ()
        {
            win = EditorWindow.GetWindow<Pruebas_Unitarias>("Pruebas Unitarias");
            win.minSize = new Vector2(400, 300);
            win.Show();
        }
        void OnEnable()
        {
            VisualElement root = rootVisualElement;

            // Create ScrollView
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip1
            Label titleLabel1 = new Label("Pruebas Unitarias");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tamaño de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(QueEs);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip2


            Label label2 = new Label(ParaQue);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label2);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create a Label acting as a hyperlink
            //Button hyperlinkButton = new Button(() =>
            //{
            //    Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            //});
            //hyperlinkButton.text = "¿Quieres aprender más sobre pruebas unitarias?";
            //hyperlinkButton.style.color = new StyleColor(Color.blue);
            //hyperlinkButton.style.cursor = Cursor.Pointer;
            //scrollView.Add(hyperlinkButton);

            // Crear un Button para el hipervínculo
            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            });
            hyperlinkButton.text = "¿Quieres aprender más sobre pruebas unitarias?";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);


            // Add ScrollView to root
            root.Add(scrollView);
        }
        //void OnGUI()
        //{
        //    GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
        //        linkStyle.normal.textColor = Color.blue;
        //        if (GUILayout.Button("Más información", linkStyle))
        //        {
        //            // Abrir el enlace en el navegador
        //            Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
        //       }
        //}



    }
}

//    EditorGUILayout.Space();
//    GUIStyle linkStyle = new GUIStyle(GUI.skin.label);
//    linkStyle.normal.textColor = Color.blue;
//    if (GUILayout.Button("Más información", linkStyle))
//    {
//        // Abrir el enlace en el navegador
//        Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
//    }