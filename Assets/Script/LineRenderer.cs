using UnityEngine;

public class LazerKontrol : MonoBehaviour {
    [SerializeField] float defDistanceRay = 100f;
    [SerializeField] Transform laserFirePoint;
    [SerializeField] LineRenderer m_lineRenderer;
    Transform m_transform;

    private void Awake() {
        m_transform = GetComponent<Transform>();
    }
    void ShootLaser() {
        if (Physics2D.Raycast(m_transform.position, transform.right)) {
            RaycastHit2D hit = Physics2D.Raycast(m_transform.position, transform.right);
            Draw2DRay(laserFirePoint.position, hit.point);
        } else {
        Draw2DRay(laserFirePoint.position, laserFirePoint.transform.right * defDistanceRay);
        }
    }
    void Draw2DRay(Vector2 startPos, Vector2 endPos) {
        m_lineRenderer.SetPosition(0, startPos);
        m_lineRenderer.SetPosition(1, endPos);
    }
}
