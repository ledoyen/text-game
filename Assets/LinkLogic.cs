using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class LinkLogic : MonoBehaviour
{
    private Text textComponent;
    private Button buttonComponent;

    private UnityAction onClickAction;

    public void SetOnClickAction(UnityAction unityAction)
    {
        this.onClickAction = unityAction;
    }

    void Start()
    {
        textComponent = GetComponentInChildren<Text>();
        buttonComponent = GetComponent<Button>();
        buttonComponent.onClick.AddListener(onClickAction);
    }

    void OnMouseOver()
    {
        textComponent.color = Color.blue;
    }

    void OnMouseExit()
    {
        textComponent.color = Color.white;
    }
}
