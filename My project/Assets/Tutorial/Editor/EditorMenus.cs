using UnityEngine;
using UnityEditor;


namespace  MiTutorial
{
    public class EditorMenus
    {

        ////////////////PRUEBAS UNITARIAS//////////////////////////////////////
        [MenuItem("Tutorial/Pruebas Unitarias/¿Qué son? y ¿para qúe sirven?")]
        public static void InitPruebas_Unitarias()
        {
            Debug.Log("Iniciando ventana");
            Pruebas_Unitarias.InitWindow();
        }
      
       /////////
       
        [MenuItem("Tutorial/Pruebas Unitarias/Tipos de pruebas unitarias")]

        public static void InitTipos_PU()
        {
            Debug.Log("Inicia ventana pruebas unitarias");
            Tipos_PU.InitWindow();
        }
        /////////
        
        [MenuItem("Tutorial/Pruebas Unitarias/Fuentes de informacíón")]

        public static void InitFuentes_PU()
        {
            Debug.Log("Inicia ventana fuentes PU");
            Fuentes_PU.InitWindow();
        }

        ///////////////// SERVIDORES CI ////////////////////////////////77
        [MenuItem("Tutorial/Servidores CI/¿Qué son? y ¿para qúe sirven?")]

        public static void InitServidores_Ci()
        {
            Debug.Log("Inicia ventana servidores ci");
            Servidores_Ci.InitWindow();
        }
        /////////

        [MenuItem("Tutorial/Servidores CI/GitHub Actions")]

        public static void InitGitHub_Actions()
        {
            Debug.Log("Inicia ventana github actions");
            GitHub_Actions.InitWindow();
        }

        [MenuItem("Tutorial/Servidores CI/Fuentes de información")]

        public static void InitFuentes_CI()
        {
            Debug.Log("Inicia ventana fuentes servidores ci");
            Fuentes_CI.InitWindow();
        }

        //////////////////////UNITY TEST FRAMEWORK ///////////////////////77

        [MenuItem("Tutorial/UTF/¿Qué es y para qué sirve?")]

        public static void InitIntro_UTF()
        {
            Debug.Log("Inicia ventana UTF");
            Intro_UTF.InitWindow();
        }
        /////////
        [MenuItem("Tutorial/UTF/Manual UTF")]

        public static void InitManual_UTF()
        {
            Debug.Log("Inicia ventana manual UTF");
            Manual_UTF.InitWindow();
        }
        /////////
        [MenuItem("Tutorial/UTF/Tips para UTF")]
        public static void InitTips_UTF()
        {
            Debug.Log("Inicia ventana Tips para UTF");
            Tips_UTF.InitWindow();
        }
        /////////
        [MenuItem("Tutorial/UTF/Fuentes sobre UTF")]
        public static void InitFuentes_UTF()
        {
            Debug.Log("Inicia ventana Fuentes sobre UTF");
            Fuentes_UTF.InitWindow();
        }
        ////////
        [MenuItem("Tutorial/UTF/Ejemplos de UTF")]
        public static void InitEjemplos_UTF()
        {
            Debug.Log("Inicia ventana Ejemplos de UTF");
            Ejemplos_UTF.InitWindow();
        }






    }
}

