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

        private string Intro = "Las pruebas unitarias son un aspecto fundamental del desarrollo de software, ya que permiten probar partes individuales de c�digo de manera aislada para asegurar que funcionen correctamente. Aqu� hay varios tipos de pruebas unitarias comunes:";

        private string PUB = "Son las pruebas m�s simples y comunes. Se centran en verificar que las funciones o m�todos produzcan el resultado esperado cuando se les proporcionan ciertos datos de entrada. Estas pruebas son esenciales para garantizar la funcionalidad b�sica del c�digo.";
        private string PCL = "Estas pruebas se enfocan en los l�mites de entrada v�lidos e inv�lidos para una funci�n o m�todo. El objetivo es asegurarse de que el c�digo maneje correctamente estos l�mites y no produzca errores o resultados inesperados";
        private string PDE = "Estas pruebas se centran en verificar que el c�digo maneje correctamente las excepciones o errores que puedan ocurrir durante su ejecuci�n. Se aseguran de que el c�digo capture y maneje adecuadamente las excepciones para evitar fallos inesperados.";
        private string PDR = "Estas pruebas se utilizan para asegurarse de que los cambios realizados en el c�digo no introduzcan nuevos errores o rompan funcionalidades existentes. Se ejecutan despu�s de cada modificaci�n en el c�digo para garantizar que todo siga funcionando como se espera.";
        private string PMS = "Estas pruebas utilizan objetos simulados (mocks) o objetos falsos (stubs) para simular el comportamiento de componentes externos o dependencias. Se utilizan para probar unidades de c�digo de manera aislada, evitando la dependencia de componentes externos reales.";
        private string PCC = "Estas pruebas se centran en medir la cantidad de c�digo que es ejecutada por las pruebas. El objetivo es asegurarse de que todas las l�neas de c�digo sean probadas al menos una vez, lo que ayuda a identificar �reas del c�digo que no est�n siendo probadas adecuadamente.";

        private string outro = "Estos son solo algunos de los tipos de pruebas unitarias que existen. Cada tipo tiene su propia importancia y prop�sito en el proceso de desarrollo de software, y la elecci�n del tipo de prueba depender� de las necesidades espec�ficas del proyecto y del c�digo que est�s desarrollando.";

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
            label8.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label8);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip1
            Label titleLabel1 = new Label("Pruebas unitarias b�sicas");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tama�o de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(PUB);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip2
            Label titleLabel2 = new Label("Prueba de casos l�mite (boundary test)");
            titleLabel2.style.whiteSpace = WhiteSpace.Normal;
            titleLabel2.style.fontSize = 16; // Tama�o de la letra
            titleLabel2.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel2);

            Label label2 = new Label(PCL);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label2);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip3
            Label titleLabel3 = new Label("Puebas de excepciones (exception tests)");
            titleLabel3.style.whiteSpace = WhiteSpace.Normal;
            titleLabel3.style.fontSize = 16; // Tama�o de la letra
            titleLabel3.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel3);

            Label label3 = new Label(PDE);
            label3.style.whiteSpace = WhiteSpace.Normal;
            label3.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label3);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip4
            Label titleLabel4 = new Label("Pruebas de regresi�n (regression tests)");
            titleLabel4.style.whiteSpace = WhiteSpace.Normal;
            titleLabel4.style.fontSize = 16; // Tama�o de la letra
            titleLabel4.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel4);

            Label label4 = new Label(PDR);
            label4.style.whiteSpace = WhiteSpace.Normal;
            label4.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label4);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip5
            Label titleLabel5 = new Label("Pruebas de mocks y stubs");
            titleLabel5.style.whiteSpace = WhiteSpace.Normal;
            titleLabel5.style.fontSize = 16; // Tama�o de la letra
            titleLabel5.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel5);

            Label label5 = new Label(PMS);
            label5.style.whiteSpace = WhiteSpace.Normal;
            label5.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label5);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip6
            Label titleLabel6 = new Label("Pruebas de cobertura de c�digo (code coverage tests)");
            titleLabel6.style.whiteSpace = WhiteSpace.Normal;
            titleLabel6.style.fontSize = 16; // Tama�o de la letra
            titleLabel6.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel6);

            Label label6 = new Label(PCC);
            label6.style.whiteSpace = WhiteSpace.Normal;
            label6.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label6);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip7
            

            Label label7 = new Label(outro);
            label7.style.whiteSpace = WhiteSpace.Normal;
            label7.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label7);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://learn.microsoft.com/es-es/visualstudio/test/unit-test-basics?view=vs-2022");
            });
            hyperlinkButton.text = "M�s informaci�n";
            hyperlinkButton.style.color = new StyleColor(Color.blue);
            hyperlinkButton.AddToClassList("hipervinculo"); // Agrega una clase CSS para estilizar el bot�n si lo deseas
            scrollView.Add(hyperlinkButton);




            // Add ScrollView to root
            root.Add(scrollView);
        }

    }
}
