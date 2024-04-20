using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace MiTutorial
{
    public class GitHub_Actions : EditorWindow
    {

        static GitHub_Actions winGit;

        private string GA1 = "GitHub Actions es un servicio de integración continua \ny entrega continua (CI/CD) proporcionado por GitHub. \nPermite a los desarrolladores automatizar flujos de trabajo \nen sus repositorios de GitHub, lo que incluye la ejecución de pruebas, \ncompilación de código, despliegue de aplicaciones y otras tareas \nrelacionadas con el desarrollo de software. GitHub \nActions se basa en archivos de configuración YAML que definen \nlos pasos a seguir en un flujo de trabajo específico, lo que \nfacilita la automatización de tareas repetitivas en el \nproceso de desarrollo de software.";
        private string GA2 = "Cuando se usa con Unity, GitHub Actions puede ser \nextremadamente útil para integrar pruebas unitarias \nescritas con Unity Test Framework en un flujo de trabajo automatizado. \nEsto significa que cada vez que se envían cambios al repositorio de \nGitHub que contiene el proyecto de Unity, GitHub Actions puede \nejecutar automáticamente las pruebas unitarias para \nverificar la funcionalidad del código. Además, GitHub Actions \npuede ser configurado para compilar el proyecto de Unity, generar \nversiones del juego y desplegarlas en diferentes \nplataformas o servicios, todo de forma automatizada. \nEsto simplifica el proceso de desarrollo y despliegue de juegos de \nUnity al eliminar tareas manuales y garantizar la consistencia en \nel proceso de entrega continua.";

        Vector2 scrollPosition = Vector2.zero;


        public static void InitWindow()
        {
            winGit = EditorWindow.GetWindow<GitHub_Actions>("GitHub Actions");

            winGit.Show();
        }

        void OnGUI()
        {

            GUIStyle bigBoldLabelStyle = new GUIStyle(EditorStyles.boldLabel);
            bigBoldLabelStyle.fontSize = 16;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition); // Agregar scroll vertical general


            EditorGUILayout.LabelField("Introduccion a Github Actions", bigBoldLabelStyle, GUILayout.ExpandHeight(false));  // TÍTULO EN NEGRITA


            string[] IntroUTF1lines = GA1.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in IntroUTF1lines)
            {
                EditorGUILayout.LabelField(line);
            }


            EditorGUILayout.Space();

            string[] IntroUTF2lines = GA2.Split(new[] { "\n", "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in IntroUTF2lines)
            {
                EditorGUILayout.LabelField(line);
            }

            EditorGUILayout.Space();



            EditorGUILayout.EndScrollView();

            if (winGit != null)
            {
                winGit.Repaint();
            }

        }

    }
}