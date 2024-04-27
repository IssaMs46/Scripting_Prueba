using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class GitHub_Actions : EditorWindow
    {

        static GitHub_Actions winGit;

        private string GA1 = "GitHub Actions es un servicio de integración continua y entrega continua (CI/CD) proporcionado por GitHub. Permite a los desarrolladores automatizar flujos de trabajo en sus repositorios de GitHub, lo que incluye la ejecución de pruebas, compilación de código, despliegue de aplicaciones y otras tareas relacionadas con el desarrollo de software. GitHub Actions se basa en archivos de configuración YAML que definen los pasos a seguir en un flujo de trabajo específico, lo que facilita la automatización de tareas repetitivas en el proceso de desarrollo de software.";
        private string GA2 = "Cuando se usa con Unity, GitHub Actions puede ser extremadamente útil para integrar pruebas unitarias escritas con Unity Test Framework en un flujo de trabajo automatizado. Esto significa que cada vez que se envían cambios al repositorio de GitHub que contiene el proyecto de Unity, GitHub Actions puede ejecutar automáticamente las pruebas unitarias para verificar la funcionalidad del código. Además, GitHub Actions puede ser configurado para compilar el proyecto de Unity, generar versiones del juego y desplegarlas en diferentes plataformas o servicios, todo de forma automatizada. Esto simplifica el proceso de desarrollo y despliegue de juegos de Unity al eliminar tareas manuales y garantizar la consistencia en el proceso de entrega continua";

        Vector2 scrollPosition = Vector2.zero;


        public static void InitWindow()
        {
            winGit = EditorWindow.GetWindow<GitHub_Actions>("GitHub Actions");

            winGit.Show();
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
            Label titleLabel1 = new Label("GitHub Actions");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tamaño de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(GA1);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));



            Label label2 = new Label(GA2);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label2);

            // Add space between paragraphs

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://docs.github.com/es/actions");
            });
            hyperlinkButton.text = "Documentación de GitHub Actions";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);




            // Add ScrollView to root
            root.Add(scrollView);
        }
    }
}