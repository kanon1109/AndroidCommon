using UnityEngine;
using System.Collections;

public class AndroidCommon : MonoBehaviour 
{
    //安卓类
#if UNITY_ANDROID
    private static AndroidJavaClass ajc = null;
#endif

    /// <summary>
    /// 显示原生tips
    /// </summary>
    /// <param name="content">内容</param>
    public static void showTips(string content)
    {
#if UNITY_ANDROID
        if (ajc == null)
            ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
        ajo.Call("showTips", new string[] { content });
#endif
    }

    /// <summary>
    /// 显示对话框
    /// </summary>
    /// <param name="title">标题</param>
    /// <param name="content">内容</param>
    /// <param name="buttonLable">按钮标签</param>
    public static void showDialog(string title, string content, string buttonLable)
    {
#if UNITY_ANDROID
        if (ajc == null)
            ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
        ajo.Call("showDialog", new string[] { title, content, buttonLable });
#endif
    }
    
    /// <summary>
    /// 调用unity的方法
    /// </summary>
    /// <param name="unityScriptName">unity脚本名称</param>
    /// <param name="unityFunctionName">unity方法名</param>
    /// <param name="arg">unity参数</param>
    public static void invokeUnity(string unityScriptName, string unityFunctionName, string arg)
    {
#if UNITY_ANDROID
        if (ajc == null)
            ajc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        AndroidJavaObject ajo = ajc.GetStatic<AndroidJavaObject>("currentActivity");
        ajo.Call("invokeUnity", new string[] { unityScriptName, unityFunctionName, arg });
#endif
    }
}
