using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;


namespace MiTutorial
{
    public class Fuentes_PU : EditorWindow
    {

        static Fuentes_PU winFuentesPU;


        public static void InitWindow()
        {
            winFuentesPU = EditorWindow.GetWindow<Fuentes_PU>("Fuentes sobre Pruebas Unitarias");
            winFuentesPU.minSize = new Vector2(400, 300);
            winFuentesPU.Show();
        }

        void OnEnable()
        {
            VisualElement root = rootVisualElement;
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            scrollView.Add(new Label(" "));


            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://histeriagamedev.wordpress.com/2020/06/20/unit-testing-en-unity/");
            });
            hyperlinkButton.text = "Unit Testing en Unity";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton2 = new Button(() =>
            {
                Application.OpenURL("https://docs.unity3d.com/Manual/testing-editortestsrunner.html");
            });
            hyperlinkButton2.text = "Unit Testing pero ligado a UTF";
            hyperlinkButton2.style.color = new StyleColor(Color.blue);
            hyperlinkButton2.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton2);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton3 = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=pr5FBtu5SvQ");
            });
            hyperlinkButton3.text = "Tutorial básico";
            hyperlinkButton3.style.color = new StyleColor(Color.blue);
            hyperlinkButton3.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton3);


            // Add ScrollView to root
            root.Add(scrollView);

        }




        

    }
}

