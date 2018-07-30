using UnityEngine;

namespace Example.Shader
{
    public class ConstantCircleMove2D : MonoBehaviour
    {
        private Vector3 InitialPosition;
        private float Distance = 50f;

        void Start()
        {
            this.InitialPosition = this.transform.localPosition;
        }

        void Update()
        {
            var radius = Time.frameCount / 60f;

            this.transform.localPosition = this.InitialPosition + new Vector3(
                Mathf.Cos(radius),
                Mathf.Sin(radius)
            ) * this.Distance;
        }
    }
}