using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Canvas startCanvas;
    [SerializeField] private Canvas DBViewCanvas;
    [SerializeField] private VehicleViewController viewController;

    public void ShowDBViewCanvas()
    {
        startCanvas.enabled = false;
        DBViewCanvas.enabled = true;
        viewController.LoadDB();
    }
    
    public void ShowStartCanvas()
    {
        startCanvas.enabled = true;
        DBViewCanvas.enabled = false;
    }
}
