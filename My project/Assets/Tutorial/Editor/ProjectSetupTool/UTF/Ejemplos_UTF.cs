using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Ejemplos_UTF : EditorWindow
    {

        static Ejemplos_UTF winEjemplosUTF;


        public static void InitWindow()
        {
            winEjemplosUTF = EditorWindow.GetWindow<Ejemplos_UTF>("Ejemplos de UTF");
            winEjemplosUTF.minSize = new Vector2(400, 300);
            winEjemplosUTF.Show();
        }



        //
        void OnEnable()
        {
            VisualElement root = rootVisualElement;
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            scrollView.Add(new Label(" "));


            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=YsNVOvGMkS0");
            });
            hyperlinkButton.text = "Tutorial de pruebas automatizadas en unity";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton2 = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=YuRdaR6wwWU");
            });
            hyperlinkButton2.text = "Pruebas unitarias y Test-Driven Development | Ejemplo desde cero";
            hyperlinkButton2.style.color = new StyleColor(Color.blue);
            hyperlinkButton2.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton2);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton3 = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=Dox5aZjuy3M");
            });
            hyperlinkButton3.text = "How to Setup a Project for Testing (Unity Tutorial)";
            hyperlinkButton3.style.color = new StyleColor(Color.blue);
            hyperlinkButton3.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton3);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton4 = new Button(() =>
            {
                Application.OpenURL("https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/getting-started.html");
            });
            hyperlinkButton4.text = "Getting started with Unity Test Framework";
            hyperlinkButton4.style.color = new StyleColor(Color.blue);
            hyperlinkButton4.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton4);



            // Add ScrollView to root
            root.Add(scrollView);

        }
        //


    }
}

