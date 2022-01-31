using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Car")]
public class CarModel : VehicleModel
{
    public float numberOfPersons;

    public override string GetAdditionalInformation()
    {
        return base.GetAdditionalInformation() + $"\nКол-во мест - {numberOfPersons}";
    }
}