using UnityEngine;

[CreateAssetMenu(menuName = "Vehicles/Airplane")]
public class AirplaneModel : VehicleModel
{
    public float liftingForce;
    
    public override string GetAdditionalInformation()
    {
        return base.GetAdditionalInformation() + $"\nПодъемная сила - {liftingForce}";
    }
}