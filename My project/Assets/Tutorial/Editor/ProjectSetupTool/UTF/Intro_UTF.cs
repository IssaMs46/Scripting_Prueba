using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Intro_UTF : EditorWindow
    {
        static Intro_UTF winIntro;

        private string IntroUTF1 = "El Unity Test Framework es una herramienta integrada en Unity que permite a los desarrolladores realizar pruebas unitarias dentro del entorno de desarrollo de Unity. Este framework proporciona un conjunto de clases y métodos que facilitan la escritura, ejecución y organización de pruebas unitarias para el código de juegos y aplicaciones desarrolladas con Unity. Con el Unity Test Framework, los desarrolladores pueden crear pruebas para verificar el comportamiento de componentes individuales, como scripts de Unity, prefabs, componentes de interfaz de usuario y más.";
        private string IntroUTF2 = "El Unity Test Framework sirve para asegurar la calidad y estabilidad del software desarrollado con Unity mediante la identificación temprana de errores y la validación del comportamiento esperado de las distintas partes del código. Al escribir pruebas unitarias con este framework, los desarrolladores pueden detectar y corregir problemas de manera más eficiente, garantizando un código más robusto y confiable. Además, el uso del Unity Test Framework promueve buenas prácticas de desarrollo, como la modularidad y la separación de preocupaciones, lo que conduce a un código más mantenible y escalable en proyectos de desarrollo de juegos y aplicaciones con Unity.";

        public static void InitWindow()
        {
            winIntro = GetWindow<Intro_UTF>("Introducción UTF");
            winIntro.minSize = new Vector2(400, 300);
            winIntro.Show();
        }

        void OnEnable()
        {
            VisualElement root = rootVisualElement;

            // Create ScrollView
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            // Create Label for IntroUTF1
            Label label1 = new Label(IntroUTF1);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for IntroUTF2
            Label label2 = new Label(IntroUTF2);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label2);

            // Add ScrollView to root
            root.Add(scrollView);
        }
    }
}
