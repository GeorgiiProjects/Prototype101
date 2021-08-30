using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    // public GameObject это класс или тип с именем plane и он виден в инспекторе, если его сделать приватным то это сломает камеру.
    // помещаем префаб самолета в GameObject plane (В инспекторе Main Camera).
    public GameObject plane;
    // private Vector3 offset - приватная переменна типа Vector 3, которая настраивает камеру с заданными координатами с именем offset, 
    // задаем новые значения камеры в new Vector3 по осям x,y и z (30,5 и 10).
    // видна только внутри класса FollowPlayerX и не видна в инспекторе.
    private Vector3 offset = new Vector3 (30, 0, 10);

    // обновляется каждый кадр
    void Update()
    {
        // transform - дает доступ к компоненту transform в инспекторе - MainCamera.
        // position - дает доступ к позиции камеры по осям x,y,z.
        // plane.transform.position - дает доступ к позиции самолета, x,y,z в инспекторе.
        // transform.position = plane.transform.position; - теперь камера будет следовать за самолетом, 
        // + offset - теперь камера будет следовать под правильным углом за самолетом.
        transform.position = plane.transform.position + offset;
    }
}
