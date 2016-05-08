using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AndroidCommonTest : MonoBehaviour
{
    public Button showTipsBtn;
    public Button showDialogBtn;
    public Button setVibratorBtn;
    public Button invokeUnityBtn;
    public Text logTxt;
    // Use this for initialization
    void Start()
    {
        this.showTipsBtn.onClick.AddListener(showTipsBtnClickHandler);
        this.showDialogBtn.onClick.AddListener(showDialogBtnClickHandler);
        this.invokeUnityBtn.onClick.AddListener(invokeUnityBtnClickHandler);
    }
    
    private void unityFunction(string arg)
    {
        this.logTxt.text = "unityFunction";
        AndroidCommon.showTips("调用unityFunction 参数是：" + arg);
    }

    private void invokeUnityBtnClickHandler()
    {
        this.logTxt.text = "invokeUnityBtnClickHandler";
        AndroidCommon.invokeUnity(this.name, "unityFunction", "aaa");
    }

    private void showDialogBtnClickHandler()
    {
        this.logTxt.text = "showDialogBtnClickHandler";
        AndroidCommon.showDialog("对话框", "这是对话框", "确定");
    }

    private void showTipsBtnClickHandler()
    {
        this.logTxt.text = "showTipsBtnClickHandler";
        AndroidCommon.showTips("这是tips");
    }
}
