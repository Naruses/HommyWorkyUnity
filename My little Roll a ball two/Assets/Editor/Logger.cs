using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

public class Logger : EditorWindow
{
    [MenuItem("Lol/Logger")]
    public static Logger ShowWindow()
    {
        Logger window = GetWindow<Logger>();

        window.titleContent = new GUIContent("Logger");

        window.minSize = new Vector2(300, 300);

        return window;
    }
        
    void OnEnable()
    {
        TextField message = new TextField("���������");

        ColorField color = new ColorField("����� �����");

        Button send = new Button(() =>
        {
            Debug.Log("<color= '#" + ColorUtility.ToHtmlStringRGB(color.value) + "'>" + message.value + "</color");
        });

        send.text = "���������!";


        rootVisualElement.Add(message);
        rootVisualElement.Add(color);
        rootVisualElement.Add(send);

    }

}
