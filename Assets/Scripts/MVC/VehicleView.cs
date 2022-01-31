using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VehicleView : MonoBehaviour
{
    [SerializeField] private Text nameView;
    [SerializeField] private Image iconView;
    [SerializeField] private Text descriptionView;

    public void SetData(string name, Sprite icon, string description)
    {
        nameView.text = name;
        iconView.sprite = icon;
        descriptionView.text = description;
    }
}
