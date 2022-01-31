using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Motorcycle")]
public class MotorcycleModel : VehicleModel
{
    public float numberOfPersons;

    public override string GetAdditionalInformation()
    {
        return base.GetAdditionalInformation() + $"\nКол-во мест - {numberOfPersons}";
    }
}