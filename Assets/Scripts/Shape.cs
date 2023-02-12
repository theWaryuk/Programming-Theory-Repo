using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    protected TextMeshProUGUI infoText;

    private string m_name = "basic shape"; // ENCAPSULATION
    private float rotateSpeed = 25.0f;

    // ENCAPSULATION
    protected void SetName(string _name)
    {
        m_name = _name;
    }

    private void Awake()
    {
        if (!infoText)
        {
            infoText = GameObject.Find("Canvas/InfoText").GetComponent<TextMeshProUGUI>();
        }
    }

    // ABSTRACTION
    protected virtual void DisplayText()
    {

        infoText.text = $"This is a {m_name}.";
    }

    // ABSTRACTION
    protected virtual void Motion()
    { 
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

    private void Update()
    {
        Motion();
    }

    private void OnMouseDown()
    {
        DisplayText();
    }
}
