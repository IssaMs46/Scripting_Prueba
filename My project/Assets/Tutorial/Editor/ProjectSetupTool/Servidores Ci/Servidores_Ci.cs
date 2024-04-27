using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using MiTutorial;
using UnityEditor.UIElements;
using UnityEngine.UIElements;



namespace MiTutorial
{
    public class Servidores_Ci : EditorWindow
    {

        static Servidores_Ci winVinculacion;
        private string QueEs = "Los Servidores de Integraci�n Continua (CI, por sus siglas en ingl�s) son plataformas de software que automatizan el proceso de integraci�n de cambios en el c�digo de un proyecto de software. Estas herramientas se utilizan com�nmente en entornos de desarrollo de software para automatizar la compilaci�n, prueba y distribuci�n del c�digo cada vez que se realizan cambios en el repositorio de c�digo fuente. Los servidores CI est�n dise�ados para trabajar en conjunto con sistemas de control de versiones, como Git, SVN u otros, y pueden ejecutar una serie de tareas definidas, como la compilaci�n del c�digo, la ejecuci�n de pruebas unitarias y la generaci�n de informes de cobertura de c�digo.";
        private string ParaQue = "La integraci�n de Unity Test Framework (UTF) con Servidores de Integraci�n Continua permite a los equipos de desarrollo automatizar las pruebas unitarias de sus proyectos de Unity como parte del proceso de integraci�n continua. Esto significa que cada vez que se realizan cambios en el c�digo, el servidor CI puede ejecutar autom�ticamente las pruebas unitarias escritas con UTF para verificar que el c�digo nuevo o modificado no cause regresiones o errores. Al automatizar las pruebas unitarias con un servidor CI, los equipos pueden identificar r�pidamente problemas en el c�digo y mantener la calidad del software a lo largo del tiempo, lo que resulta en un desarrollo m�s eficiente y confiable.";

        Vector2 scrollPosition = Vector2.zero;

        public static void InitWindow()
        {
            winVinculacion = EditorWindow.GetWindow<Servidores_Ci>("�Qu� son y para qu� sirven?");

            winVinculacion.Show();
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
            Label titleLabel1 = new Label("�Qu� son los servidores CI?");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tama�o de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(QueEs);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip2
            Label titleLabel2 = new Label("�Para qu� sirven?");
            titleLabel2.style.whiteSpace = WhiteSpace.Normal;
            titleLabel2.style.fontSize = 16; // Tama�o de la letra
            titleLabel2.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel2);

            Label label2 = new Label(ParaQue);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label2);

            // Add space between paragraphs
            
            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            Button hyperlinkButton = new Button(() =>
            {
                Application.OpenURL("https://www.youtube.com/watch?v=u5LGtbsodpE");
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