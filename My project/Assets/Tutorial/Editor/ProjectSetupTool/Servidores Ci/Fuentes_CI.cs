using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine.Windows;


namespace MiTutorial
{
    public class Fuentes_CI : EditorWindow
    {

        static Fuentes_CI winFuentesCI;


        public static void InitWindow()
        {
            winFuentesCI = EditorWindow.GetWindow<Fuentes_CI>("Fuentes sobre servidores CI");
            winFuentesCI.minSize = new Vector2(400, 300);
            winFuentesCI.Show();
        }



        void OnEnable ()
        {
            VisualElement root = rootVisualElement;
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            scrollView.Add(new Label(" "));


            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://www.jetbrains.com/es-es/teamcity/ci-cd-guide/ci-cd-tools/servers/");
            });
            hyperlinkButton.text = "¿Qué son los servidores de integración continua?";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton2 = new Button(() =>
            {
                Application.OpenURL("https://histeriagamedev.wordpress.com/2020/06/20/unit-testing-en-unity/");
            });
            hyperlinkButton2.text = "Integración y distriibución continua (CI/CD)";
            hyperlinkButton2.style.color = new StyleColor(Color.blue);
            hyperlinkButton2.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton2);
             
            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton3 = new Button(() =>
            {
                Application.OpenURL("https://docs.github.com/es/actions/automating-builds-and-tests/about-continuous-integration");
            });
            hyperlinkButton3.text = "Acerca de la integración continua";
            hyperlinkButton3.style.color = new StyleColor(Color.blue);
            hyperlinkButton3.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton3);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton4 = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=sIhm4YOMK6Q");
            });
            hyperlinkButton4.text = "Tutorial GitHub Actions";
            hyperlinkButton4.style.color = new StyleColor(Color.blue);
            hyperlinkButton4.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton4);



            // Add ScrollView to root
            root.Add(scrollView);

        }
        

    }
}

