using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
    // Помещаем префаб пропеллера в GameObject spinProppeler (В инспекторе префаб Player - Propeller).
    public GameObject spinProppeler;
    // Скорость вращения пропеллера 500
    public int speedRotation = 500;

    // Обновляем каждый кадр
    void Update()
    {
        // Заставляем вращаться пропеллер самолета с одинаковой скоростью на любом пк со скоростью speedRotation.
        transform.Rotate(Vector3.forward * Time.deltaTime * speedRotation);
    }
}
