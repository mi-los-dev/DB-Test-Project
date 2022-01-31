using UnityEngine;

public class VehicleModel : ScriptableObject
{
    public string nomination;
    public Sprite image;
    public float weight;
    public float maxSpeed;

    public virtual string GetAdditionalInformation()
    {
        return "Вес - " + weight + 
               '\n' + "Мас. скорость - " + maxSpeed;
    }
}