using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Tipos_PU : EditorWindow
    {

        static Tipos_PU winPU;

        private string Intro = "Las pruebas unitarias son un aspecto fundamental del desarrollo de software, ya que permiten probar partes individuales de código de manera aislada para asegurar que funcionen correctamente. Aquí hay varios tipos de pruebas unitarias comunes:";

        private string PUB = "Son las pruebas más simples y comunes. Se centran en verificar que las funciones o métodos produzcan el resultado esperado cuando se les proporcionan ciertos datos de entrada. Estas pruebas son esenciales para garantizar la funcionalidad básica del código.";
        private string PCL = "Estas pruebas se enfocan en los límites de entrada válidos e inválidos para una función o método. El objetivo es asegurarse de que el código maneje correctamente estos límites y no produzca errores o resultados inesperados";
        private string PDE = "Estas pruebas se centran en verificar que el código maneje correctamente las excepciones o errores que puedan ocurrir durante su ejecución. Se aseguran de que el código capture y maneje adecuadamente las excepciones para evitar fallos inesperados.";
        private string PDR = "Estas pruebas se utilizan para asegurarse de que los cambios realizados en el código no introduzcan nuevos errores o rompan funcionalidades existentes. Se ejecutan después de cada modificación en el código para garantizar que todo siga funcionando como se espera.";
        private string PMS = "Estas pruebas utilizan objetos simulados (mocks) o objetos falsos (stubs) para simular el comportamiento de componentes externos o dependencias. Se utilizan para probar unidades de código de manera aislada, evitando la dependencia de componentes externos reales.";
        private string PCC = "Estas pruebas se centran en medir la cantidad de código que es ejecutada por las pruebas. El objetivo es asegurarse de que todas las líneas de código sean probadas al menos una vez, lo que ayuda a identificar áreas del código que no están siendo probadas adecuadamente.";

        private string outro = "Estos son solo algunos de los tipos de pruebas unitarias que existen. Cada tipo tiene su propia importancia y propósito en el proceso de desarrollo de software, y la elección del tipo de prueba dependerá de las necesidades específicas del proyecto y del código que estés desarrollando.";

        //Vector2 scrollPosition = Vector2.zero;


        public static void InitWindow()
        {
            winPU = EditorWindow.GetWindow<Tipos_PU>("Tipos de Pruebas unitarias");
            winPU.minSize = new Vector2(400, 300);
            winPU.Show();
        }

        void OnEnable()
        {
            VisualElement root = rootVisualElement;

            // Create ScrollView
            ScrollView scrollView = new ScrollView();
            scrollView.style.flexGrow = 1;

            // Add space between paragraphs
            scrollView.Add(new Label(" "));


            Label label8 = new Label(Intro);
            label8.style.whiteSpace = WhiteSpace.Normal;
            label8.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label8);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip1
            Label titleLabel1 = new Label("Pruebas unitarias básicas");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tamaño de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(PUB);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip2
            Label titleLabel2 = new Label("Prueba de casos límite (boundary test)");
            titleLabel2.style.whiteSpace = WhiteSpace.Normal;
            titleLabel2.style.fontSize = 16; // Tamaño de la letra
            titleLabel2.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel2);

            Label label2 = new Label(PCL);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label2);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip3
            Label titleLabel3 = new Label("Puebas de excepciones (exception tests)");
            titleLabel3.style.whiteSpace = WhiteSpace.Normal;
            titleLabel3.style.fontSize = 16; // Tamaño de la letra
            titleLabel3.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel3);

            Label label3 = new Label(PDE);
            label3.style.whiteSpace = WhiteSpace.Normal;
            label3.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label3);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip4
            Label titleLabel4 = new Label("Pruebas de regresión (regression tests)");
            titleLabel4.style.whiteSpace = WhiteSpace.Normal;
            titleLabel4.style.fontSize = 16; // Tamaño de la letra
            titleLabel4.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel4);

            Label label4 = new Label(PDR);
            label4.style.whiteSpace = WhiteSpace.Normal;
            label4.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label4);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip5
            Label titleLabel5 = new Label("Pruebas de mocks y stubs");
            titleLabel5.style.whiteSpace = WhiteSpace.Normal;
            titleLabel5.style.fontSize = 16; // Tamaño de la letra
            titleLabel5.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel5);

            Label label5 = new Label(PMS);
            label5.style.whiteSpace = WhiteSpace.Normal;
            label5.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label5);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip6
            Label titleLabel6 = new Label("Pruebas de cobertura de código (code coverage tests)");
            titleLabel6.style.whiteSpace = WhiteSpace.Normal;
            titleLabel6.style.fontSize = 16; // Tamaño de la letra
            titleLabel6.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel6);

            Label label6 = new Label(PCC);
            label6.style.whiteSpace = WhiteSpace.Normal;
            label6.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label6);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip7
            

            Label label7 = new Label(outro);
            label7.style.whiteSpace = WhiteSpace.Normal;
            label7.style.fontSize = 14; // Tamaño de la letra
            scrollView.Add(label7);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            });
            hyperlinkButton.text = "Más información";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el botón si lo deseas
            scrollView.Add(hyperlinkButton);




            // Add ScrollView to root
            root.Add(scrollView);
        }

    }
}
