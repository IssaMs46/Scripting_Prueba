using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Fuentes_UTF : EditorWindow
    {

        static Fuentes_UTF winFuentesUTF;


        public static void InitWindow()
        {
            winFuentesUTF = EditorWindow.GetWindow<Fuentes_UTF>("Fuentes sobre UTF");
            winFuentesUTF.minSize = new Vector2(400, 300);
            winFuentesUTF.Show();
        }



        /// 
        void OnEnable()
        {
            VisualElement root = rootVisualElement;
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            scrollView.Add(new Label(" "));


            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://docs.unity3d.com/Packages/com.unity.test-framework@1.1/manual/index.html");
            });
            hyperlinkButton.text = "About Unity Test Framework";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton2 = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=wTiF2D0_vKA");
            });
            hyperlinkButton2.text = "QA your code: The new Unity Test Framework";
            hyperlinkButton2.style.color = new StyleColor(Color.blue);
            hyperlinkButton2.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton2);

            scrollView.Add(new Label(" "));

            //

            Button hyperlinkButton3 = new Button(() =>
            {
                Application.OpenURL("https://gamedevdustin.medium.com/quickstart-guide-unitys-test-framework-in-unity-2022-1ee25fe94765");
            });
            hyperlinkButton3.text = "QuickStart guide UTF 2022";
            hyperlinkButton3.style.color = new StyleColor(Color.blue);
            hyperlinkButton3.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton3);

            scrollView.Add(new Label(" "));

            //

          



            // Add ScrollView to root
            root.Add(scrollView);

        }

        ///


        

    }
}

