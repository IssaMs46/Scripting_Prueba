using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Manual_UTF : EditorWindow
    {

        static Manual_UTF winManualUTF;

        public static void InitWindow()
        {
            winManualUTF = EditorWindow.GetWindow<Manual_UTF>("Manual UTF");
            winManualUTF.minSize = new Vector2(400, 300);
            winManualUTF.Show();
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
                Application.OpenURL("https://docs.unity3d.com/Packages/com.unity.test-framework@1.4/manual/manual.html");
            });
            hyperlinkButton.text = "Manual UTF";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);

            scrollView.Add(new Label(" "));

            //

            


            // Add ScrollView to root
            root.Add(scrollView);

        }

        //


        

    }
}

