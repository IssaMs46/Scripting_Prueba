using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace MiTutorial
{
    public class Tips_UTF : EditorWindow
    {
        static Tips_UTF winTipsUTF;

        private string Tip1 = "Divide tus pruebas en casos de prueba simples y espec�ficos que se centren en un comportamiento o funci�n particular de tu c�digo. Esto facilitar� la identificaci�n y correcci�n de errores.";
        private string Tip2 = "Aseg�rate de incluir casos de prueba que cubran los l�mites y casos extremos de tus funciones y componentes. Esto te ayudar� a descubrir posibles errores en condiciones inesperadas.";
        private string Tip3 = "Actualiza tus pruebas conforme actualices tu c�digo. Los cambios en el c�digo pueden afectar el comportamiento de las pruebas existentes, as� que aseg�rate de mantenerlas actualizadas para reflejar el estado actual del c�digo.";
        private string Tip4 = "Utiliza objetos simulados (mocks) o falsos (stubs) para simular el comportamiento de componentes externos o dependencias. Esto te permitir� probar unidades de c�digo de manera aislada y evitar� la dependencia de componentes externos reales.";
        private string Tip5 = "Configura tus pruebas para que se ejecuten autom�ticamente cada vez que realices cambios en tu c�digo. Esto te permitir� detectar errores r�pidamente y garantizar� que tus pruebas se ejecuten de manera consistente en todo el ciclo de desarrollo.";
        private string Tip6 = "Escribe c�digo modular y separa las preocupaciones para facilitar la escritura y ejecuci�n de pruebas unitarias. Esto har� que tus pruebas sean m�s f�ciles de mantener y actualizar a medida que tu proyecto crece.";
        private string Tip7 = "Utiliza las assertivas proporcionadas por el framework de pruebas de Unity, como Assert.AreEqual, Assert.IsTrue, Assert.IsFalse, entre otras, para verificar el comportamiento esperado de tu c�digo de manera clara y concisa.";

        private string Outro = "Estos consejos te ayudar�n a escribir y mantener pruebas unitarias efectivas utilizando el Unity Test Framework. Recuerda que las pruebas unitarias son una parte importante del proceso de desarrollo de software y pueden ayudarte a garantizar la calidad y estabilidad de tu juego o aplicaci�n.";

        public static void InitWindow()
        {
            winTipsUTF = GetWindow<Tips_UTF>("Tips para UTF");
            winTipsUTF.minSize = new Vector2(400, 300);
            winTipsUTF.Show();
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
            Label titleLabel1 = new Label("Escribe pruebas simples y espec�ficas:");
            titleLabel1.style.whiteSpace = WhiteSpace.Normal;
            titleLabel1.style.fontSize = 16; // Tama�o de la letra
            titleLabel1.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel1);

            Label label1 = new Label(Tip1);
            label1.style.whiteSpace = WhiteSpace.Normal;
            label1.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label1);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip2
            Label titleLabel2 = new Label("Prueba los l�mites y casos extremos:");
            titleLabel2.style.whiteSpace = WhiteSpace.Normal;
            titleLabel2.style.fontSize = 16; // Tama�o de la letra
            titleLabel2.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel2);

            Label label2 = new Label(Tip2);
            label2.style.whiteSpace = WhiteSpace.Normal;
            label2.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label2);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip3
            Label titleLabel3 = new Label("Mant�n tus pruebas actualizadas:");
            titleLabel3.style.whiteSpace = WhiteSpace.Normal;
            titleLabel3.style.fontSize = 16; // Tama�o de la letra
            titleLabel3.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel3);

            Label label3 = new Label(Tip3);
            label3.style.whiteSpace = WhiteSpace.Normal;
            label3.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label3);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip4
            Label titleLabel4 = new Label("Utiliza mocks y stubs cuando sea necesario:");
            titleLabel4.style.whiteSpace = WhiteSpace.Normal;
            titleLabel4.style.fontSize = 16; // Tama�o de la letra
            titleLabel4.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel4);

            Label label4 = new Label(Tip4);
            label4.style.whiteSpace = WhiteSpace.Normal;
            label4.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label4);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip5
            Label titleLabel5 = new Label("Automatiza tus pruebas:");
            titleLabel5.style.whiteSpace = WhiteSpace.Normal;
            titleLabel5.style.fontSize = 16; // Tama�o de la letra
            titleLabel5.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel5);

            Label label5 = new Label(Tip5);
            label5.style.whiteSpace = WhiteSpace.Normal;
            label5.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label5);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip6
            Label titleLabel6 = new Label("Practica la modularidad y la separaci�n de preocupaciones:");
            titleLabel6.style.whiteSpace = WhiteSpace.Normal;
            titleLabel6.style.fontSize = 16; // Tama�o de la letra
            titleLabel6.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel6);

            Label label6 = new Label(Tip6);
            label6.style.whiteSpace = WhiteSpace.Normal;
            label6.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label6);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Tip7
            Label titleLabel7 = new Label("Utiliza assertivas espec�ficas:");
            titleLabel7.style.whiteSpace = WhiteSpace.Normal;
            titleLabel7.style.fontSize = 16; // Tama�o de la letra
            titleLabel7.style.unityFontStyleAndWeight = FontStyle.Bold;
            scrollView.Add(titleLabel7);

            Label label7 = new Label(Tip7);
            label7.style.whiteSpace = WhiteSpace.Normal;
            label7.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(label7);

            // Add space between paragraphs
            scrollView.Add(new Label(" "));

            // Create Label for Outro
            Label labelOutro = new Label(Outro);
            labelOutro.style.whiteSpace = WhiteSpace.Normal;
            labelOutro.style.fontSize = 14; // Tama�o de la letra
            scrollView.Add(labelOutro);

            // Add ScrollView to root
            root.Add(scrollView);
        }
    }
}
