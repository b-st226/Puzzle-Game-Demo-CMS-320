using UnityEngine;
public class touchRotate : MonoBehaviour
{
private void OnMouseDown()
{ // youWin a bool variable from another class
transform.Rotate(0, 0, 90);
}
}