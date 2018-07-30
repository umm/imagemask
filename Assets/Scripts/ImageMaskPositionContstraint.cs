using UnityEngine;
using UnityEngine.UI;

namespace UnityModule.ImageMask
{
    [RequireComponent(typeof(Image))]
    public class ImageMaskPositionContstraint : MonoBehaviour
    {
        public RectTransform TrackTransform;
        private Material Material;
        private RectTransform RectTransform;

        void Start()
        {
            var image = this.GetComponent<Image>();
            this.Material = new Material(image.material);
            image.material = this.Material;
            this.RectTransform = this.GetComponent<RectTransform>();
        }

        void Update()
        {
            if (this.TrackTransform.gameObject.activeSelf)
            {
                var x = this.TrackTransform.localPosition.x;
                var y = this.TrackTransform.localPosition.y;
                var xratio = (x - this.RectTransform.rect.xMin) / this.RectTransform.rect.width;
                var yratio = (y - this.RectTransform.rect.yMin) / this.RectTransform.rect.height;
                var vector = new Vector2(xratio, yratio);
                this.Material.SetVector("_MaskPosition", vector);
            }
        }
    }
}