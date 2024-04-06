using UnityEngine;
using UnityEditor;


namespace  MiTutorial
{
    public class EditorMenus
    {
        [MenuItem("Tutorial/Project/Project Setup Tool")]
        public static void InitProjectSetupTool()
        {
            Debug.Log("Iniciando ventana");
            ProjectSetup_Window.InitWindow();
        }
    }
}

