using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    // Скорость перемещения самолета, настраивается в инспекторе в префабе Player.
    public float speed;
    // Скорость поворота самолета, настраивается в инспекторе в префабе Player.
    public float rotationSpeed;
    // переменная для перемещения самолета вверх и вниз.
    private float verticalInput;

    // используем FixedUpdate() с фиксированной частотой обновления, например 60 кадров в секунду.
    void FixedUpdate()
    {
        // Input.GetAxis("Vertical"); получаем доступ к менеджеру в unity Project settings - Input Manager - Axes - Vertical - Name (Vertical)
        verticalInput = Input.GetAxis("Vertical");

        // Самолет перемещается автоматически вперед со скоростью.
        transform.Translate(Vector3.forward * speed);

        // Самолет двигается с определенной скоростью вверх или вниз в зависимости от значения переменной rotationSpeed.
        // * verticalInput самолет может двигаться вверх или вниз с клавиатуры.
        // transform.Rotate(Vector3.right получаем доступ к углу поворота самолета по оси x, за счет чего самолет начинает поворачивать правильно.
        // Time.deltaTime * turnSpeed самолет с одинаковой скоростью на всех пк, поворачивается со скоростью turnSpeed метров в секунду.
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
    }
}
